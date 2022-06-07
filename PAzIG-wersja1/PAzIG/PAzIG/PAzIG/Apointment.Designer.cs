namespace PAzIG
{
    partial class Apointment
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
            this.dateHourLb = new System.Windows.Forms.Label();
            this.doctoLb = new System.Windows.Forms.Label();
            this.doctorTextBox = new System.Windows.Forms.TextBox();
            this.createLb = new System.Windows.Forms.Label();
            this.createBt = new System.Windows.Forms.Button();
            this.backBt = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.VisitListLv = new System.Windows.Forms.ListView();
            this.VisitLb = new System.Windows.Forms.Label();
            this.requiredLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // petLb
            // 
            this.petLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petLb.AutoSize = true;
            this.petLb.Location = new System.Drawing.Point(268, 93);
            this.petLb.Name = "petLb";
            this.petLb.Size = new System.Drawing.Size(38, 13);
            this.petLb.TabIndex = 50;
            this.petLb.Text = "Pet Id:";
            // 
            // petTextBox
            // 
            this.petTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.petTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.petTextBox.Location = new System.Drawing.Point(271, 125);
            this.petTextBox.Name = "petTextBox";
            this.petTextBox.ReadOnly = true;
            this.petTextBox.Size = new System.Drawing.Size(163, 20);
            this.petTextBox.TabIndex = 49;
            // 
            // dateHourLb
            // 
            this.dateHourLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateHourLb.AutoSize = true;
            this.dateHourLb.Location = new System.Drawing.Point(46, 172);
            this.dateHourLb.Name = "dateHourLb";
            this.dateHourLb.Size = new System.Drawing.Size(82, 13);
            this.dateHourLb.TabIndex = 46;
            this.dateHourLb.Text = "Date and hour*:";
            // 
            // doctoLb
            // 
            this.doctoLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.doctoLb.AutoSize = true;
            this.doctoLb.Location = new System.Drawing.Point(45, 93);
            this.doctoLb.Name = "doctoLb";
            this.doctoLb.Size = new System.Drawing.Size(54, 13);
            this.doctoLb.TabIndex = 44;
            this.doctoLb.Text = "Doctor Id:";
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doctorTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.doctorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.doctorTextBox.Location = new System.Drawing.Point(48, 125);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.ReadOnly = true;
            this.doctorTextBox.Size = new System.Drawing.Size(163, 20);
            this.doctorTextBox.TabIndex = 43;
            // 
            // createLb
            // 
            this.createLb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.createLb.AutoSize = true;
            this.createLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createLb.Location = new System.Drawing.Point(120, 34);
            this.createLb.Name = "createLb";
            this.createLb.Size = new System.Drawing.Size(227, 24);
            this.createLb.TabIndex = 42;
            this.createLb.Text = "Create An Appointment";
            // 
            // createBt
            // 
            this.createBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createBt.BackColor = System.Drawing.Color.Red;
            this.createBt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.createBt.Location = new System.Drawing.Point(269, 414);
            this.createBt.Name = "createBt";
            this.createBt.Size = new System.Drawing.Size(163, 51);
            this.createBt.TabIndex = 51;
            this.createBt.Text = "Create";
            this.createBt.UseVisualStyleBackColor = false;
            this.createBt.Click += new System.EventHandler(this.createBt_Click);
            // 
            // backBt
            // 
            this.backBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBt.BackColor = System.Drawing.Color.Red;
            this.backBt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.backBt.Location = new System.Drawing.Point(47, 414);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(163, 51);
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
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 211);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker1.TabIndex = 63;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // VisitListLv
            // 
            this.VisitListLv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VisitListLv.BackColor = System.Drawing.SystemColors.Info;
            this.VisitListLv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.VisitListLv.HideSelection = false;
            this.VisitListLv.Location = new System.Drawing.Point(224, 211);
            this.VisitListLv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VisitListLv.Name = "VisitListLv";
            this.VisitListLv.Size = new System.Drawing.Size(206, 175);
            this.VisitListLv.TabIndex = 64;
            this.VisitListLv.UseCompatibleStateImageBehavior = false;
            this.VisitListLv.View = System.Windows.Forms.View.List;
            // 
            // VisitLb
            // 
            this.VisitLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VisitLb.AutoSize = true;
            this.VisitLb.Location = new System.Drawing.Point(227, 172);
            this.VisitLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VisitLb.Name = "VisitLb";
            this.VisitLb.Size = new System.Drawing.Size(90, 13);
            this.VisitLb.TabIndex = 65;
            this.VisitLb.Text = "Visits for that day:";
            // 
            // requiredLB
            // 
            this.requiredLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requiredLB.AutoSize = true;
            this.requiredLB.Location = new System.Drawing.Point(53, 373);
            this.requiredLB.Name = "requiredLB";
            this.requiredLB.Size = new System.Drawing.Size(103, 13);
            this.requiredLB.TabIndex = 85;
            this.requiredLB.Text = "*required information";
            // 
            // Apointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(481, 511);
            this.Controls.Add(this.requiredLB);
            this.Controls.Add(this.VisitLb);
            this.Controls.Add(this.VisitListLv);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.createBt);
            this.Controls.Add(this.petLb);
            this.Controls.Add(this.petTextBox);
            this.Controls.Add(this.dateHourLb);
            this.Controls.Add(this.doctoLb);
            this.Controls.Add(this.doctorTextBox);
            this.Controls.Add(this.createLb);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Apointment";
            this.Text = "Apointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label petLb;
        private System.Windows.Forms.Label dateHourLb;
        private System.Windows.Forms.Label doctoLb;
        private System.Windows.Forms.Label createLb;
        private System.Windows.Forms.Button createBt;
        private System.Windows.Forms.Button backBt;
        internal System.Windows.Forms.TextBox petTextBox;
        internal System.Windows.Forms.TextBox doctorTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView VisitListLv;
        private System.Windows.Forms.Label VisitLb;
        private System.Windows.Forms.Label requiredLB;
    }
}