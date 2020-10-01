using static System.Console;
using static System.Convert;

class Level2
{
	public static void T1()
	{
		WriteLine("Level2 Test1:");
		int n, heigth, boys_number;
		string sex;
		double girls_height, boys_height;
		boys_height = girls_height = 0;
		boys_number = 0;
		n = ToInt32(ReadLine());
		for (int i = 1; i <= n; i++)
		{
			sex = ReadLine();
			heigth = ToInt32(ReadLine());
			if (sex == "boy")
			{
				boys_height += heigth;
				boys_number++;
			}
			else
				girls_height += heigth;
		}
		WriteLine($"boys: {boys_height / boys_number}\tgirls: {girls_height / (n - boys_number)}");
	}
	public static void T2()
	{
		WriteLine("Level2 Test2:");
		int n, a, b, r, x, y;
		n = ToInt32(ReadLine());
		a = ToInt32(ReadLine());
		b = ToInt32(ReadLine());
		r = ToInt32(ReadLine());
		for (int i = 1; i <= n; i++)
		{
			x = ToInt32(ReadLine());
			y = ToInt32(ReadLine());
			WriteLine((a - x) * (a - x) + (b - y) * (b - y) <= r * r);
		}
		WriteLine();
	}
	public static void T3()
	{
		WriteLine("Level2 Test3:");

		WriteLine();
	}
	public static void T4()
	{
		WriteLine("Level2 Test4:");

		WriteLine();
	}
	public static void T5()
	{
		WriteLine("Level2 Test5:");

		WriteLine();
	}
	public static void T6()
	{
		WriteLine("Level2 Test6:");

		WriteLine();
	}
	public static void T7()
	{
		WriteLine("Level2 Test7:");

		WriteLine();
	}
	public static void T8()
	{
		WriteLine("Level2 Test8:");

		WriteLine();
	}
	public static void T9()
	{
		WriteLine("Level2 Test9:");

		WriteLine();
	}
	public static void T10()
	{
		WriteLine("Level2 Test10:");

		WriteLine();
	}
	public static void T11()
	{
		WriteLine("Level2 Test11:");

		WriteLine();
	}
	public static void T12()
	{
		WriteLine("Level2 Test12:");

		WriteLine();
	}	
}