using static System.Console;
using static System.Convert;
using System;

class Level1
{
    public static void T1()
    {
        WriteLine("Level1 Test1:");

        WriteLine();
    }
    public static void T2()
    {
        WriteLine("Level1 Test2:");

        WriteLine();
    }
    public static void T3()
    {
        WriteLine("Level1 Test3:");
		int i;
		double s = 0;
		double[,] a = new double[4, 4] {
			{1, 2, 3, 4},
			{123, 15, 21, 3},
			{1233, 125, 121, 321},
			{14, 121, 31, 31}
		};
		for (i = 0; i < 4; i++)
		{
			s += a[i, i];
		}
        WriteLine();
		WriteLine(s);
    }
    public static void T4()
    {
        WriteLine("Level1 Test4:");

        WriteLine();
    }
    public static void T5()
    {
        WriteLine("Level1 Test5:");

        WriteLine();
    }
    public static void T6()
    {
        WriteLine("Level1 Test6:");
		double[,] a = new double[4, 7]{
			{16, 7, 36, 58, 72, 26, 39},
			{24, 66, 7, 23, 8, 55, 75},
			{32, 86, 17, 39, 49, 77, 15},
			{85, 63, 7, 7, 5, 2, 66}
		};
		int[] b = new int[4];
		int i, j, ind;
		for (i = 0; i < 4; i++)
		{
			ind = 0;
			for (j = 0; j < 7; j++)
			{
				if (a[i, j] < a[i, ind])
				{
					ind = j;
				}
			}
			b[i] = ind;
		}
        WriteLine();
		for (i = 0; i < 4; i++)
		{
			WriteLine(b[i]);
		}
    }
    public static void T7()
    {
        WriteLine("Level1 Test7:");

        WriteLine();
    }
    public static void T8()
    {
        WriteLine("Level1 Test8:");
		
        WriteLine();
    }
    public static void T9()
    {
        WriteLine("Level1 Test9:");

        WriteLine();
    }
    public static void T10()
    {
        WriteLine("Level1 Test10:");

        WriteLine();
    }
    public static void T11()
    {
        WriteLine("Level1 Test11:");

        WriteLine();
    }
    public static void T12()
    {
        WriteLine("Level1 Test12:");
		double[,] a = new double[6, 7]{
			{66, 2, 35, 53, 37, 42, 60},
			{7, 17, 19, 17, 19, 83, 15},
			{56, 72, 41, 64, 70, 64, 32},
			{95, 77, 96, 68, 31, 75, 80},
			{76, 31, 69, 80, 47, 63, 49},
			{64, 1, 28, 81, 76, 25, 49}
		};
		int i, j, max_i = 0, max_j = 0;
		for (i = 0; i < 6; i++)
		{
			for (j = 0; j < 7; j++)
			{
				if (a[i, j] > a[max_i, max_j])
				{
					(max_i, max_j) = (i, j);
				}
			}
		}
		for (i = max_i; i < 5; i++)
		{
			for (j = 0; j < 6; j++)
			{
				(a[i, j], a[i + 1, j]) = (a[i + 1, j], a[i, j]);
			}
		}
		for (i = 0; i < 6; i++)
		{
			for (j = max_j; j < 6; j++)
			{
				(a[i, j], a[i, j + 1]) = (a[i, j + 1], a[i, j]);
			}
		}
		for (i = 0; i < 5; i++)
		{
			for (j = 0; j < 6; j++)
			{
				Write($"{a[i, j]} ");
			}
			WriteLine();
		}
        WriteLine();
    }
    public static void T13()
    {
        WriteLine("Level1 Test13:");
		int i, j, ind = 0;
		double[,] a = new double[5, 5] {
			{86, 68, 16, 56, 94},
			{7, 52, 62, 86, 89},
			{95, 27, 42, 13, 88},
			{80, 37, 54, 71, 6},
			{30, 13, 81, 54, 68}
		};
		for (i = 0; i < 5; i++)
		{
			if (a[i, i] > a[ind, ind])
				ind = i;
		}
		for (i = 0; i < 5; i++)
		{
			(a[i, 3], a[i, ind]) = (a[i, ind], a[i, 3]);
		}
		for (i = 0; i < 5; i++)
		{
			for (j = 0; j < 5; j++)
			{
				Write($"{a[i, j]}\t");
			}
			WriteLine();
		}
    }
    public static void T14()
    {
        WriteLine("Level1 Test14:");

        WriteLine();
    }
    public static void T15()
    {
        WriteLine("Level1 Test15:");

        WriteLine();
    }
    public static void T16()
    {
        WriteLine("Level1 Test16:");

        WriteLine();
    }
    public static void T17()
    {
        WriteLine("Level1 Test17:");
		int i, j, ind;
		double[,] a = new double[5, 7] {
			{34, 78, 18, 63, 89, 13, 3},  
			{7, 6, 61, 49, 28, 50, 65},
			{1, 81, 24, 87, 19, 73, 73},
			{68, 80, 62, 8, 56, 76, 36},
			{90, 57, 39, 5, 56, 10, 59}
		};
		for (i = 0; i < 5; i++)
		{
			ind = 0;
			for (j = 0; j < 7; j++)
			{
				if (a[i, j] < a[i, ind])
				{
					ind = j;
				}
			}
			for (j = ind; j >= 1; j--) // здесь происходит перемещение минимального элем-а в начало строки
			{
				(a[i, j], a[i, j - 1]) = (a[i, j - 1], a[i, j]);
			}
			for (j = 0; j < 7; j++)
			{
				Write($"{a[i, j]}\t");
			}
			WriteLine();
		}
        WriteLine();
    }
    public static void T18()
    {
        WriteLine("Level1 Test18:");

        WriteLine();
    }
    public static void T19()
    {
        WriteLine("Level1 Test19:");

        WriteLine();
    }
    public static void T20()
    {
        WriteLine("Level1 Test20:");

        WriteLine();
    }
    public static void T21()
    {
        WriteLine("Level1 Test21:");

        WriteLine();
    }
    public static void T22()
    {
        WriteLine("Level1 Test22:");

        WriteLine();
    }
    public static void T23()
    {
        WriteLine("Level1 Test23:");

        WriteLine();
    }
    public static void T24()
    {
        WriteLine("Level1 Test24:");

        WriteLine();
    }
    public static void T25()
    {
        WriteLine("Level1 Test25:");

        WriteLine();
    }
    public static void T26()
    {
        WriteLine("Level1 Test26:");

        WriteLine();
    }
    public static void T27()
    {
        WriteLine("Level1 Test27:");

        WriteLine();
    }
    public static void T28()
    {
        WriteLine("Level1 Test28:");

        WriteLine();
    }
    public static void T29()
    {
        WriteLine("Level1 Test29:");
		int i, j, ind = 0;
		double[,] a = new double[5, 7] {
			{84, 21, 81, 15, 10, 99, 58},
			{95, 2, 27, 99, 94, 17, 11},
			{13, 38, 99, 78, 14, 95, 31},
			{66, 26, 16, 11, 68, 20, 62},
			{69, 3, 82, 28, 8, 51, 76}
		};
		for (j = 0; j < 7; j++)
		{
			if (Math.Abs(a[1, j]) < Math.Abs(a[1, ind]))
			{
				ind = j;
			}
		}
		for (i = 0; i < 5; i++)
		{
			for (j = ind; j < 6; j++)
			{
				(a[i, j], a[i, j + 1]) = (a[i, j + 1], a[i, j]);
			}
		}
		for (i = 0; i < 5; i++)
		{
			for (j = 0; j < 6; j++)
			{
				Write($"{a[i, j]}\t");
			}
			WriteLine();
		}
        WriteLine();
    }
    public static void T30()
    {
        WriteLine("Level1 Test30:");

        WriteLine();
    }
    public static void T31()
    {
        WriteLine("Level1 Test31:");
		int i, j, ind = 0;
		double[] b = new double[5] {1, 23, 4, 5, 6};
		double[,] a = new double[5, 8] {
			{98, 27, 27, 8, 53, 21, 82, 0},
			{79, 27, 48, 55, 20, 34, 61, 0},
			{30, 11, 50, 66, 55, 59, 28, 0},
			{48, 73, 9, 24, 20, 1, 23, 0},
			{2, 46, 59, 92, 16, 8, 52, 0}
		};
		for (j = 0; j < 7; j++)
		{
			if (a[4, j] < a[4, ind])
			{
				ind = j;
			}
		}
		for (i = 0; i < 5; i++)
		{
			for (j = 7; j > ind + 1; j--)
			{
				(a[i, j], a[i, j - 1]) = (a[i, j - 1], a[i, j]);
			}
		}
		for (i = 0; i < 5; i++)
		{
			a[i, ind + 1] = b[i];
		}
		for (i = 0; i < 5; i++)
		{
			for (j = 0; j < 8; j++)
			{
				Write($"{a[i, j]}\t");
			}
			WriteLine();
		}
        WriteLine();
    }
    public static void T32()
    {
        WriteLine("Level1 Test32:");

        WriteLine();
    }
    public static void T33()
    {
        WriteLine("Level1 Test33:");

        WriteLine();
    }
}