using static System.Console;
using static System.Convert;
using static System.Math;

class Level1
{
    public static void T1()
    {
        WriteLine("Level1 Test1:");
		
        WriteLine();
    }
    public static void T2()
    {
        WriteLine("Level1 Test2:");

        WriteLine();
    }
    public static void T3()
    {
        WriteLine("Level1 Test3:");

        WriteLine();
    }
    public static void T4()
    {
        WriteLine("Level1 Test4:");

        WriteLine();
    }
    public static void T5()
    {
        WriteLine("Level1 Test5:");

        WriteLine();
    }
    public static void T6()
    {
        WriteLine("Level1 Test6:");
		double[] vector = new double[5] {2, 12, 124, 543, 4};
		double s = 0;
		for (int i = 0; i <= 4; i++)
		{
			s += vector[i] * vector[i];
		}
        WriteLine(Sqrt(s));
    }
    public static void T7()
    {
        WriteLine("Level1 Test7:");

        WriteLine();
    }
    public static void T8()
    {
        WriteLine("Level1 Test8:");

        WriteLine();
    }
    public static void T9()
    {
        WriteLine("Level1 Test9:");

        WriteLine();
    }
    public static void T10()
    {
        WriteLine("Level1 Test10:");
		int c = 0;
		double P, Q;
		double[] a = new double[10] {1, 42, 51, 12, 45, 523, 1, 54, 35, 1};
		P = ToDouble(ReadLine());
		Q = ToDouble(ReadLine());
		for (int i = 0; i <= 9; i++)
		{
			if (a[i] > P && a[i] < Q)
				c++;
		}
        WriteLine(c);
    }
    public static void T11()
    {
        WriteLine("Level1 Test11:");
		double[] a = new double[10] {-2, 4, 52, -5, 12, 5, -1, 42, -10, 5};
		int c = 0, i = 0;
		for (; i <= 9; i++)
		{
			if (a[i] > 0)
				c++;
		}
		double[] b = new double[c];
		for (int j = 0, q = 0;  j <= c - 1; q++)
		{
			if (a[q] > 0)
			{
				b[j] = a[q];
				WriteLine(b[j]);
				j++;
			}
		}
        WriteLine();
    }
    public static void T12()
    {
        WriteLine("Level1 Test12:");
		double[] a = new double[8] {2, 3, -4 , 121, -19, 2, -8, 21};
		int c = 0;
		for (int i = 0; i < 8; i++)
		{
			if (a[i] < 0)
				c = i;
		}
        WriteLine($"{a[c]}, {c}");
    }
    public static void T13()
    {
        WriteLine("Level1 Test13:");
		int i = 0;
		double[] a = new double[10] {1, 2, 3, 4, 5, 6, 7, 8, 19, 2}, b = new double[5], c = new double[5];
		for (i = 0; i < 5; i++)
		{
			b[i] = a[i * 2];
			WriteLine(b[i]);
		}
		WriteLine("==");
		for (i = 0; i < 5; i++)
		{
			c[i] = a[i * 2 + 1];
			WriteLine(c[i]);
		}
        WriteLine();
    }
    public static void T14()
    {
        WriteLine("Level1 Test14:");

        WriteLine();
    }
    public static void T15()
    {
        WriteLine("Level1 Test15:");

        WriteLine();
    }
}