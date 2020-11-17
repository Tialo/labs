using System;
using static System.Console;

namespace Lab5lvl3
{
	public class T1
	{
		public delegate double fi(double x, ref int i, ref int den);
		public static void Start()
		{
			for (double x = 0.1; x <= 1; x += 0.1)
			{
				WriteLine(1 + Sum(x, firstTerm));
				WriteLine(Math.Exp(Math.Cos(x))*Math.Cos(Math.Sin(x)));
				WriteLine("==================");
			}
			WriteLine("Second Sum");
			for (double x = Math.PI / 5 ; x <= Math.PI; x += Math.PI / 25)
			{
				WriteLine(Sum(x, secondTerm));
				WriteLine((x * x - Math.PI * Math.PI / 3) / 4);
				WriteLine("==================");
			}
		}
		public static double firstTerm(double x, ref int i, ref int den)
		{
			i++;
			den *= i;
			return Math.Cos(i * x) / den;
		}
		public static double secondTerm(double x, ref int i, ref int den)
		{
			i++;
			den = i * i;
			if (i % 2 == 0)
			{
				return Math.Cos(i * x) / den;
			}
			else
			{
				return -Math.Cos(i * x) / den;
			}
		}
		public static double Sum(double x, fi f)
		{
			int den = 1;
			int i = 0;
			double a, s = 0;
			do
			{
				a = f(x, ref i, ref den);
				s += a;
			} while (Math.Abs(a) > 0.00001);
			return s;
		}
	}
	
	public class T2
	{
		public delegate double[,] fi(double[,] x, int y);
		public static void Start()
		{
			double[,] a = new double[4, 5] {
				{1, 7, 2, 129, 3},
				{6, 2, 213, 4, 5},
				{6, 41, 32, 4, 12},
				{125, 754, 32, 643, 12}
			};
			for (int i = 0; i < 4; i++)
			{
				if (i % 2 == 0)
				{
					a = transform(a, ascSort, i);
				}
				else
				{
					a = transform(a, desSort, i);
				}
			}
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					Write($"{a[i, j]} ");
				}
				WriteLine();
			}
		}
		public static double[,] transform(double[,] x, fi f, int i)
		{
			return f(x, i);
		}
		public static double[,] ascSort(double[,] x, int y)
		{
			for (int i = 0; i < x.GetLength(1) - 1; i++)
			{
				int m_ind = i;
				for (int j = i + 1; j < x.GetLength(1); j++)
				{
					if (x[y ,j] < x[y, m_ind])
					{
						m_ind = j;
					}
				}
				(x[y, i], x[y, m_ind]) = (x[y, m_ind], x[y ,i]);
			}
			return x;
		}
		public static double[,] desSort(double[,] x, int y)
		{
			for (int i = 0; i < x.GetLength(1) - 1; i++)
			{
				int m_ind = i;
				for (int j = i + 1; j < x.GetLength(1); j++)
				{
					if (x[y ,j] > x[y, m_ind])
					{
						m_ind = j;
					}
				}
				(x[y, i], x[y, m_ind]) = (x[y, m_ind], x[y ,i]);
			}
			return x;
		}
	}
	
	public class T3
	{
		public delegate double fi(double x);
		public static double y1(double x)
		{
			return x * x - Math.Sin(x);
		}
		public static double y2(double x)
		{
			return Math.Exp(x) - 1;
		}
		public static int sgn(fi f, double x)
		{
			if (f(x) >= 0) return 1;
			else return -1;
		}
		public static int cnt(fi f, double a, double b, double h)
		{
			int	ans = 1, curr = sgn(f, a);
			for (double x = a + h; x <= b; x += h)
			{
				if (curr != sgn(f, x))
				{
					ans++;
					curr *= -1;
				}
			}
			return ans;
		}
		public static void Start()
		{
			WriteLine(cnt(y1, 0, 2, 0.1));
			WriteLine(cnt(y2, -1, 1, 0.2));
		}
	}
}