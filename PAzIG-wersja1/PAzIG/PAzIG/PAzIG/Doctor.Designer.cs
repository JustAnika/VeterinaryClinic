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
            this.editVisitBt = new System.Windows.Forms.Button();
            this.editBt = new System.Windows.Forms.Button();
            this.orderBt = new System.Windows.Forms.Button();
            this.logOutBt = new System.Windows.Forms.Button();
            this.petBT = new System.Windows.Forms.Button();
            this.visitLst = new System.Windows.Forms.ListView();
            this.loginInfoLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patientLst
            // 
            this.patientLst.HideSelection = false;
            this.patientLst.Location = new System.Drawing.Point(61, 134);
            this.patientLst.Margin = new System.Windows.Forms.Padding(4);
            this.patientLst.Name = "patientLst";
            this.patientLst.Size = new System.Drawing.Size(457, 319);
            this.patientLst.TabIndex = 4;
            this.patientLst.UseCompatibleStateImageBehavior = false;
            this.patientLst.View = System.Windows.Forms.View.List;
            // 
            // editVisitBt
            // 
            this.editVisitBt.Location = new System.Drawing.Point(579, 55);
            this.editVisitBt.Margin = new System.Windows.Forms.Padding(4);
            this.editVisitBt.Name = "editVisitBt";
            this.editVisitBt.Size = new System.Drawing.Size(168, 46);
            this.editVisitBt.TabIndex = 7;
            this.editVisitBt.Text = "Edit Visit";
            this.editVisitBt.UseVisualStyleBackColor = true;
            this.editVisitBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // editBt
            // 
            this.editBt.Location = new System.Drawing.Point(321, 55);
            this.editBt.Margin = new System.Windows.Forms.Padding(4);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(168, 46);
            this.editBt.TabIndex = 6;
            this.editBt.Text = "Edit Pet";
            this.editBt.UseVisualStyleBackColor = true;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            // 
            // orderBt
            // 
            this.orderBt.Location = new System.Drawing.Point(824, 55);
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
            this.logOutBt.Location = new System.Drawing.Point(439, 500);
            this.logOutBt.Margin = new System.Windows.Forms.Padding(4);
            this.logOutBt.Name = "logOutBt";
            this.logOutBt.Size = new System.Drawing.Size(168, 46);
            this.logOutBt.TabIndex = 9;
            this.logOutBt.Text = "Log Out";
            this.logOutBt.UseVisualStyleBackColor = true;
            this.logOutBt.Click += new System.EventHandler(this.logOutBt_Click);
            // 
            // petBT
            // 
            this.petBT.Location = new System.Drawing.Point(61, 55);
            this.petBT.Margin = new System.Windows.Forms.Padding(4);
            this.petBT.Name = "petBT";
            this.petBT.Size = new System.Drawing.Size(168, 46);
            this.petBT.TabIndex = 10;
            this.petBT.Text = "Add Pet";
            this.petBT.UseVisualStyleBackColor = true;
            this.petBT.Click += new System.EventHandler(this.petBT_Click);
            // 
            // visitLst
            // 
            this.visitLst.HideSelection = false;
            this.visitLst.Location = new System.Drawing.Point(552, 134);
            this.visitLst.Name = "visitLst";
            this.visitLst.Size = new System.Drawing.Size(439, 318);
            this.visitLst.TabIndex = 11;
            this.visitLst.UseCompatibleStateImageBehavior = false;
            this.visitLst.View = System.Windows.Forms.View.List;
            // 
            // loginInfoLb
            // 
            this.loginInfoLb.AutoSize = true;
            this.loginInfoLb.Location = new System.Drawing.Point(903, 524);
            this.loginInfoLb.Name = "loginInfoLb";
            this.loginInfoLb.Size = new System.Drawing.Size(36, 16);
            this.loginInfoLb.TabIndex = 12;
            this.loginInfoLb.Text = "login";
            this.loginInfoLb.Visible = false;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 596);
            this.Controls.Add(this.loginInfoLb);
            this.Controls.Add(this.visitLst);
            this.Controls.Add(this.petBT);
            this.Controls.Add(this.logOutBt);
            this.Controls.Add(this.orderBt);
            this.Controls.Add(this.editVisitBt);
            this.Controls.Add(this.editBt);
            this.Controls.Add(this.patientLst);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView patientLst;
        private System.Windows.Forms.Button editVisitBt;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.Button orderBt;
        private System.Windows.Forms.Button logOutBt;
        private System.Windows.Forms.Button petBT;
        private System.Windows.Forms.ListView visitLst;
        internal System.Windows.Forms.Label loginInfoLb;
    }
}