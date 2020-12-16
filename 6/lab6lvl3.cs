using System;
using static System.Console;

namespace Lab6lvl3
{
	public class T1
	{
		struct Student{
			public string sur;
			public double[] r;
			public double avg;
			public Student(string sur, double[] r){
				this.sur = sur;
				this.r = r;
				this.avg = 0;
				for (int i = 0; i < 5; i++) {
					this.avg += r[i];
				}
				this.avg /= 5;
			}
		}
		struct Group{
			public double avg;
			public int number;
			public int pn;
			public Student[] sts;
			public Group(int number, int pn){
				this.sts = new Student[number];
				this.pn = pn;
				this.number = number - 1; this.avg = 0;
			}
			public void addStudent(Student st){
				this.sts[number--] = st;
				this.avg += st.avg / 10;
			}
			public void sort(){
				for (int i = 0; i < 10; i++){
					for (int j = i; j < 10; j++){
						if (sts[i].avg < sts[j].avg){
							Student t;
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
			gr[0].addStudent(new Student("Max", new double[] {2, 5, 5, 2, 5}));
			gr[0].addStudent(new Student("Dan", new double[] {2, 5, 5, 2, 5}));
			gr[0].addStudent(new Student("Gol", new double[] {2, 5, 5, 2, 5}));
			gr[0].addStudent(new Student("Bat", new double[] {2, 5, 5, 2, 5}));
			gr[0].addStudent(new Student("Fon", new double[] {2, 5, 5, 2, 5}));
			gr[0].addStudent(new Student("Bah", new double[] {2, 5, 5, 2, 5}));
			gr[0].addStudent(new Student("Rol", new double[] {2, 5, 5, 2, 5}));
			gr[0].addStudent(new Student("Fin", new double[] {2, 5, 5, 2, 5}));
			gr[0].addStudent(new Student("Fan", new double[] {2, 5, 5, 2, 5}));
			gr[0].addStudent(new Student("Kof", new double[] {2, 5, 5, 2, 5}));
			gr[1].addStudent(new Student("Che", new double[] {2, 5, 5, 2, 5}));
			gr[1].addStudent(new Student("Pus", new double[] {2, 5, 5, 2, 5}));
			gr[1].addStudent(new Student("Elz", new double[] {2, 5, 5, 2, 5}));
			gr[1].addStudent(new Student("Sta", new double[] {2, 5, 5, 2, 5}));
			gr[1].addStudent(new Student("Put", new double[] {2, 5, 5, 2, 5}));
			gr[1].addStudent(new Student("Med", new double[] {2, 5, 5, 2, 5}));
			gr[1].addStudent(new Student("Nav", new double[] {2, 5, 5, 2, 5}));
			gr[1].addStudent(new Student("Gor", new double[] {2, 5, 5, 2, 5}));
			gr[1].addStudent(new Student("Ras", new double[] {2, 5, 5, 2, 5}));
			gr[1].addStudent(new Student("Slo", new double[] {2, 5, 5, 2, 5}));
			gr[2].addStudent(new Student("Dud", new double[] {2, 5, 5, 2, 5}));
			gr[2].addStudent(new Student("Sob", new double[] {2, 5, 5, 2, 5}));
			gr[2].addStudent(new Student("Hiu", new double[] {2, 5, 5, 2, 5}));
			gr[2].addStudent(new Student("Nev", new double[] {2, 5, 5, 2, 5}));
			gr[2].addStudent(new Student("Sol", new double[] {2, 5, 5, 2, 5}));
			gr[2].addStudent(new Student("Eon", new double[] {2, 5, 5, 2, 5}));
			gr[2].addStudent(new Student("Lil", new double[] {2, 5, 5, 2, 5}));
			gr[2].addStudent(new Student("Big", new double[] {2, 5, 5, 2, 5}));
			gr[2].addStudent(new Student("Fit", new double[] {2, 5, 5, 2, 5}));
			gr[2].addStudent(new Student("Biz", new double[] {2, 5, 5, 2, 5}));
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
					WriteLine($"Фамилия\t{gr[i].sts[j].sur}\tСредний балл\t{gr[i].sts[j].avg}");
				}
				WriteLine();
			}
			for (int i = 0; i < 3; i++){
				WriteLine($"Группа\t{gr[i].pn} Средний балл\t{gr[i].avg}");
			}
		}
	}
	
