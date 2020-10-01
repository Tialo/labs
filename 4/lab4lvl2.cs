using static System.Console;
using static System.Convert;

class Level2
{
    public static void T1()
    {
        WriteLine("Level2 Test1:");

        WriteLine();
    }
    public static void T2()
    {
        WriteLine("Level2 Test2:");

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
		int i, j, max_i = 0, max_j = 0;
		double[,] a = new double[6, 6];
		for (i = 0; i < 6; i++)
		{
			for (j = 0; j < 6; j++)
			{
				a[i, j] = ToDouble(ReadLine());
				if (i == j && a[i, j] > a[max_i, max_j])
				{
					(max_i, max_j) = (i, j);
				}
			}
		}
		for (i = 0; i < 6; i++)
		{
			for (j = 0; j < 6; j++)
			{
				if (j > i && i < max_i)
				{
					a[i, j] = 0;
				}
				Write($"{a[i, j]}\t");
			}
			WriteLine();
		}
        WriteLine();
    }
    public static void T8()
    {
        WriteLine("Level2 Test8:");
		int i, j, max1, max2;
		double[,] a = new double[6, 6];
		for (i = 0; i < 6; i++)
		{
			for (j = 0; j < 6; j++)
			{
				a[i, j] = ToDouble(ReadLine());
			}
		}
		for (i = 0; i < 3; i++)
		{
			max1 = max2 = 0;
			for (j = 0; j < 6; j++)
			{
				if (a[2 * i, j] > a[2 * i, max1])
				{
					max1 = j;
				}
				if (a[2 * i + 1, j] > a[2 * i + 1, j])
				{
					max2 = j;
				}
			}
			(a[2 * i, max1], a[2 * i + 1, max2]) = (a[2 * i + 1, max2], a[2 * i, max1]);
		}
        WriteLine();
		for (i = 0; i < 6; i++)
		{
			for (j = 0; j < 6; j++)
			{
				Write($"{a[i, j]}\t");
			}
			WriteLine();
		}
    }
    public static void T9()
    {
        WriteLine("Level2 Test9:");
		int i, j;
		double[,] a = new double[6, 7];
		for (i = 0; i < 6; i++)
		{
			for (j = 6; j >= 0; j--)
			{
				a[i, j] = ToDouble(ReadLine());
			}
		}
        WriteLine();
		for (i = 0; i < 6; i++)
		{
			for (j = 0; j < 7; j++)
			{
				Write($"{a[i, j]}\t");
			}
			WriteLine();
		}
    }
}