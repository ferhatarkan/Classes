﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student ogrenci1 = new Student();
            ogrenci1.FirstName = "Engin";
            ogrenci1.Age = 35;
            ogrenci1.Mail = "engin@";

            Student ogrenci2 = new Student();
            ogrenci2.FirstName = "Derin";
            ogrenci2.Age = 6;
            ogrenci2.Mail = "derin@";

            Student ogrenci3 = new Student();
            ogrenci3.FirstName = "Salih";
            ogrenci3.Age = 33;
            ogrenci3.Mail = "salih@";

            List<Student> students = new List<Student>() { ogrenci1,ogrenci2,ogrenci3 };

            foreach (var student in students)
            {
                lbxStudents.Items.Add(student.FirstName);
                
                //MessageBox.Show(student.FirstName+" "+student.Age);
            }

            dgrwStudents.DataSource = students;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
