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
		int i, j, ind = 0;
		double[,] a = new double[6, 6] {
			{75, 89, 47, 97, 94, 87},
			{72, 16, 31, 19, 91, 6},
			{8, 43, 40, 65, 27, 7},
			{59, 31, 9, 70, 75, 22},
			{64, 88, 64, 92, 83, 46},
			{59, 89, 39, 11, 62, 68}
		};
		for (i = 0; i < 6; i++)
		{
			if (a[i, i] > a[ind, ind])
			{
				ind = i;
			}
		}
		for (i = 0; i < ind; i++)
		{
			for (j = i + 1; j < 6; j++)
			{
				a[i, j] = 0;
			}
		}
		for (i = 0; i < 6; i++)
		{
			for (j = 0; j < 6; j++)
			{
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
		double[,] a = new double[6, 6] {
			{75, 89, 47, 97, 94, 87},
			{72, 16, 31, 19, 91, 6},
			{8, 43, 40, 65, 27, 7},
			{59, 31, 9, 70, 75, 22},
			{64, 88, 64, 92, 83, 46},
			{59, 89, 39, 11, 62, 68}
		};
		for (i = 0; i < 3; i++)
		{
			max1 = max2 = 0;
			for (j = 0; j < 6; j++)
			{
				if (a[2 * i, j] > a[2 * i, max1])
				{
					max1 = j;
				}
				if (a[2 * i + 1, j] > a[2 * i + 1, max2])
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
		double[,] a = new double[6, 7] {
			{36, 80, 91, 26, 84, 56, 61},
			{15, 32, 7, 44, 51, 12, 29},
			{76, 67, 93, 72, 0, 42, 78},
			{50, 60, 90, 38, 27, 44, 58},
			{3, 59, 71, 50, 81, 54, 76},
			{60, 64, 49, 93, 66, 91, 63}
		};
        WriteLine();
		for (i = 0; i < 6; i++)
		{
			for (j = 0; j < (7 + 1) / 2; j++)
			{
				(a[i, j], a[i, 6 - j]) = (a[i, 6 - j], a[i, j]);
			}
		}
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