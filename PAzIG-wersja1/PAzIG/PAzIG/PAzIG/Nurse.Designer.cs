namespace PAzIG
{
    partial class Nurse
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
            this.registrationBt = new System.Windows.Forms.Button();
            this.editBt = new System.Windows.Forms.Button();
            this.createBt = new System.Windows.Forms.Button();
            this.patientLst = new System.Windows.Forms.ListView();
            this.doctorLst = new System.Windows.Forms.ListView();
            this.logOutBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrationBt
            // 
            this.registrationBt.Location = new System.Drawing.Point(55, 32);
            this.registrationBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registrationBt.Name = "registrationBt";
            this.registrationBt.Size = new System.Drawing.Size(380, 46);
            this.registrationBt.TabIndex = 0;
            this.registrationBt.Text = "Registration";
            this.registrationBt.UseVisualStyleBackColor = true;
            this.registrationBt.Click += new System.EventHandler(this.registrationBt_Click);
            // 
            // editBt
            // 
            this.editBt.Location = new System.Drawing.Point(459, 32);
            this.editBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(380, 46);
            this.editBt.TabIndex = 1;
            this.editBt.Text = "Edition";
            this.editBt.UseVisualStyleBackColor = true;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            // 
            // createBt
            // 
            this.createBt.Location = new System.Drawing.Point(863, 32);
            this.createBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createBt.Name = "createBt";
            this.createBt.Size = new System.Drawing.Size(380, 46);
            this.createBt.TabIndex = 2;
            this.createBt.Text = "Create An Appointment";
            this.createBt.UseVisualStyleBackColor = true;
            this.createBt.Click += new System.EventHandler(this.createBt_Click);
            // 
            // patientLst
            // 
            this.patientLst.HideSelection = false;
            this.patientLst.Location = new System.Drawing.Point(55, 102);
            this.patientLst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.patientLst.Name = "patientLst";
            this.patientLst.Size = new System.Drawing.Size(571, 319);
            this.patientLst.TabIndex = 3;
            this.patientLst.UseCompatibleStateImageBehavior = false;
            // 
            // doctorLst
            // 
            this.doctorLst.HideSelection = false;
            this.doctorLst.Location = new System.Drawing.Point(671, 102);
            this.doctorLst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctorLst.Name = "doctorLst";
            this.doctorLst.Size = new System.Drawing.Size(571, 319);
            this.doctorLst.TabIndex = 4;
            this.doctorLst.UseCompatibleStateImageBehavior = false;
            // 
            // logOutBt
            // 
            this.logOutBt.Location = new System.Drawing.Point(557, 463);
            this.logOutBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOutBt.Name = "logOutBt";
            this.logOutBt.Size = new System.Drawing.Size(168, 46);
            this.logOutBt.TabIndex = 10;
            this.logOutBt.Text = "Log Out";
            this.logOutBt.UseVisualStyleBackColor = true;
            this.logOutBt.Click += new System.EventHandler(this.logOutBt_Click);
            // 
            // Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 565);
            this.Controls.Add(this.logOutBt);
            this.Controls.Add(this.doctorLst);
            this.Controls.Add(this.patientLst);
            this.Controls.Add(this.createBt);
            this.Controls.Add(this.editBt);
            this.Controls.Add(this.registrationBt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Nurse";
            this.Text = "Nurse";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registrationBt;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.Button createBt;
        private System.Windows.Forms.ListView patientLst;
        private System.Windows.Forms.ListView doctorLst;
        private System.Windows.Forms.Button logOutBt;
    }
}