using Microsoft.EntityFrameworkCore;
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
    public partial class FormGuardianMenu : Form
    {
        public FormGuardianMenu()
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
                foreach (var guardian in db.Guardians)
                {
                    comboBox1.Items.Add(guardian.FirstName + " " + guardian.LastName);
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
                PhoneNumber = textBoxPhone.Text              
            };
            if (!radioButton1.Checked) dummyGuardian.Id = GetGuardianFromComboBox().Id;
            return dummyGuardian;
        }
        #region Action
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            guardianActionButton.Visible = true;
            comboBox1.Visible = false;
            comboBox1.Enabled = false;
            guardianActionButton.Text = "Lägg till";
            ClearTextBoxes();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            guardianActionButton.Visible = true;
            RadioBtnLocation(78);
            guardianActionButton.Text = "Redigera";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            guardianActionButton.Visible = true;
            RadioBtnLocation(108);
            guardianActionButton.Text = "Ta bort";
        }
        public void RadioBtnLocation(int pos)
        {
            comboBox1.Location = new Point(188, pos);
            comboBox1.Visible = true;
            comboBox1.Enabled = true;
        }
        #endregion
        private void ClearTextBoxes() //https://stackoverflow.com/a/4811390
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private bool CheckIfTextEmpty() //https://stackoverflow.com/a/8750307
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    if (textBox.Text == string.Empty) return true;
                }
            };
            return false;
        }
        private Guardian GetGuardianFromComboBox()
        {
            using var db = new SchoolContext();
            string[] guardianName = comboBox1.Text.Split(' ');
            var guardian = db.Guardians.First(p => p.FirstName == guardianName[0] && p.LastName == guardianName[1]);
            return guardian;
        }
        private void ChangeTextBoxesText()
        {
            var guardian = GetGuardianFromComboBox();
            nameBox.Text = guardian.FirstName;
            lastNameBox.Text = guardian.LastName;
            perNumBox.Text = guardian.PersonalNumber.ToString();
            textBoxPhone.Text = guardian.PhoneNumber;
            //no Idea how to set combobox selection to match a string input so I leave that one for the user to work around :=)
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTextBoxesText();
        }

        private void GuardianActionButton_Click(object sender, EventArgs e)
        {
            if (CheckIfTextEmpty() == false)
            {
                if (radioButton1.Checked) Create.Guardian(GuardianInfo());
                else if (radioButton2.Checked) Edit.Guardian(GuardianInfo());
                else if (radioButton3.Checked) Delete.Guardian(GetGuardianFromComboBox());//only need what person the combobox shows
                MessageBox.Show("Klar! Ändringar visas nästa gång du laddar sidan.");
            }
            else MessageBox.Show("Fyll i all information");
        }
    }
}
