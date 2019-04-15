using System;
using System.Collections.Generic;

namespace SuperHorses
{
	public class Animal
	{
		public string Name = ""; //имя лошади
		public readonly string[] Info = new string[3]; //персональные данные
		
		public readonly List<string> EventsLog = new List<string>(); //список событий для вывода в форму
		
		//числа побед и проигрышей коника
		public int Wins = 0;
		public int Loses = 0;
		
		//победная ставка: сумма при победе
		public double WinSum = 0;
	}
}
