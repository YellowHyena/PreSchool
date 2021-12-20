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
        private void FormAddChild_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolContext())
            {
                foreach (var group in db.Groups)
                {
                    groupComboBox.Items.Add(group.Name);
                }               
            }

        }
        private void perNumBox_TextChanged(object sender, EventArgs e)
        {
            bool number = long.TryParse(perNumBox.Text, out long perNum);
            if (number == true || perNumBox.Text == "") perNumHelpLabel.Visible = false;
            else perNumHelpLabel.Visible = true;
        }


        public Dummy ChildInfo()
        {
            var tempChild = new Dummy
            {
                FirstName = nameBox.Text,
                LastName = lastNameBox.Text,
                PersonalNumber = perNumBox.Text,
                StartDate = startDatePicker.Value,
                EndDate = endDatePicker.Value,
                ApplicationDate = applicationDatePicker.Value,
                PublicPreSchool = publicCheckBox.Checked,
                FifteenHours = fifteenHCheckBox.Checked,
                Group = groupComboBox.Text,
                Guardian1 = guardianComboBox.Text,
                Guardian2=guardianComboBox2.Text
            };
            return tempChild;
        }

        private void addChildButton_Click(object sender, EventArgs e)
        {
           // Create.Child(ChildInfo());
        }

        private void lastNameBox_Leave(object sender, EventArgs e)
        {
            using (var db = new SchoolContext())
            {
                string input = lastNameBox.Text;
                var list = db.Guardians.Where(g => g.LastName.Contains(input));
                if (list == null) return;
                foreach (var guardian in list)
                {
                    guardianComboBox.Items.Add(guardian.FirstName + " " + guardian.LastName);
                    guardianComboBox2.Items.Add(guardian.FirstName + " " + guardian.LastName);
                }
            }
        }
    }
}
