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
		double[] vector = new double[5];
		double s = 0;
		for (int i = 0; i <= 4; i++)
		{
			vector[i] = ToDouble(ReadLine());
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
		double[] a = new double[10];
		P = ToDouble(ReadLine());
		Q = ToDouble(ReadLine());
		for (int i = 0; i <= 9; i++)
		{
			a[i] = ToDouble(ReadLine());
			if (a[i] > P && a[i] < Q)
				c++;
		}
        WriteLine(c);
    }
    public static void T11()
    {
        WriteLine("Level1 Test11:");
		double[] a = new double[10];
		int c = 0, i = 0;
		for (; i <= 9; i++)
		{
			a[i] = ToDouble(ReadLine());
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
		double[] a = new double[8];
		int c = 0;
		for (int i = 0; i < 8; i++)
		{
			a[i] = ToDouble(ReadLine());
			if (a[i] < 0)
				c = i;
		}
        WriteLine($"{a[c]}, {c}");
    }
    public static void T13()
    {
        WriteLine("Level1 Test13:");
		int i = 0;
		double[] a = new double[10], b = new double[5], c = new double[5];
		for (i = 0; i < 10; i++)
		{
			if (i % 2 == 0)
				b[i / 2] = ToDouble(ReadLine());
			else
				c[i / 2] = ToDouble(ReadLine());
		}
		for (i = 0; i < 5; i++)
		{
			WriteLine(b[i]);
		}
		for (i = 0; i < 5; i++)
		{
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