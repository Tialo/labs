using static System.Console;
using static System.Convert;

class Level3
{
    public static void T1a()
    {
        WriteLine("Level3 Test1:");
		int i, j, t, ind;
		double m;
		double[,] a = new double[7, 5] {
			{66, 58, 40, 65, 21}, // 21
			{89, 79, 41, 80, 27}, // 27
			{25, 50, 45, 21, 83}, // 21
			{4, 21, 35, 98, 77}, // 4
			{88, 16, 41, 54, 16}, // 16
			{79, 11, 48, 83, 35}, // 11
			{94, 4, 80, 5, 36} // 4
		};
		for (t = 0; t < 7; t++)
		{
			m = 100000000;
			ind = 0;
			for (i = t; i < 7; i++)
			{
				for (j = 0; j < 5; j++)
				{
					if (a[i, j] < m)
					{
						m = a[i, j];
						ind = i;
					}
				}
			}
			for (j = 0; j < 5; j++)
			{
				(a[t, j], a[ind, j]) = (a[ind, j], a[t, j]);
			}
		}
		for (i = 0; i < 7; i++)
		{
			for (j = 0; j < 5; j++)
			{
				Write($"{a[i, j]}\t");
			}
			WriteLine();
		}
        WriteLine();
    }
    public static void T1b()
    {
        WriteLine("Level3 Test1:");
		int i, j, t, ind;
		double m;
		double[] a = new double[7 * 5] {
			6, 67, 57, 15, 21, // 6
			38, 52, 97, 58, 80, // 38
			53, 10, 92, 83, 28, // 10
			69, 43, 85, 74, 21, // 21
			97, 13, 35, 19, 72, // 13
			42, 18, 49, 62, 45, // 18
			68, 66, 79, 21, 3 // 3
		};
		for (t = 0; t < 7; t++)
		{
			m = 100000000;
			ind = 0;
			for (i = t; i < 7; i++)
			{
				for (j = 0; j < 5; j++)
				{
					if (a[i * 5 + j] < m)
					{
						m = a[i * 5 + j];
						ind = i;
					}
				}
			}
			for (j = 0; j < 5; j++)
			{
				(a[t * 5 + j], a[ind * 5 + j]) = (a[ind * 5 + j], a[t * 5 + j]);
			}
		}
		for (i = 0; i < 7; i++)
		{
			for (j = 0; j < 5; j++)
			{
				Write($"{a[i * 5 + j]}\t");
			}
			WriteLine();
		}
        WriteLine();
    }
    public static void T2()
    {
        WriteLine("Level3 Test2:");
		const int n = 10;
		int i, j;
		double[,] a = new double[n, n] {
			{21, 53, 58, 46, 12, 18, 44, 79, 83, 44},
			{75, 41, 91, 69, 81, 5, 77, 3, 95, 36},
			{26, 11, 27, 88, 44, 6, 13, 43, 56, 71},
			{26, 17, 49, 74, 16, 80, 36, 59, 91, 75},
			{52, 99, 83, 5, 27, 60, 38, 32, 41, 33},
			{76, 4, 79, 80, 42, 87, 9, 59, 71, 94},
			{0, 25, 79, 89, 98, 83, 19, 82, 13, 4},
			{68, 95, 71, 64, 16, 97, 39, 18, 46, 2},
			{80, 36, 61, 29, 59, 88, 27, 62, 77, 56},
			{33, 81, 30, 48, 51, 1, 69, 33, 41, 59}
		};
		for (i = 0; i < n; i++)
		{
			a[i, 0] = a[0, i] = a[n - 1, i] = a[i, n - 1] = 0;
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
		int i, j, k = 0;
		double[] b = new double[2 * 7 - 1];
		double[,] a = new double[7, 7] {
			{43, 30, 45, 98, 28, 65, 86},
			{43, 3, 77, 14, 50, 69, 4},
			{79, 58, 75, 71, 67, 48, 43},
			{28, 81, 82, 93, 74, 46, 59},
			{39, 6, 60, 6, 90, 43, 58},
			{50, 84, 24, 46, 92, 59, 60},
			{33, 67, 7, 83, 0, 59, 38}
		};
		for (i = 0; i < 7; i++)
		{
			for (j = 0; j < 7; j++)
			{
				Write($"{a[i, j]}\t");
			}
			WriteLine();
		}
		for (i = 7 - 1; i >= 0; i--)
		{
			for (j = 0; j <= 7 - 1 - i; j++)
			{
				b[k] += a[i + j, j];
			}
			k++;
		}
		k = 2 * 7 - 2;
		for (j = 7 - 1; j > 0; j--)
		{
			for (i = 0; i <= 7 - 1 - j; i++)
			{
				b[k] += a[i, j + i];
			}
			k--;
		}
        WriteLine();
		for (i = 0; i < 2 * 7 - 1; i++)
		{
			Write($"{b[i]} ");
		}
    }
    public static void T4()
    {
        WriteLine("Level3 Test4:");
		int i, j;
		double[,] a = new double[7, 7] {
			{32, 25, 53, 77, 41, 65, 41},
			{69, 5, 67, 5, 36, 49, 67},
			{36, 49, 50, 75, 95, 75, 92},
			{20, 66, 51, 39, 10, 48, 62},
			{98, 97, 62, 87, 11, 79, 78},
			{60, 55, 61, 42, 90, 88, 28},
			{68, 95, 43, 0, 13, 53, 7}
		};
		for (i = 7 / 2; i < 7; i++)
		{
			for (j = 0; j <= i; j++)
			{
				a[i, j] = 1;
			}
		}
        WriteLine();
		for (i = 0; i < 7; i++)
		{
			for (j = 0; j < 7; j++)
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
		int i, j, t, n, m, ind;
		double[,] a = new double[7, 5] {
			{-4, -44, 17, -65, 58}, // 2
			{77, -13, -49, 83, 16}, // 3
			{74, 40, 29, 2, 24}, // 5
			{27, -6, -69, -94, -8}, // 1
			{-48, -98, 46, 15, -31}, // 2
			{-70, -92, 49, 4, 90}, // 3
			{-92, 75, 93, 38, 55} // 4
		};
		for (t = 0; t < 7; t++)
		{
			m = 0;
			ind = 0;
			for (i = t; i < 7; i++)
			{
				n = 0;
				for (j = 0; j < 5; j++)
				{
					if (a[i, j] > 0)
					{
						n += 1;
						if (n > m)
						{
							ind = i;
							m = n;
						}
					}
				}
			}
			for (j = 0; j < 5; j++)
			{
				(a[t, j], a[ind, j]) = (a[ind, j], a[t, j]);
			}
		}
		for (i = 0; i < 7; i++)
		{
			for (j = 0; j < 5; j++)
			{
				Write($"{a[i, j]}\t");
			}
			WriteLine();
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
		int i, j, t, m;
		double[,] a = new double[5, 12] {
			{80, 56, 61, 34, 19, 45, 94, 63, 60, 14, 62, 24},
			{59, 72, 99, 48, 37, 82, 13, 81, 71, 30, 39, 76},
			{60, 2, 47, 63, 31, 29, 8, 91, 18, 11, 69, 80},
			{75, 1, 2, 84, 92, 13, 26, 1, 10, 96, 38, 82},
			{34, 51, 76, 38, 71, 78, 38, 64, 18, 45, 35, 86}
		};
		for (i = 0; i < 5; i++)
		{
			for (j = 0; j < 12 - 2; j += 2)
			{
				m = j;
				for (t = j + 2; t < 12; t += 2)
				{
					if (a[i, t] > a[i, m])
						m = t;
				}
				(a[i, j], a[i, m]) = (a[i, m], a[i, j]);
			}
			for (j = 1; j < 12 - 1; j += 2)
			{
				m = j;
				for (t = j + 2; t < 12; t += 2)
				{
					if (a[i, t] < a[i, m])
						m = t;
				}
				(a[i, j], a[i, m]) = (a[i, m], a[i, j]);
			}
		}
		for (i = 0; i < 5; i++)
		{
			for (j = 0; j < 12; j++)
			{
				Write($"{a[i, j]}\t");
			}
			WriteLine();
		}
    }
    public static void T11()
    {
        WriteLine("Level3 Test11:");
		int i, j, c = 0;
		double[,] a = new double[6, 9] {
			{52, 47, 74, -83, -44, 81, 30, 74, 77},
			{62, 71, -33, -48, 34, 0, -47, 69, 63},
			{-61, 0, 94, 21, 65, 3, 89, 36, -13},
			{-29, -95, 9, -26, 70, -51, 24, -81, 24},
			{-3, 58, -100, -59, 0, -99, -73, 74, 46},
			{56, -46, 66, -13, -47, 39, -51, 53, -45}
		};
		for (i = 0; i < 6 - c; i++)
		{
			for (j = 0; j < 9; j++)
			{
				if (a[i, j] == 0)
				{
					for (int f = i; f < 5; f++)
					{
						for (int k = 0; k < 9; k++)
						{
							(a[f, k], a[f + 1, k]) = (a[f + 1, k], a[f, k]);
						}
					}
					c++;
					i--;
				}
			}
		}
		for (i = 0; i < 6 - c; i++)
		{
			for (j = 0; j < 9; j++)
			{
				Write($"{a[i, j]}\t");
			}
			WriteLine();
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