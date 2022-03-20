using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
{
// Получение исходных данных из TextBox
double x = Convert.ToDouble(textBox2.Text);
double b = Convert.ToDouble(textBox1.Text);

// Ввод исходных данных в окно результатов
textBox3.Text = "Результаты работы программы " +
"ст. Червинского А.Ю. " + Environment.NewLine;
textBox3.Text += "При X = " + textBox2.Text + Environment.NewLine;
textBox3.Text += "При b = " + textBox1.Text + Environment.NewLine;
// Вычисление выражения
double g;
double xb = x * b;
if (xb < 0.5 && xb < 10)
g = Math.Pow(Math.E,Math.Pow(x,2) - Math.Abs(b));
else if (xb < 0.1 && xb < 0.5)
g = Math.Sqrt(Math.Abs(Math.Pow(x,2) + b));
else
g = 2*Math.Pow(Math.Pow(x,2),2);

// Вывод результата
textBox3.Text += "G = " + g.ToString() + Environment.NewLine;                   
}
        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }
    }
}
