using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        private int n;
        static int A(int n)
        {
            if (n == 1) return 1;
            else if (n > 1)
            {
                int a = n;
                if ((Math.Pow(2, a - 1) <= n) && (n <= Math.Pow(2, a)))
                {
                    return a;
                }
                return A(n / 2) + 1;
            }
            return 0;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num_textBox.Text == "")
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                try
                {
                    n = int.Parse(num_textBox.Text);
                    if (n == 0)
                    {
                        MessageBox.Show("0 - не натуральное число. Попробуйте еще раз!!!");
                        return;
                    }
                    else if (n < 0)
                    {
                        MessageBox.Show("Отрицательное число не является натуральным");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод!!!");
                    return;
                }
                res_TextBox.Text = "a = " + A(n);

            }
        }
    }
}
