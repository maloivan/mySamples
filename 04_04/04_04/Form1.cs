using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            Random rnd = new Random();

            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            int sum = 0;

            int[,] mas = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rnd.Next(-4,12);
                    dataGridView1.Rows[i].Cells[j].Value = mas[i, j];
                    dataGridView2.Rows[i].Cells[j].Value ="";
                    sum += mas[i, j];
                }
            }

            listBox1.Items.Add("sum = "+sum);
            dataGridView1.AutoResizeColumns();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            Random rnd = new Random();

            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = m;

            int[,] mas = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = Math.Abs((int)(Math.Pow(i, 3) - Math.Pow(j, 3)));
                    dataGridView1.Rows[i].Cells[j].Value = i + "," + j;
                    dataGridView2.Rows[i].Cells[j].Value = mas[i, j];
                }
            }
            dataGridView1.AutoResizeColumns();
            dataGridView2.AutoResizeColumns();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            Random rnd = new Random();

            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = m;

            int[,] mas = new int[n, m];

            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j < m/2; j++)
                {
                    mas[i, j] = 0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = m/2; j < m; j++)
                {
                    mas[i, j] = 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = mas[i, j];
                }
            }
            dataGridView1.AutoResizeColumns();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            Random rnd = new Random();

            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = m;

            int[,] mas = new int[n, m];

            for (int i = 0; i < n/2; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = 0;
                }
            }

            for (int i = n/2; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = mas[i, j];
                }
            }
            dataGridView1.AutoResizeColumns();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            Random rnd = new Random();

            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = m;

            int[,] mas = new int[n, m];

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < m/2; j++)
                {
                    mas[i, j] = 0;
                }
            }

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = m/2; j < m; j++)
                {
                    mas[i, j] = 1;
                }
            }

            for (int i = n/2; i < n; i++)
            {
                for (int j = 0; j < m/2; j++)
                {
                    mas[i, j] = 2;
                }
            }

            for (int i = n / 2; i < n; i++)
            {
                for (int j = m/2; j < m; j++)
                {
                    mas[i, j] = 3;
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = mas[i, j];
                }
            }
            dataGridView1.AutoResizeColumns();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            Random rnd = new Random();

            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = m;

            int[,] mas = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                mas[i, 0] = 1;
            }
            for (int j = 0; j <m; j++)
            {
                mas[0, j] = 1;
            }
            for (int j = 0; j < m; j++)
            {
                mas[n-1, j] = 1;
            }
            for (int i = 0; i < n; i++)
            {
                mas[i, m-1] = 1;
            }


            for (int i = 1; i < n-1; i++)
            {
                for (int j = 1; j < m-1; j++)
                {
                    mas[i, j] = 100;
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = mas[i, j];
                }
            }
            dataGridView1.AutoResizeColumns();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            Random rnd = new Random();
            int a= int.Parse(textBox3.Text);

            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = m;

            int[,] mas = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rnd.Next(-4, 12);
                    dataGridView1.Rows[i].Cells[j].Value = mas[i, j];
                }
            }
            int sum = 0;

            if (a < n)
            {
                for (int i = 0; i < m; i++)
                {
                    sum += mas[a, i];
                }
                double sr = (double)sum / m;
                listBox1.Items.Add("sr = " + Math.Round(sr, 2));
            }
            else
            {
                listBox1.Items.Add("номер искомой строки неверен");
            }
           
           

            dataGridView1.AutoResizeColumns();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            Random rnd = new Random();
            int a = int.Parse(textBox3.Text);

            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = m;

            int[,] mas = new int[n, m];
            int max = -10;
            int maxI = 0;
            int maxJ = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rnd.Next(-4, 12);
                    dataGridView1.Rows[i].Cells[j].Value = mas[i, j];

                    if (mas[i,j]>max)
                    {
                        max = mas[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                }
            }

            listBox1.Items.Add("max="+max);
            listBox1.Items.Add("[" + maxI+","+maxJ+"]");
            dataGridView1.AutoResizeColumns();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            Random rnd = new Random();
            int a = int.Parse(textBox3.Text);

            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = m;

            int[,] mas = new int[n, m];
            int max = -10;
          
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rnd.Next(-4, 12);
                    dataGridView1.Rows[i].Cells[j].Value = mas[i, j];

                    if (mas[i, j] > max)
                    {
                        max = mas[i, j];
                    }
                }
            }
            listBox1.Items.Add("max=" + max);
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (max==mas[i,j])
                    {
                        count++;
                        listBox1.Items.Add("[" + i + "," + j + "]");
                    }
                }
            }

            listBox1.Items.Add("count Max=" + count);



            dataGridView1.AutoResizeColumns();
        }
    }
}
