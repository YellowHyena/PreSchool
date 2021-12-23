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

        private void FormViewAll_Load(object sender, EventArgs e) //adds all persons and groups to corresponding listbox or combobox
        {
            AddGroupsToComboBox();
            AddChildrenToComboBox();
            AddGuardiansToComboBox();
            AddEmployeesToComboBox();
        }

        private void AddGroupsToComboBox() //Adds groups to combobox for filtering
        {
            using var db = new SchoolContext();
            foreach (var group in db.Groups) 
            {
                comboBoxFilterGroup.Items.Add(group.Name);
            }
        }

        private void AddChildrenToComboBox() //Adds children to listbox1
        {
            using var db = new SchoolContext();
            foreach (var child in db.Children) 
            {
                string name = child.FirstName + " " + child.LastName;
                listBox1.Items.Add(name);
            }
        }
        private void AddGuardiansToComboBox() //Adds guardians to listbox2
        {
            using var db = new SchoolContext();
            foreach (var guardian in db.Guardians) 
            {
                string name = guardian.FirstName + " " + guardian.LastName;
                listBox2.Items.Add(name);
            }
        }
        private void AddEmployeesToComboBox() //Adds employees to listbox1
        {
            using var db = new SchoolContext();
            foreach (var guardian in db.Employees) 
            {
                string name = guardian.FirstName + " " + guardian.LastName;
                listBox3.Items.Add(name);
            }
        }

        private void checkBoxFilterGroup_CheckedChanged(object sender, EventArgs e) //filter toggle
        {
            comboBoxFilterGroup.Enabled = checkBoxFilterGroup.Checked;
            if (checkBoxFilterGroup.Checked == false) //resets to "normal" state
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
                if (comboBoxFilterGroup.Text != "") ShowPeopleInSelectedGroup(); // if filter is on and a group is selected
            }
        }

        private void comboBoxFilterGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPeopleInSelectedGroup();
        }

        private void ShowPeopleInSelectedGroup() // gets what child and employee is in selected group and shows it
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
            //Wanted to get guardians whos child is in selected group but can't get it to work

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
