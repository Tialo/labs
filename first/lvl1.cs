using System;

class Level1
{
	public static void T1()
	{	
		Console.WriteLine("Level1 Test1:");
		int s = 0;
		for (int i = 2; i <= 35; i += 3)
			s += i;
		Console.WriteLine(s);
	}	
	
	public static void T2()
	{
		Console.WriteLine("Level1 Test2:");
		double s = 0;
		for (int i = 1; i <= 10; i++)
		{
			s += 1.0 / i;
		}
		Console.WriteLine(s);
	}
	
	public static void T3()
	{
		Console.WriteLine("Level1 Level1 Test3:");
		double s = 0.0;
		for (double i = 2.0; i <= 112; i += 2)
		{
			s += i / (i + 1);
		}
		Console.WriteLine(s);
	}
	
	public static void T4()
	{
		Console.WriteLine("Level1 Test4:");
		double s = 0.0, c = 1.0;
		double x = Convert.ToDouble(Console.ReadLine());
		for (double i = 1; i <= 9; i++)
		{
			s += Math.Cos(i * x) / c;
			c *= x;
		}
		Console.WriteLine(s);
	}
	public static void T5()
	{
		Console.WriteLine("Level1 Test5:");
		int s = 0, p, h;
		h = Convert.ToInt32(Console.ReadLine());
		p = Convert.ToInt32(Console.ReadLine());
		
		for (int i = 0; i <= 9; i++)
		{
			s += (p + i * h) * (p + i * h);
		}
		Console.WriteLine(s);
	}
	public static void T6()
	{
		Console.WriteLine("Level1 Test6:");
		double x = -4, y;
		for (;x <= 4; x += 0.5)
		{
			y = 0.5 * x * x - 7 * x;
			Console.WriteLine($"{x}\t{y}");
		}
		Console.WriteLine();
	}
	public static void T7()
	{
		Console.WriteLine("Level1 Test7:");

		Console.WriteLine();
	}
	public static void T8()
	{
		Console.WriteLine("Level1 Test8:");

		Console.WriteLine();
	}
	public static void T9()
	{
		Console.WriteLine("Level1 Test9:");
		double s = 0.0, a, fv = 1.0;
		int i, f = 1, p = 1;
		for (i = 1; i <= 6; i++)
		{
			p = -p;
			fv *= 5;
			f *= i;
			a = p * fv / f;
			s += a;
		}
		Console.WriteLine(s);
	}
	public static void T10()
	{
		Console.WriteLine("Level1 Test10:");

		Console.WriteLine();
	}
	public static void T11()
	{
		Console.WriteLine("Level1 Test11:");
		for (int i = 1; i <= 5; i++)
		{
			Console.Write($"{5} ");
		}
		Console.WriteLine();
	}
	public static void T12()
	{
		Console.WriteLine("Level1 Test12:");

		Console.WriteLine();
	}
	public static void T13()
	{
		Console.WriteLine("Level1 Test13:");

		Console.WriteLine();
	}
	public static void T14()
	{
		Console.WriteLine("Level1 Test14:");
		int x = 1, y = 1;
		Console.Write($"{x} {y} ");
		for (int i = 1; i <= 6; i++)
		{
			(x, y) = (x + y, x);
			Console.Write($"{x} ");
		}
		Console.WriteLine();
	}
	public static void T15()
	{
		Console.WriteLine("Level1 Test15:");
		double a = 1, fib1 = 1.0 , fib2 = 1.0;
		for (int i = 1; i <= 5; i++)
		{
			a = fib1 / fib2;
			(fib1, fib2) = (fib1 + fib2, fib1);
		}
		Console.WriteLine(a);
	}
	public static void T16()
	{
		Console.WriteLine("Level1 Test16:");
		ulong s = 0, x = 1;
		for (int i = 1; i <= 64; i++)
		{
			s += x;
			x *= 2;
		}
		Console.WriteLine(s / 15);
	}
	public static void T17()
	{
		Console.WriteLine("Level1 Test17:");
		const int R = 6350;
		double l;
		for (int i = 1; i <= 10; i++)
		{
			l = Math.Sqrt(2 * R * i + i * i);
			Console.WriteLine(l);
		}
		Console.WriteLine();
	}
	public static void T18()
	{
		Console.WriteLine("Level1 Test18:");
		int i, c = 10;
		for (i = 3; i <= 24; i += 3)
			c += c;		
		Console.WriteLine(c);
	}
	
}