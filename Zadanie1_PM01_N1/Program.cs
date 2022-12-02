using System;

namespace Variant10
{
	class Program
	{
		static void Main()
		{
			try
			{
				double x, y;
				Console.Write("Введите x: "); x = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите y: "); y = Convert.ToDouble(Console.ReadLine());

				if ((x > 50 | x < -50) & (y > 25 | y < 25))
				{
					Console.WriteLine("Точка находится вне области.");
				}
				else if (x >= -50 & x <= 50 & y == 25 | y == -25)
				{
					Console.WriteLine("Точка находится на границе области.");
				}
				else if (y >= -25 & y <= 25 & x == 50 | x == -50)
				{
					Console.WriteLine("Точка находится на границе области.");
				}
				else if (x < 50 & x > -50 & y < 25 & y > -25)
				{
					Console.WriteLine("Точка находится внутри области.");
				}
			}
			catch
			{
				Console.WriteLine("Некорректно введены параметры!");
			}
			
		}
	}
}