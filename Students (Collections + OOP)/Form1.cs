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
                //newstudent.FirstName = "";
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

                //txtFirstName.Text = lbStudenten.SelectedItem.ToString().Substring()
                //txtLastName.Text = lbStudenten.SelectedItem.ToString().Substring(startIndex:0, length: txtLastName.TextLength);

            }

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                lbStudenten.Items.Remove(lbStudenten.SelectedItem);
            }
            else
            {

            }


        }
    }
}
