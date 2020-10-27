using static System.Console;
using static System.Convert;
using static System.Math;

class Level3
{
    public static void T1()
    {
        WriteLine("Level3 Test1:");

        WriteLine();
    }
    public static void T2()
    {
        WriteLine("Level3 Test2:");

        WriteLine();
    }
    public static void T3()
    {
        WriteLine("Level3 Test3:");

        WriteLine();
    }
    public static void T4()
    {
        WriteLine("Level3 Test4:");
		double x = 0, y, r1, r2;
		r1 = ToDouble(ReadLine());
		r2 = ToDouble(ReadLine());
		do
		{
			x = ToDouble(ReadLine());
			if (x == -123456789)
			{
				break;
			}
			y = ToDouble(ReadLine());
			WriteLine(r1 * r1 <= x * x + y * y && x * x + y * y <= r2 * r2);
		} while (x != -123456789);
        WriteLine();
    }
    public static void T5()
    {
        WriteLine("Level3 Test5:");

        WriteLine();
    }
    public static void T6()
    {
        WriteLine("Level3 Test6:");

        WriteLine();
    }
    public static void T7()
    {
        WriteLine("Level3 Test7:");

        WriteLine();
    }
    public static void T8()
    {
        WriteLine("Level3 Test8:");

        WriteLine();
    }
    public static void T9()
    {
        WriteLine("Level3 Test9:");

        WriteLine();
    }
    public static void T10()
    {
        WriteLine("Level3 Test10:");

        WriteLine();
    }
    public static void T11()
    {
        WriteLine("Level3 Test11:");
		int i, num = 0, count = 0;
		bool bad;
		double s = 0, mid, mark = 1;
		do
		{
			bad = false;
			mid = 0;
			for (i = 0; i < 4; i++)
			{
				mark = ToInt32(ReadLine());
				if (mark == 0)
				{
					break;
				}
				if (mark == 2)
				{
					bad = true;
				}
				mid += mark;
			}
			if (bad)
			{
				num++;
			}
			else
			{
				s += mid;
				count += 4;
			} 
		} while (mark != 0);
        WriteLine($"{num}\t{s / (count - 4)}");
    }
    public static void T12()
    {
        WriteLine("Level3 Test12:");
		string choice;
		double r;
		r = ToDouble(ReadLine());
		choice = ReadLine();
		while (r != 0)
		{
			switch(choice)
			{
				case "triangle":
					WriteLine(Sqrt(3) * r * r / 4);
					break;
				case "square":
					WriteLine(r * r);
					break;
				case "circle":
					WriteLine(PI * r * r / 2);
					break;
			}
			r = ToDouble(ReadLine());
			choice = ReadLine();
		}	
        WriteLine();
    }
    public static void T13()
    {
        WriteLine("Level3 Test13:");
		string choice;
		double a, b;
		a = ToDouble(ReadLine());
		b = ToDouble(ReadLine());
		choice = ReadLine();
		while (a * b > 0)
		{
			switch(choice)
			{
				case "isosceles":
					WriteLine(Sqrt(Abs(b * b - (a / 2) * (a / 2))) * (a / 2));
					break;
				case "ring":
					WriteLine(Abs(PI * a * a / 2 - PI * b * b / 2));
					break;
				case "rectangle":
					WriteLine(a * b);
					break;
			}
			a = ToDouble(ReadLine());
			b = ToDouble(ReadLine());
			choice = ReadLine();
		}
        WriteLine();
    }
}