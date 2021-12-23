using PreSchool.CRUD;
using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool.Forms
{
    public partial class FormEmployeeMenu : Form
    {
        //Child, Guardian and Employee forms are basically identical, they just gather and show different types of information

        public FormEmployeeMenu()
        {
            InitializeComponent();
        }

        private void FormEmployeeMenu_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolContext())
            {
                foreach (var group in db.Groups) //Adds the existing groups to combobox dropdown
                {
                    groupComboBox.Items.Add(group.Name);
                }

                foreach (var employee in db.Employees) //Adds the existing guardians for selection when editing or deleting
                {
                    comboBox1.Items.Add(employee.FirstName + " " + employee.LastName);
                }
            }
        }

        public Dummy EmployeeInfo() //Using dummy to indicate that this is just information and not a person. Also easier to just transfer strings and transform it to classes elsewhere
        {
            var dummyEmployee = new Dummy
            {
                FirstName = nameBox.Text,
                LastName = lastNameBox.Text,
                PersonalNumber = long.Parse(perNumBox.Text),
                EmployementDate = datePickerEmploymentDate.Value,
                Group = groupComboBox.Text
            };
            if (!radioButton1.Checked) dummyEmployee.Id = GetEmployeeFromComboBox().Id;
            return dummyEmployee;
        }

        private void employeeActionButton_Click(object sender, EventArgs e) //Adds, edits or deletes depending on radiobuttons
        {
            if (CheckIfTextEmpty() == false)
            {
                bool success = true; // sending this to eatch method to see if it succeed
                if (radioButton1.Checked) success = Create.Employee(EmployeeInfo());
                else if (radioButton2.Checked) success = Edit.Employee(EmployeeInfo());
                else if (radioButton3.Checked) Delete.Employee(GetEmployeeFromComboBox());//dont need all info so no need for dummy
                if (success == true) MessageBox.Show("Klar! Ändringar visas nästa gång du laddar sidan.");
            }
            else MessageBox.Show("Fyll i all information");
        }

        private void perNumBox_TextChanged(object sender, EventArgs e) //Checks if personal number has a letter in it and disables action button if true
        {
            bool number = long.TryParse(perNumBox.Text, out long perNum);
            if (number == true || perNumBox.Text == "")
            {
                perNumHelpLabel.Visible = false;
                employeeActionButton.Enabled = true;
            }
            else
            {
                perNumHelpLabel.Visible = true;
                employeeActionButton.Enabled = false;
            }
        }

        //ActionChoiceHandles what happens when radiobuttons are pressed
        #region ActionChoice
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            employeeActionButton.Visible = true;
            comboBox1.Visible = false;
            comboBox1.Enabled = false;
            employeeActionButton.Text = "Lägg till";
            ClearTextBoxes();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            employeeActionButton.Visible = true;
            RadioBtnLocation(78);
            employeeActionButton.Text = "Redigera";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            employeeActionButton.Visible = true;
            RadioBtnLocation(108);
            employeeActionButton.Text = "Ta bort";
        }
        public void RadioBtnLocation(int pos)
        {
            comboBox1.Location = new Point(188, pos);
            comboBox1.Visible = true;
            comboBox1.Enabled = true;
        }
        #endregion

        private Employee GetEmployeeFromComboBox() //gets what person is selected for editing or deletion
        {
            using var db = new SchoolContext();
            string[] employeeName = comboBox1.Text.Split(' ');
            var employee = db.Employees.First(p => p.FirstName == employeeName[0] && p.LastName == employeeName[1]); //crash if first or last names has spaces
            return employee;
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
            var employee = GetEmployeeFromComboBox();
            nameBox.Text = employee.FirstName;
            lastNameBox.Text = employee.LastName;
            perNumBox.Text = employee.PersonalNumber.ToString();
            textBoxPhone.Text = employee.PhoneNumber;
            datePickerEmploymentDate.Value = employee.EmployementDate;
            //no Idea how to set combobox selection to match a string input so I leave that one for the user to work around :=)
        }
    }
}
