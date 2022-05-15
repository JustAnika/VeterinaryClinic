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
            this.dateLb = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.doctoLb = new System.Windows.Forms.Label();
            this.doctorTextBox = new System.Windows.Forms.TextBox();
            this.createLb = new System.Windows.Forms.Label();
            this.createBt = new System.Windows.Forms.Button();
            this.backBt = new System.Windows.Forms.Button();
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
            this.petTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.petTextBox.Name = "petTextBox";
            this.petTextBox.Size = new System.Drawing.Size(216, 22);
            this.petTextBox.TabIndex = 49;
            // 
            // dateLb
            // 
            this.dateLb.AutoSize = true;
            this.dateLb.Location = new System.Drawing.Point(212, 223);
            this.dateLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(39, 16);
            this.dateLb.TabIndex = 46;
            this.dateLb.Text = "Date:";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(216, 262);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(216, 22);
            this.dateTextBox.TabIndex = 45;
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
            this.doctorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctorTextBox.Name = "doctorTextBox";
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
            this.createBt.Location = new System.Drawing.Point(361, 336);
            this.createBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createBt.Name = "createBt";
            this.createBt.Size = new System.Drawing.Size(217, 63);
            this.createBt.TabIndex = 51;
            this.createBt.Text = "Create";
            this.createBt.UseVisualStyleBackColor = true;
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(64, 336);
            this.backBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(217, 63);
            this.backBt.TabIndex = 60;
            this.backBt.Text = "Go Back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // Apointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 454);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.createBt);
            this.Controls.Add(this.petLb);
            this.Controls.Add(this.petTextBox);
            this.Controls.Add(this.dateLb);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.doctoLb);
            this.Controls.Add(this.doctorTextBox);
            this.Controls.Add(this.createLb);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Apointment";
            this.Text = "Apointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label petLb;
        private System.Windows.Forms.Label dateLb;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label doctoLb;
        private System.Windows.Forms.TextBox doctorTextBox;
        private System.Windows.Forms.Label createLb;
        private System.Windows.Forms.Button createBt;
        private System.Windows.Forms.Button backBt;
        internal System.Windows.Forms.TextBox petTextBox;
    }
}