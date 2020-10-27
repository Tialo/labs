using static System.Console;
using static System.Convert;

class Additional
{
    public static void T11()
    {
        WriteLine("Additional Test11:");
		int i, i1 = 0, i2 = 10;
		double x;
		bool fail = false;
		double[] a = new double[10] {1, 3, 5, 7, 8, 10, 11, 13, 14, 15};
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
		int i;
		double[] a = new double[5] {1, 2, 3, 4, 5}, b = new double[5] {-1, -2, -3, -4 , -5}, c = new double[10];
		for (i = 0; i < 5; i++)
		{
			c[2 * i] = a[i];
		}
		for (i = 0; i < 5; i++)
		{
			c[2 * i + 1] = b[i];
		}
		for (i = 0; i < 10; i++)
		{
			WriteLine(c[i]);
		}
        WriteLine();
    }
    public static void T13()
    {
        WriteLine("Additional Test13:");
		int i = 0, j = 0, f = 0;
		double[] a = new double[4] {1, 56, 188, 288}, b = new double[5] {2, 3, 4, 199, 311}, c = new double[9];
		while (i + j < 9)
		{
			if (i >= 4)
			{
				c[f] = b[j];
				j++;
			}
			else if (j >= 5)
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
		for (i = 0; i < 9; i++)
		{
			WriteLine(c[i]);
		}
    }
    public static void T14()
    {
        WriteLine("Additional Test14:");
		int i;
		double[] a = new double[7] {1, 2, 3, 4, 5, 6, 7};
		for (i = 0; i < 7 / 2; i++)
		{
			(a[i], a[7 - i - 1]) = (a[7 - i - 1], a[i]);
		}
        WriteLine();
		for (i = 0; i < 7; i++)
		{
			WriteLine(a[i]);
		}
    }
    public static void T15()
    {
        WriteLine("Additional Test15:");
		int i, m = 2;
		double[] a = new double[7] {0, 1, 2, 3, 4, 5, 6};
		for (i = 0; i < 7; i++)
		{
			a[(i + m) % 7] = a[i];
		}
        WriteLine();
		for (i = 0; i < 7; i++)
			WriteLine(a[i]);
    }
}