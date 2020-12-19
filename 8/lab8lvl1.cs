using static System.Console;
using System;

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

        WriteLine();
    }
    public static void T7()
    {
        WriteLine("Level1 Test7:");
		string p = "abc";
		string s = "thfjgykhcjlekabcn2ebf abc ssfgavshhjva bcajbjchasvabcabcbcabccabbccoja bf asjfas fjav a b aca c  a b cac vabjlfbknalkv.bw n";
		string[] a = s.Split(' ');
		for (int i = 0; i < a.Length; i++){
			for (int j = 0; j <= a[i].Length - p.Length; j++){
				if (a[i].Substring(j, p.Length) == p){
					WriteLine(a[i]);
					break;
				}
			}
		}
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

        WriteLine();
    }
    public static void T11()
    {
        WriteLine("Level1 Test11:");
		string s = "Azam, Bark, Afqnt, Avasgsb, Basoii, Okg, Ginba, Bkaaft, Kbsd, Povn, Qjnbdf, Cofm";
		string[] a = s.Split(", ");
		for (int i = 0; i < a.Length; i++){
			for (int j = i + 1; j < a.Length; j++){
				bool change = false;
				for (int k = 0; k < Math.Min(a[i].Length, a[j].Length); k++){
					if (a[i][k] > a[j][k]){
						change = true;
						break;
					}
					if (a[i][k] < a[j][k]) break;
				}
				if (change){
					string t = a[i];
					a[i] = a[j];
					a[j] = t;
				}
			}
		}
		for (int i = 0; i < a.Length - 1; i++){
			Write($"{a[i]}, ");
		}
		Write(a[a.Length-1]);
    }
    public static void T12()
    {
        WriteLine("Level1 Test12:");

        WriteLine();
    }
    public static void T13()
    {
        WriteLine("Level1 Test13:");

        WriteLine();
    }
    public static void T14()
    {
        WriteLine("Level1 Test14:");
		double sum = 0;
		string s = "r1ugfhpjg;wp01yorp1h980o9r10y1uip0129781o35i712c8056425091c4809689v4293mc0rj23oilfyphofl";
		for (int i = 0; i < s.Length; i++){
			if (Char.IsDigit(s[i])){
				if (s[i] == '0' && i > 0 && s[i-1] == '1') sum += 9;
				else sum += Char.GetNumericValue(s[i]);
			}
		}
        WriteLine(sum);
    }
    public static void T15()
    {
        WriteLine("Level1 Test15:");

        WriteLine();
    }
}