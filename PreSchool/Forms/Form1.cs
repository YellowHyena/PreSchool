using PreSchool.Forms;

namespace PreSchool
{
    public partial class Form1 : Form
    {
        //Based on https://www.youtube.com/watch?v=JP5rgXO_5Sk
        public Form1()
        {
            InitializeComponent();
        }

        private void HideSubMenu()
        {
            panelHandleSubMenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        #region ShowMenu
        private void btnShow_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormViewAll());
            HideSubMenu();
        }

        private void btnShowChild_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        #region HandleSubMenu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelHandleSubMenu);
        }
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