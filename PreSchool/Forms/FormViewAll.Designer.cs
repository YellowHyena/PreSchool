namespace PreSchool
{
    partial class FormViewAll
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.comboBoxFilterGroup = new System.Windows.Forms.ComboBox();
            this.checkBoxFilterGroup = new System.Windows.Forms.CheckBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(48, 83);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 364);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(290, 83);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(194, 364);
            this.listBox2.TabIndex = 1;
            // 
            // comboBoxFilterGroup
            // 
            this.comboBoxFilterGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterGroup.Enabled = false;
            this.comboBoxFilterGroup.FormattingEnabled = true;
            this.comboBoxFilterGroup.Location = new System.Drawing.Point(290, 515);
            this.comboBoxFilterGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxFilterGroup.Name = "comboBoxFilterGroup";
            this.comboBoxFilterGroup.Size = new System.Drawing.Size(188, 28);
            this.comboBoxFilterGroup.TabIndex = 3;
            this.comboBoxFilterGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterGroup_SelectedIndexChanged);
            // 
            // checkBoxFilterGroup
            // 
            this.checkBoxFilterGroup.AutoSize = true;
            this.checkBoxFilterGroup.Location = new System.Drawing.Point(155, 517);
            this.checkBoxFilterGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxFilterGroup.Name = "checkBoxFilterGroup";
            this.checkBoxFilterGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxFilterGroup.Size = new System.Drawing.Size(111, 24);
            this.checkBoxFilterGroup.TabIndex = 4;
            this.checkBoxFilterGroup.Text = "Visa grupp";
            this.checkBoxFilterGroup.UseVisualStyleBackColor = true;
            this.checkBoxFilterGroup.CheckedChanged += new System.EventHandler(this.checkBoxFilterGroup_CheckedChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(536, 83);
            this.listBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(194, 364);
            this.listBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Barn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vårdnadshavare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Anställda";
            // 
            // FormViewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.checkBoxFilterGroup);
            this.Controls.Add(this.comboBoxFilterGroup);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormViewAll";
            this.Text = "FormViewAll";
            this.Load += new System.EventHandler(this.FormViewAll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ComboBox comboBoxFilterGroup;
        private CheckBox checkBoxFilterGroup;
        private ListBox listBox3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}