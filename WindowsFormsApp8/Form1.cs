using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{

    public partial class Form1 : Form
    {
        public static string GetAsciiString(int[] numbers)
        {
            StringBuilder sb = new StringBuilder();

            foreach (int number in numbers)
            {
                sb.Append((char)number);
            }

            return sb.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            khoitaosoghe(11, 15);
            khoitaoday(11, 1);
        }

        private void khoitaoday(int v1, int v2)
        {
            int x, y = 16, kc = 30, d=65;
            for (int i = 0; i < v1; i++)
            {
                x = 11;   
                for (int j = 0; j < v2; j++)
                {
                    Button btnDay = new Button();
                    btnDay.Location = new System.Drawing.Point(x, y);
                    btnDay.Size = new System.Drawing.Size(30, 23);
                    btnDay.Text = ((char)d).ToString();
                    btnDay.BackColor = Color.White;
                    panel2.Controls.Add(btnDay);
                    x += kc;
                }
                y += kc;
                d++;
            }
        
        }

        private void khoitaosoghe(int v1, int v2)
        {
            int x, y = 16,kc = 30,d;
            for (int i = 0; i < v1; i++) {
                x = 11; 
                d = 1;
                


                for (int j = 0; j < v2; j++)
                {
                    Button btnGhe = new Button();
                    btnGhe.Location = new System.Drawing.Point(x, y);
                    btnGhe.Size = new System.Drawing.Size(30, 23);
                    btnGhe.Text = d++.ToString();
                    btnGhe.BackColor = Color.White;
                    panel1.Controls.Add(btnGhe);
                    x += kc;                  
                }
                y += kc;
            } 
        }
    }
}
