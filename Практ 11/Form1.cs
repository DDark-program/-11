using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Практ_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("a..a");
            string s = "aba aca aea abba adca abea";
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                object[] mas = new object[matches.Count];
                matches.CopyTo(mas, 0);
                listBox1.DataSource = mas;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("a[^1-9a-z]b");
            string s = "ave a#b a2b a$b a4b a5b a-b acb";
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                object[] mas = new object[matches.Count];
                matches.CopyTo(mas, 0);
                listBox2.DataSource = mas;
            }
            else MessageBox.Show("Совпадений не найдено");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа №11\n" +
                "Подъяблонского Данилы Владимировича\n" +
                "Задание:\n" +
                "Дана строка 'aba aca aea abba adca abea'.\n" +
                "Напишите регулярное выражение, которое найдет строки abba adca abea.\n" +
                "Дана строка 'ave a#b a2b a$b a4b a5b a-b acb'. \n" +
                "Напишите регулярное выражение,которое найдет строки следующего вида: по краям стоят буквы 'a' и 'b',а междуними - не буква и не цифра.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
