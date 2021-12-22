using Microsoft.EntityFrameworkCore;
using PreSchool.CRUD;
using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool
{
    public partial class FormChildMenu : Form
    {
        public FormChildMenu()
        {
            InitializeComponent();
        }
        private void FormAddChild_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolContext()) //Adds the existing groups and children to combobox dropdowns
            {
                foreach (var group in db.Groups)
                {
                    groupComboBox.Items.Add(group.Name);
                }
                foreach (var child in db.Children)
                {
                    comboBox1.Items.Add(child.FirstName +" "+ child.LastName);
                }
            }
        }

        private void perNumBox_TextChanged(object sender, EventArgs e) //Checks if personal number has a letter in it. NOTE: MAYBE ADD MAXIMUM AND MINIMUM LENGTH?
        {
            bool number = long.TryParse(perNumBox.Text, out long perNum);
            if (number == true || perNumBox.Text == "") perNumHelpLabel.Visible = false;
            else perNumHelpLabel.Visible = true;
        }

        public Dummy ChildInfo() //Using dummy to indicate that this is just information and not a person
        {
            var dummyChild = new Dummy
            {
                FirstName = nameBox.Text,
                LastName = lastNameBox.Text,
                PersonalNumber = long.Parse(perNumBox.Text),
                StartDate = startDatePicker.Value,
                EndDate = endDatePicker.Value,
                ApplicationDate = applicationDatePicker.Value,
                Group = groupComboBox.Text             
            };
            if (!radioButton1.Checked) dummyChild.Id = GetChildFromComboBox().Id;
            return dummyChild;
        }

        private void ChildActionButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) Create.Child(ChildInfo());
            else if (radioButton2.Checked) Edit.Child(ChildInfo());
            else if (radioButton3.Checked) Delete.Child(GetChildFromComboBox()); //only need what person the combobox shows
            MessageBox.Show("Klar! Ändringar visas nästa gång du laddar sidan.");
        }

        #region Action
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            childActionButton.Visible = true;
            comboBox1.Visible = false;
            comboBox1.Enabled = false;
            childActionButton.Text = "Lägg till";
            ClearTextBoxes();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            childActionButton.Visible = true;
            RadioBtnLocation(78);
            childActionButton.Text = "Redigera";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            childActionButton.Visible = true; 
            RadioBtnLocation(108);
            childActionButton.Text = "Ta bort";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTextBoxesText();
        }

        private Child GetChildFromComboBox()
        {
            using var db = new SchoolContext();
            string[] childName = comboBox1.Text.Split(' ');
            var child = db.Children.First(p => p.FirstName == childName[0] && p.LastName == childName[1]);
            return child;
        }
        private void ChangeTextBoxesText()
        {
            var child = GetChildFromComboBox();
            nameBox.Text = child.FirstName;
            lastNameBox.Text = child.LastName;
            perNumBox.Text = child.PersonalNumber.ToString();
            startDatePicker.Value = child.StartDate;
            endDatePicker.Value = child.EndDate;
            applicationDatePicker.Value = child.ApplicationDate;
            //no Idea how to set combobox selection to match a string input so I leave that one for the user to work around :=)
        }
    }
}
