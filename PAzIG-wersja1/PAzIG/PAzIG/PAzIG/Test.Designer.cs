namespace PAzIG
{
    partial class Test
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
            this.petLb = new System.Windows.Forms.Label();
            this.petTextBox = new System.Windows.Forms.TextBox();
            this.techLb = new System.Windows.Forms.Label();
            this.createLb = new System.Windows.Forms.Label();
            this.dateLb = new System.Windows.Forms.Label();
            this.orderBt = new System.Windows.Forms.Button();
            this.backBt = new System.Windows.Forms.Button();
            this.fromLB = new System.Windows.Forms.Label();
            this.OpisLb = new System.Windows.Forms.Label();
            this.requiredLB = new System.Windows.Forms.Label();
            this.OpisTb = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.testListLV = new System.Windows.Forms.ListView();
            this.listLB = new System.Windows.Forms.Label();
            this.TechComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // petLb
            // 
            this.petLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petLb.AutoSize = true;
            this.petLb.Location = new System.Drawing.Point(287, 94);
            this.petLb.Name = "petLb";
            this.petLb.Size = new System.Drawing.Size(42, 13);
            this.petLb.TabIndex = 52;
            this.petLb.Text = "Pet Id*:";
            // 
            // petTextBox
            // 
            this.petTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.petTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.petTextBox.Location = new System.Drawing.Point(290, 126);
            this.petTextBox.Name = "petTextBox";
            this.petTextBox.ReadOnly = true;
            this.petTextBox.Size = new System.Drawing.Size(163, 20);
            this.petTextBox.TabIndex = 51;
            // 
            // techLb
            // 
            this.techLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.techLb.AutoSize = true;
            this.techLb.Location = new System.Drawing.Point(62, 94);
            this.techLb.Name = "techLb";
            this.techLb.Size = new System.Drawing.Size(92, 13);
            this.techLb.TabIndex = 54;
            this.techLb.Text = "Technician login*:";
            // 
            // createLb
            // 
            this.createLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.createLb.AutoSize = true;
            this.createLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createLb.Location = new System.Drawing.Point(185, 42);
            this.createLb.Name = "createLb";
            this.createLb.Size = new System.Drawing.Size(130, 24);
            this.createLb.TabIndex = 55;
            this.createLb.Text = "Order A Test";
            // 
            // dateLb
            // 
            this.dateLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateLb.AutoSize = true;
            this.dateLb.Location = new System.Drawing.Point(62, 166);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(37, 13);
            this.dateLb.TabIndex = 57;
            this.dateLb.Text = "Date*:";
            // 
            // orderBt
            // 
            this.orderBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.orderBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.orderBt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.orderBt.Location = new System.Drawing.Point(290, 437);
            this.orderBt.Name = "orderBt";
            this.orderBt.Size = new System.Drawing.Size(163, 51);
            this.orderBt.TabIndex = 58;
            this.orderBt.Text = "Order";
            this.orderBt.UseVisualStyleBackColor = false;
            this.orderBt.Click += new System.EventHandler(this.orderBt_Click);
            // 
            // backBt
            // 
            this.backBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backBt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.backBt.Location = new System.Drawing.Point(64, 437);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(163, 51);
            this.backBt.TabIndex = 59;
            this.backBt.Text = "Go Back";
            this.backBt.UseVisualStyleBackColor = false;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // fromLB
            // 
            this.fromLB.AutoSize = true;
            this.fromLB.Location = new System.Drawing.Point(371, 50);
            this.fromLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fromLB.Name = "fromLB";
            this.fromLB.Size = new System.Drawing.Size(35, 13);
            this.fromLB.TabIndex = 60;
            this.fromLB.Text = "label1";
            this.fromLB.Visible = false;
            // 
            // OpisLb
            // 
            this.OpisLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpisLb.AutoSize = true;
            this.OpisLb.Location = new System.Drawing.Point(287, 166);
            this.OpisLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OpisLb.Name = "OpisLb";
            this.OpisLb.Size = new System.Drawing.Size(66, 13);
            this.OpisLb.TabIndex = 61;
            this.OpisLb.Text = "Type of test:";
            // 
            // requiredLB
            // 
            this.requiredLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requiredLB.AutoSize = true;
            this.requiredLB.Location = new System.Drawing.Point(210, 412);
            this.requiredLB.Name = "requiredLB";
            this.requiredLB.Size = new System.Drawing.Size(103, 13);
            this.requiredLB.TabIndex = 85;
            this.requiredLB.Text = "*required information";
            // 
            // OpisTb
            // 
            this.OpisTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpisTb.BackColor = System.Drawing.SystemColors.Info;
            this.OpisTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.OpisTb.Location = new System.Drawing.Point(290, 195);
            this.OpisTb.Margin = new System.Windows.Forms.Padding(2);
            this.OpisTb.Name = "OpisTb";
            this.OpisTb.Size = new System.Drawing.Size(164, 20);
            this.OpisTb.TabIndex = 86;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 195);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker1.TabIndex = 87;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // testListLV
            // 
            this.testListLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testListLV.BackColor = System.Drawing.SystemColors.Info;
            this.testListLV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.testListLV.HideSelection = false;
            this.testListLV.Location = new System.Drawing.Point(65, 268);
            this.testListLV.Margin = new System.Windows.Forms.Padding(2);
            this.testListLV.Name = "testListLV";
            this.testListLV.Size = new System.Drawing.Size(388, 128);
            this.testListLV.TabIndex = 88;
            this.testListLV.UseCompatibleStateImageBehavior = false;
            this.testListLV.View = System.Windows.Forms.View.List;
            // 
            // listLB
            // 
            this.listLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listLB.AutoSize = true;
            this.listLB.Location = new System.Drawing.Point(63, 244);
            this.listLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.listLB.Name = "listLB";
            this.listLB.Size = new System.Drawing.Size(212, 13);
            this.listLB.TabIndex = 89;
            this.listLB.Text = "List of tests for the technician for given day:";
            // 
            // TechComboBox
            // 
            this.TechComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TechComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.TechComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TechComboBox.FormattingEnabled = true;
            this.TechComboBox.Location = new System.Drawing.Point(65, 126);
            this.TechComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.TechComboBox.Name = "TechComboBox";
            this.TechComboBox.Size = new System.Drawing.Size(163, 21);
            this.TechComboBox.TabIndex = 90;
            this.TechComboBox.SelectedValueChanged += new System.EventHandler(this.TechComboBox_SelectedValueChanged);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(514, 525);
            this.Controls.Add(this.TechComboBox);
            this.Controls.Add(this.listLB);
            this.Controls.Add(this.testListLV);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.OpisTb);
            this.Controls.Add(this.requiredLB);
            this.Controls.Add(this.OpisLb);
            this.Controls.Add(this.fromLB);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.orderBt);
            this.Controls.Add(this.dateLb);
            this.Controls.Add(this.createLb);
            this.Controls.Add(this.techLb);
            this.Controls.Add(this.petLb);
            this.Controls.Add(this.petTextBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label petLb;
        private System.Windows.Forms.Label techLb;
        private System.Windows.Forms.Label createLb;
        private System.Windows.Forms.Label dateLb;
        private System.Windows.Forms.Button orderBt;
        private System.Windows.Forms.Button backBt;
        internal System.Windows.Forms.Label fromLB;
        private System.Windows.Forms.Label OpisLb;
        private System.Windows.Forms.Label requiredLB;
        private System.Windows.Forms.TextBox OpisTb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.TextBox petTextBox;
        private System.Windows.Forms.ListView testListLV;
        private System.Windows.Forms.Label listLB;
        private System.Windows.Forms.ComboBox TechComboBox;
    }
}