	public class T4
	{
		public struct Participant{
			public string sur;
			public double r;
			public Participant(string sur, double r){
				this.sur = sur;
				this.r = r;
			}
		}
		public struct Group{
			public int pn;
			public int size;
			public Participant[] ps;
			public Group(int number, int size){
				this.ps = new Participant[number];
				this.size = size;
				this.pn = 0;
			}
			public void addParticipant(Participant p){
				this.ps[this.pn++] = p;
			}
			public void sort(){
				for (int i = 0; i < 10; i++){
					for (int j = i; j < 10; j++){
						if (this.ps[i].r < this.ps[j].r){
							Participant t;
							t = this.ps[i];
							this.ps[i] = this.ps[j];
							this.ps[j] = t;
						}
					}
				}
			}
		}
		public static Group concatenate(Group a, Group b){
			Group c = new Group(20, 1);
			int i = 0, j = 0;
			for (;i < 10 && j < 10;){
				if (a.ps[i].r > b.ps[j].r){
					c.addParticipant(a.ps[i]);
					i++;
				}else{
					c.addParticipant(b.ps[j]);
					j++;
				}
			}
			if (i == 9){
				for (;j<10;j++) c.addParticipant(b.ps[j]);
			}else{
				for (;i<10;i++) c.addParticipant(a.ps[i]);
			}
			return c;
		}
		public static void Start()
		{
			Group[] gr = new Group[2];
			for (int i = 0; i < 2; i++) gr[i] = new Group(10, i + 1);
			gr[0].addParticipant(new Participant("Max", 24.4));
			gr[0].addParticipant(new Participant("Dan", 34.3));
			gr[0].addParticipant(new Participant("Gol", 41.2));
			gr[0].addParticipant(new Participant("Bat", 52.2));
			gr[0].addParticipant(new Participant("Fon", 41.2));
			gr[0].addParticipant(new Participant("Bah", 75.5));
			gr[0].addParticipant(new Participant("Rol", 43.5));
			gr[0].addParticipant(new Participant("Fin", 15.6));
			gr[0].addParticipant(new Participant("Fan", 63.4));
			gr[0].addParticipant(new Participant("Kof", 59.1));
			gr[1].addParticipant(new Participant("Che", 85.4));
			gr[1].addParticipant(new Participant("Pus", 46.5));
			gr[1].addParticipant(new Participant("Elz", 65.4));
			gr[1].addParticipant(new Participant("Sta", 47.5));
			gr[1].addParticipant(new Participant("Put", 94.5));
			gr[1].addParticipant(new Participant("Med", 47.1));
			gr[1].addParticipant(new Participant("Nav", 47.6));
			gr[1].addParticipant(new Participant("Gor", 25.6));
			gr[1].addParticipant(new Participant("Ras", 76.7));
			gr[1].addParticipant(new Participant("Slo", 31.3));
			for (int i = 0; i < 2; i++) gr[i].sort();
			Group c = concatenate(gr[0], gr[1]);
			for (int i = 0; i < 20; i++){
				WriteLine($"Фамилия\t{c.ps[i].sur}\tРезультат{c.ps[i].r}");
			}
		}
	}
	
