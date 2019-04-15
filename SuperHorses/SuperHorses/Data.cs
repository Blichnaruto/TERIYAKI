using System;
using System.Collections.Generic;
using System.IO;

namespace SuperHorses
{
	public static class Data
	{
		public const int MAX_STEPS = 5;
		
		//текущая выделенная лошадь
		public static int SelectedAnimal = 0;
		
		//пользовательские данные [поля данных класса]
		public static int Step = 1; //кол-во заездов (его текущий номер)
		public static int Wins = 0;
		public static int Loses = 0;
		public static double Money = 1000;
		
		//список из всех объектов всех лошадок
		public static readonly List<Animal> Animals = new List<Animal>();
		
		//загрузчик лошадей из файла [константа]
		public const string FILE_LINES = "input.txt";
		
		//загрузить списко всех лошадей из файла в общий список
		public static void LoadAll()
		{
			Animals.Clear();
			
			string[] lines = File.ReadAllLines(FILE_LINES);
			
			foreach(string line in lines)
			{
				string[] data = line.Split(','); //делим каждую строку на отедльную часть вида [а], [b], [c], [d]
				
				//создание объекта лошади и заполнение данными частями
				Animal animal = new Animal();
				animal.Name = data[0].Trim();
				animal.Info[0] = data[1].Trim();
				animal.Info[1] = data[2].Trim();
				animal.Info[2] = data[3].Trim();
				
				//занесение его в общий список
				Animals.Add(animal);
			}
			
			SelectedAnimal = new Random().Next(0, Animals.Count); //изначальное выделение случайной лошади
		}
		
		//из списка всех лошадей выбирает select случайных
		public static void RandomizeAll(int select = 6)
		{
			Animal[] animals = Animals.ToArray();
			
			Animals.Clear();
			
			Random r = new Random();
			
			for(int i = 0; i < select;)
			{
				Animal a = animals[r.Next(0, animals.Length - 1)];
				
				if(!IsExists(a.Name)) 
				{
					Animals.Add(a);
					i++;
				}
				
				if(i > 100) return;
			}
		}
		
		//проверить есть ли лошадь с этим именем в списке
		public static bool IsExists(string Name)
		{
			foreach(Animal a in Animals) 
			{
				if(a.Name == Name) return true;
			}
			
			return false;
		}
		
		//[это свойство] возвращает номер самой удачливой лошадки
		public static int BestAnimal
		{
			get
			{
				Animal[] animals = Animals.ToArray();
				
				int bestIndex = 0;
				int bestRecord = 0;
				
				for(int i = 0; i < animals.Length; i++)
				{
					if(animals[i].Wins > bestRecord)
					{
						bestRecord = animals[i].Wins;
						bestIndex = i;
					}
				}
				
				return bestIndex;
			}
		}
	}
}
