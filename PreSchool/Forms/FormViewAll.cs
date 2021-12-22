using Microsoft.EntityFrameworkCore;
using PreSchool.Database;

namespace PreSchool
{
    public partial class FormViewAll : Form
    {
        public FormViewAll()
        {
            InitializeComponent();
        }

        private void FormViewAll_Load(object sender, EventArgs e)
        {
            AddGroupsToComboBox();
            AddChildrenToComboBox();
            AddGuardiansToComboBox();
            AddEmployeesToComboBox();
        }

        private void AddGroupsToComboBox()
        {
            using var db = new SchoolContext();
            foreach (var group in db.Groups) //Adds groups to combobox
            {
                comboBoxFilterGroup.Items.Add(group.Name);
            }
        }

        private void AddChildrenToComboBox()
        {
            using var db = new SchoolContext();
            foreach (var child in db.Children) //Adds children to listbox1
            {
                string name = child.FirstName + " " + child.LastName;
                listBox1.Items.Add(name);
            }
        }
        private void AddGuardiansToComboBox()
        {
            using var db = new SchoolContext();
            foreach (var guardian in db.Guardians) //Adds guardians to listbox1
            {
                string name = guardian.FirstName + " " + guardian.LastName;
                listBox2.Items.Add(name);
            }
        }
        private void AddEmployeesToComboBox()
        {
            using var db = new SchoolContext();
            foreach (var guardian in db.Employees) //Adds employees to listbox1
            {
                string name = guardian.FirstName + " " + guardian.LastName;
                listBox3.Items.Add(name);
            }
        }

        private void checkBoxFilterGroup_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxFilterGroup.Enabled = checkBoxFilterGroup.Checked;
            if (checkBoxFilterGroup.Checked == false)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                AddChildrenToComboBox();
                AddGuardiansToComboBox();
                AddEmployeesToComboBox();
            }
            else
            {
                if (comboBoxFilterGroup.Text != "") ShowPeopleInSelectedGroup();
            }
        }

        private void comboBoxFilterGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPeopleInSelectedGroup();
        }

        private void ShowPeopleInSelectedGroup()
        {
            using var db = new SchoolContext();

            var groupName = db.Groups.FirstOrDefault(g => g.Name == comboBoxFilterGroup.Text);


            //Child
            listBox1.Items.Clear();

            var childGroup = db.Children.Include("Groups").Where(g => g.Groups.Contains(groupName)); //Gets children

            foreach (var child in childGroup) //Shows children
            {
                string name = child.FirstName + " " + child.LastName;
                listBox1.Items.Add(name);
            }

            //Guardian
            listBox2.Items.Clear();
            //Can't get this to work so i leave this empty when using filters

            //Employee
            var employeeGroup = db.Employees.Include("Groups").Where(g => g.Groups.Contains(groupName)); //Gets employees

            listBox3.Items.Clear();

            foreach (var employee in employeeGroup) //Shows employees
            {
                string name = employee.FirstName + " " + employee.LastName;
                listBox3.Items.Add(name);
            }
        }
    }
}
