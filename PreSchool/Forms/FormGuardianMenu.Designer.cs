namespace PreSchool.Forms
{
    partial class FormGuardianMenu
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
            this.guardianActionButton = new System.Windows.Forms.Button();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // perNumHelpLabel
            // 
            this.perNumHelpLabel.AutoSize = true;
            this.perNumHelpLabel.Location = new System.Drawing.Point(504, 310);
            this.perNumHelpLabel.Name = "perNumHelpLabel";
            this.perNumHelpLabel.Size = new System.Drawing.Size(112, 20);
            this.perNumHelpLabel.TabIndex = 68;
            this.perNumHelpLabel.Text = "Enbart siffror!";
            this.perNumHelpLabel.Visible = false;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(283, 212);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(211, 26);
            this.nameBox.TabIndex = 47;
            // 
            // guardianActionButton
            // 
            this.guardianActionButton.Location = new System.Drawing.Point(283, 478);
            this.guardianActionButton.Name = "guardianActionButton";
            this.guardianActionButton.Size = new System.Drawing.Size(132, 32);
            this.guardianActionButton.TabIndex = 67;
            this.guardianActionButton.Text = "Action";
            this.guardianActionButton.UseVisualStyleBackColor = true;
            this.guardianActionButton.Visible = false;
            this.guardianActionButton.Click += new System.EventHandler(this.GuardianActionButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(190, 212);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 48;
            this.nameLabel.Text = "Namn";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(283, 259);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(211, 26);
            this.lastNameBox.TabIndex = 49;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(151, 266);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 50;
            this.lastNameLabel.Text = "Efternamn";
            // 
            // perNumBox
            // 
            this.perNumBox.Location = new System.Drawing.Point(283, 307);
            this.perNumBox.Name = "perNumBox";
            this.perNumBox.Size = new System.Drawing.Size(211, 26);
            this.perNumBox.TabIndex = 51;
            this.perNumBox.TextChanged += new System.EventHandler(this.perNumBox_TextChanged);
            // 
            // perNumLabel
            // 
            this.perNumLabel.AutoSize = true;
            this.perNumLabel.Location = new System.Drawing.Point(109, 314);
            this.perNumLabel.Name = "perNumLabel";
            this.perNumLabel.Size = new System.Drawing.Size(123, 20);
            this.perNumLabel.TabIndex = 52;
            this.perNumLabel.Text = "Personnummer";
            // 
            // comboBoxGuardFor
            // 
            this.comboBoxGuardFor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGuardFor.FormattingEnabled = true;
            this.comboBoxGuardFor.Location = new System.Drawing.Point(283, 151);
            this.comboBoxGuardFor.Name = "comboBoxGuardFor";
            this.comboBoxGuardFor.Size = new System.Drawing.Size(211, 28);
            this.comboBoxGuardFor.TabIndex = 62;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(85, 154);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(155, 20);
            this.groupLabel.TabIndex = 53;
            this.groupLabel.Text = "Vårdnadshavare för";
            // 
            // labelPhoneCheck
            // 
            this.labelPhoneCheck.AutoSize = true;
            this.labelPhoneCheck.Location = new System.Drawing.Point(504, 355);
            this.labelPhoneCheck.Name = "labelPhoneCheck";
            this.labelPhoneCheck.Size = new System.Drawing.Size(112, 20);
            this.labelPhoneCheck.TabIndex = 71;
            this.labelPhoneCheck.Text = "Enbart siffror!";
            this.labelPhoneCheck.Visible = false;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(283, 352);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(211, 26);
            this.textBoxPhone.TabIndex = 69;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(109, 359);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(125, 20);
            this.labelPhone.TabIndex = 70;
            this.labelPhone.Text = "Telefonnummer";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 28);
            this.comboBox1.TabIndex = 75;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(99, 109);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton3.Size = new System.Drawing.Size(83, 24);
            this.radioButton3.TabIndex = 74;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ta bort";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 79);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(97, 24);
            this.radioButton2.TabIndex = 73;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Redigera";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(93, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(89, 24);
            this.radioButton1.TabIndex = 72;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Lägg till";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FormGuardianMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.labelPhoneCheck);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.perNumHelpLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.guardianActionButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.perNumBox);
            this.Controls.Add(this.perNumLabel);
            this.Controls.Add(this.comboBoxGuardFor);
            this.Controls.Add(this.groupLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormGuardianMenu";
            this.Text = "Guardian Menu";
            this.Load += new System.EventHandler(this.FormAddGuardian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label perNumHelpLabel;
        private TextBox nameBox;
        private Button guardianActionButton;
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
        private ComboBox comboBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}