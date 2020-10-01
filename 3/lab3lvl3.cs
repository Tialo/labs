using static System.Console;
using static System.Convert;

class Level3
{
    public static void T1()
    {
        WriteLine("Level3 Test1:");
		int n, i, max_i = 0, k = 0;
		n = ToInt32(ReadLine());
		double[] a = new double[n], b = new double[n];
		for (i = 0; i < n; i++)
		{
			a[i] = ToDouble(ReadLine());
			if (a[i] > a[max_i])
			{
				max_i = i;
				b[0] = max_i;
				k = 1;
			}
			else if (a[i] == a[max_i])
			{
				b[k] = i;
				k++;
			}			
		}
        WriteLine();
		for (i = 0; i < k; i++)
		{
			WriteLine(b[i]);
		}
    }
    public static void T2()
    {
        WriteLine("Level3 Test2:");

        WriteLine();
    }
    public static void T3()
    {
        WriteLine("Level3 Test3:");

        WriteLine();
    }
    public static void T4()
    {
        WriteLine("Level3 Test4:");

        WriteLine();
    }
    public static void T5()
    {
        WriteLine("Level3 Test5:");
		int n, i, j, min_i = 0;
		n = ToInt32(ReadLine());
		double[] a = new double[n], b = new double[(n + 1) / 2];
		for (i = 0; i < n; i++)
		{
			a[i] = ToDouble(ReadLine());
			if (i % 2 == 0)
			{
				b[i / 2] = a[i];
			}
		}
		for (i = 0; i < (n + 1) / 2 - 1; i++)
		{
			min_i = i;
			for (j = i + 1; j < (n + 1) / 2; j++)
			{
				if (b[j] < b[min_i])
					min_i = j;
			}
			(b[i], b[min_i]) = (b[min_i], b[i]);
		}
        WriteLine();
		for (i = 0; i < n; i++)
		{
			if (i % 2 == 0)
			{
				WriteLine(b[i / 2]);
			}
			else
				WriteLine(a[i]);
		}
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
		int n, i, j, k = 0, max_i = 0;
		n = ToInt32(ReadLine());
		double[] a = new double[n], b = new double[n];
		for (i = 0; i < n; i++)
		{
			a[i] = ToDouble(ReadLine());
			if (a[i] < 0)
			{
				b[k] = a[i];
				k++;
			}
		}
		for (i = 0; i < k - 1; i++)
		{
			max_i = i;
			for (j = i + 1; j < k; j++)
			{
				if (b[j] > b[max_i])
					max_i = j;
			}
			(b[max_i], b[i]) = (b[i], b[max_i]);
		}
		k = 0;
        WriteLine();
		for (i = 0; i < n; i++)
		{
			if (a[i] <= 0)
			{
				a[i] = b[k];
				k++;
			}
			WriteLine(a[i]);
		}
    }
    public static void T9()
    {
        WriteLine("Level3 Test9:");
		int n, i, curr_d, curr_a, best_d, best_a;
		n = ToInt32(ReadLine());
		curr_d = curr_a = best_a = best_d = 1;
		double[] a = new double[n];
		for (i = 0; i < n; i++)
		{
			a[i] = ToDouble(ReadLine());
		}
		for (i = 0; i < n - 1; i++)
		{
			if (curr_a > best_a)
			{
				best_a = curr_a;
			}
			if (curr_d > best_d)
			{
				best_d = curr_d;
			}
			if (a[i] > a[i + 1])
			{
				curr_a = 1;
				curr_d++;
			}
			else if (a[i] < a[i + 1])
			{
				curr_d = 1;
				curr_a++;
			}
			else
			{
				curr_a = curr_d = 1;
			}
		}
        WriteLine();
		if (best_a < curr_a)
		{
			best_a = curr_a;			
		}
		if (best_d < curr_d)
		{
			best_d = curr_d;
		}
		if (best_a > best_d)
		{
			WriteLine(best_a);
		}
		else
		{
			WriteLine(best_d);
		}
    }
    public static void T10()
    {
        WriteLine("Level3 Test10:");

        WriteLine();
    }
    public static void T11()
    {
        WriteLine("Level3 Test11:");

        WriteLine();
    }
    public static void T12()
    {
        WriteLine("Level3 Test12:");
		int i, c = 0, j = 0;
		double[] a = new double[12], b;
		for (i = 0; i < 12; i++)
		{
			a[i] = ToDouble(ReadLine());
			if (a[i] < 0)
			{
				c++;
			}
		}
        WriteLine();
		b = new double[12 - c];
		for (i = 0; i < 12; i++)
		{
			if (a[i] >= 0)
			{
				b[j] = a[i];
				WriteLine(b[j]);
				j++;
			}
		}
    }
    public static void T13()
    {
        WriteLine("Level3 Test13:");
		int i, n, j, k = 0;
		bool not_found = true;
		n = ToInt32(ReadLine());
		double[] a = new double[n], b = new double[n];
		for (i = 0; i < n; i++)
		{
			a[i] = ToDouble(ReadLine());
		}
		for (i = 0; i < n; i++)
		{
			for (j = 0; j < n; j++)
			{
				if (b[j] == a[i])
				{
					not_found = false;
					break;
				}
			}
			if (not_found)
			{
				b[k] = a[i];
				k++;
			}
			not_found = true;
		}
		double[] c = new double[k];
		for (i = 0; i < k; i++)
		{
			c[i] = b[i];
			WriteLine(c[i]);
		}
        WriteLine();
    }
    public static void T14()
    {
        WriteLine("Level3 Test14:");

        WriteLine();
    }
}