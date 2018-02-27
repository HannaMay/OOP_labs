using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1_2_sem4
{
    public partial class Form1 : Form
    {
        private delegate void Comparator();
        List<int> list = new List<int>();
        Comparator comparators;
        bool b1, b2;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            try
            {                
                Random rand = new Random();
                for (int i = 0; i < int.Parse(textBox_Generate.Text); i++)
                {
                    list.Add(rand.Next(0,1000));
                    textBox_Before.Text += list.ElementAt(i).ToString() + "\r  ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Sort()
        {
            try
            {
                textBox_After.Clear();
                if (b1)
                {                    
                    var temp = from t in list
                               orderby t
                               select t;
                    foreach (var item in temp)
                    {
                        textBox_After.Text += item.ToString() + "\r  ";
                    }
                }
                else 
                {                   
                    var temp2 = from t in list
                                orderby t descending
                                select t;
                    foreach (var item in temp2)
                    {
                        textBox_After.Text += item.ToString() + "\r  ";
                    }
                }
                b1 = b2 = false;      
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }        
        private void textBox_Generate_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnt_Asc_Click(object sender, EventArgs e)
        {
            try
            {
                comparators = Sort;
                b1 = true;
                comparators();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Dsc_Click(object sender, EventArgs e)
        {
            try
            {
                comparators = Sort;
                b2 = true;
                comparators();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            try
            {
                int k = list.Max();
                textBox_After.Clear();
                textBox_After.Text += k.ToString() + "\r  ";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            try
            {
                int k = list.Min();
                textBox_After.Clear();
                textBox_After.Text += k.ToString() + "\r  ";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_Before_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_After_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
