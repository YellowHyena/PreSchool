using PreSchool.CRUD;
using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool.Forms
{
    public partial class FormEmployeeMenu : Form
    {
        public FormEmployeeMenu()
        {
            InitializeComponent();
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolContext()) //Adds the existing groups to combobox dropdown
            {
                foreach (var group in db.Groups)
                {
                    groupComboBox.Items.Add(group.Name);
                }

                foreach (var employee in db.Employees) //Adds employees to combobox
                {
                    comboBox1.Items.Add(employee.FirstName + " " + employee.LastName);
                }
            }
        }
        public Dummy EmployeeInfo() //Using dummy to indicate that this is just information and not a person
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
        private void employeeActionButton_Click(object sender, EventArgs e)
        {
            if (CheckIfTextEmpty() == false)
            {
                if (radioButton1.Checked) Create.Employee(EmployeeInfo());
                else if (radioButton2.Checked) Edit.Employee(EmployeeInfo());
                else if (radioButton3.Checked) Delete.Employee(GetEmployeeFromComboBox());//only need what person the combobox shows
                MessageBox.Show("Klar! Ändringar visas nästa gång du laddar sidan.");
            }
            else MessageBox.Show("Fyll i all information");
        }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTextBoxesText();
        }

        private Employee GetEmployeeFromComboBox()
        {
            using var db = new SchoolContext();
            string[] employeeName = comboBox1.Text.Split(' ');
            var employee = db.Employees.First(p => p.FirstName == employeeName[0] && p.LastName == employeeName[1]);
            return employee;
        }

        private void ChangeTextBoxesText()
        {
            var employee = GetEmployeeFromComboBox();
            nameBox.Text = employee.FirstName;
            lastNameBox.Text = employee.LastName;
            perNumBox.Text = employee.PersonalNumber.ToString();
            datePickerEmploymentDate.Value = employee.EmployementDate;
            //no Idea how to set combobox selection to match a string input so I leave that one for the user to work around :=)
        }
    }
}
