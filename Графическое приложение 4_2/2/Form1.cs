using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        private int max;
        private void P(int max, int n)
        {
            if (n <= max)
            {
                for (int i = 1; i <= n; i++)
                    richTextBox1.Text +=n + " ";
                richTextBox1.Text +="\n";
                P(max, n + 1);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                int n = 1;
                try
                {
                    max = int.Parse(textBox1.Text);
                    if (max < 1)
                    {
                        MessageBox.Show("Число должно быть положительным");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод!!!");
                    return;
                }
                richTextBox1.Text = "";
                P(max, n);
            }
        }
    }
}
