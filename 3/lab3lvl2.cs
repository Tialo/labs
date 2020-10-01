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
		int n, max_i = 0, min_i = 0, i, c = 0, j = 0;
		n = ToInt32(ReadLine());
		double[] a = new double[n];
		for (i = 0; i < n; i++)
		{
			a[i] = ToDouble(ReadLine());
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
		int n, i = 0, ind = 0, j = 0;
		double P, s = 0, d;
		n = ToInt32(ReadLine());
		P = ToDouble(ReadLine());
		double[] a = new double[n];
		for (; i < n; i++)
		{
			a[i] = ToDouble(ReadLine());
			s += a[i];
		}
		s /= n;
		d = a[0];
		for (i = 0; i < n; i++)
		{
			if (Abs(a[i] - s) < d)
			{
				ind = i;
				d = Abs(a[i] - s);
			}
		}
		double[] b = new double[n + 1];
		WriteLine("----------------------------");
		for (i = 0; i < n; j++)
		{
			if (j == ind + 1)
				b[j] = P;
			else
			{
				b[j] = a[i];
				i++;
			}
			WriteLine(b[j]);
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
		int n, i, min_i = 0, max_i = 0;
		n = ToInt32(ReadLine());
		double[] a = new double[n];
		for (i = 0; i < n; i++)
		{
			a[i] = ToDouble(ReadLine());
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
		int n, i, ind = 0, j = 0;
		n = ToInt32(ReadLine());
		double[] a = new double[n], b = new double[n - 1];
		for (i = 0; i < n; i++)
		{
			a[i] = ToDouble(ReadLine());
			if (a[i] < a[ind])
				ind = i;
		}
		for (i = 0; i < n; j++, i++)
		{
			if (i == ind)
			{
				i++;
				b[j] = a[i];
			}
			b[j] = a[i];
			WriteLine(b[j]);
		}
        WriteLine();
    }
    public static void T11()
    {
        WriteLine("Level2 Test11:");
		int n, i, ind = 0;
		double P;
		n = ToInt32(ReadLine());
		P = ToInt32(ReadLine());
		double[] a = new double[n], b = new double[n + 1];
		for (i = 0; i < n; i++)
		{
			a[i] = ToDouble(ReadLine());
			if (a[i] > 0)
				ind = i;
		}
		for (i = 0; i <= n; i++)
		{
			if (i < ind + 1)
			{
				b[i] = a[i];
			}
			else if (i == ind + 1)
			{
				b[i] = P;
			}
			else
			{
				b[i] = a[i - 1];
			}
			WriteLine(b[i]);
		}
        WriteLine();
    }
    public static void T12()
    {
        WriteLine("Level2 Test12:");
		int n, i, ind = -1, max_i = 0;
		double s = 0;
		n = ToInt32(ReadLine());
		double[] a = new double[n];
		for (i = 0; i < n; i++)
		{
			a[i] = ToDouble(ReadLine());
			if (ind == -1 && a[i] < 0)
				ind = i;
			if (a[max_i] < a[i])
				max_i = i;
		}
		for (i = max_i + 1; i < n; i++)
		{
			s += a[i];
		}
		for (i = 0; i < n; i++)
		{
			if (i == ind)
				a[i] = s;
			WriteLine(a[i]);
		}
        WriteLine();
    }
    public static void T13()
    {
        WriteLine("Level2 Test13:");
		int n, i, ind = 0;
		n = ToInt32(ReadLine());
		double[] a = new double[n];
		for (i = 0; i < n; i++)
		{
			a[i] = ToDouble(ReadLine());
			if (i % 2 == 0 && a[i] > a[ind])
				ind = i;
		}
		for (i = 0; i < n; i++)
		{
			if (i == ind)
				a[i] = ind;
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
		int n, m, k, i;
		n = ToInt32(ReadLine());
		m = ToInt32(ReadLine());
		k = ToInt32(ReadLine());
		double[] a = new double[n], b = new double[m], c = new double[n + m];
		for (i = 0; i < n; i++)
			a[i] = ToDouble(ReadLine());
		for (i = 0; i < m; i++)
			b[i] = ToDouble(ReadLine());
		for (i = 0; i < n + m; i++)
		{
			if (i < k)
				c[i] = a[i];
			else if (i >= k && i < k + m)
				c[i] = b[i - k];
			else
				c[i] = a[i - m];
			WriteLine(c[i]);
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