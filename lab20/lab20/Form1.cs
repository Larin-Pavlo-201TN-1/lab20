/*
Функція обчислює целую частина неправильного дробу, представленої
чисельником і знаменником — цілими числами. 
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string a = numerator_txt.Text;
            string b = denominator_txt.Text;
            try
            {
                int numerator = Convert.ToInt32(a);
                int denominator = Convert.ToInt32(b);

                int res = numerator / denominator;
                result.Text = res.ToString();
            }

            catch (FormatException) when (a == "" || b == "")
            {
                result.Text = "Заповніть всі поля";
            }

            catch (FormatException) 
            {
                result.Text = "Неможливо перетворити рядок в число";
            }

            catch (DivideByZeroException)
            {
                result.Text = "Ділення на 0";
            }
        }
    }
}
