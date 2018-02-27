using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace OOP_labs_sem4
{
    public partial class Form1 : Form
    {
        
        float a, b;
        double c;
        int count;
        bool znak = true;
        private double memory = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void Calculate()
        {
            try
            {
                switch (count)
                {
                    case 1:
                        b = a + float.Parse(InputText.Text);
                        InputText.Text = b.ToString();
                        break;
                    case 2:
                        b = a - float.Parse(InputText.Text);
                        InputText.Text = b.ToString();
                        break;
                    case 3:
                        b = a * float.Parse(InputText.Text);
                        InputText.Text = b.ToString();
                        break;
                    case 4:
                        b = a / float.Parse(InputText.Text);
                        InputText.Text = b.ToString();
                        break;
                    case 5:
                        double a1 = double.Parse(InputText.Text);
                        double a2 = a;
                        c = Math.Pow(a2, a1);
                        InputText.Text = c.ToString();
                        break;
                    default:
                        InputText.Text = "ERROR!";
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        public double MemoryShow(double b, double c)
        {
            string text1 = b.ToString();
            string text2 = c.ToString();
            
            using (FileStream file = new FileStream(@"E:\Calculate.txt", FileMode.OpenOrCreate))
            {                
               byte[] array = Encoding.Default.GetBytes(text1);
               file.Write(array, 0, array.Length); 
            }
            
            using (FileStream file = File.OpenRead(@"E:\Calculate.txt"))
            {
                byte[] array = new byte[file.Length];              
                file.Read(array, 0, array.Length);               
                string textFromFile = Encoding.Default.GetString(array);
                MessageBox.Show("Текст из файла: " + textFromFile);
            }
            
            return memory; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InputText.Text = InputText.Text + 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            InputText.Text = InputText.Text + 2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            InputText.Text = InputText.Text + 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputText.Text = InputText.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InputText.Text = InputText.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InputText.Text = InputText.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InputText.Text = InputText.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InputText.Text = InputText.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InputText.Text = InputText.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InputText.Text = InputText.Text + 9;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = float.Parse(InputText.Text);
            InputText.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = float.Parse(InputText.Text);
            InputText.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = float.Parse(InputText.Text);
            InputText.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = float.Parse(InputText.Text);
            InputText.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Calculate();
            label1.Text = "";
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = float.Parse(InputText.Text);
            InputText.Clear();
            count = 5;
            label1.Text = a.ToString() + "^";
            znak = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            InputText.Text = "";
            label1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int length = InputText.Text.Length - 1;
            string text = InputText.Text;
            InputText.Clear();
            for (int i = 0; i < length; i++)
            {
                InputText.Text = InputText.Text + text[i];
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                InputText.Text = "-" + InputText.Text;
                znak = false;
            }
            else if (znak ==false)
            {
                InputText.Text = InputText.Text.Replace("-", "");
                znak = true;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MemoryShow(b, c);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            InputText.Text = InputText.Text + ",";
        }
    }
}
