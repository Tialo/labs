using System;

class Level1
{
	public static void T1()
	{
		Console.WriteLine("Level1 Test1:");
		double x, y; 
		(x, y) = (0, 2);
		Console.WriteLine(Math.Abs(x * x + y * y - 2 * 2) <= 1e-3);
		(x, y) = (1.5, 0.7);
		Console.WriteLine(Math.Abs(x * x + y * y - 2 * 2) <= 1e-3);
		(x, y) = (1, 1);
		Console.WriteLine(Math.Abs(x * x + y * y - 2 * 2) <= 1e-3);
		(x, y) = (3, 0);
		Console.WriteLine(Math.Abs(x * x + y * y - 2 * 2) <= 1e-3);
	}
	public static void T2()
	{
		Console.WriteLine("Level1 Test2:");
		double x, y;
		x = Convert.ToDouble(Console.ReadLine());
		y = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine(y >= 0 && y + Math.Abs(x) <= 1);
	}
	public static void T3()
	{
		Console.WriteLine("Level1 Test3:");
		double a, b;
		a = Convert.ToDouble(Console.ReadLine());
		b = Convert.ToDouble(Console.ReadLine());
		if (a > 0)
			Console.WriteLine(Math.Max(a, b));
		else
			Console.WriteLine(Math.Min(a, b));
		Console.WriteLine();
	}
	public static void T4()
	{
		Console.WriteLine("Level1 Test4:");

		Console.WriteLine();
	}
	public static void T5()
	{
		Console.WriteLine("Level1 Test5:");

		Console.WriteLine();
	}
	public static void T6()
	{
		Console.WriteLine("Level1 Test6:");

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

		Console.WriteLine();
	}
	public static void T10()
	{
		Console.WriteLine("Level1 Test10:");

		Console.WriteLine();
	}
}