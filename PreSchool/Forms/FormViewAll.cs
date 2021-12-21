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
            using (var db = new SchoolContext())
            {
                foreach (var group in db.Groups) //Adds groups to combobox
                {
                    comboBoxFilterGroup.Items.Add(group.Name);
                }

                string name = "";
                foreach (var child in db.Children)
                {
                    name = child.FirstName + " " + child.LastName;
                    listBox1.Items.Add(name);
                }



            }
        }

        private void checkBoxFilterGroup_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxFilterGroup.Enabled = checkBoxFilterGroup.Checked;
            //if (checkBoxFilterGroup.Checked==false)
        }

        private void comboBoxFilterGroup_SelectedIndexChanged(object sender, EventArgs e)
        {   
            ShowPeopleInSelectedGroup();
        }

        private void ShowPeopleInSelectedGroup()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            using var db = new SchoolContext();           
            var groupName = db.Groups.FirstOrDefault(g => g.Name == comboBoxFilterGroup.Text);
            var childGroup = db.Children.Include("Groups").Where(g => g.Groups.Contains(groupName)); //Gets children
            var employeeGroup = db.Employees.Include("Groups").Where(g => g.Groups.Contains(groupName)); //Gets employees

            foreach (var child in childGroup) //Shows children
            {
                string name = child.FirstName + " " + child.LastName;
                listBox1.Items.Add(name);
            }

            foreach (var epmloyee in employeeGroup) //Shows employees
            {
                string name = epmloyee.FirstName + " " + epmloyee.LastName;
                listBox2.Items.Add(name);
            }


            //Add parents whos child belongs to selected group!
        }
    }
}
