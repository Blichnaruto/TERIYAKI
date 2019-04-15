using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Word;

namespace SuperHorses
{
	public partial class MainForm : Form
	{
		//при загрузке программы получаем список лошадей через UpdateList()
		public MainForm()
		{
			InitializeComponent();
			
			UpdateList();
		}
		
		//обновление статистики игрока: выигрыши, пригрыши, номер заезда, деньги
		public void UpdateStates()
		{
			try { moneyTB.Text = Data.Money.ToString("0.00") + "$"; }
			catch { moneyTB.Text = Data.Money + "$"; }
			winlosesLB.Text = "Выигрышей: " + Data.Wins
				+ Environment.NewLine + "Проигрышей: " + Data.Loses;
			stepLB.Text = Data.Step + " заезд";
		}
		
		//обновление главного списка лошадок
		public void UpdateList()
		{
			horsesLT.Items.Clear();
			
			Data.LoadAll();
			Data.RandomizeAll();
			
			foreach(Animal h in Data.Animals)
			{
				horsesLT.Items.Add(h.Name);
			}
		}
		
		//загрузка данных о лошади в купон
		public void LoadSelectedAnimal()
		{
			double cf = 0; // Ф О Р М У Л А
			if(Data.Step == 1) cf = 1.166667; //перв.кооф
			
			double m = Data.Animals[Data.SelectedAnimal].Wins + Data.Animals[Data.SelectedAnimal].Loses;
			double sum = Convert.ToDouble((int) sumUD.Value); //текущая ставка [(int) - приведение типов]
			
			if(Data.Step > 1) 
			{
				cf = 1.00001 + ((m + Data.Animals[Data.SelectedAnimal].Loses -
			                             Data.Animals[Data.SelectedAnimal].Wins) / (horsesLT.Items.Count - 1));
				
				if(Data.Animals[Data.SelectedAnimal].Loses > (Data.Animals[Data.SelectedAnimal].Wins - 1)) cf += 1.0;
			}
			
			Data.Animals[Data.SelectedAnimal].WinSum = (cf * sum) -  (sum % 2);
			
			infoTB.Text =
				Data.Animals[Data.SelectedAnimal].Info[0] + Environment.NewLine +
				Data.Animals[Data.SelectedAnimal].Info[1] + Environment.NewLine +
				Data.Animals[Data.SelectedAnimal].Info[2] + Environment.NewLine +
				"Выиграла " + Data.Animals[Data.SelectedAnimal].Wins + " раз" + Environment.NewLine +
				"Проиграла " + Data.Animals[Data.SelectedAnimal].Loses + " раз" + Environment.NewLine + 
				"Выигрыш: " + Data.Animals[Data.SelectedAnimal].WinSum  + Environment.NewLine +
				"Коэффициент: " + cf;
			
			LoadImage(Data.Animals[Data.SelectedAnimal].Name); //загрузка картинки лошади
		}
		
		//загрузчик изображений в правый бок
		public void LoadImage(string name)
		{
			string path = Environment.CurrentDirectory + @"\images\";
			string ext = ".jpg";
			
			if(File.Exists(path + name + ext)) animalPIC.Image = Image.FromFile(path + name + ext);
			else animalPIC.Image = Image.FromFile(path + "Default" + ext);
		}
		
