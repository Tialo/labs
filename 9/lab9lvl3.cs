using static System.Console;
using System.IO;
using System.Text;

namespace Lab9lvl3
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
			string line;
			int c = 0;
			StreamReader sr = new StreamReader(@"C:\Users\tialo\Desktop\c#\labs\9\i1.txt");
			while((line = sr.ReadLine()) != null){
				string[] a = line.Split(' ');
				string name = a[0];
				double[] r = new double[a.Length - 1];
				for (int i = 1; i < a.Length; i++){
					r[i - 1] = double.Parse(a[i]);
				}
				Student_with_scholarship t1 = new Student_with_scholarship();
				t1.student(name, r);
				gr[c / 10].addStudent(t1);
				c++;
			}
			sr.Close();
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
			StreamWriter sw = new StreamWriter(@"C:\Users\tialo\Desktop\c#\labs\9\o1.txt");
			for (int i = 0; i < 3; i++){
				for (int j = 0; j < 10; j++){
					sw.WriteLine($"Фамилия\t{gr[i].sts[j].sur}\tСредний балл\t{gr[i].sts[j].avg}\tСтипендия\t{gr[i].sts[j].scholarship()}");
				}
				WriteLine();
			}
			for (int i = 0; i < 3; i++){
				sw.WriteLine($"Группа\t{gr[i].pn} Средний балл\t{gr[i].avg}");
			}
			sw.Close();
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
			StreamReader sr = new StreamReader(@"C:\Users\tialo\Desktop\c#\labs\9\i2.txt");
			string line;
			int c = 0;
			while ((line = sr.ReadLine()) != null){
				string[] a = line.Split(' ');
				string name = a[0];
				double[] r = new double[a.Length - 1];
				for (int i = 1; i < a.Length; i++){
					r[i - 1] = double.Parse(a[i]);
				}
				t1[c] = new Student_with_scholarship();
				t1[c].student(name, r);
				c++;
			}
			sr.Close();
			for (int i = 0; i < 10; i++){
				for (int j = i; j < 10; j++){
					if (t1[i].avg < t1[j].avg){
						Student_with_scholarship t = t1[i];
						t1[i] = t1[j];
						t1[j] = t;
					}
				}
			}
			StreamWriter sw = new StreamWriter(@"C:\Users\tialo\Desktop\c#\labs\9\o2.txt");
			for (int i = 0; i < 10; i++){
				if (!t1[i].disq()){
					sw.WriteLine($"{t1[i].name}\tScore\t{t1[i].avg:f2}\tScholarship\t{t1[i].scholarship()}");
				}
			}
			sw.Close();
		}
	}
}