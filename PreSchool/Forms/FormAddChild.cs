using PreSchool.CRUD;
using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool
{
    public partial class FormAddChild : Form
    {
        public FormAddChild()
        {
            InitializeComponent();
        }
        private void perNumBox_TextChanged(object sender, EventArgs e)
        {
            long perNum;
            bool number = long.TryParse(perNumBox.Text, out perNum);
            if (number == true || perNumBox.Text == "") perNumHelpLabel.Visible = false;
            else perNumHelpLabel.Visible = true;
        }

        private void addChildButton_Click_1(object sender, EventArgs e)
        {
            Create.Child(ChildInfo());
        }
        public Child ChildInfo()
        {
            using var db = new SchoolContext();
            var tempChild = new Child
            {
                FirstName = nameBox.Text,
                LastName = lastNameBox.Text,
                PersonalNumber = long.Parse(perNumBox.Text),
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
