using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_32___07_10_2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_0_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count == 0)
            {
                listBox1.Items.Add('0');
            }
            else
            {
                listBox1.Items.Add(listBox1.Items[0].ToString() + '0');
                listBox1.Items.RemoveAt(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                listBox1.Items.Add('1');
            }
            else
            {
                listBox1.Items.Add(listBox1.Items[0].ToString() + '1');
                listBox1.Items.RemoveAt(0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                listBox1.Items.Add('2');
            }
            else
            {
                listBox1.Items.Add(listBox1.Items[0].ToString() + '2');
                listBox1.Items.RemoveAt(0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                listBox1.Items.Add('3');
            }
            else
            {
                listBox1.Items.Add(listBox1.Items[0].ToString() + '3');
                listBox1.Items.RemoveAt(0);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                listBox1.Items.Add('4');
            }
            else
            {
                listBox1.Items.Add(listBox1.Items[0].ToString() + '4');
                listBox1.Items.RemoveAt(0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                listBox1.Items.Add('5');
            }
            else
            {
                listBox1.Items.Add(listBox1.Items[0].ToString() + '5');
                listBox1.Items.RemoveAt(0);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                listBox1.Items.Add('6');
            }
            else
            {
                listBox1.Items.Add(listBox1.Items[0].ToString() + '6');
                listBox1.Items.RemoveAt(0);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                listBox1.Items.Add('7');
            }
            else
            {
                listBox1.Items.Add(listBox1.Items[0].ToString() + '7');
                listBox1.Items.RemoveAt(0);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                listBox1.Items.Add('8');
            }
            else
            {
                listBox1.Items.Add(listBox1.Items[0].ToString() + '8');
                listBox1.Items.RemoveAt(0);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                listBox1.Items.Add('9');
            }
            else
            {
                listBox1.Items.Add(listBox1.Items[0].ToString() + '9');
                listBox1.Items.RemoveAt(0);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!Operator())
            {
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add('+');
                }
                else
                {
                    listBox1.Items.Add(listBox1.Items[0].ToString() + '+');
                    listBox1.Items.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("Ação Inválida!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!Operator())
            {
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add('-');
                }
                else
                {
                    listBox1.Items.Add(listBox1.Items[0].ToString() + '-');
                    listBox1.Items.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("Ação Inválida!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!Operator())
            {
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add('*');
                }
                else
                {
                    listBox1.Items.Add(listBox1.Items[0].ToString() + '*');
                    listBox1.Items.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("Ação Inválida!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!Operator())
            {
                if (listBox1.Items.Count == 0)
                {
                    listBox1.Items.Add('/');
                }
                else
                {
                    listBox1.Items.Add(listBox1.Items[0].ToString() + '/');
                    listBox1.Items.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("Ação Inválida!");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.RemoveAt(0);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0 && listBox1.Items[0].ToString().Split('+', '-', '*', '/').Length == 2 && listBox1.Items[0].ToString().Split('+', '-', '*', '/')[1] != "")
            {
                string txt = listBox1.Items[0].ToString();
                string operators = "+-*/";
                char Op = ' ';
                foreach (char ch in txt)
                {
                    if (operators.Contains(ch))
                    {
                        Op = ch;
                    }
                }

                listBox1.Items.RemoveAt(0);
                string[] c = new string[] { };
                switch (Op)
                {
                    case ' ':
                        listBox1.Items.Add(txt);
                        break;
                    case '+':
                        c = txt.Split('+');
                        if (c.Length == 2 && c[1] != "")
                        {
                            listBox1.Items.Add(int.Parse(c[0]) + int.Parse(c[1]));
                        }
                        break;
                    case '-':
                        c = txt.Split('-');
                        if (c.Length == 2 && c[1] != "")
                        {
                            listBox1.Items.Add(int.Parse(c[0]) - int.Parse(c[1]));
                        }
                        break;
                    case '*':
                        c = txt.Split('*');
                        if (c.Length == 2 && c[1] != "")
                        {
                            listBox1.Items.Add(int.Parse(c[0]) * int.Parse(c[1]));
                        }
                        break;
                    case '/':
                        c = txt.Split('/');
                        if (c.Length == 2 && c[1] != "")
                        {
                            if (c[1] == "0")
                            {

                            }
                            listBox1.Items.Add(int.Parse(c[0]) / int.Parse(c[1]));
                        }
                        break;
                }

                if (Op != ' ' && c.Length == 2)
                {
                    txt = $"{txt} = {listBox1.Items[0]}";
                    listBox2.Items.Add(txt);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool Operator()
        {
            string operators = "+-*/";
            if (listBox1.Items.Count > 0)
            {
                for (int i = 0; i < listBox1.Items[0].ToString().Length; i++)
                {
                    if (operators.Contains(listBox1.Items[0].ToString()[i]))
                    {
                        return true;
                    }
                }
            }
            else
            {
                return true;
            }
            return false;
        }
    }
}
