using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int n = 5;
            int[,] mas = new int[n,n];
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = n;
            dataGridView1.RowHeadersWidth = 110;

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = "Ученик " + (i + 1);

            }
            dataGridView1.Columns[0].HeaderCell.Value = "Фізика";
            dataGridView1.Columns[1].HeaderCell.Value = "Матем.";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = rnd.Next(-5,11);
                    dataGridView1.Rows[i].Cells[j].Value = mas[i, j];
                }
            }

            for (int j = 0; j < n; j++)
            {
                Swap(ref mas[0, j], ref mas[n - 1, j]);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   
                    dataGridView2.Rows[i].Cells[j].Value = mas[i, j];
                }
            }

            listBox1.Items.Add($"Первый э.м. - {mas[0,0]}, последний э.м. - {mas[n-1,n-1]}");
            

            dataGridView1.AutoResizeColumns();
            dataGridView2.AutoResizeColumns();
        }
    }
}
