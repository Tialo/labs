using static System.Console;
using static System.Convert;

class Additional
{
    public static void T11()
    {
        WriteLine("Additional Test11:");
		int n, i, i1 = 0, i2;
		double x;
		bool fail = false;
		n = ToInt32(ReadLine());
		i2 = n;
		double[] a = new double[n];
		for (i = 0; i < n; i++)
		{
			a[i] = ToDouble(ReadLine());
		}
		x = ToDouble(ReadLine());
		i = (i1 + i2) / 2;
		while (a[i] != x)
		{
			if (x < a[i])
			{
				i2 = i - 1;
			}
			if (x > a[i])
			{
				i1 = i + 1;
			}
			if (i2 < i1)
			{
				WriteLine(-1);
				fail = true;
				break;
			}
			i = (i1 + i2) / 2;
		}
        WriteLine();
		if (!fail)
		{
			WriteLine(i);
		}
    }
    public static void T12()
    {
        WriteLine("Additional Test12:");
		int n, i;
		n = ToInt32(ReadLine());
		double[] a = new double[n], b = new double[n], c = new double[2 * n];
		for (i = 0; i < n; i++)
		{
			a[i] = ToDouble(ReadLine());
		}
		for (i = 0; i < n; i++)
		{
			b[i] = ToDouble(ReadLine());
		}
		for (i = 0; i < 2 * n; i++)
		{
			if (i % 2 == 0)
			{
				c[i] = a[i / 2];
			}
			else
			{
				c[i] = b[i / 2];
			}
			WriteLine(c[i]);
		}
        WriteLine();
    }
    public static void T13()
    {
        WriteLine("Additional Test13:");
		int n, m, i = 0, j = 0, f = 0;
		n = ToInt32(ReadLine());
		m = ToInt32(ReadLine());
		double[] a = new double[n], b = new double[m], c = new double[m + n];
		for (i = 0; i < n; i++)
		{
			a[i] = ToDouble(ReadLine());
		}
		for (j = 0; j < m; j++)
		{
			b[j] = ToDouble(ReadLine());
		}
		i = j = 0;
		while (i + j < m + n)
		{
			if (i >= n)
			{
				c[f] = b[j];
				j++;
			}
			else if (j >= m)
			{
				c[f] = a[i];
				i++;
			}
			else
			{
				if (a[i] >= b[j])
				{
					c[f] = a[i];
					i++;
				}
				else
				{
					c[f] = b[j];
					j++;
				}	
			}
			f++;
		}
        WriteLine();
		for (i = 0; i < m + n; i++)
		{
			WriteLine(c[i]);
		}
    }
    public static void T14()
    {
        WriteLine("Additional Test14:");
		int n, i;
		n = ToInt32(ReadLine());
		double[] a = new double[n];
		for (i = 0; i < n; i++)
		{
			a[i] = ToDouble(ReadLine());
		}
		for (i = 0; i < n / 2; i++)
		{
			(a[i], a[n - i - 1]) = (a[n - i - 1], a[i]);
		}
        WriteLine();
		for (i = 0; i < n; i++)
		{
			WriteLine(a[i]);
		}
    }
    public static void T15()
    {
        WriteLine("Additional Test15:");
		int i, n, m;
		n = ToInt32(ReadLine());
		m = ToInt32(ReadLine());
		double[] a = new double[n];
		for (i = 0; i < n; i++)
		{
			a[(i + m) % n] = ToDouble(ReadLine());
		}
        WriteLine();
		for (i = 0; i < n; i++)
			WriteLine(a[i]);
    }
}