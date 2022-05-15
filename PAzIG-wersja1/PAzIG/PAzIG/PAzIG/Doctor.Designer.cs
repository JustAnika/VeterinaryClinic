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
            this.ownerBt = new System.Windows.Forms.Button();
            this.orderBt = new System.Windows.Forms.Button();
            this.logOutBt = new System.Windows.Forms.Button();
            this.petBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patientLst
            // 
            this.patientLst.HideSelection = false;
            this.patientLst.Location = new System.Drawing.Point(46, 109);
            this.patientLst.Name = "patientLst";
            this.patientLst.Size = new System.Drawing.Size(699, 260);
            this.patientLst.TabIndex = 4;
            this.patientLst.UseCompatibleStateImageBehavior = false;
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(473, 45);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(126, 37);
            this.addBt.TabIndex = 7;
            this.addBt.Text = "Add Visit";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // editBt
            // 
            this.editBt.Location = new System.Drawing.Point(329, 45);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(126, 37);
            this.editBt.TabIndex = 6;
            this.editBt.Text = "Edition";
            this.editBt.UseVisualStyleBackColor = true;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            // 
            // ownerBt
            // 
            this.ownerBt.Location = new System.Drawing.Point(46, 45);
            this.ownerBt.Name = "ownerBt";
            this.ownerBt.Size = new System.Drawing.Size(126, 37);
            this.ownerBt.TabIndex = 5;
            this.ownerBt.Text = "Add Owner";
            this.ownerBt.UseVisualStyleBackColor = true;
            this.ownerBt.Click += new System.EventHandler(this.registrationBt_Click);
            // 
            // orderBt
            // 
            this.orderBt.Location = new System.Drawing.Point(619, 45);
            this.orderBt.Name = "orderBt";
            this.orderBt.Size = new System.Drawing.Size(126, 37);
            this.orderBt.TabIndex = 8;
            this.orderBt.Text = "Order A Test";
            this.orderBt.UseVisualStyleBackColor = true;
            this.orderBt.Click += new System.EventHandler(this.orderBt_Click);
            // 
            // logOutBt
            // 
            this.logOutBt.Location = new System.Drawing.Point(329, 406);
            this.logOutBt.Name = "logOutBt";
            this.logOutBt.Size = new System.Drawing.Size(126, 37);
            this.logOutBt.TabIndex = 9;
            this.logOutBt.Text = "Log Out";
            this.logOutBt.UseVisualStyleBackColor = true;
            this.logOutBt.Click += new System.EventHandler(this.logOutBt_Click);
            // 
            // petBT
            // 
            this.petBT.Location = new System.Drawing.Point(187, 45);
            this.petBT.Name = "petBT";
            this.petBT.Size = new System.Drawing.Size(126, 37);
            this.petBT.TabIndex = 10;
            this.petBT.Text = "Add Pet";
            this.petBT.UseVisualStyleBackColor = true;
            this.petBT.Click += new System.EventHandler(this.petBT_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 484);
            this.Controls.Add(this.petBT);
            this.Controls.Add(this.logOutBt);
            this.Controls.Add(this.orderBt);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.editBt);
            this.Controls.Add(this.ownerBt);
            this.Controls.Add(this.patientLst);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView patientLst;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Button editBt;
        private System.Windows.Forms.Button ownerBt;
        private System.Windows.Forms.Button orderBt;
        private System.Windows.Forms.Button logOutBt;
        private System.Windows.Forms.Button petBT;
    }
}