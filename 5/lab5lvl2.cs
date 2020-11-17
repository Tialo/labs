using static System.Console;
using static System.Convert;
using System;

namespace Lab5lvl2
{
	public class T6
	{
		static public void Start()
		{
			WriteLine("Level2 Test6:");
			double[] a = new double[7] {213, 2, 3, 756, 42, 12, 42}, b = new double[8] {14, 12, 4, 412, 53, 756, 12, 41};
			int i;
			a = deleteMax(a);
			b = deleteMax(b);
			a = concatenation(a, b);
			for (i = 0; i < a.Length; i++)
			{
				WriteLine($"{a[i]} ");
			}
		}
		static public double[] deleteMax(double[] x)
		{
			int m_i = 0, i;
			for (i = 0; i < x.Length; i++)
			{
				if (x[i] > x[m_i])
				{
					m_i = i;
				}
			}
			for (i = m_i; i < x.Length - 1; i++)
			{
				(x[i], x[i + 1]) = (x[i + 1], x[i]);
			}
			return x;
		}
		public static double[] concatenation(double[] x, double[] y)
		{
			double[] f = new double[13];
			int i;
			for (i = 0; i < 6; i++)
			{
				f[i] = x[i];
			}
			for (i = 0; i < 7; i++)
			{
				f[i + 6] = y[i];
			}
			return f;
		}
	}
	
	public class T10
	{
		public static void Start()
		{
			WriteLine("Level2 Test10:");
			int i, j, ti = 0, tj = 0, bi = 0, bj = 1;
			double[,] a = new double[7, 7] {
				{27, 78, 84, 82, 77, 15, 96},
				{39, 18, 98, 72, 60, 23, 9},
				{71, 69, 36, 12, 50, 72, 63},
				{70, 0, 43, 17, 91, 59, 78},
				{28, 94, 93, 34, 42, 94, 82},
				{92, 95, 15, 13, 9, 99, 28},
				{8, 90, 67, 11, 11, 40, 10}
			};
			for (i = 0; i < 7; i++)
			{
				for (j = 0; j < 7; j++)
				{
					if (i >= j && a[i, j] > a[bi, bj])
					{
						(bi, bj) = (i, j);
					}
					else if (j > i && a[i, j] < a[ti, tj])
					{
						(ti, tj) = (i, j);
					}
				}
			}
			if (tj > bj)
			{
				a = deleteColumn(a, tj);
				a = deleteColumn(a, bj);
			}
			else if (bj > tj)
			{
				a = deleteColumn(a, bj);
				a = deleteColumn(a, tj);
			}
			else
			{
				a = deleteColumn(a, tj);
			}
			for (i = 0; i < a.GetLength(0); i++)
			{
				for (j = 0; j < a.GetLength(1) - 2; j++)
				{
					Write($"{a[i, j]}\t");
				}
				WriteLine();
			}
		}
		public static double[,] deleteColumn(double[,] x, int ind)
		{
			int i, j;
			for (i = 0; i < x.GetLength(0); i++)
			{
				for (j = ind; j < x.GetLength(1) - 1; j++)
				{
					(x[i, j], x[i, j + 1]) = (x[i, j + 1], x[i, j]);
				}
			}
			return x;
		}
	}
	
	public class T23
	{
		public static void Start()
		{
			WriteLine("Level2 Test23");
			int i, j;
			double[,] a = new double[6, 5] {
				{43, 12, 15, 53, 98},
				{14, 22, 14, 33, 83},
				{79, 54, 31, 46, 47},
				{24, 52, 94, 88, 5},
				{95, 81, 28, 7, 88},
				{36, 97, 15, 26, 84}
			}, b = new double[4, 7] {
				{9, 33, 65, 45, 17, 43, 92},
				{73, 67, 94, 22, 98, 11, 30},
				{3, 91, 18, 75, 11, 46, 67},
				{48, 36, 85, 42, 37, 27, 23}
			};
			a = transform(a);
			b = transform(b);
			WriteLine("===================");
			for (i = 0; i < 6; i++)
			{
				for (j = 0; j < 5; j++)
				{
					Write($"{a[i, j]} ");
				}
				WriteLine();
			}
			WriteLine("===================");
			for (i = 0; i < 4; i++)
			{
				for (j = 0; j < 7; j++)
				{
					Write($"{b[i, j]} ");
				}
				WriteLine();
			}
		}
		public static double[] find5Max(double[,] x)
		{
			double[] f = new double[x.Length];
			double[] ans = new double[5];
			for (int i = 0; i < x.GetLength(0); i++)
			{
				for (int j = 0; j < x.GetLength(1); j++)
				{
					f[x.GetLength(1) * i + j] = x[i, j];
				}
			}
			for (int i = 0; i < f.Length; i++)
			{
				for (int j = i; j < f.Length; j++)
				{
					if (f[i] < f[j])
					{
						(f[i], f[j]) = (f[j], f[i]);
					}
				}
			}
			for (int i = 0; i < 5; i++)
			{
				ans[i] = f[i];
			}
			return ans;
		}
		public static double[,] transform(double[,] x)
		{
			double[] f = find5Max(x);
			int i, j, c = 0;
			for (int k = 0; k < 5; k++)
			{
				for (i = 0; i < x.GetLength(0); i++)
				{
					for (j = 0; j < x.GetLength(1); j++)
					{
						if (x[i, j] == f[k] && c == k)
						{
							x[i, j] *= 4;
							c++;
						}
					}
				}
			}
			for (i = 0; i < x.GetLength(0); i++)
			{
				for (j = 0; j < x.GetLength(1); j++)
				{
					x[i, j] /= 2;
				}
			}
			return x;
		}
	}
}