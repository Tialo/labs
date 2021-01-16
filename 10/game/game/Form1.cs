using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace game
{
  
    public partial class Form1 : Form
    {
        public int n = 50;
        public Matrix m;
        public bool started = false;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 150;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m = new Matrix(n, panel1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
                button2.Text = "while (1 == 0)";
            }
            else
            {
                timer1.Stop();
                button2.Text = "while (1 == 1)";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.Iter();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            m.Iter();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    m.matrix[i, j].b.BackColor = Color.White;
                    m.matrix[i, j].alive[0] = m.matrix[i, j].alive[1] = false;
                }
            }
        }
    }

    public class Cell
    {
        public bool[] alive;
        public Button b;
        public Cell(int x, int y, System.Windows.Forms.Panel p)
        {
            this.b = new Button
            {
                BackColor = Color.White,
                Location = new System.Drawing.Point(x, y),
                Parent = p,
                Size = new System.Drawing.Size(15, 15),
            };
            this.b.Click += (sender, e) => { this.b.BackColor = Color.Black; this.alive[0] = true; };
            this.alive = new bool[2];
        }
        public void Revive()
        {
            this.b.BackColor = Color.Black;
            this.alive[1] = true;
        }
        public void Kill()
        {
            this.b.BackColor = Color.White;
            this.alive[1] = false;
        }
    }

    public class Matrix
    {
        public Cell[,] matrix;
        public int size;
        public Matrix(int n, System.Windows.Forms.Panel p)
        {
            this.matrix = new Cell[n, n];
            this.size = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) this.matrix[i, j] = new Cell(15 * i, 15 * j, p);
            }
        }
        public void Iter()
        {
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    int amount = 0;
                    for (int dx = -1; dx <= 1; dx++)
                    {
                        for (int dy = -1; dy <= 1; dy++)
                        {
                            if ((dx != 0 || dy != 0) && i + dx >= 0 && i + dx < this.size && j + dy >= 0 && j + dy < this.size)
                            {
                                if (this.matrix[i + dx, j + dy].alive[0]) amount++;
                            }
                        }
                    }
                    if (amount == 3 || amount == 2 && this.matrix[i, j].alive[0])
                    {
                        this.matrix[i, j].Revive();
                    }
                    else if ((amount > 3 || amount < 2) && this.matrix[i, j].alive[0])
                    {
                        this.matrix[i, j].Kill();
                    }
                }
            }
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    this.matrix[i, j].alive[0] = this.matrix[i, j].alive[1];
                    this.matrix[i, j].alive[1] = false;
                }
            }
        }
    }
}
