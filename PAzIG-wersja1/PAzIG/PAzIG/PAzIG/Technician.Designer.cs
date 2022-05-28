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
            this.testsLst.Location = new System.Drawing.Point(67, 54);
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
            this.loginLb.Size = new System.Drawing.Size(45, 20);
            this.loginLb.TabIndex = 12;
            this.loginLb.Text = "login";
            this.loginLb.Visible = false;
            // 
            // Technician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 431);
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
    }
}