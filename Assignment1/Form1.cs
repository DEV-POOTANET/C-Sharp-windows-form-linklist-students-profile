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

namespace Assignment1
{
   
    public partial class Form1 : Form
    {
        public struct Student
        {
            public string name;
            public string phone;
        }

        List<Student> studentList = new List<Student>();
        int curitem=0;
        public Form1()
        {
            InitializeComponent();
            //Txtname.Text = "Pootanet";
            //TxtPhone.Text = "062161312";
            LoadFile();
           
        }
        public void LoadFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader("student.text"))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] item = line.Split(',');
                        string name = item[0];
                        string phone = item[1];

                        Student s = new Student { name = name, phone = phone };
                        studentList.Add(s);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
            viewAll();
            LabNumber.Text = 0 + "/" + studentList.Count;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            
            string nameToDelete = Txtname.Text;
            string phoneToDelete = TxtPhone.Text;

            if (string.IsNullOrEmpty(nameToDelete) || string.IsNullOrEmpty(phoneToDelete))
            {
                MessageBox.Show("Please select a student to delete.", "Error");
                return;
            }
           
            var studentToDelete = studentList.Find(student => student.name == nameToDelete && student.phone == phoneToDelete);
          
            studentList.Remove(studentToDelete);
            SaveToFile();
            viewAll();
            Txtname.Text = "";
            TxtPhone.Text = "";
            LabNumber.Text = 0 + "/" + studentList.Count;
        }
        

        private void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter("student.text"))
            {
                foreach (Student student in studentList)
                {
                    sw.WriteLine($"{student.name},{student.phone}");
                }
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void updateCount()
        {
            LabNumber.Text = curitem + 1 + "/" + studentList.Count;
            Showitem(curitem);
        }
        public void viewAll()
        {
            string text = $"{"Name",-30}{"Phone",-20}\n";

            foreach (Student student in studentList)
            {
                text += $"{student.name,-30}{student.phone,-20}\n";
            }
            LabList.Text= text;
        }

        public void Save(Student s)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("student.text", append: true))
                {
                    sw.WriteLine(s.name + ", "+ s.phone);
                }
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message, "Error");
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Student st;
            string name = Txtname.Text;
            string phone = TxtPhone.Text;
            if (name == "" || phone == "")
            {
                MessageBox.Show("No data input" ,"Error");
                return;
            }
            st = new Student();
            st.name= name;
            st.phone = phone;
            studentList.Add(st);

            viewAll();
            Save(st);

            LabNumber.Text = studentList.Count + "/" + studentList.Count;
            curitem = studentList.Count -1 ;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Txtname.Text = "";
            TxtPhone.Text = "";
            //LabList.Text = "No Student List";
        }
        public void Showitem(int id)
        {
            Txtname.Text = studentList[id].name;
            TxtPhone.Text = studentList[id].phone;
            LabNumber.Text = id + 1 + "/" + studentList.Count;
        }
        private void Btnfirst_Click(object sender, EventArgs e)
        {
            if (studentList.Count > 0)
            {
                curitem = 0;
                Showitem(curitem);
            }
            else
            {
                MessageBox.Show("No data student", "Error");
            }
        }

        private void BtnPr_Click(object sender, EventArgs e)
        {
            if (studentList.Count > 0) 
            {
                curitem--;

                if (curitem < 0)
                {
                    curitem = studentList.Count - 1; 
                }

                Showitem(curitem);
            }
            else
            {
                MessageBox.Show("No data student", "Error");
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (studentList.Count > 0)
            {
                curitem++;
                if (curitem == studentList.Count)
                {
                    curitem = 0;                    
                }
                Showitem(curitem);
            }
            else
            {
                MessageBox.Show("No data student", "Error");
            }
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            if (studentList.Count > 0)
            {
                if (studentList.Count > 0)
                {
                    curitem = studentList.Count - 1;
                    Showitem(curitem);

                }
            }
            else
            {
                MessageBox.Show("No data student", "Error");
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            Txtname.Text = "";
            TxtPhone.Text = "";
            LabNumber.Text = 0 + "/" + studentList.Count;
            curitem = 0;
            viewAll();
        }
    }
}
