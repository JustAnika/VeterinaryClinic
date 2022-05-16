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
            this.addBt = new System.Windows.Forms.Button();
            this.backBt = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // addLb
            // 
            this.addLb.AutoSize = true;
            this.addLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addLb.Location = new System.Drawing.Point(268, 49);
            this.addLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addLb.Name = "addLb";
            this.addLb.Size = new System.Drawing.Size(116, 29);
            this.addLb.TabIndex = 2;
            this.addLb.Text = "Edit Visit";
            // 
            // infoLb
            // 
            this.infoLb.AutoSize = true;
            this.infoLb.Location = new System.Drawing.Point(400, 340);
            this.infoLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLb.Name = "infoLb";
            this.infoLb.Size = new System.Drawing.Size(138, 16);
            this.infoLb.TabIndex = 39;
            this.infoLb.Text = "Additional Information:";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(404, 379);
            this.infoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(216, 22);
            this.infoTextBox.TabIndex = 38;
            // 
            // petLb
            // 
            this.petLb.AutoSize = true;
            this.petLb.Location = new System.Drawing.Point(56, 229);
            this.petLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.petLb.Name = "petLb";
            this.petLb.Size = new System.Drawing.Size(49, 16);
            this.petLb.TabIndex = 37;
            this.petLb.Text = "Pet Id*:";
            // 
            // petTextBox
            // 
            this.petTextBox.Location = new System.Drawing.Point(60, 268);
            this.petTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.petTextBox.Name = "petTextBox";
            this.petTextBox.ReadOnly = true;
            this.petTextBox.Size = new System.Drawing.Size(216, 22);
            this.petTextBox.TabIndex = 36;
            // 
            // laboratoryLb
            // 
            this.laboratoryLb.AutoSize = true;
            this.laboratoryLb.Location = new System.Drawing.Point(400, 123);
            this.laboratoryLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laboratoryLb.Name = "laboratoryLb";
            this.laboratoryLb.Size = new System.Drawing.Size(75, 16);
            this.laboratoryLb.TabIndex = 35;
            this.laboratoryLb.Text = "Laboratory:";
            // 
            // laboratoryTextBox
            // 
            this.laboratoryTextBox.Location = new System.Drawing.Point(404, 162);
            this.laboratoryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.laboratoryTextBox.Name = "laboratoryTextBox";
            this.laboratoryTextBox.Size = new System.Drawing.Size(216, 22);
            this.laboratoryTextBox.TabIndex = 34;
            // 
            // dateLb
            // 
            this.dateLb.AutoSize = true;
            this.dateLb.Location = new System.Drawing.Point(56, 340);
            this.dateLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(114, 20);
            this.dateLb.TabIndex = 33;
            this.dateLb.Text = "Date an hour*:";
            // 
            // doctoLb
            // 
            this.doctoLb.AutoSize = true;
            this.doctoLb.Location = new System.Drawing.Point(56, 123);
            this.doctoLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doctoLb.Name = "doctoLb";
            this.doctoLb.Size = new System.Drawing.Size(69, 16);
            this.doctoLb.TabIndex = 31;
            this.doctoLb.Text = "Doctor Id*:";
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.Location = new System.Drawing.Point(60, 162);
            this.doctorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.Size = new System.Drawing.Size(216, 22);
            this.doctorTextBox.TabIndex = 30;
            // 
            // medicineLb
            // 
            this.medicineLb.AutoSize = true;
            this.medicineLb.Location = new System.Drawing.Point(400, 229);
            this.medicineLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medicineLb.Name = "medicineLb";
            this.medicineLb.Size = new System.Drawing.Size(65, 16);
            this.medicineLb.TabIndex = 41;
            this.medicineLb.Text = "Medicine:";
            // 
            // medicineTB
            // 
            this.medicineTB.Location = new System.Drawing.Point(404, 268);
            this.medicineTB.Margin = new System.Windows.Forms.Padding(4);
            this.medicineTB.Name = "medicineTB";
            this.medicineTB.Size = new System.Drawing.Size(216, 22);
            this.medicineTB.TabIndex = 40;
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(423, 450);
            this.addBt.Margin = new System.Windows.Forms.Padding(4);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(172, 54);
            this.addBt.TabIndex = 42;
            this.addBt.Text = "Add";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(80, 450);
            this.backBt.Margin = new System.Windows.Forms.Padding(4);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(172, 54);
            this.backBt.TabIndex = 60;
            this.backBt.Text = "Go Back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 379);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 22);
            this.dateTimePicker1.TabIndex = 61;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // EditVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 543);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.addBt);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox doctorTextBox;
        private System.Windows.Forms.Label medicineLb;
        private System.Windows.Forms.TextBox medicineTB;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Button backBt;
        internal System.Windows.Forms.TextBox petTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}