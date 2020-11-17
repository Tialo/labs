using static System.Console;
using static System.Convert;
using System;

namespace Lab5lvl1
{
	public class T1
	{
		static public void Start()
		{
			WriteLine("Level1 Task1:");
			WriteLine(combination(8, 5));
			WriteLine(combination(10, 5));
			WriteLine(combination(11, 5));
		}
		static public int combination(int n, int k)
		{
			return factorial(n) / (factorial(k) * factorial(n - k));
		}
		static public int factorial(int n)
		{
			int f = 1;
			for (int i = 1; i <= n; i++)
			{
				f *= i;
			}
			return f;
		}
	}
	public class T2
	{
		static public void Start()
		{
			WriteLine("Level1 Task2:");
			double x = 10, y = 4, z = 7;
			WriteLine(Area(x, y, z));
		}
		static public double Area(double a, double b, double c)
		{
			double p = (a + b + c) / 2;
			return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
		}
	}
}