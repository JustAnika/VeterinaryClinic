namespace PAzIG
{
    partial class Technician
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
            this.logOutBt = new System.Windows.Forms.Button();
            this.testsLst = new System.Windows.Forms.ListView();
            this.loginLb = new System.Windows.Forms.Label();
            this.dateLB = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // logOutBt
            // 
            this.logOutBt.Location = new System.Drawing.Point(301, 341);
            this.logOutBt.Margin = new System.Windows.Forms.Padding(4);
            this.logOutBt.Name = "logOutBt";
            this.logOutBt.Size = new System.Drawing.Size(168, 46);
            this.logOutBt.TabIndex = 10;
            this.logOutBt.Text = "Log Out";
            this.logOutBt.UseVisualStyleBackColor = true;
            this.logOutBt.Click += new System.EventHandler(this.logOutBt_Click);
            // 
            // testsLst
            // 
            this.testsLst.HideSelection = false;
            this.testsLst.Location = new System.Drawing.Point(66, 89);
            this.testsLst.Margin = new System.Windows.Forms.Padding(4);
            this.testsLst.Name = "testsLst";
            this.testsLst.Size = new System.Drawing.Size(625, 244);
            this.testsLst.TabIndex = 11;
            this.testsLst.UseCompatibleStateImageBehavior = false;
            this.testsLst.View = System.Windows.Forms.View.List;
            // 
            // loginLb
            // 
            this.loginLb.AutoSize = true;
            this.loginLb.Location = new System.Drawing.Point(606, 377);
            this.loginLb.Name = "loginLb";
            this.loginLb.Size = new System.Drawing.Size(36, 16);
            this.loginLb.TabIndex = 12;
            this.loginLb.Text = "login";
            this.loginLb.Visible = false;
            // 
            // dateLB
            // 
            this.dateLB.AutoSize = true;
            this.dateLB.Location = new System.Drawing.Point(63, 44);
            this.dateLB.Name = "dateLB";
            this.dateLB.Size = new System.Drawing.Size(112, 16);
            this.dateLB.TabIndex = 13;
            this.dateLB.Text = "Tests for the day: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Technician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 431);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateLB);
            this.Controls.Add(this.loginLb);
            this.Controls.Add(this.testsLst);
            this.Controls.Add(this.logOutBt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Technician";
            this.Text = "Technician";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutBt;
        private System.Windows.Forms.ListView testsLst;
        internal System.Windows.Forms.Label loginLb;
        private System.Windows.Forms.Label dateLB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}