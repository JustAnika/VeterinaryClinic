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
            this.editBt = new System.Windows.Forms.Button();
            this.createBt = new System.Windows.Forms.Button();
            this.patientLst = new System.Windows.Forms.ListView();
            this.doctorLst = new System.Windows.Forms.ListView();
            this.logOutBt = new System.Windows.Forms.Button();
            this.addPetBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editBt
            // 
            this.editBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editBt.BackColor = System.Drawing.Color.Maroon;
            this.editBt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editBt.Location = new System.Drawing.Point(381, 26);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(207, 37);
            this.editBt.TabIndex = 1;
            this.editBt.Text = "Edition";
            this.editBt.UseVisualStyleBackColor = false;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            // 
            // createBt
            // 
            this.createBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createBt.BackColor = System.Drawing.Color.Maroon;
            this.createBt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.createBt.Location = new System.Drawing.Point(661, 26);
            this.createBt.Name = "createBt";
            this.createBt.Size = new System.Drawing.Size(207, 37);
            this.createBt.TabIndex = 2;
            this.createBt.Text = "Create An Appointment";
            this.createBt.UseVisualStyleBackColor = false;
            this.createBt.Click += new System.EventHandler(this.createBt_Click);
            // 
            // patientLst
            // 
            this.patientLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientLst.BackColor = System.Drawing.SystemColors.Info;
            this.patientLst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.patientLst.HideSelection = false;
            this.patientLst.Location = new System.Drawing.Point(41, 83);
            this.patientLst.Name = "patientLst";
            this.patientLst.Size = new System.Drawing.Size(429, 260);
            this.patientLst.TabIndex = 3;
            this.patientLst.UseCompatibleStateImageBehavior = false;
            this.patientLst.View = System.Windows.Forms.View.List;
            // 
            // doctorLst
            // 
            this.doctorLst.BackColor = System.Drawing.SystemColors.Info;
            this.doctorLst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.doctorLst.HideSelection = false;
            this.doctorLst.Location = new System.Drawing.Point(503, 83);
            this.doctorLst.Name = "doctorLst";
            this.doctorLst.Size = new System.Drawing.Size(429, 260);
            this.doctorLst.TabIndex = 4;
            this.doctorLst.UseCompatibleStateImageBehavior = false;
            this.doctorLst.View = System.Windows.Forms.View.List;
            // 
            // logOutBt
            // 
            this.logOutBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logOutBt.BackColor = System.Drawing.Color.Maroon;
            this.logOutBt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.logOutBt.Location = new System.Drawing.Point(418, 376);
            this.logOutBt.Name = "logOutBt";
            this.logOutBt.Size = new System.Drawing.Size(126, 37);
            this.logOutBt.TabIndex = 10;
            this.logOutBt.Text = "Log Out";
            this.logOutBt.UseVisualStyleBackColor = false;
            this.logOutBt.Click += new System.EventHandler(this.logOutBt_Click);
            // 
            // addPetBT
            // 
            this.addPetBT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPetBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addPetBT.BackColor = System.Drawing.Color.Maroon;
            this.addPetBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addPetBT.Location = new System.Drawing.Point(110, 26);
            this.addPetBT.Name = "addPetBT";
            this.addPetBT.Size = new System.Drawing.Size(204, 37);
            this.addPetBT.TabIndex = 11;
            this.addPetBT.Text = "Add Pet";
            this.addPetBT.UseVisualStyleBackColor = false;
            this.addPetBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(956, 459);
            this.Controls.Add(this.addPetBT);
            this.Controls.Add(this.logOutBt);
            this.Controls.Add(this.doctorLst);
            this.Controls.Add(this.patientLst);
            this.Controls.Add(this.createBt);
            this.Controls.Add(this.editBt);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Nurse";
            this.Text = "Nurse";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.Button createBt;
        private System.Windows.Forms.ListView patientLst;
        private System.Windows.Forms.ListView doctorLst;
        private System.Windows.Forms.Button logOutBt;
        private System.Windows.Forms.Button addPetBT;
    }
}