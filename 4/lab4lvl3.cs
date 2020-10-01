using static System.Console;
using static System.Convert;

class Level3
{
    public static void T1a()
    {
        WriteLine("Level3 Test1:");
		int i, j, ind, k = 0;
		double[,] a = new double[7, 5], d = new double[7, 5];
		double[] b = new double[7];
		for (i = 0; i < 7; i++)
		{
			ind = 0;
			for (j = 0; j < 5; j++)
			{
				a[i, j] = ToDouble(ReadLine());
				if (a[i, j] < a[i, ind])
				{
					ind = j;
				}
			}	
			b[k] = a[i, ind];
			k++;
		}
		for (i = 0; i < 7; i++)
		{
			ind = 0;
			for (j = 0; j < 7; j++)
			{
				if (b[j] > b[ind])
				{
					ind = j;
				}
			}
			for (j = 0; j < 5; j++)
			{
				d[i, j] = a[ind, j];
			}
			b[ind] = double.NegativeInfinity;
		}
		for (i = 0; i < 7; i++)
		{
			for (j = 0; j < 5; j++)
			{
				Write($"{d[i, j]}\t");
			}
			WriteLine();
		}
        WriteLine();
    }
    public static void T1b()
    {
        WriteLine("Level3 Test1:");
		int i, j, ind, k = 0;
		double[] a = new double[7 * 5], d = new double[7 * 5];
		double[] b = new double[7];
		for (i = 0; i < 7; i++)
		{
			ind = 0;
			for (j = 0; j < 5; j++)
			{
				a[i * 5 + j] = ToDouble(ReadLine());
				if (a[i * 5 + j] < a[i * 5 + ind])
				{
					ind = j;
				}
			}	
			b[k] = a[i * 5 + ind];
			k++;
		}
		for (i = 0; i < 7; i++)
		{
			ind = 0;
			for (j = 0; j < 7; j++)
			{
				if (b[j] > b[ind])
				{
					ind = j;
				}
			}
			for (j = 0; j < 5; j++)
			{
				d[i * 5 + j] = a[ind * 5 + j];
			}
			b[ind] = double.NegativeInfinity;
		}
		for (i = 0; i < 7; i++)
		{
			for (j = 0; j < 5; j++)
			{
				Write($"{d[i * 5 + j]}\t");
			}
			WriteLine();
		}
        WriteLine();
    }
    public static void T2()
    {
        WriteLine("Level3 Test2:");
		const int n = 10;
		double[,] a = new double[n, n];
		int i, j;
		for (i = 0; i < n; i++)
		{
			for (j = 0; j < n; j++)
			{
				a[i, j] = 1;
			}
		}
		for (i = 0; i < 2 * n; i++)
		{
			a[i % 10, i / 10 * 9] = a[i / 10 * 9, i % 10] = 0;
		}
		for (i = 0; i < n; i++)
		{
			for (j = 0; j < n; j++)
			{
				Write($"{a[i, j]}\t");
			}
			WriteLine();
		}
        WriteLine();
    }
    public static void T3()
    {
        WriteLine("Level3 Test3:");
		int n, i, j, k = 0;
		n = ToInt32(ReadLine());
		double[,] a = new double[n, n];
		double[] b = new double[2 * n - 1];
		for (i = 0; i < n; i++)
		{
			for (j = 0; j < n; j++)
			{
				a[i, j] = ToDouble(ReadLine());
			}
		}
		for (i = 0; i < n; i++)
		{
			for (j = 0; j < n; j++)
			{
				Write($"{a[i, j]}\t");
			}
			WriteLine();
		}
		for (i = n - 1; i >= 0; i--)
		{
			for (j = 0; j <= n - 1 - i; j++)
			{
				b[k] += a[i + j, j];
			}
			k++;
		}
		k = 2 * n - 2;
		for (j = n - 1; j > 0; j--)
		{
			for (i = 0; i <= n - 1 - j; i++)
			{
				b[k] += a[i, j + i];
			}
			k--;
		}
        WriteLine();
		for (i = 0; i < 2 * n - 1; i++)
		{
			Write($"{b[i]} ");
		}
    }
    public static void T4()
    {
        WriteLine("Level3 Test4:");
		int i, j, n;
		n = ToInt32(ReadLine());
		double[,] a = new double[n, n];
		for (i = 0; i < n; i++)
		{
			for (j = 0; j < n; j++)
			{
				a[i, j] = ToDouble(ReadLine());
				if (i >= n / 2 && i >= j)
				{
					a[i, j] = 1;
				}
			}
		}
        WriteLine();
		for (i = 0; i < n; i++)
		{
			for (j = 0; j < n; j++)
			{
				Write($"{a[i, j]}\t");
			}
			WriteLine();
		}
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
		int i, j, k = 0;
		double[,] a = new double[7, 5], d = new double[7, 5];
		double[] b = new double[7];
		for (i = 0; i < 7; i++)
		{
			for (j = 0; j < 5; j++)
			{
				a[i, j] = ToDouble(ReadLine());
				if (a[i, j] > 0)
				{
					b[k]++;
				}
			}
			k++;
		}
		for (i = 0; i < 7; i++)
		{
			k = 0;
			for (j = 0; j < 7; j++)
			{
				if (b[j] > b[k])
				{
					k = j;
				}
			}
			for (j = 0; j < 5; j++)
			{
				d[i, j] = a[k, j]; 
				Write($"{d[i, j]}\t");
			}
			WriteLine();
			b[k] = double.NegativeInfinity;
		}
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
		int n, m, i, j, q, ind;
		n = ToInt32(ReadLine());
		m = ToInt32(ReadLine());
		double[,] a = new double[n, m];
		double[] b = new double[m];
		for (i = 0; i < n; i++)
		{
			for (j = 0; j < m; j++)
			{
				a[i, j] = ToDouble(ReadLine());
			}
			for (j = 0; j < m - 2; j += 2)
			{
				ind = j;
				for (q = j + 2; q < m; q += 2)
				{
					if (a[i, q] > a[i, ind])
					{
						ind = q;
					}
				}
				(a[i, j], a[i, ind]) = (a[i, ind], a[i, j]);
			}
			for (j = 1; j < m - 2; j += 2)
			{
				ind = j;
				for (q = j + 2; q < m; q += 2)
				{
					if (a[i, q] < a[i, ind])
					{
						ind = q;
					}
				}
				(a[i, j], a[i, ind]) = (a[i, ind], a[i, j]);
			}
		}
		for (i = 0; i < n; i++)
		{
			for (j = 0; j < m; j++)
			{
				Write($"{a[i, j]}\t");
			}
			WriteLine();
		}
        WriteLine();
    }
    public static void T11()
    {
        WriteLine("Level3 Test11:");
		int n, m, i, j, l = 0, r = 0, i_d = 0, j_d = 0;
		n = ToInt32(ReadLine());
		m = ToInt32(ReadLine());
		double[,] a = new double[n, m];
		int[] b = new int[n], c = new int[m];
		for (i = 0; i < n; i++)
		{
			for (j = 0; j < m; j++)
			{
				a[i, j] = ToDouble(ReadLine());
				if (a[i, j] == 0)
				{
					b[i] = c[j] = 1;
				}
			}
		}
		for (i = 0; i < n; i++)
		{
			l += b[i];
		}
		for (j = 0; j < m; j++)
		{
			r += c[j];
		}
		double[,] d = new double[n - l, m - r];
		for (i = 0; i < n; i++)
		{
			if (b[i] == 1)
			{
				i_d++;
				continue;
			}
			for (j = 0; j < m; j++)
			{
				if (c[j] == 1)
				{
					j_d++;
					continue;
				}
				d[i - i_d, j - j_d] = a[i, j];
				Write($"{d[i - i_d, j - j_d]}\t");
			}
			WriteLine();
			j_d = 0;
		}
        WriteLine();
    }
    public static void T12()
    {
        WriteLine("Level3 Test12:");

        WriteLine();
    }
    public static void T13()
    {
        WriteLine("Level3 Test13:");

        WriteLine();
    }
    public static void T14()
    {
        WriteLine("Level3 Test14:");

        WriteLine();
    }
}