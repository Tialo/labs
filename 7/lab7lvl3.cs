using System;
using static System.Console;

namespace Lab7lvl3
{
	public class T1
	{
		public class Student{
			public string sur;
			public double[] r;
			public double avg;
			public void student(string sur, double[] r){
				this.sur = sur;
				this.r = r;
				this.avg = 0;
				for (int i = 0; i < 5; i++) {
					this.avg += r[i];
				}
				this.avg /= 5;
			}
		}
		public class Student_with_scholarship: Student{
			public int scholarship(){
				bool good = true;
				for (int i = 0; i < this.r.Length; i++){
					if (this.r[i] < 4){
						good = false;
						break;
					}
				}
				if (good) return 15000;
				else return 2000;
			}
		}
		public class Group{
			public double avg;
			public int number;
			public int pn;
			public Student_with_scholarship[] sts;
			public Group(int number, int pn){
				this.sts = new Student_with_scholarship[number];
				this.pn = pn;
				this.number = number - 1; this.avg = 0;
			}
			public void addStudent(Student_with_scholarship st){
				this.sts[number--] = st;
				this.avg += st.avg / 10;
			}
			public void sort(){
				for (int i = 0; i < 10; i++){
					for (int j = i; j < 10; j++){
						if (sts[i].avg < sts[j].avg){
							Student_with_scholarship t;
							t = this.sts[i];
							this.sts[i] = this.sts[j];
							this.sts[j] = t;
						}
					}
				}
			}
		}
		public static void Start()
		{
			Group[] gr = new Group[3];
			for (int i = 0; i < 3; i++) gr[i] = new Group(10, i + 1);
			Student_with_scholarship[] t1 = new Student_with_scholarship[30];
			for (int i = 0; i < 30; i++) t1[i] = new Student_with_scholarship();
			t1[1].student("Max", new double[] {2, 5, 5, 2, 5});
			gr[0].addStudent(t1[1]);
			t1[2].student("Dan", new double[] {3, 5, 5, 4, 5});
			gr[0].addStudent(t1[2]);
			t1[3].student("Gol", new double[] {4, 5, 5, 4, 5});
			gr[0].addStudent(t1[3]);
			t1[4].student("Bat", new double[] {5, 5, 5, 5, 5});
			gr[0].addStudent(t1[4]);
			t1[5].student("Fon", new double[] {2, 5, 5, 2, 5});
			gr[0].addStudent(t1[5]);
			t1[6].student("Bah", new double[] {2, 3, 3, 2, 5});
			gr[0].addStudent(t1[6]);
			t1[7].student("Rol", new double[] {2, 2, 2, 2, 2});
			gr[0].addStudent(t1[7]);
			t1[8].student("Fin", new double[] {2, 4, 5, 2, 5});
			gr[0].addStudent(t1[8]);
			t1[9].student("Fan", new double[] {4, 5, 5, 5, 5});
			gr[0].addStudent(t1[9]);
			t1[10].student("Kof", new double[] {5, 5, 5, 4, 5});
			gr[0].addStudent(t1[10]);
			t1[11].student("Che", new double[] {2, 5, 5, 2, 5});
			gr[1].addStudent(t1[11]);
			t1[12].student("Pus", new double[] {2, 5, 2, 2, 5});
			gr[1].addStudent(t1[12]);
			t1[13].student("Elz", new double[] {2, 3, 5, 2, 5});
			gr[1].addStudent(t1[13]);
			t1[14].student("Sta", new double[] {2, 5, 4, 4, 5});
			gr[1].addStudent(t1[14]);
			t1[15].student("Put", new double[] {2, 5, 5, 4, 5});
			gr[1].addStudent(t1[15]);
			t1[16].student("Med", new double[] {2, 5, 5, 2, 4});
			gr[1].addStudent(t1[16]);
			t1[17].student("Nav", new double[] {2, 5, 4, 4, 5});
			gr[1].addStudent(t1[17]);
			t1[18].student("Gor", new double[] {2, 3, 5, 5, 5});
			gr[1].addStudent(t1[18]);
			t1[19].student("Ras", new double[] {4, 5, 5, 4, 5});
			gr[1].addStudent(t1[19]);
			t1[20].student("Slo", new double[] {2, 5, 5, 5, 5});
			gr[1].addStudent(t1[20]);
			t1[21].student("Dud", new double[] {3, 5, 3, 2, 5});
			gr[2].addStudent(t1[21]);
			t1[22].student("Sob", new double[] {2, 5, 4, 2, 4});
			gr[2].addStudent(t1[22]);
			t1[23].student("Hiu", new double[] {2, 2, 5, 2, 5});
			gr[2].addStudent(t1[23]);
			t1[24].student("Nev", new double[] {2, 5, 3, 2, 3});
			gr[2].addStudent(t1[24]);
			t1[25].student("Sol", new double[] {2, 5, 2, 2, 3});
			gr[2].addStudent(t1[25]);
			t1[26].student("Eon", new double[] {2, 5, 5, 3, 5});
			gr[2].addStudent(t1[26]);
			t1[27].student("Lil", new double[] {2, 5, 3, 2, 5});
			gr[2].addStudent(t1[27]);
			t1[28].student("Big", new double[] {2, 3, 5, 2, 5});
			gr[2].addStudent(t1[28]);
			t1[29].student("Fit", new double[] {2, 5, 2, 2, 5});
			gr[2].addStudent(t1[29]);
			t1[30].student("Biz", new double[] {2, 5, 5, 2, 4});
			gr[2].addStudent(t1[30]);
			for (int i = 0; i < 3; i++) gr[i].sort();
			for (int i = 0; i < 3; i++){
				for (int j = i; j < 3; j++){
					if (gr[i].avg < gr[j].avg){
						Group t;
						t = gr[i];
						gr[i] = gr[j];
						gr[j] = t;
					}
				}
			}
			for (int i = 0; i < 3; i++){
				for (int j = 0; j < 10; j++){
					WriteLine($"Фамилия\t{gr[i].sts[j].sur}\tСредний балл\t{gr[i].sts[j].avg}\tСтипендия\t{gr[i].sts[j].scholarship()}");
				}
				WriteLine();
			}
			for (int i = 0; i < 3; i++){
				WriteLine($"Группа\t{gr[i].pn} Средний балл\t{gr[i].avg}");
			}
		}
	}
	public class T2{
		class Student{
			public string name;
			public double avg;
			public double[] r;
			public void student(string name, double[] r){
				this.name = name;
				this.r = r;
				this.avg = 0;
				for (int i = 0; i < 3; i++){
					this.avg += r[i] / 3;
				}
			}
			public bool disq(){
				for (int i = 0; i < 3; i++){
					if (this.r[i] == 2) return true;
				}
				return false;
			}
		}
		class Student_with_scholarship: Student{
			public int scholarship(){
				for (int i = 0; i < 3; i++){
					if (this.r[i] == 3) return 2000;
				}
				return 15000;
			}
		}
		public static void Start(){
			Student_with_scholarship[] t1 = new Student_with_scholarship[10];
			for (int i = 0; i < 10; i++) t1[i] = new Student_with_scholarship();
			t1[0].student("Max", new double[] {2, 5, 5, 2, 5});
			t1[1].student("Dan", new double[] {3, 5, 5, 4, 5});
			t1[2].student("Gol", new double[] {4, 5, 5, 4, 5});
			t1[3].student("Bat", new double[] {5, 5, 5, 5, 5});
			t1[4].student("Fon", new double[] {4, 5, 5, 4, 5});
			t1[5].student("Bah", new double[] {2, 3, 3, 2, 5});
			t1[6].student("Rol", new double[] {2, 2, 2, 2, 2});
			t1[7].student("Fin", new double[] {3, 4, 5, 4, 5});
			t1[8].student("Fan", new double[] {4, 5, 5, 5, 5});
			t1[9].student("Kof", new double[] {5, 5, 5, 4, 5});
			for (int i = 0; i < 10; i++){
				for (int j = i; j < 10; j++){
					if (t1[i].avg < t1[j].avg){
						Student_with_scholarship t = t1[i];
						t1[i] = t1[j];
						t1[j] = t;
					}
				}
			}
			for (int i = 0; i < 10; i++){
				if (!t1[i].disq()){
					WriteLine($"{t1[i].name}\tScore\t{t1[i].avg:f2}\tScholarship\t{t1[i].scholarship()}");
				}
			}
		}
	}
}