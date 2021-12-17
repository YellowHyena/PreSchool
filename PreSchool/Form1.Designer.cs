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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.perNumLabel = new System.Windows.Forms.Label();
            this.perNumBox = new System.Windows.Forms.TextBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.publicCheckBox = new System.Windows.Forms.CheckBox();
            this.fifteenHCheckBox = new System.Windows.Forms.CheckBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.applicationLabel = new System.Windows.Forms.Label();
            this.applicationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.guardianComboBox = new System.Windows.Forms.ComboBox();
            this.guardianLabel = new System.Windows.Forms.Label();
            this.guardianComboBox2 = new System.Windows.Forms.ComboBox();
            this.guardianLabel2 = new System.Windows.Forms.Label();
            this.addChildButton = new System.Windows.Forms.Button();
            this.perNumHelpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(214, 112);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(151, 27);
            this.nameBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(149, 112);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Namn";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(121, 161);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(77, 20);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Efternamn";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(214, 154);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(151, 27);
            this.lastNameBox.TabIndex = 2;
            // 
            // perNumLabel
            // 
            this.perNumLabel.AutoSize = true;
            this.perNumLabel.Location = new System.Drawing.Point(91, 205);
            this.perNumLabel.Name = "perNumLabel";
            this.perNumLabel.Size = new System.Drawing.Size(107, 20);
            this.perNumLabel.TabIndex = 5;
            this.perNumLabel.Text = "Personnummer";
            // 
            // perNumBox
            // 
            this.perNumBox.Location = new System.Drawing.Point(214, 198);
            this.perNumBox.Name = "perNumBox";
            this.perNumBox.Size = new System.Drawing.Size(151, 27);
            this.perNumBox.TabIndex = 4;
            this.perNumBox.TextChanged += new System.EventHandler(this.perNumBox_TextChanged);
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(122, 245);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(76, 20);
            this.groupLabel.TabIndex = 7;
            this.groupLabel.Text = "Avdelning";
            // 
            // publicCheckBox
            // 
            this.publicCheckBox.AutoSize = true;
            this.publicCheckBox.Location = new System.Drawing.Point(457, 112);
            this.publicCheckBox.Name = "publicCheckBox";
            this.publicCheckBox.Size = new System.Drawing.Size(135, 24);
            this.publicCheckBox.TabIndex = 8;
            this.publicCheckBox.Text = "Allmän förskola";
            this.publicCheckBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.publicCheckBox.UseVisualStyleBackColor = true;
            // 
            // fifteenHCheckBox
            // 
            this.fifteenHCheckBox.AutoSize = true;
            this.fifteenHCheckBox.Location = new System.Drawing.Point(457, 142);
            this.fifteenHCheckBox.Name = "fifteenHCheckBox";
            this.fifteenHCheckBox.Size = new System.Drawing.Size(173, 24);
            this.fifteenHCheckBox.TabIndex = 9;
            this.fifteenHCheckBox.Text = "15-timmars placering";
            this.fifteenHCheckBox.UseVisualStyleBackColor = true;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(214, 423);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(250, 27);
            this.startDatePicker.TabIndex = 10;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(121, 428);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(83, 20);
            this.startLabel.TabIndex = 11;
            this.startLabel.Text = "Startdatum";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(121, 470);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(77, 20);
            this.endLabel.TabIndex = 13;
            this.endLabel.Text = "Slutdatum";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(214, 465);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(250, 27);
            this.endDatePicker.TabIndex = 12;
            // 
            // applicationLabel
            // 
            this.applicationLabel.AutoSize = true;
            this.applicationLabel.Location = new System.Drawing.Point(81, 514);
            this.applicationLabel.Name = "applicationLabel";
            this.applicationLabel.Size = new System.Drawing.Size(127, 20);
            this.applicationLabel.TabIndex = 15;
            this.applicationLabel.Text = "Ansökningsdatum";
            // 
            // applicationDatePicker
            // 
            this.applicationDatePicker.Location = new System.Drawing.Point(214, 507);
            this.applicationDatePicker.Name = "applicationDatePicker";
            this.applicationDatePicker.Size = new System.Drawing.Size(250, 27);
            this.applicationDatePicker.TabIndex = 14;
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Items.AddRange(new object[] {
            "Avdelning 1",
            "Avdelning 2",
            "Avdelning 3"});
            this.groupComboBox.Location = new System.Drawing.Point(214, 242);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(151, 28);
            this.groupComboBox.TabIndex = 16;
            // 
            // guardianComboBox
            // 
            this.guardianComboBox.FormattingEnabled = true;
            this.guardianComboBox.Location = new System.Drawing.Point(214, 300);
            this.guardianComboBox.Name = "guardianComboBox";
            this.guardianComboBox.Size = new System.Drawing.Size(151, 28);
            this.guardianComboBox.TabIndex = 18;
            // 
            // guardianLabel
            // 
            this.guardianLabel.AutoSize = true;
            this.guardianLabel.Location = new System.Drawing.Point(78, 303);
            this.guardianLabel.Name = "guardianLabel";
            this.guardianLabel.Size = new System.Drawing.Size(126, 20);
            this.guardianLabel.TabIndex = 17;
            this.guardianLabel.Text = "Vårdnadshavare 1";
            // 
            // guardianComboBox2
            // 
            this.guardianComboBox2.FormattingEnabled = true;
            this.guardianComboBox2.Location = new System.Drawing.Point(214, 346);
            this.guardianComboBox2.Name = "guardianComboBox2";
            this.guardianComboBox2.Size = new System.Drawing.Size(151, 28);
            this.guardianComboBox2.TabIndex = 20;
            // 
            // guardianLabel2
            // 
            this.guardianLabel2.AutoSize = true;
            this.guardianLabel2.Location = new System.Drawing.Point(78, 349);
            this.guardianLabel2.Name = "guardianLabel2";
            this.guardianLabel2.Size = new System.Drawing.Size(126, 20);
            this.guardianLabel2.TabIndex = 19;
            this.guardianLabel2.Text = "Vårdnadshavare 2";
            // 
            // addChildButton
            // 
            this.addChildButton.Location = new System.Drawing.Point(214, 611);
            this.addChildButton.Name = "addChildButton";
            this.addChildButton.Size = new System.Drawing.Size(94, 29);
            this.addChildButton.TabIndex = 21;
            this.addChildButton.Text = "Add";
            this.addChildButton.UseVisualStyleBackColor = true;
            this.addChildButton.Click += new System.EventHandler(this.addChildButton_Click_1);
            // 
            // perNumHelpLabel
            // 
            this.perNumHelpLabel.AutoSize = true;
            this.perNumHelpLabel.Location = new System.Drawing.Point(371, 201);
            this.perNumHelpLabel.Name = "perNumHelpLabel";
            this.perNumHelpLabel.Size = new System.Drawing.Size(99, 20);
            this.perNumHelpLabel.TabIndex = 22;
            this.perNumHelpLabel.Text = "Enbart siffror!";
            this.perNumHelpLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 916);
            this.Controls.Add(this.perNumHelpLabel);
            this.Controls.Add(this.addChildButton);
            this.Controls.Add(this.guardianComboBox2);
            this.Controls.Add(this.guardianLabel2);
            this.Controls.Add(this.guardianComboBox);
            this.Controls.Add(this.guardianLabel);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.applicationLabel);
            this.Controls.Add(this.applicationDatePicker);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.fifteenHCheckBox);
            this.Controls.Add(this.publicCheckBox);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.perNumLabel);
            this.Controls.Add(this.perNumBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameBox;
        private Label nameLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lastNameLabel;
        private TextBox lastNameBox;
        private Label perNumLabel;
        private TextBox perNumBox;
        private Label groupLabel;
        private CheckBox publicCheckBox;
        private CheckBox fifteenHCheckBox;
        private DateTimePicker startDatePicker;
        private Label startLabel;
        private Label endLabel;
        private DateTimePicker endDatePicker;
        private Label applicationLabel;
        private DateTimePicker applicationDatePicker;
        private ComboBox groupComboBox;
        private ComboBox guardianComboBox;
        private Label guardianLabel;
        private ComboBox guardianComboBox2;
        private Label guardianLabel2;
        private Button addChildButton;
        private Label perNumHelpLabel;
    }
}