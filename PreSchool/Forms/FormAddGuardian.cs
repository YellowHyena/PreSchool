using PreSchool.CRUD;
using PreSchool.Database;
using PreSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreSchool.Forms
{
    public partial class FormAddGuardian : Form
    {
        public FormAddGuardian()
        {
            InitializeComponent();
        }

        private void FormAddGuardian_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolContext())
            {
                foreach (var child in db.Children)
                {
                    comboBoxGuardFor.Items.Add(child.FirstName + " " + child.LastName);
                }
            }
        }
        private void perNumBox_TextChanged(object sender, EventArgs e) //Checks if personal number has a letter in it. NOTE: MAYBE ADD MAXIMUM AND MINIMUM LENGTH?
        {
            bool number = long.TryParse(perNumBox.Text, out long perNum);
            if (number == true || perNumBox.Text == "") perNumHelpLabel.Visible = false;
            else perNumHelpLabel.Visible = true;
        }

        public Dummy GuardianInfo() //Using dummy to indicate that this is just information and not a person
        {

            var dummyGuardian = new Dummy
            {
                Child = comboBoxGuardFor.Text,
                FirstName = nameBox.Text,
                LastName = lastNameBox.Text,
                PersonalNumber = long.Parse(perNumBox.Text),
                PhoneNumber = textBoxPhone.Text,
            };
            return dummyGuardian;
        }

        private void addGuardianButton_Click(object sender, EventArgs e)
        {
            Create.Guardian(GuardianInfo());
        }

    }
}
