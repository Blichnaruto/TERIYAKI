using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperHorses
{
	public partial class AnimalEventsLog : Form
	{
		public AnimalEventsLog()
		{
			InitializeComponent();
		}
		
		void AnimalEventsLogLoad(object sender, EventArgs e)
		{
			//загружаем в textbox лог событий при открытии формы
			foreach(string line in Data.Animals[Data.SelectedAnimal].EventsLog)
			{
				infoTB.Text += line + Environment.NewLine;
			}
		}
		
		void ClearBTNClick(object sender, EventArgs e)
		{
			//очищаем все поля и события коня
			Data.Animals[Data.SelectedAnimal].EventsLog.Clear();
			infoTB.Clear();
		}
	}
}
