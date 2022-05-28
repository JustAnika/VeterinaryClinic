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
            this.petLb.AutoSize = true;
            this.petLb.Location = new System.Drawing.Point(357, 114);
            this.petLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.petLb.Name = "petLb";
            this.petLb.Size = new System.Drawing.Size(44, 16);
            this.petLb.TabIndex = 50;
            this.petLb.Text = "Pet Id:";
            // 
            // petTextBox
            // 
            this.petTextBox.Location = new System.Drawing.Point(361, 154);
            this.petTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.petTextBox.Name = "petTextBox";
            this.petTextBox.ReadOnly = true;
            this.petTextBox.Size = new System.Drawing.Size(216, 22);
            this.petTextBox.TabIndex = 49;
            // 
            // dateHourLb
            // 
            this.dateHourLb.AutoSize = true;
            this.dateHourLb.Location = new System.Drawing.Point(61, 212);
            this.dateHourLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateHourLb.Name = "dateHourLb";
            this.dateHourLb.Size = new System.Drawing.Size(99, 16);
            this.dateHourLb.TabIndex = 46;
            this.dateHourLb.Text = "Date and hour*:";
            // 
            // doctoLb
            // 
            this.doctoLb.AutoSize = true;
            this.doctoLb.Location = new System.Drawing.Point(60, 114);
            this.doctoLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doctoLb.Name = "doctoLb";
            this.doctoLb.Size = new System.Drawing.Size(64, 16);
            this.doctoLb.TabIndex = 44;
            this.doctoLb.Text = "Doctor Id:";
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.Location = new System.Drawing.Point(64, 154);
            this.doctorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.ReadOnly = true;
            this.doctorTextBox.Size = new System.Drawing.Size(216, 22);
            this.doctorTextBox.TabIndex = 43;
            // 
            // createLb
            // 
            this.createLb.AutoSize = true;
            this.createLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createLb.Location = new System.Drawing.Point(160, 42);
            this.createLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createLb.Name = "createLb";
            this.createLb.Size = new System.Drawing.Size(281, 29);
            this.createLb.TabIndex = 42;
            this.createLb.Text = "Create An Appointment";
            // 
            // createBt
            // 
            this.createBt.Location = new System.Drawing.Point(359, 510);
            this.createBt.Margin = new System.Windows.Forms.Padding(4);
            this.createBt.Name = "createBt";
            this.createBt.Size = new System.Drawing.Size(217, 63);
            this.createBt.TabIndex = 51;
            this.createBt.Text = "Create";
            this.createBt.UseVisualStyleBackColor = true;
            this.createBt.Click += new System.EventHandler(this.createBt_Click);
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(63, 510);
            this.backBt.Margin = new System.Windows.Forms.Padding(4);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(217, 63);
            this.backBt.TabIndex = 60;
            this.backBt.Text = "Go Back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 260);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 22);
            this.dateTimePicker1.TabIndex = 63;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // VisitListLv
            // 
            this.VisitListLv.HideSelection = false;
            this.VisitListLv.Location = new System.Drawing.Point(298, 260);
            this.VisitListLv.Name = "VisitListLv";
            this.VisitListLv.Size = new System.Drawing.Size(273, 215);
            this.VisitListLv.TabIndex = 64;
            this.VisitListLv.UseCompatibleStateImageBehavior = false;
            this.VisitListLv.View = System.Windows.Forms.View.List;
            // 
            // VisitLb
            // 
            this.VisitLb.AutoSize = true;
            this.VisitLb.Location = new System.Drawing.Point(303, 212);
            this.VisitLb.Name = "VisitLb";
            this.VisitLb.Size = new System.Drawing.Size(110, 16);
            this.VisitLb.TabIndex = 65;
            this.VisitLb.Text = "Visits for that day:";
            // 
            // requiredLB
            // 
            this.requiredLB.AutoSize = true;
            this.requiredLB.Location = new System.Drawing.Point(71, 459);
            this.requiredLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requiredLB.Name = "requiredLB";
            this.requiredLB.Size = new System.Drawing.Size(130, 16);
            this.requiredLB.TabIndex = 85;
            this.requiredLB.Text = "*required information";
            // 
            // Apointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 629);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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