using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public decimal Oper1 { get; set; } = 0;
        public decimal Oper2 { get; set; } = 0;
        public bool oper2 { get; set; } = true;
        public string Opp { get; set; }
        public bool op { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oper2)
            {
                var send = sender as Button;
                Oper1 = Convert.ToDecimal(send.Text);
                label1.Text = send.Text;
            }
            else
            {
                var send = sender as Button;
                Oper2 = Convert.ToDecimal(send.Text);
                label3.Text = send.Text;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var send = sender as Button;

            if (!op)
            {
                Opp = send.Text;
                label2.Text = send.Text;
            }
            op = true;
            oper2 = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label4.Visible = true; label1.Visible = false; label2.Visible = false; label3.Visible = false;
            if (op && Oper2 != 0)
            {


                switch (Opp)
                {
                    case "+":
                        {
                            label4.Text = Convert.ToString(Oper1 + Oper2);
                            break;
                        }
                    case "-":
                        {
                            label4.Text = Convert.ToString(Oper1 - Oper2);
                            break;
                        }
                    case "/":
                        {
                            if (Oper2 != 0)
                            {
                                label4.Text = Convert.ToString(Oper1 / Oper2);

                            }
                            else
                            {
                                label4.Text = "Divided By Zero";
                            }
                            break;
                        }
                    case "x":
                        {
                            label4.Text = Convert.ToString(Oper1 * Oper2);
                            break;
                        }
                    default: break;
                }
            }
            else if (op && Oper2 == 0)
            {

                switch (Opp)
                {
                    case "+":
                        {
                            label4.Text = Convert.ToString(Oper1 + 1);
                            break;
                        }
                    case "-":
                        {
                            label4.Text = Convert.ToString(Oper1 - 1);
                            break;
                        }
                    case "/":
                        {
                            label4.Text = Convert.ToString(Oper1 / 2);

                            break;
                        }
                    case "x":
                        {
                            label4.Text = Convert.ToString(Oper1 * 2);
                            break;
                        }
                    default: break;
                }
            }
            else
            {
                label4.Text = Oper1.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Visible = false;
            Oper1 = 0;
            Oper2 = 0;
            op = false;
            oper2 = true;
            Opp = "";
        }
    }
}