	public class T6
	{
		struct Answers{
			public string[,] ans;
			public int[,] count;
			public double[] nn;
			int n;
			int s;
			public Answers(int n, int s){
				this.n = n;
				this.s = s;
				this.nn = new double[s];
				this.ans = new string[s, n];
				this.count = new int[s, n];
			}
			public void addAnswer(string[] a){
				for (int i = 0; i < this.s; i++){
					if (a[i] == "") continue;
					this.nn[i]++;
					int j = 0;
					while (j < this.n && a[i] != this.ans[i, j]){
						j++;
					}
					if (j == this.n){
						int x = 0;
						while (this.ans[i, x] != null) x++;
						this.ans[i, x] = a[i]; this.count[i, x] = 1;
					}else{
						this.count[i, j]++;
					}
				}
			}
			public void print(string[,] t, int[,] n){
				int[] ind = new int[this.s + 1];
				for (int j = 0, x = 0; j < this.s; j++){
					if (n[j, 0] != 0){
						Write($"Question {j + 1}\tRate\t");
						ind[x++] = j;
					}
				}
				WriteLine();
				for (int i = 0; i < 5; i++){
					for (int j = 0; j < this.s; j++){
						int x = ind[j];
						if (n[x, i] != 0 && (x != 0 || ind[j + 1] != 0)) Write($"{t[x, i]}\t\t{100.0*n[x, i]/this.nn[x]:f1}\t");
						else Write("\t\t\t");
					}
					WriteLine();
				}
			}
			public void show(){
				string[,] t = new string[s, 5];
				int[,] n = new int[s, 5];
				for (int i = 0; i < s; i++){
					for (int j = 0; j < this.n; j++){
						for (int k = 0; k < 5; k++){
							if (this.count[i, j] > n[i, k]){
								for (int p = 4; p > k; p--){
									n[i, p] = n[i, p - 1];
									t[i, p] = t[i, p - 1];
								}
								n[i, k] = this.count[i, j];
								t[i, k] = this.ans[i, j];
								break;
							}
						}
					}
				}
				print(t, n);
			}
			
		}
		public static void Start()
		{
			Answers a = new Answers(10, 3);
			a.addAnswer(new string[] {"anim1", "char1", ""}); 
			a.addAnswer(new string[] {"anim3", "char1", "item3"}); 
			a.addAnswer(new string[] {"anim6", "", ""});
			a.addAnswer(new string[] {"anim1", "char2", "item1"}); 
			a.addAnswer(new string[] {"anim6", "char1", ""});
			a.addAnswer(new string[] {"anim1", "char2", "item2"});
			a.addAnswer(new string[] {"anim5", "", "item2"}); 
			a.addAnswer(new string[] {"anim2", "", "item2"}); 
			a.addAnswer(new string[] {"anim4", "", ""}); 
			a.addAnswer(new string[] {"anim5", "char1", ""});
			a.show();
			WriteLine();
			WriteLine("=====================================================================");
			Answers b = new Answers(6, 3);
			b.addAnswer(new string[] {"", "char1", "item1"});
			b.addAnswer(new string[] {"", "char2", ""});
			b.addAnswer(new string[] {"", "char2", ""});
			b.addAnswer(new string[] {"", "char1", ""});
			b.addAnswer(new string[] {"", "char1", ""});
			b.addAnswer(new string[] {"", "char1", ""});
			b.show();
			WriteLine("=====================================================================");
			Answers с = new Answers(6, 3);
			с.addAnswer(new string[] {"anim1", "", "item1"});
			с.addAnswer(new string[] {"", "", "item2"});
			с.addAnswer(new string[] {"", "", "item3"});
			с.addAnswer(new string[] {"", "", "item4"});
			с.addAnswer(new string[] {"", "", "item5"});
			с.addAnswer(new string[] {"", "", "item6"});
			с.show();
			WriteLine("=====================================================================");
			Answers d = new Answers(3, 3);
			d.addAnswer(new string[] {"", "", "item1"});
			d.addAnswer(new string[] {"", "", "item2"});
			d.addAnswer(new string[] {"", "", "item2"});
			d.show();
		}
	}
}