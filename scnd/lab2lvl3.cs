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
		double r1, r2, x, y;
		string input1, input2;
		r1 = ToDouble(ReadLine());
		r2 = ToDouble(ReadLine());
		input1 = ReadLine();
		while (input1 != "end")
		{
			input2 = ReadLine();
			x = ToDouble(input1);
			y = ToDouble(input2);
			WriteLine(r1 * r1 <= x * x + y * y && x * x + y * y <= r2 * r2);
			input1 = ReadLine();
		}
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
		int i, n, count = 0, mark1, mark2, mark3, mark4, num = 0;
		double s = 0;
		n = ToInt32(ReadLine());
		for (i = 0; i < n; i++)
		{
			mark1 = ToInt32(ReadLine());
			mark2 = ToInt32(ReadLine());
			mark3 = ToInt32(ReadLine());
			mark4 = ToInt32(ReadLine());
			if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
			{
				num++;
			}
			else
			{
				s += mark1 + mark2 + mark3 + mark4;
				count += 4;
			}
		}
        WriteLine($"{num}\t{(s) / (count)}");
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