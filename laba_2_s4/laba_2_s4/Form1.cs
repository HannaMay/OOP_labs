using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace laba_2_s4
{
    public partial class Form1 : Form
    {
        public List<Student> student_list = new List<Student>();
        public List<Address> address_list = new List<Address>();
        public List<Work> work_list = new List<Work>();

        public Form1()
        {
            InitializeComponent();

        }

        private bool CheckStudent()
        {
            if (Surname_txtbox.Text.Equals("") || Name_textBox.Text.Equals("") || Profession_comboBox.Text.Equals("") ||
            Course_comboBox.Text.Equals("") || Averange_maskedTextBox.Text.Equals("") || (Male.Checked == false && female.Checked == false) ||
            address_list.Count == 0 || work_list.Count == 0)
            {
                return false;
            }
            return true;
        }

        private bool CheckAddress()
        {
            if (Street_txtbox.Text.Equals("") || City_comboBox.Text.Equals("") || House_maskedTextBox.Text.Equals("") ||
            Index_maskedTextBox.Text.Equals("") || Flat_maskedTextBox.Text.Equals(""))
            {
                return false;
            }
            return true;
        }

        private bool CheckWork()
        {
            if (Company_txtBox.Text.Equals("") || Position_txtBox.Text.Equals("") || Experience_maskedTextBox.Equals("") ||
            checkedListBox.CheckedItems.Count == 0)
            {
                return false;
            }
            return true;
        }

        private void SaveStudent_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckStudent())
                {
                    MessageBox.Show("Informaition not found!");
                }
                else
                {
                    Student student = new Student(Surname_txtbox.Text, Name_textBox.Text, (string)Profession_comboBox.SelectedItem,
                        (string)Course_comboBox.SelectedItem, float.Parse(Averange_maskedTextBox.Text), (int)Age_numericUpDown.Value,
                        Male.Checked ? Male.Text : female.Text, address_list.Last(), work_list.Last());

                    student_list.Add(student);
                    ViewStudent_listBox.Items.Add(student);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearStudent_btn_Click(object sender, EventArgs e)
        {
            Surname_txtbox.Clear();
            Name_textBox.Clear();
            Profession_comboBox.Text = "";
            Course_comboBox.Text = "";
            Averange_maskedTextBox.Clear();
            Age_numericUpDown.Value = Age_numericUpDown.Minimum;
            Male.Checked = female.Checked = false;
        }

        private void SaveAddress_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckAddress())
                {
                    MessageBox.Show("Informaition not found!");
                }
                else
                {
                    Address address = new Address((string)City_comboBox.SelectedItem, Street_txtbox.Text,
                        int.Parse(House_maskedTextBox.Text), int.Parse(Flat_maskedTextBox.Text), int.Parse(Index_maskedTextBox.Text));

                    address_list.Add(address);
                    ViewAddress_listBox.Items.Add(address);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearAddress_btn_Click(object sender, EventArgs e)
        {
            Street_txtbox.Clear();
            City_comboBox.Text = "";
            House_maskedTextBox.Clear();
            Index_maskedTextBox.Clear();
            Flat_maskedTextBox.Clear();
        }

        private void SaveForm_btn_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.FileName = "Serialize_xml.xml";
                saveFileDialog1.InitialDirectory = "E:\\programming\\C#\\Tests\\tetstDependet";
                saveFileDialog1.ShowDialog();
                using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
                    xmlSerializer.Serialize(fs, student_list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OpenForm_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Serialize_xml.xml";
            openFileDialog1.InitialDirectory = "E:\\programming\\C#\\Tests\\tetstDependet";
            openFileDialog1.ShowDialog();
            List<Student> stud;
            try
            {
                using (FileStream fst = new FileStream(openFileDialog1.FileName, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
                    stud = (List<Student>)xmlSerializer.Deserialize(fst);
                }
                if (stud.Count != 0)
                {
                    foreach (Student st in stud)
                    {
                        student_list.Add(st);
                        view_form.Items.Add(st);
                    }
                }
                else
                {
                    MessageBox.Show("collection is empty");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SaveWork_btn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> list = new List<string>();
                if (!CheckWork())
                {
                    MessageBox.Show("Informaition not found!");
                }
                else
                {
                    foreach (string s in checkedListBox.CheckedItems)
                    {
                        list.Add(s);
                    }
                    Work work = new Work(Company_txtBox.Text, Position_txtBox.Text, int.Parse(Experience_maskedTextBox.Text), list);

                    work_list.Add(work);
                    ViewWork_listBox.Items.Add(work);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearWork_btn_Click(object sender, EventArgs e)
        {
            Company_txtBox.Clear();
            Position_txtBox.Clear();
            Experience_maskedTextBox.Clear();
            checkedListBox.ClearSelected();
            foreach (int i in checkedListBox.CheckedIndices)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }
    }
}