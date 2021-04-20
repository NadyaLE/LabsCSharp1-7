using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Litke_05
{
    public partial class Calculator : Form
    {
        private static bool[] check = new bool[5];
        private static int A = 0;
        private static int B = 0;
        private static int C = 0;
        private static int D = 0;
        private static double X = 0;
      
        public Calculator()
        {
            InitializeComponent();
        }
        private static string Calculate()
        {
            string s = "";
            if (!check.Contains(false) && X != 0) {
                s = Convert.ToString(A * X * X * X + B * X * X  + C / X + (D / X) / X);
            }
            else {
                s = "Введены некорректные данные";
            }
            return s;
        }
        private void textBox_A_TextChanged(object sender, EventArgs e)
        {

            check[0] = Int32.TryParse(textBox_A.Text, out A);
            textBox_Result.Text = Calculate();
        }

        private void textBox_B_TextChanged(object sender, EventArgs e)
        {
            check[1] = Int32.TryParse(textBox_B.Text, out B);
            textBox_Result.Text = Calculate();
        }

        private void textBox_C_TextChanged(object sender, EventArgs e)
        {
            check[2] = Int32.TryParse(textBox_C.Text, out C);
            textBox_Result.Text = Calculate();
        }

        private void textBox_D_TextChanged(object sender, EventArgs e)
        {
            check[3] = Int32.TryParse(textBox_D.Text, out D);
            textBox_Result.Text = Calculate();
        }

        private void textBox_X_TextChanged(object sender, EventArgs e)
        {
            check[4] = Double.TryParse(textBox_X.Text, out X);
            textBox_Result.Text = Calculate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
