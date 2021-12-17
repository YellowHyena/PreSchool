using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void perNumBox_TextChanged(object sender, EventArgs e)
        {
            int perNum;
            bool number = int.TryParse(perNumBox.Text, out perNum);
            if (number == true || perNumBox.Text == "") perNumHelpLabel.Visible = false;
            else perNumHelpLabel.Visible = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void addChildButton_Click_1(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string lastName = lastNameBox.Text;
            int perNum = int.Parse(perNumBox.Text);
            string group = groupComboBox.Text;
            DateTime start = startDatePicker.Value;
            DateTime end = endDatePicker.Value;
            DateTime apply = applicationDatePicker.Value;
            bool publ = publicCheckBox.Checked;
            bool fifteen = fifteenHCheckBox.Checked;


            CRUD.Create.Child(ChildInfo);
        }
        public Child ChildInfo()
        {
            using var db = new SchoolContext();
            var tempChild = new Child
            {
                FirstName = nameBox.Text,
                LastName = lastNameBox.Text,
                PersonalNumber = int.Parse(perNumBox.Text),
                StartDate = startDatePicker.Value,
                EndDate = endDatePicker.Value,
                ApplicationDate = applicationDatePicker.Value,
                PublicPreSchool = publicCheckBox.Checked,
                FifteenHours = fifteenHCheckBox.Checked,
                
            };
            string group = groupComboBox.Text;
            string guardian1 = guardianComboBox.Text;
            string guardian2 = guardianComboBox2.Text;
            return tempChild;
        }
    }
}