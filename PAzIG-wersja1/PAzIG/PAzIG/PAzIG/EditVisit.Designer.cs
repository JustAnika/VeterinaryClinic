namespace PAzIG
{
    partial class EditVisit
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
            this.addLb = new System.Windows.Forms.Label();
            this.infoLb = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.petLb = new System.Windows.Forms.Label();
            this.petTextBox = new System.Windows.Forms.TextBox();
            this.laboratoryLb = new System.Windows.Forms.Label();
            this.laboratoryTextBox = new System.Windows.Forms.TextBox();
            this.dateLb = new System.Windows.Forms.Label();
            this.doctoLb = new System.Windows.Forms.Label();
            this.doctorTextBox = new System.Windows.Forms.TextBox();
            this.medicineLb = new System.Windows.Forms.Label();
            this.medicineTB = new System.Windows.Forms.TextBox();
            this.editBt = new System.Windows.Forms.Button();
            this.backBt = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.infoVisitLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addLb
            // 
            this.addLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addLb.AutoSize = true;
            this.addLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addLb.Location = new System.Drawing.Point(201, 40);
            this.addLb.Name = "addLb";
            this.addLb.Size = new System.Drawing.Size(91, 24);
            this.addLb.TabIndex = 2;
            this.addLb.Text = "Edit Visit";
            // 
            // infoLb
            // 
            this.infoLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLb.AutoSize = true;
            this.infoLb.Location = new System.Drawing.Point(300, 276);
            this.infoLb.Name = "infoLb";
            this.infoLb.Size = new System.Drawing.Size(111, 13);
            this.infoLb.TabIndex = 39;
            this.infoLb.Text = "Additional Information:";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.infoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.infoTextBox.Location = new System.Drawing.Point(303, 308);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(163, 20);
            this.infoTextBox.TabIndex = 38;
            // 
            // petLb
            // 
            this.petLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.petLb.AutoSize = true;
            this.petLb.Location = new System.Drawing.Point(42, 186);
            this.petLb.Name = "petLb";
            this.petLb.Size = new System.Drawing.Size(42, 13);
            this.petLb.TabIndex = 37;
            this.petLb.Text = "Pet Id*:";
            // 
            // petTextBox
            // 
            this.petTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.petTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.petTextBox.Location = new System.Drawing.Point(45, 218);
            this.petTextBox.Name = "petTextBox";
            this.petTextBox.ReadOnly = true;
            this.petTextBox.Size = new System.Drawing.Size(163, 20);
            this.petTextBox.TabIndex = 36;
            // 
            // laboratoryLb
            // 
            this.laboratoryLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laboratoryLb.AutoSize = true;
            this.laboratoryLb.Location = new System.Drawing.Point(300, 100);
            this.laboratoryLb.Name = "laboratoryLb";
            this.laboratoryLb.Size = new System.Drawing.Size(60, 13);
            this.laboratoryLb.TabIndex = 35;
            this.laboratoryLb.Text = "Laboratory:";
            // 
            // laboratoryTextBox
            // 
            this.laboratoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laboratoryTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.laboratoryTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.laboratoryTextBox.Location = new System.Drawing.Point(303, 132);
            this.laboratoryTextBox.Name = "laboratoryTextBox";
            this.laboratoryTextBox.Size = new System.Drawing.Size(163, 20);
            this.laboratoryTextBox.TabIndex = 34;
            // 
            // dateLb
            // 
            this.dateLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateLb.AutoSize = true;
            this.dateLb.Location = new System.Drawing.Point(42, 276);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(82, 13);
            this.dateLb.TabIndex = 33;
            this.dateLb.Text = "Date and hour*:";
            // 
            // doctoLb
            // 
            this.doctoLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.doctoLb.AutoSize = true;
            this.doctoLb.Location = new System.Drawing.Point(42, 100);
            this.doctoLb.Name = "doctoLb";
            this.doctoLb.Size = new System.Drawing.Size(58, 13);
            this.doctoLb.TabIndex = 31;
            this.doctoLb.Text = "Doctor Id*:";
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doctorTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.doctorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.doctorTextBox.Location = new System.Drawing.Point(45, 132);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.ReadOnly = true;
            this.doctorTextBox.Size = new System.Drawing.Size(163, 20);
            this.doctorTextBox.TabIndex = 30;
            // 
            // medicineLb
            // 
            this.medicineLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medicineLb.AutoSize = true;
            this.medicineLb.Location = new System.Drawing.Point(300, 186);
            this.medicineLb.Name = "medicineLb";
            this.medicineLb.Size = new System.Drawing.Size(53, 13);
            this.medicineLb.TabIndex = 41;
            this.medicineLb.Text = "Medicine:";
            // 
            // medicineTB
            // 
            this.medicineTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.medicineTB.BackColor = System.Drawing.SystemColors.Info;
            this.medicineTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.medicineTB.Location = new System.Drawing.Point(303, 218);
            this.medicineTB.Name = "medicineTB";
            this.medicineTB.Size = new System.Drawing.Size(163, 20);
            this.medicineTB.TabIndex = 40;
            // 
            // editBt
            // 
            this.editBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.editBt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.editBt.FlatAppearance.BorderSize = 0;
            this.editBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.editBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.editBt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.editBt.Location = new System.Drawing.Point(317, 366);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(129, 44);
            this.editBt.TabIndex = 42;
            this.editBt.Text = "Edit";
            this.editBt.UseVisualStyleBackColor = false;
            this.editBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // backBt
            // 
            this.backBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backBt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backBt.FlatAppearance.BorderSize = 0;
            this.backBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backBt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.backBt.Location = new System.Drawing.Point(60, 366);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(129, 44);
            this.backBt.TabIndex = 60;
            this.backBt.Text = "Go Back";
            this.backBt.UseVisualStyleBackColor = false;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(45, 308);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker1.TabIndex = 61;
            // 
            // infoVisitLb
            // 
            this.infoVisitLb.AutoSize = true;
            this.infoVisitLb.Location = new System.Drawing.Point(359, 39);
            this.infoVisitLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoVisitLb.Name = "infoVisitLb";
            this.infoVisitLb.Size = new System.Drawing.Size(35, 13);
            this.infoVisitLb.TabIndex = 62;
            this.infoVisitLb.Text = "label1";
            this.infoVisitLb.Visible = false;
            // 
            // EditVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(521, 441);
            this.Controls.Add(this.infoVisitLb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.editBt);
            this.Controls.Add(this.medicineLb);
            this.Controls.Add(this.medicineTB);
            this.Controls.Add(this.infoLb);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.petLb);
            this.Controls.Add(this.petTextBox);
            this.Controls.Add(this.laboratoryLb);
            this.Controls.Add(this.laboratoryTextBox);
            this.Controls.Add(this.dateLb);
            this.Controls.Add(this.doctoLb);
            this.Controls.Add(this.doctorTextBox);
            this.Controls.Add(this.addLb);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Name = "EditVisit";
            this.Text = "AddVisit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label addLb;
        private System.Windows.Forms.Label infoLb;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Label petLb;
        private System.Windows.Forms.Label laboratoryLb;
        private System.Windows.Forms.TextBox laboratoryTextBox;
        private System.Windows.Forms.Label dateLb;
        private System.Windows.Forms.Label doctoLb;
        private System.Windows.Forms.Label medicineLb;
        private System.Windows.Forms.TextBox medicineTB;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.Button backBt;
        internal System.Windows.Forms.TextBox petTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.TextBox doctorTextBox;
        internal System.Windows.Forms.Label infoVisitLb;
    }
}