using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace laba_2_s4
{
    public partial class Form2 : Form
    {
        
        public Form2(List<Student> list)
        {
            InitializeComponent();
            this.list = list;
        }             

        public string name = String.Empty;
        public string surname = String.Empty;
        public string prof = String.Empty;
        public string course = String.Empty;
        public int beforenum = 1;
        public int afternum = 10;
        public List<Student> search_list = new List<Student>();
        private List<Student> list;

        private bool search = true;
        public Form2()
        {
            InitializeComponent();
        }
        private void GoToDefault()
        {
            name = surname = prof = course = String.Empty;
            beforenum = 1;
            afternum = 10;
            search = true;
        }
        private void Search(IEnumerable<Student> list)
        {
            try
            {
                Regex regex = new Regex("[A-яA-z]{1,35}");
                ViewResultOfSearch_listBox.Items.Clear();
                List<Student> querylist = new List<Student>(list.Count());
                bool wasCheck = false;

                //Name
                if (!name.Equals(String.Empty) && search)
                {
                    var result = from std in list
                                 where std.name == name
                                 select std;

                    if (result.Count()==0)
                    {
                        search = false;
                    }
                    else if (search)
                    {
                        querylist = new List<Student>(result.Count());
                        foreach (Student a in result)
                        {
                            if (!querylist.Contains(a))
                            {
                                querylist.Add(a);                               
                            }
                            
                        }
                    }
                }
                //Surname
                if (!surname.Equals(String.Empty)&& search)
                {
                    
                    var result = from std in  list 
                                 where std.surname == surname
                                 select std;
                    wasCheck = true;
                    if (result.Count() == 0)
                    {
                        search = false;
                    }
                    else
                    {
                        querylist = new List<Student>(result.Count());
                        foreach (Student a in result)
                        {
                            if (!querylist.Contains(a))
                            {
                                querylist.Add(a);
                                
                            }                            
                        }
                    }
                }
                //Profesion
                if (!prof.Equals(String.Empty))
                {
                    wasCheck = true;
                    var result = from std in wasCheck ? querylist : list
                                 where std.profession == prof
                                 select std;

                    if (result.Count() == 0)
                    {
                        search = false;
                    }
                    else if (search)
                    {
                        querylist = new List<Student>(result.Count());
                        foreach (Student a in result)
                        {
                            if (!querylist.Contains(a))
                            {
                                querylist.Add(a);
                                
                            }
                        }
                    }
                }
                //Course
                if (!course.Equals(String.Empty))
                {
                    wasCheck = true;
                    var result = from std in wasCheck ? querylist : list
                                 where std.course == course
                                 select std;

                    if (result.Count() == 0)
                    {
                        search = false;
                    }
                    else if (search)
                    {
                        querylist = new List<Student>(result.Count());
                        foreach (Student a in result)
                        {
                            if (!querylist.Contains(a))
                            {
                                querylist.Add(a);
                                
                            }

                        }
                    }
                }
                //Average
                if (beforenum>0 && afternum<10)
                {
                    wasCheck = true;
                    var result = from std in wasCheck ? querylist : list
                                 where std.average > beforenum
                                 select std;
                    var resultafter = from std in result
                                      where std.average < afternum
                                      select std;

                    if (resultafter.Count() == 0)
                    {
                        search = false;
                    }
                    else if (search)
                    {
                        querylist = new List<Student>(result.Count());
                        foreach (Student a in resultafter)
                        {
                            if (!querylist.Contains(a))
                            {
                                querylist.Add(a);
                                
                            }
                        }
                    }
                }

                if (querylist.Count != 0 && search)
                {
                    foreach (Student a in querylist)
                    {
                        ViewResultOfSearch_listBox.Items.Add(a);
                    }
                    search_list = querylist;
                }
                else
                {
                    MessageBox.Show("no matches found");
                }
                GoToDefault();
                querylist.Clear();
            }
            catch 
            {
               MessageBox.Show("Test");
            }
        }
        private void Search_btn_Click(object sender, EventArgs e)
        {
            ViewResultOfSearch_listBox.Items.Clear();
            try
            {                
                bool flag = false;                
                if (!Name_textBox.Text.Equals(String.Empty))
                {
                    flag = true;
                    name = Name_textBox.Text;
                }
                if (!Surname_txtbox.Text.Equals(String.Empty))
                {
                    flag = true;
                    surname = Surname_txtbox.Text;
                }
                if (!Profession_comboBox.Text.Equals(String.Empty))
                {
                    flag = true;
                    prof = Profession_comboBox.Text;
                }
                if (!Course_comboBox.Text.Equals(String.Empty))
                {
                    flag = true;
                    course = Course_comboBox.Text;
                }
                int averageaf = Convert.ToInt32(AfterAverage_txtbox.Text);
                int averagebef = Convert.ToInt32(BeforeAverage_txtbox.Text);
                if (!(averageaf == 0 && averagebef == 0))
                {
                    flag = true;
                    afternum = Convert.ToInt32(AfterAverage_txtbox.Text);
                    beforenum = Convert.ToInt32(BeforeAverage_txtbox.Text);
                }
                
                if (!flag)
                {
                    MessageBox.Show("You entered invalid search data!");
                    return;
                }

                Search(list);
                GoToDefault();
                
                foreach (Student a in search_list)
                {
                    ViewResultOfSearch_listBox.Items.Add(a);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ХЗ что не так " + ex.Message + ex.Source);
            }
        }

        private void Clear_SearchBtn_Click(object sender, EventArgs e)
        {
            Surname_txtbox.Clear();
            Name_textBox.Clear();
            Profession_comboBox.Text = "";
            Course_comboBox.Text = "";
            AfterAverage_txtbox.Clear();
            BeforeAverage_txtbox.Clear();
        }
    }
}
