using System;
using System.Text.RegularExpressions;


namespace LAbDelegate
{
	class Program
	{
		private static int funcNum;
		private static double value;
		private static Func<double, double>[] function;

		static void Main(string[] args)
		{
			while (true)
			{
				try
				{
					Input();
					GetDelegat();
					Console.WriteLine(function[funcNum](value));

				}
				catch
				{
					Console.WriteLine("Сталася помилка Входная строка имела неверный формат \n Натиснiть будь - яку клавiшу для остаточного виходу");
					Console.ReadKey();
					break;
				}
			}

		}
		private static void Input()
		{
			Console.WriteLine("Введiть даннi");
			string input = Console.ReadLine();
			Regex reg = new Regex(@"\s*\w*\d\s(\d*\,{0,1}\d*)\w*");
			Match put = reg.Match(input);
			string input1 = Convert.ToString(put);
			Regex reg2 = new Regex(@"\w*\d\s(\d*\,{0,1}\d*)\w*");
			Match put2 = reg2.Match(input1);
			string input2 = Convert.ToString(put2);
			string[] words = input2.Split(new char[] { ' ' });
			string first = words[0];
			string second = words[1];
			funcNum = Convert.ToInt32(first);
			value = Convert.ToDouble(second);
		}

		private static void GetDelegat()
		{
			Func<double, double>[] funcs = new Func<double, double>[3];
			funcs[0] = x => Math.Sqrt(Math.Abs(x));
			funcs[1] = x => Math.Pow(x,3);
			funcs[2] = x => x + 3.5;
			function = funcs;
		}

	}
}
