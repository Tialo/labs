using System;

class Level3
{
	public static void T1()
	{
		Console.WriteLine("Level3 Test1:");
		double x = 0.1, s, a, c, f, f_i, p;
		for (;x <= 1; x += 0.1)
		{
			f = f_i = p = c = 1.0;
			a = p * c / f;
			s = a;
			while (Math.Abs(a) >= 0.0001)
			{
				p = -p;
				c *= x * x;
				f *= f_i * (f_i + 1);
				f_i += 2;
				a = p * c / f;
				s += a;
			}
			Console.WriteLine(Math.Cos(x));
			Console.WriteLine(s);
			Console.WriteLine("------------------");
		}
		Console.WriteLine();
	}
	public static void T2()
	{
		Console.WriteLine("Level3 Test2:");
		double s = 0.0, x = 0.1, a = 1.0;
		int i = 1;
		for (;x <= 0.8; x += 0.1)
		{
			s = 0.0;
			i = 1;
			a = Math.Pow(x, i) * Math.Sin(i / 4.0 * Math.PI);
			while (Math.Abs(a) >= 0.0000000001)
			{	
				s += a;
				i++;
				a = Math.Pow(x, i) * Math.Sin(i / 4.0 * Math.PI);
			}
			Console.WriteLine(x * Math.Sin(Math.PI / 4) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x));
			Console.WriteLine(s);
			Console.WriteLine("------------------");
			
		}
		Console.WriteLine();
	}
	public static void T3()
	{
		Console.WriteLine("Level3 Test3:");
		double s, a;
		int i, f;
		for (double x = 0.1; x <= 1; x += 0.1)
		{
			s = 1.0;
			i = 1;
			f = 1;
			a = Math.Cos(i * x) / f;
			while (Math.Abs(a) >= 0.0001)
			{
				s += a;
				i++;
				f *= i;
				a = Math.Cos(i * x) / f;
			}
			Console.WriteLine("------------------");
			Console.WriteLine(Math.Pow(Math.E, Math.Cos(x)) * Math.Cos(Math.Sin(x)));
			Console.WriteLine(s);
		}
	}
	public static void T4()
	{
		Console.WriteLine("Test4:");

		Console.WriteLine();
	}
	public static void T5()
	{
		Console.WriteLine("Test5:");

		Console.WriteLine();
	}
	public static void T6()
	{
		Console.WriteLine("Test6:");

		Console.WriteLine();
	}
	public static void T7()
	{
		Console.WriteLine("Test7:");

		Console.WriteLine();
	}
	public static void T8()
	{
		Console.WriteLine("Test8:");

		Console.WriteLine();
	}
	public static void T9()
	{
		Console.WriteLine("Test9:");

		Console.WriteLine();
	}
}