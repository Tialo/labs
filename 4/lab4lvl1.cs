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
		int i, j;
		double s = 0;
		double[,] a = new double[4, 4];
		for (i = 0; i < 4; i++)
		{
			for (j = 0; j < 4; j++)
			{
				a[i, j] = ToDouble(ReadLine());
				s += a[i, j];
			}
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
		double[,] a = new double[4, 7];
		int[] b = new int[4];
		int i, j, ind;
		for (i = 0; i < 4; i++)
		{
			ind = 0;
			for (j = 0; j < 7; j++)
			{
				a[i, j] = ToDouble(ReadLine());
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
		double[,] a = new double[6, 7], b = new double[5, 6];
		int i, j, max_i = 0, max_j = 0;
		for (i = 0; i < 6; i++)
		{
			for (j = 0; j < 7; j++)
			{
				a[i, j] = ToDouble(ReadLine());
				if (a[i, j] > a[max_i, max_j])
				{
					(max_i, max_j) = (i, j);
				}
			}
		}
		for (i = 0; i < 6; i++)
		{
			for (j = 0; j < 7; j++)
			{
				if (i < max_i)
				{
					if (j < max_j)
					{
						b[i, j] = a[i, j];
						Write($"{b[i, j]}\t");
					}
					else if (j > max_j)
					{
						b[i, j - 1] = a[i, j];
						Write($"{b[i, j - 1]}\t");
					}
				}
				else if (i > max_i)
				{
					if (j < max_j)
					{
						b[i - 1, j] = a[i, j];
						Write($"{b[i - 1, j]}\t");
					}
					else if (j > max_j)
					{
						b[i - 1, j - 1] = a[i, j];
						Write($"{b[i - 1, j - 1]}\t");
					}
				}
			}
			if (i == max_i)
			{
				continue;
			}
			WriteLine();
		}
        WriteLine();
    }
    public static void T13()
    {
        WriteLine("Level1 Test13:");
		int i, j, max_i = 0, max_j = 0;
		double[,] a = new double[5, 5];
		for (i = 0; i < 5; i++)
		{
			for (j = 0; j < 5; j++)
			{
				a[i, j] = ToDouble(ReadLine());
				if (i == j && a[i, j] > a[max_i, max_j])
				{
					(max_i, max_j) = (i, j);
				}
			}
		}
        WriteLine();
		for (i = 0; i < 5; i++)
		{
			(a[i, 4], a[i, max_j]) = (a[i, max_j], a[i, 4]);
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
		int i, j, n, m, ind;
		n = ToInt32(ReadLine());
		m = ToInt32(ReadLine());
		double[,] a = new double[n, m];
		for (i = 0; i < n; i++)
		{
			ind = 0;
			for (j = 0; j < m; j++)
			{
				a[i, j] = ToDouble(ReadLine());
				if (a[i, j] < a[i, ind])
				{
					ind = j;
				}
			}
			for (j = ind; j >= 1; j--)
			{
				(a[i, j], a[i, j - 1]) = (a[i, j - 1], a[i, j]);
			}
			for (j = 0; j < m; j++)
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
		double[,] a = new double[5, 7], b = new double[5, 6];
		for (i = 0; i < 5; i++)
		{
			for (j = 0; j < 7; j++)
			{
				a[i, j] = ToDouble(ReadLine());
			}
		}
		for (j = 0; j < 7; j++)
		{
			if (Math.Abs(a[1, j]) < Math.Abs(a[1, ind]))
			{
				ind = j;
			}
		}
		for (i = 0; i < 5; i++)
		{
			for (j = 0; j < 6; j++)
			{
				if (j < (ind + 1) % 7)
				{
					b[i, j] = a[i, j];
				}
				else if (j >= (ind + 1) % 7)
				{
					b[i, j] = a[i, j + 1];
				}
				Write($"{b[i, j]}\t");
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
		double[] b = new double[5];
		double[,] a = new double[5, 8];
		for (i = 0; i < 5; i++)
		{
			for (j = 0; j < 7; j++)
			{
				a[i, j] = ToDouble(ReadLine());
				if (i == 4 && a[i, j] < a[i, ind])
				{
					ind = j;
				}
			}
		}
		for (i = 0; i < 5; i++)
		{
			b[i] = ToDouble(ReadLine());
		}
		for (i = 0; i < 5; i++)
		{
			for (j = 7; j > ind; j--)
			{
				if (j > ind + 1)
				{
					a[i, j] = a[i, j - 1];
				}
				else if (j == ind + 1)
				{
					a[i, j] = b[i];
				}
			}
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
