namespace PreSchool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelHandleSubMenu = new System.Windows.Forms.Panel();
            this.btnHandleEmployee = new System.Windows.Forms.Button();
            this.btnHandleGuardian = new System.Windows.Forms.Button();
            this.btnHandleChild = new System.Windows.Forms.Button();
            this.btnHandle = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelHandleSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panelSideMenu.Controls.Add(this.panelHandleSubMenu);
            this.panelSideMenu.Controls.Add(this.btnHandle);
            this.panelSideMenu.Controls.Add(this.btnShow);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 603);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelHandleSubMenu
            // 
            this.panelHandleSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.panelHandleSubMenu.Controls.Add(this.btnHandleEmployee);
            this.panelHandleSubMenu.Controls.Add(this.btnHandleGuardian);
            this.panelHandleSubMenu.Controls.Add(this.btnHandleChild);
            this.panelHandleSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHandleSubMenu.Location = new System.Drawing.Point(0, 90);
            this.panelHandleSubMenu.Name = "panelHandleSubMenu";
            this.panelHandleSubMenu.Size = new System.Drawing.Size(250, 120);
            this.panelHandleSubMenu.TabIndex = 4;
            this.panelHandleSubMenu.Visible = false;
            // 
            // btnHandleEmployee
            // 
            this.btnHandleEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHandleEmployee.FlatAppearance.BorderSize = 0;
            this.btnHandleEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHandleEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHandleEmployee.Location = new System.Drawing.Point(0, 80);
            this.btnHandleEmployee.Name = "btnHandleEmployee";
            this.btnHandleEmployee.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHandleEmployee.Size = new System.Drawing.Size(250, 40);
            this.btnHandleEmployee.TabIndex = 2;
            this.btnHandleEmployee.Text = "Anställda";
            this.btnHandleEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHandleEmployee.UseVisualStyleBackColor = true;
            this.btnHandleEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnHandleGuardian
            // 
            this.btnHandleGuardian.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHandleGuardian.FlatAppearance.BorderSize = 0;
            this.btnHandleGuardian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHandleGuardian.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHandleGuardian.Location = new System.Drawing.Point(0, 40);
            this.btnHandleGuardian.Name = "btnHandleGuardian";
            this.btnHandleGuardian.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHandleGuardian.Size = new System.Drawing.Size(250, 40);
            this.btnHandleGuardian.TabIndex = 1;
            this.btnHandleGuardian.Text = "Vårdnadshavare";
            this.btnHandleGuardian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHandleGuardian.UseVisualStyleBackColor = true;
            this.btnHandleGuardian.Click += new System.EventHandler(this.btnAddGuardian_Click);
            // 
            // btnHandleChild
            // 
            this.btnHandleChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHandleChild.FlatAppearance.BorderSize = 0;
            this.btnHandleChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHandleChild.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHandleChild.Location = new System.Drawing.Point(0, 0);
            this.btnHandleChild.Name = "btnHandleChild";
            this.btnHandleChild.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHandleChild.Size = new System.Drawing.Size(250, 40);
            this.btnHandleChild.TabIndex = 0;
            this.btnHandleChild.Text = "Barn";
            this.btnHandleChild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHandleChild.UseVisualStyleBackColor = true;
            this.btnHandleChild.Click += new System.EventHandler(this.btnAddChildForm_Click);
            // 
            // btnHandle
            // 
            this.btnHandle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHandle.FlatAppearance.BorderSize = 0;
            this.btnHandle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHandle.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHandle.Location = new System.Drawing.Point(0, 45);
            this.btnHandle.Name = "btnHandle";
            this.btnHandle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHandle.Size = new System.Drawing.Size(250, 45);
            this.btnHandle.TabIndex = 3;
            this.btnHandle.Text = "Hantera";
            this.btnHandle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHandle.UseVisualStyleBackColor = true;
            this.btnHandle.Click += new System.EventHandler(this.btnHandle_Click);
            // 
            // btnShow
            // 
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShow.Location = new System.Drawing.Point(0, 0);
            this.btnShow.Name = "btnShow";
            this.btnShow.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnShow.Size = new System.Drawing.Size(250, 45);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Visa";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(250, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(782, 603);
            this.panelChild.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 603);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1050, 650);
            this.Name = "Form1";
            this.Text = "PreSchool";
            this.panelSideMenu.ResumeLayout(false);
            this.panelHandleSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelHandleSubMenu;
        private Button btnHandleEmployee;
        private Button btnHandleGuardian;
        private Button btnHandleChild;
        private Button btnHandle;
        private Button btnShow;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panelChild;
    }
}