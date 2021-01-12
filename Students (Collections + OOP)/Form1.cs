using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students__Collections___OOP_
{
    public partial class Form1 : Form
    {

        List<Student> myStudents = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student newstudent = new Student(txtFirstName.Text, txtLastName.Text);
            myStudents.Add(newstudent);
            lbStudenten.Items.Add(newstudent.Naam());
        }

        private void lbStudenten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
