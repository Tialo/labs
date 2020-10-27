using static System.Console;
using static System.Convert;
using static System.Math;

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
		int max_i = 0, min_i = 0, i, c = 0, j = 0;
		double[] a = new double[7] {5, 10, -1, 2, -4, -20, 3};
		for (i = 0; i < 7; i++)
		{		
			if (a[i] > a[max_i])
				max_i = i;
			if (a[i] < a[min_i])
				min_i = i;
		}
		if (max_i < min_i)
			(min_i, max_i) = (max_i, min_i);
		for (i = min_i + 1; i <= max_i; i++)
		{
			if (a[i] < 0)
				c++;
		}
		double[] b = new double[c];
		for (i = 0; j < c; i++)
		{
			if (a[i] < 0)
			{
				b[j] = a[i];
				WriteLine(b[j]);
				j++;
			}
		}
        WriteLine();
    }
    public static void T6()
    {
        WriteLine("Level2 Test6:");
		int i = 0, ind = 0;
		double P, s = 0, d;
		P = ToDouble(ReadLine());
		double[] a = new double[9] {24, 49, 16, 37, 39, 78, 41, 91, -1};
		for (; i < 8; i++)
		{
			s += a[i];
		}
		s /= 8;
		d = Abs(s - a[0]);
		for (i = 0; i < 8; i++)
		{
			if (Abs(a[i] - s) <= d)
			{
				ind = i + 1;
				d = Abs(a[i] - s);
			}
		}
		WriteLine("----------------------------");
		for (i = 8; i > ind; i--)
		{
			a[i] = a[i - 1];
		}
		a[ind] = P;
		for (i = 0; i < 9; i++)
		{
			WriteLine(a[i]);
		}		
        WriteLine();
    }
    public static void T7()
    {
        WriteLine("Level2 Test7:");

        WriteLine();
    }
    public static void T8()
    {
        WriteLine("Level2 Test8:");

        WriteLine();
    }
    public static void T9()
    {
        WriteLine("Level2 Test9:");
		double s = 0;
		int i, min_i = 0, max_i = 0;
		double[] a = new double[8] {412, 10, 21, 1245, 21, 45, 8, 543};
		for (i = 0; i < 8; i++)
		{
			if (a[i] < a[min_i])
				min_i = i;
			if (a[i] > a[max_i])
				max_i = i;
		}
		if (max_i < min_i)
			(min_i, max_i) = (max_i, min_i);
		for (i = min_i + 1; i < max_i; i++)
		{
			s += a[i];
		}
		s /= max_i - min_i - 1;
        WriteLine(s);
    }
    public static void T10()
    {
        WriteLine("Level2 Test10:");
		int i, ind = 0;
		double[] a = new double[9] {-1, 16, -5, 5, 9, -24, 24, 2, 18};
		for (i = 0; i < 9; i++)
		{
			if (a[i] > 0)
			{
				ind = i;
				break;
			}
		}
		for (i = 0; i < 9; i++)
		{
			if (a[i] < a[ind] && a[i] > 0)
				ind = i;
		}
		for (i = ind; i < 8; i++)
		{
			a[i] = a[i + 1];
		}
		for (i = 0; i < 8; i++)
		{
			WriteLine(a[i]);
		}
        WriteLine();
    }
    public static void T11()
    {
        WriteLine("Level2 Test11:");
		int i, ind = 0;
		double P;
		P = ToInt32(ReadLine());
		double[] a = new double[9] {-7, -2, 4, 12, -5, -4, 14, -99, 0};
		for (i = 0; i < 8; i++)
		{
			if (a[i] > 0)
				ind = i + 1;
		}
		for (i = 8; i > ind; i--)
		{
			a[i] = a[i - 1];
		}
		a[ind] = P;
		for (i = 0; i < 9; i++)
		{
			WriteLine(a[i]);
		}
        WriteLine();
    }
    public static void T12()
    {
        WriteLine("Level2 Test12:");
		int i, ind = -1, max_i = 0;
		double s = 0;
		double[] a = new double[9] {2, 3, -9, 41, -6, 51, 2, -4, 28};
		for (i = 0; i < 9; i++)
		{
			if (ind == -1 && a[i] < 0)
				ind = i;
			if (a[max_i] < a[i])
				max_i = i;
		}
		for (i = max_i + 1; i < 9; i++)
		{
			s += a[i];
		}
		a[ind] = s;
		for (i = 0; i < 9; i++)
		{
			WriteLine(a[i]);
		}
        WriteLine();
    }
    public static void T13()
    {
        WriteLine("Level2 Test13:");
		int i, ind = 0;
		double[] a = new double[6] {4, 12, 9, 124, 2, -1};
		for (i = 0; i < 6; i += 2)
		{
			if (a[i] > a[ind])
				ind = i;
		}
		a[ind] = ind;
		for (i = 0; i < 6; i++)
		{
			WriteLine(a[i]);
		}
        WriteLine();
    }
    public static void T14()
    {
        WriteLine("Level2 Test14:");
		
        WriteLine();
    }
    public static void T15()
    {
        WriteLine("Level2 Test15:");
		int k, i;
		k = 3;
		double[] a = new double[7] {1, 2, 3, 4, 5, 6, 7}, b = new double[15] {12, 534, 12, 421, 41, 3, 534, 551, 0, 0, 0, 0, 0, 0, 0};
		for (int j = 0; j < 7; j++)
		{
			for (i = 14; i >= k; i--)
			{
				b[i] = b[i - 1];
			}
		}
		for (i = k; i < k + 7; i++)
		{
			b[i] = a[i - k];
		}
		for (i = 0; i < 15; i++)
		{
			WriteLine(b[i]);
		}
        WriteLine();
    }
    public static void T16()
    {
        WriteLine("Level2 Test16:");

        WriteLine();
    }
    public static void T17()
    {
        WriteLine("Level2 Test17:");

        WriteLine();
    }
    public static void T18()
    {
        WriteLine("Level2 Test18:");

        WriteLine();
    }
    public static void T19()
    {
        WriteLine("Level2 Test19:");

        WriteLine();
    }
    public static void T20()
    {
        WriteLine("Level2 Test20:");

        WriteLine();
    }
}