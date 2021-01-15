using System;
using System.Collections.Generic;
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

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("First name and family name must be filled in!");

            }
            else
            {

                Student newstudent = new Student(txtFirstName.Text, txtLastName.Text);
               
                myStudents.Add(newstudent);
                lbStudenten.Items.Add(newstudent.Name());
                txtFirstName.Text = null;
                txtLastName.Text = null;
            }


        }

        private void lbStudenten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbStudenten.SelectedItem != null)
            {
                string FullName = lbStudenten.SelectedItem.ToString();
                string[] nameComponents = FullName.Split(' ');
                string[] LastName = FullName.Split(' ');


                if(nameComponents.Length >=2)
                {

                    txtFirstName.Text = nameComponents[0];
                    txtLastName.Text = nameComponents[1];
                }    

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                lbStudenten.Items.Remove(lbStudenten.SelectedItem);
            }
           


        }
    }
}
