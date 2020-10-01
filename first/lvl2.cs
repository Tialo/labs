using System;

class Level2
{
	public static void T1()
	{
		Console.WriteLine("Level2 Test1:");

		Console.WriteLine();
	}
	public static void T2()
	{
		Console.WriteLine("Level2 Test2:");
		int p = 1, n = 1;
		while (p <= 30000)
		{
			p *= n;
			n += 3;
		}
		Console.WriteLine(n - 3);
	}
	public static void T3()
	{
		Console.WriteLine("Level2 Test3:");

		Console.WriteLine();
	}
	public static void T4()
	{
		Console.WriteLine("Level2 Test4:");
		double s = 1, x, a;
		x = Convert.ToDouble(Console.ReadLine());
		a = x = x * x;
		while (a > 0.0001)
		{
			s += a;
			a *= x;
		}
		Console.WriteLine(s);
	}
	public static void T5()
	{
		Console.WriteLine("Level2 Test5:");

		Console.WriteLine();
	}
	public static void T6()
	{
		Console.WriteLine("Level2 Test6:");

		Console.WriteLine();
	}
	public static void T7()
	{
		Console.WriteLine("Level2 Test7:");

		Console.WriteLine();
	}
	public static void T8()
	{
		Console.WriteLine("Level2 Test8:");
		double s = 0.0, a = 10.0;
		int d = 0;
		for (int i = 1; i <= 7; i++)
		{
			s += a;
			a *= 1.1;
		}
		Console.WriteLine(s);
		s = 0.0;
		a = 10.0;
		while (s < 100)
		{
			s += a;
			a *= 1.1;
			d++;
		}
		Console.WriteLine(d);
		s = 0.0;
		a = 10.0;
		d = 1;
		while (a < 20)
		{
			a *= 1.1;
			d++;
		}
		Console.WriteLine(d);
	}
	public static void T9()
	{
		Console.WriteLine("Level2 Test9:");

		Console.WriteLine();
	}
	public static void T10()
	{
		Console.WriteLine("Level2 Test10:");

		Console.WriteLine();
	}
	public static void T11()
	{
		Console.WriteLine("Level2 Test11:");

		Console.WriteLine();
	}
}