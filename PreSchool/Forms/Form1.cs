using PreSchool.Forms;

namespace PreSchool
{
    public partial class Form1 : Form
    {
        //Based on https://www.youtube.com/watch?v=JP5rgXO_5Sk I had more submenus before, like in the video
        //but got rid of them, so some code here might be useless but I dont dare change it cuz i dont get exactly
        //how windows forms works and i dont wanna test line by line and check what i can get rid off
        public Form1()
        {
            InitializeComponent();
        }

        private void HideSubMenu() //Used when i need to hide the submenu, duh
        {
            panelHandleSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu) //Checks what submenu i'm in, I had more before, like in the video but I got rid of them
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e) //shows viewform 
        {
            OpenChildForm(new FormViewAll());
            HideSubMenu();
        }

        private void btnHandle_Click(object sender, EventArgs e) //show handle submenu
        {
            ShowSubMenu(panelHandleSubMenu);
        }
       
        //handles what happens when you press buttons in the handle sub menu, it opens forms depending on button
        #region HandleSubMenu
        private void btnAddChildForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChildMenu());
            HideSubMenu();
        }

        private void btnAddGuardian_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGuardianMenu());
            HideSubMenu();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormEmployeeMenu());
            HideSubMenu();
        }
        #endregion


        //I have no clue whats happening here but its important according to the video
        //If I remember it just does so I can open a childform in the panel in the main form,
        //based on the code here it looks that way anyways.
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.Show();
        }
    }
}