namespace PAzIG
{
    partial class Owner
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
            this.petsLst = new System.Windows.Forms.ListView();
            this.logOutBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // petsLst
            // 
            this.petsLst.HideSelection = false;
            this.petsLst.Location = new System.Drawing.Point(48, 50);
            this.petsLst.Name = "petsLst";
            this.petsLst.Size = new System.Drawing.Size(470, 199);
            this.petsLst.TabIndex = 13;
            this.petsLst.UseCompatibleStateImageBehavior = false;
            // 
            // logOutBt
            // 
            this.logOutBt.Location = new System.Drawing.Point(224, 283);
            this.logOutBt.Name = "logOutBt";
            this.logOutBt.Size = new System.Drawing.Size(126, 37);
            this.logOutBt.TabIndex = 12;
            this.logOutBt.Text = "Log Out";
            this.logOutBt.UseVisualStyleBackColor = true;
            this.logOutBt.Click += new System.EventHandler(this.logOutBt_Click);
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 355);
            this.Controls.Add(this.petsLst);
            this.Controls.Add(this.logOutBt);
            this.Name = "Owner";
            this.Text = "Owner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView petsLst;
        private System.Windows.Forms.Button logOutBt;
    }
}