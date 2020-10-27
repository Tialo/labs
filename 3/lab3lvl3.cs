using static System.Console;
using static System.Convert;

class Level3
{
    public static void T1()
    {
        WriteLine("Level3 Test1:");
		int i, max_i = 0, k = 0;
		double[] a = new double[7], b = new double[7];
		for (i = 0; i < 7; i++)
		{
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
		int i, j, min_i = 0;
		double[] a = new double[7] {1, 543, 23, 54, 18, 91, 21};
		for (i = 0; i < 5; i += 2)
		{
			min_i = i;
			for (j = i + 2; j < 7; j += 2)
			{
				if (a[j] < a[min_i])
					min_i = j;
			}
			(a[i], a[min_i]) = (a[min_i], a[i]);
		}
        WriteLine();
		for (i = 0; i < 7; i++)
		{
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
		int i, j, max_i = 0;
		double[] a = new double[9] {1, 23, -1, 4, -51, -2, -4, 2, -6};
		for (i = 0; i < 8; i++)
		{
			max_i = i;
			for (j = i + 1; j < 9; j++)
			{
				if (a[j] > a[max_i] && a[i] < 0 && a[j] < 0)
					max_i = j;
			}
			(a[i], a[max_i]) = (a[max_i], a[i]);
		}
		for (i = 0; i < 9; i++)
		{
			WriteLine(a[i]);
		}
    }
    public static void T9()
    {
        WriteLine("Level3 Test9:");
		int i, curr_d, curr_a, best_d, best_a;
		curr_d = curr_a = best_a = best_d = 1;
		double[] a = new double[10] {1, 2, 3, 2, 1, 0, 1, 2, 3, 4};
		for (i = 0; i < 9; i++)
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
		double[] a = new double[12] { -1, 2, -3, 4, -5, -6, -7, 8, 9, 10, -11, -12 };
		for (i = 0; i < 12 - c; i++)
		{
			if (a[i] < 0)
			{
				c++;
				for (j = i; j < 11 - c; j++)
				{
					a[j] = a[j + 1];
				}
				i--;
			}
		}
		for (i = 0; i < 12 - c; i++)
		{
			WriteLine(a[i]);
		}
        WriteLine();
    }
    public static void T13()
    {
        WriteLine("Level3 Test13:");
		int i, j, k = 0;
		double[] a = new double[8] {1, 1, 3, 4, 5, 5, 5, 7};
		for (i = 0; i < 7 - k; i++)
		{
			for (j = i; j < 8 - k; j++)
			{
				if (a[j] == a[i])
				{
					k++;
					for (int o = j; o < 8 - k; o++)
					{
						a[o] = a[o + 1];
					}
				}
			}
		}
		for (i = 0; i < 8 - k; i++)
		{
			WriteLine(a[i]);
		}
        WriteLine();
    }
    public static void T14()
    {
        WriteLine("Level3 Test14:");

        WriteLine();
    }
}