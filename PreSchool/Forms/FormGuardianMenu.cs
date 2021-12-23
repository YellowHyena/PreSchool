using PreSchool.CRUD;
using PreSchool.Database;
using PreSchool.Models;

namespace PreSchool.Forms
{
    public partial class FormGuardianMenu : Form
    {
        //Child, Guardian and Employee forms are basically identical, they just gather and show different types of information
      
        public FormGuardianMenu()
        {
            InitializeComponent();
        }
       
        private void FormAddGuardian_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolContext())
            {
                foreach (var child in db.Children) //Adds the existing children to combobox dropdown
                {
                    comboBoxGuardFor.Items.Add(child.FirstName + " " + child.LastName);
                }
                foreach (var guardian in db.Guardians) //Adds the existing guardians for selection when editing or deleting
                {
                    comboBox1.Items.Add(guardian.FirstName + " " + guardian.LastName);
                }
            }
        }
        
        public Dummy GuardianInfo() //Using dummy to indicate that this is just information and not a person. Also easier to just transfer strings and transform it to classes elsewhere
        {
            var dummyGuardian = new Dummy
            {
                Child = comboBoxGuardFor.Text,
                FirstName = nameBox.Text,
                LastName = lastNameBox.Text,
                PersonalNumber = long.Parse(perNumBox.Text),
                PhoneNumber = textBoxPhone.Text
            };
            if (!radioButton1.Checked) dummyGuardian.Id = GetGuardianFromComboBox().Id;
            return dummyGuardian;
        }
       
        private void GuardianActionButton_Click(object sender, EventArgs e) //Adds, edits or deletes depending on radiobuttons
        {
            if (CheckIfTextEmpty() == false)
            {
                if (radioButton1.Checked) Create.Guardian(GuardianInfo());
                else if (radioButton2.Checked) Edit.Guardian(GuardianInfo());
                else if (radioButton3.Checked) Delete.Guardian(GetGuardianFromComboBox());//dont need all info so no need for dummy
                MessageBox.Show("Klar! Ändringar visas nästa gång du laddar sidan.");
            }
            else MessageBox.Show("Fyll i all information");
        }
       
        private void perNumBox_TextChanged(object sender, EventArgs e) //Checks if personal number has a letter in it and disables action button if true
        {
            bool number = long.TryParse(perNumBox.Text, out long perNum);
            if (number == true || perNumBox.Text == "")
            {
                perNumHelpLabel.Visible = false;
                guardianActionButton.Enabled = true;
            }
            else
            {
                perNumHelpLabel.Visible = true;
                guardianActionButton.Enabled = false;
            }
        }

        //ActionChoiceHandles what happens when radiobuttons are pressed
        #region Action
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            guardianActionButton.Visible = true;
            comboBox1.Visible = false;
            comboBox1.Enabled = false;
            guardianActionButton.Text = "Lägg till";
            ClearTextBoxes();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            guardianActionButton.Visible = true;
            RadioBtnLocation(78);
            guardianActionButton.Text = "Redigera";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            guardianActionButton.Visible = true;
            RadioBtnLocation(108);
            guardianActionButton.Text = "Ta bort";
        }
        public void RadioBtnLocation(int pos)
        {
            comboBox1.Location = new Point(188, pos);
            comboBox1.Visible = true;
            comboBox1.Enabled = true;
        }
        #endregion          
        
        private Guardian GetGuardianFromComboBox() //gets what person is selected for editing or deletion
        {
            using var db = new SchoolContext();
            string[] guardianName = comboBox1.Text.Split(' ');
            var guardian = db.Guardians.First(p => p.FirstName == guardianName[0] && p.LastName == guardianName[1]);
            return guardian;
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
                    if (textBox.Text == string.Empty || comboBoxGuardFor.Text == String.Empty) return true;
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
            var guardian = GetGuardianFromComboBox();
            nameBox.Text = guardian.FirstName;
            lastNameBox.Text = guardian.LastName;
            perNumBox.Text = guardian.PersonalNumber.ToString();
            textBoxPhone.Text = guardian.PhoneNumber;
            //no Idea how to set combobox selection to match a string input so I leave that one for the user to work around :=)
        }
    }
}
