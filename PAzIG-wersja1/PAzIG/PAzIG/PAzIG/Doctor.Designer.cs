namespace PAzIG
{
    partial class Doctor
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
            this.patientLst = new System.Windows.Forms.ListView();
            this.addBt = new System.Windows.Forms.Button();
            this.editBt = new System.Windows.Forms.Button();
            this.registrationBt = new System.Windows.Forms.Button();
            this.orderBt = new System.Windows.Forms.Button();
            this.logOutBt = new System.Windows.Forms.Button();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.SuspendLayout();
            // 
            // patientLst
            // 
            this.patientLst.HideSelection = false;
            this.patientLst.Location = new System.Drawing.Point(61, 134);
            this.patientLst.Margin = new System.Windows.Forms.Padding(4);
            this.patientLst.Name = "patientLst";
            this.patientLst.Size = new System.Drawing.Size(769, 319);
            this.patientLst.TabIndex = 4;
            this.patientLst.UseCompatibleStateImageBehavior = false;
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(465, 55);
            this.addBt.Margin = new System.Windows.Forms.Padding(4);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(168, 46);
            this.addBt.TabIndex = 7;
            this.addBt.Text = "Add Visit";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // editBt
            // 
            this.editBt.Location = new System.Drawing.Point(260, 55);
            this.editBt.Margin = new System.Windows.Forms.Padding(4);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(168, 46);
            this.editBt.TabIndex = 6;
            this.editBt.Text = "Edition";
            this.editBt.UseVisualStyleBackColor = true;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            // 
            // registrationBt
            // 
            this.registrationBt.Location = new System.Drawing.Point(61, 55);
            this.registrationBt.Margin = new System.Windows.Forms.Padding(4);
            this.registrationBt.Name = "registrationBt";
            this.registrationBt.Size = new System.Drawing.Size(168, 46);
            this.registrationBt.TabIndex = 5;
            this.registrationBt.Text = "Registration";
            this.registrationBt.UseVisualStyleBackColor = true;
            this.registrationBt.Click += new System.EventHandler(this.registrationBt_Click);
            // 
            // orderBt
            // 
            this.orderBt.Location = new System.Drawing.Point(664, 55);
            this.orderBt.Margin = new System.Windows.Forms.Padding(4);
            this.orderBt.Name = "orderBt";
            this.orderBt.Size = new System.Drawing.Size(168, 46);
            this.orderBt.TabIndex = 8;
            this.orderBt.Text = "Order A Test";
            this.orderBt.UseVisualStyleBackColor = true;
            this.orderBt.Click += new System.EventHandler(this.orderBt_Click);
            // 
            // logOutBt
            // 
            this.logOutBt.Location = new System.Drawing.Point(359, 498);
            this.logOutBt.Margin = new System.Windows.Forms.Padding(4);
            this.logOutBt.Name = "logOutBt";
            this.logOutBt.Size = new System.Drawing.Size(168, 46);
            this.logOutBt.TabIndex = 9;
            this.logOutBt.Text = "Log Out";
            this.logOutBt.UseVisualStyleBackColor = true;
            this.logOutBt.Click += new System.EventHandler(this.logOutBt_Click);
            // 
            // serviceController1
            // 
            this.serviceController1.MachineName = "LAPTOP-DD";
            this.serviceController1.ServiceName = "SQLAgent$SQLEXPRESS";
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 598);
            this.Controls.Add(this.logOutBt);
            this.Controls.Add(this.orderBt);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.editBt);
            this.Controls.Add(this.registrationBt);
            this.Controls.Add(this.patientLst);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Doctor_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView patientLst;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.Button registrationBt;
        private System.Windows.Forms.Button orderBt;
        private System.Windows.Forms.Button logOutBt;
        private System.ServiceProcess.ServiceController serviceController1;
    }
}