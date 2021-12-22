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
            return dummyEmployee;
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            Create.Employee(EmployeeInfo());
        }
    }
}
