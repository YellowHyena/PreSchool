namespace PreSchool.Forms
{
    partial class FormAddGuardian
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.perNumHelpLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addGuardianButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.perNumBox = new System.Windows.Forms.TextBox();
            this.perNumLabel = new System.Windows.Forms.Label();
            this.comboBoxGuardFor = new System.Windows.Forms.ComboBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.labelPhoneCheck = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // perNumHelpLabel
            // 
            this.perNumHelpLabel.AutoSize = true;
            this.perNumHelpLabel.Location = new System.Drawing.Point(522, 263);
            this.perNumHelpLabel.Name = "perNumHelpLabel";
            this.perNumHelpLabel.Size = new System.Drawing.Size(112, 20);
            this.perNumHelpLabel.TabIndex = 68;
            this.perNumHelpLabel.Text = "Enbart siffror!";
            this.perNumHelpLabel.Visible = false;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(301, 165);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(211, 26);
            this.nameBox.TabIndex = 47;
            // 
            // addGuardianButton
            // 
            this.addGuardianButton.Location = new System.Drawing.Point(301, 431);
            this.addGuardianButton.Name = "addGuardianButton";
            this.addGuardianButton.Size = new System.Drawing.Size(132, 32);
            this.addGuardianButton.TabIndex = 67;
            this.addGuardianButton.Text = "Add";
            this.addGuardianButton.UseVisualStyleBackColor = true;
            this.addGuardianButton.Click += new System.EventHandler(this.addGuardianButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(208, 165);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 48;
            this.nameLabel.Text = "Namn";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(301, 212);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(211, 26);
            this.lastNameBox.TabIndex = 49;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(169, 219);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 50;
            this.lastNameLabel.Text = "Efternamn";
            // 
            // perNumBox
            // 
            this.perNumBox.Location = new System.Drawing.Point(301, 260);
            this.perNumBox.Name = "perNumBox";
            this.perNumBox.Size = new System.Drawing.Size(211, 26);
            this.perNumBox.TabIndex = 51;
            this.perNumBox.TextChanged += new System.EventHandler(this.perNumBox_TextChanged);
            // 
            // perNumLabel
            // 
            this.perNumLabel.AutoSize = true;
            this.perNumLabel.Location = new System.Drawing.Point(127, 267);
            this.perNumLabel.Name = "perNumLabel";
            this.perNumLabel.Size = new System.Drawing.Size(123, 20);
            this.perNumLabel.TabIndex = 52;
            this.perNumLabel.Text = "Personnummer";
            // 
            // comboBoxGuardFor
            // 
            this.comboBoxGuardFor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGuardFor.FormattingEnabled = true;
            this.comboBoxGuardFor.Location = new System.Drawing.Point(301, 104);
            this.comboBoxGuardFor.Name = "comboBoxGuardFor";
            this.comboBoxGuardFor.Size = new System.Drawing.Size(211, 28);
            this.comboBoxGuardFor.TabIndex = 62;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(89, 107);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(155, 20);
            this.groupLabel.TabIndex = 53;
            this.groupLabel.Text = "Vårdnadshavare för";
            // 
            // labelPhoneCheck
            // 
            this.labelPhoneCheck.AutoSize = true;
            this.labelPhoneCheck.Location = new System.Drawing.Point(522, 308);
            this.labelPhoneCheck.Name = "labelPhoneCheck";
            this.labelPhoneCheck.Size = new System.Drawing.Size(112, 20);
            this.labelPhoneCheck.TabIndex = 71;
            this.labelPhoneCheck.Text = "Enbart siffror!";
            this.labelPhoneCheck.Visible = false;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(301, 305);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(211, 26);
            this.textBoxPhone.TabIndex = 69;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(127, 312);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(125, 20);
            this.labelPhone.TabIndex = 70;
            this.labelPhone.Text = "Telefonnummer";
            // 
            // FormAddGuardian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.labelPhoneCheck);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.perNumHelpLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.addGuardianButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.perNumBox);
            this.Controls.Add(this.perNumLabel);
            this.Controls.Add(this.comboBoxGuardFor);
            this.Controls.Add(this.groupLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormAddGuardian";
            this.Text = "FormAddGuardian";
            this.Load += new System.EventHandler(this.FormAddGuardian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label perNumHelpLabel;
        private TextBox nameBox;
        private Button addGuardianButton;
        private Label nameLabel;
        private TextBox lastNameBox;
        private Label lastNameLabel;
        private TextBox perNumBox;
        private Label perNumLabel;
        private ComboBox comboBoxGuardFor;
        private Label groupLabel;
        private Label labelPhoneCheck;
        private TextBox textBoxPhone;
        private Label labelPhone;
    }
}