		//функция при подтверждении ставки - основная
		public void Accept()
		{
			int sum = (int) sumUD.Value; //текущая ставка [(int) - приведение типов]
			
			if(Data.Money < sum) 
			{
				MessageBox.Show("Денег на ставку не хватает :(");
				return;
			}
			
			Random r = new Random();
			
			int animalWin = 0; //номер лошади, которая выиграла
			
			if(r.Next(1, 6) == 1) //random 16.6%
			{
				//если выпали 16.6% выигрыша, выигрывает самая удачливая лошадка
				animalWin = Data.BestAnimal;
			}
			else
			{
				//в случаи если < 16.6% - шанс выиграть 1 к (количеству строк в списке, обычно 6)
				animalWin = r.Next(0, horsesLT.Items.Count);
			}
			
			Data.Step++; //переключаем на следующий по номеру заезд
			
			//засчитывем проигрыши и выигрыш лошадкам
			foreach(Animal a in Data.Animals)
			{
				if(a.Name == Data.Animals[animalWin].Name) 
				{
					a.Wins++;
					
					LogEvent(a, "Заезд " + Data.Step + " лошадь " + a.Name + " ВЫИГРЫВАЕТ!!!");
				}
				else 
				{
					a.Loses++;
					
					LogEvent(a, "Заезд " + Data.Step + " лошадь " + a.Name + " проигрывает.");
				}
			}
			
			LoadSelectedAnimal();
			
			MessageBox.Show("В этом заезде выиграла лошадь " + Data.Animals[animalWin].Name);
			
			//считаем поражение или победу, отражаем ее на балансе
			if(Data.SelectedAnimal == animalWin)
			{
				//если ставка выигрышная
				Data.Wins++;
				
				Data.Money += Data.Animals[animalWin].WinSum;
				
				MessageBox.Show("Ваш выигрыш составил: " + Data.Animals[animalWin].WinSum);
			}
			else 
			{
				//уменьшаем баланс на указанную игроком сумму и засчитываем проигрыш
				Data.Loses++;
				
				Data.Money -= sum;
			}
			
			if(Data.Step == Data.MAX_STEPS + 1)
			{
				Data.Step = 1;
				
				UpdateList();
			}
		}
		
		//выводим событие в лог животного
		public void LogEvent(Animal animal, string data)
		{
			animal.EventsLog.Add(DateTime.Now.ToLongTimeString() + " > " + data);
		}
		
		//==========================< СОБЫТИЯ В ФОРМЕ >=================================
		
		void AutoupdaterTTick(object sender, EventArgs e)
		{
			UpdateStates(); //timer обновляет все ресурсы раз в секунду
		}
		
		//при выделении лошади в списке слева
		void HorsesLTSelectedIndexChanged(object sender, EventArgs e)
		{
			Data.SelectedAnimal = horsesLT.SelectedIndex; //уста-ем выделенную 
			
			LoadSelectedAnimal(); //вызываем функцию вывода данных в купон
			
			acceptBTN.Enabled = true; //делаем кнопку подтверждения доступной
			infoLINK.Visible = true; //делаем видимой ссылку инфы
		}
		
		void AcceptBTNClick(object sender, EventArgs e)
		{
			Accept(); //подтверждение кнопкой установки ставки
		}
		
		void InfoLINKLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new AnimalEventsLog().ShowDialog(); //показываем форму событий лошадки
		}
		
		void HelpLINKLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//при нажатии на ссылку помощи запускаем процесс открытия файла help.htm
			System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\help.htm");
		}
		
		void WordLINKLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//выводим данные в MS Word
			const string SEPERATOR_NEWLINE = "\n";
			
			try
			{
				ApplicationClass app = new ApplicationClass();
				app.Visible = true;
				object o =  Type.Missing;
				Document doc = app.Documents.Add(o, o, o, o);
				doc.Activate();
			
				app.ActiveDocument.Content.Bold = 10;
				app.ActiveDocument.Content.InsertAfter("Статистика игры от " + DateTime.Now.ToString());
				app.ActiveDocument.Content.InsertAfter(SEPERATOR_NEWLINE);
				app.ActiveDocument.Content.InsertAfter("Баланс: " + Data.Money);
				app.ActiveDocument.Content.InsertAfter(SEPERATOR_NEWLINE);
				app.ActiveDocument.Content.InsertAfter("Проигрышей: " + Data.Loses);
				app.ActiveDocument.Content.InsertAfter(SEPERATOR_NEWLINE);
				app.ActiveDocument.Content.InsertAfter("Выигрышей: " + Data.Wins);
				app.ActiveDocument.Content.InsertAfter(SEPERATOR_NEWLINE);
			}
			catch 
			{
				MessageBox.Show("Не удалось подключиться к MS Office Word", "Ошибка при создании статистики!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
