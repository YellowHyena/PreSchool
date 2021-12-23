using PreSchool.CRUD;
using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool
{
    public partial class FormChildMenu : Form
    {
        //Child, Guardian and Employee forms are basically identical, they just gather and show different types of information
        
        public FormChildMenu()
        {
            InitializeComponent();
        }
       
        private void FormAddChild_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolContext())
            {
                foreach (var group in db.Groups) //Adds the existing groups to combobox dropdown
                {
                    groupComboBox.Items.Add(group.Name);
                }

                foreach (var child in db.Children) //Adds the existing children for selection when editing or deleting
                {
                    comboBox1.Items.Add(child.FirstName + " " + child.LastName);
                }
            }
        }
       
        public Dummy ChildInfo() //Using dummy to indicate that this is just information and not a person. Also easier to just transfer strings and transform it to classes elsewhere
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
       
        private void ChildActionButton_Click(object sender, EventArgs e) //Adds, edits or deletes depending on radiobuttons
        {
            if (CheckIfTextEmpty() == false)
            {
                bool success = true; // sending this to eatch method to see if it succeed
                if (radioButton1.Checked) success = Create.Child(ChildInfo());
                else if (radioButton2.Checked) success = Edit.Child(ChildInfo());
                else if (radioButton3.Checked) Delete.Child(GetChildFromComboBox()); //dont need all info so no need for dummy
                if (success== true) MessageBox.Show("Klar! Ändringar visas nästa gång du laddar sidan.");
            }
            else MessageBox.Show("Fyll i all information");
        }

        private void perNumBox_TextChanged(object sender, EventArgs e) //Checks if personal number has a letter in it and disables action button if true
        {
            bool number = long.TryParse(perNumBox.Text, out long perNum);
            if (number == true || perNumBox.Text == "")
            {
                perNumHelpLabel.Visible = false;
                childActionButton.Enabled = true;
            }
            else
            {
                perNumHelpLabel.Visible = true;
                childActionButton.Enabled = false;
            }
        }

        //ActionChoiceHandles what happens when radiobuttons are pressed
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

        private Child GetChildFromComboBox() //gets what person is selected for editing or deletion
        {
            using var db = new SchoolContext();
            string[] childName = comboBox1.Text.Split(' ');
            var child = db.Children.First(p => p.FirstName == childName[0] && p.LastName == childName[1]);  //crash if first or last name has spaces
            return child;
        }

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
                    if (textBox.Text == string.Empty || groupComboBox.Text == String.Empty) return true;
                }
            };
            return false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //when selecting an existing person from dropdown menu
        {
            ChangeTextBoxesText();
        }
        
        private void ChangeTextBoxesText() //changes text to mirror selected persons information
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
