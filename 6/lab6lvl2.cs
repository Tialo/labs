using System;
using static System.Console;
using static System.Math;

namespace Lab6lvl2
{
	public class T1
	{
		public struct Student{
			public string name;
			public double r1, r2, r3, r4, avg;
			public Student(string name, double r1, double r2, double r3, double r4){
				this.name = name;
				this.r1 = r1; this.r2 = r2; this.r3 = r3; this.r4 = r4;
				this.avg = (r1+r2+r3+r4)/4;
			}
		}
		public static void Start()
		{
			Student[] st = new Student[10];
			st[0] = new Student("Vasya", 4, 2, 3, 3);
			st[1] = new Student("Petya", 5, 5, 5, 5);
			st[2] = new Student("Dima", 4, 4, 5, 4);
			st[3] = new Student("Misha", 5, 5, 5, 4);
			st[4] = new Student("Sasha", 5, 4, 4, 5);
			st[5] = new Student("Masha", 2, 2, 2, 2);
			st[6] = new Student("Zhenya", 3, 3, 3, 3);
			st[7] = new Student("Olya", 3, 4, 4, 5);
			st[8] = new Student("Nastya", 5, 5, 5, 2);
			st[9] = new Student("Vsevolod", 2, 3, 4, 5);
			for (int i = 0; i < 10; i++){
				for (int j = i; j < 10; j++){
					if (st[i].avg < st[j].avg){
						Student t;
						t = st[i];
						st[i] = st[j];
						st[j] = t;
					}
				}
			}
			for (int i = 0; i < 10 && st[i].avg >= 4; i++){
				WriteLine($"{st[i].name}\t{st[i].avg:f2}");
			}
		}
	}
	
	public class T2
	{
		struct Student{
			public string name;
			public double r1, r2, r3, avg;
			public bool passed;
			public Student(string name, double r1, double r2, double r3){
				this.passed = true;
				this.name = name;
				this.r1 = r1; this.r2 = r2; this.r3 = r3;
				this.avg = (r1+r2+r3)/3;
				if (r1 == 2 || r2 == 2 || r3 == 2) this.passed = false;
			}
		}
		public static void Start()
		{
			Student[] st = new Student[10];
			st[0] = new Student("Vasya", 4, 2, 3);
			st[1] = new Student("Petya", 5, 5, 5);
			st[2] = new Student("Dima", 4, 4, 5);
			st[3] = new Student("Misha", 5, 5, 5);
			st[4] = new Student("Sasha", 5, 4, 4);
			st[5] = new Student("Masha", 2, 2, 2);
			st[6] = new Student("Zhenya", 3, 3, 3);
			st[7] = new Student("Olya", 3, 4, 4);
			st[8] = new Student("Nastya", 5, 5, 5);
			st[9] = new Student("Vsevolod", 2, 3, 4);
			for (int i = 0; i < 10; i++){
				for (int j = i; j < 10; j++){
					if (st[i].avg < st[j].avg){
						Student t;
						t = st[i];
						st[i] = st[j];
						st[j] = t;
					}
				}
			}
			for (int i = 0; i < 10 && st[i].passed; i++){
				WriteLine($"{st[i].name}\t{st[i].avg:f2}");
			}
		}
	}
	
	public class T3
	{
		struct Sportsman{
			public string surname;
			public double r1, r2, r3, best;
			public Sportsman(string surname, double r1, double r2, double r3){
				this.surname = surname;
				this.r1 = r1; this.r2 = r2; this.r3 = r3;
				this.best = Max(r1, Max(r2, r3));
			}
		}
		public static void Start()
		{
			Sportsman[] sp = new Sportsman[10];
			sp[0] = new Sportsman("Vasilev", 4, 2, 3);
			sp[1] = new Sportsman("Petrov", 5, 5, 5);
			sp[2] = new Sportsman("Dmitr", 4, 4, 5);
			sp[3] = new Sportsman("Mishin", 5, 5, 5);
			sp[4] = new Sportsman("Sashin", 5, 4, 4);
			sp[5] = new Sportsman("Mashina", 2, 2, 2);
			sp[6] = new Sportsman("Zhenin", 3, 3, 3);
			sp[7] = new Sportsman("Olina", 3, 4, 4);
			sp[8] = new Sportsman("Nastina", 5, 5, 5);
			sp[9] = new Sportsman("Vsevol", 2, 3, 4);
			for (int i = 0; i < 10; i++){
				for (int j = i; j < 10; j++){
					if (sp[i].best < sp[j].best){
						Sportsman t;
						t = sp[i];
						sp[i] = sp[j];
						sp[j] = t;
					}
				}
			}
			for (int i = 0; i < 10; i++){
				WriteLine($"Фамилия\t{sp[i].surname}\tРезультат {sp[i].best:f2}");
			}
		}
	}
}