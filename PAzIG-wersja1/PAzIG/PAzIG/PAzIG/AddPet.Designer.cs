namespace PAzIG
{
    partial class AddPet
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
            this.ageLb = new System.Windows.Forms.Label();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.sexLb = new System.Windows.Forms.Label();
            this.sexTB = new System.Windows.Forms.TextBox();
            this.speciesLb = new System.Windows.Forms.Label();
            this.speciesTB = new System.Windows.Forms.TextBox();
            this.nameLb = new System.Windows.Forms.Label();
            this.petTB = new System.Windows.Forms.TextBox();
            this.registerLb = new System.Windows.Forms.Label();
            this.infoLb = new System.Windows.Forms.Label();
            this.infoTB = new System.Windows.Forms.TextBox();
            this.formLB = new System.Windows.Forms.Label();
            this.backBt = new System.Windows.Forms.Button();
            this.registerBt = new System.Windows.Forms.Button();
            this.ownerLST = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.petLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ageLb
            // 
            this.ageLb.AutoSize = true;
            this.ageLb.Location = new System.Drawing.Point(324, 298);
            this.ageLb.Name = "ageLb";
            this.ageLb.Size = new System.Drawing.Size(29, 13);
            this.ageLb.TabIndex = 26;
            this.ageLb.Text = "Age:";
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(327, 330);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(163, 20);
            this.ageTB.TabIndex = 25;
            // 
            // sexLb
            // 
            this.sexLb.AutoSize = true;
            this.sexLb.Location = new System.Drawing.Point(324, 216);
            this.sexLb.Name = "sexLb";
            this.sexLb.Size = new System.Drawing.Size(28, 13);
            this.sexLb.TabIndex = 24;
            this.sexLb.Text = "Sex:";
            // 
            // sexTB
            // 
            this.sexTB.Location = new System.Drawing.Point(327, 248);
            this.sexTB.Name = "sexTB";
            this.sexTB.Size = new System.Drawing.Size(163, 20);
            this.sexTB.TabIndex = 23;
            // 
            // speciesLb
            // 
            this.speciesLb.AutoSize = true;
            this.speciesLb.Location = new System.Drawing.Point(48, 302);
            this.speciesLb.Name = "speciesLb";
            this.speciesLb.Size = new System.Drawing.Size(48, 13);
            this.speciesLb.TabIndex = 22;
            this.speciesLb.Text = "Species:";
            // 
            // speciesTB
            // 
            this.speciesTB.Location = new System.Drawing.Point(51, 334);
            this.speciesTB.Name = "speciesTB";
            this.speciesTB.Size = new System.Drawing.Size(163, 20);
            this.speciesTB.TabIndex = 21;
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(48, 216);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(38, 13);
            this.nameLb.TabIndex = 20;
            this.nameLb.Text = "Name:";
            // 
            // petTB
            // 
            this.petTB.Location = new System.Drawing.Point(51, 248);
            this.petTB.Name = "petTB";
            this.petTB.Size = new System.Drawing.Size(163, 20);
            this.petTB.TabIndex = 19;
            // 
            // registerLb
            // 
            this.registerLb.AutoSize = true;
            this.registerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerLb.Location = new System.Drawing.Point(180, 34);
            this.registerLb.Name = "registerLb";
            this.registerLb.Size = new System.Drawing.Size(171, 24);
            this.registerLb.TabIndex = 27;
            this.registerLb.Text = "Register New Pet";
            // 
            // infoLb
            // 
            this.infoLb.AutoSize = true;
            this.infoLb.Location = new System.Drawing.Point(190, 394);
            this.infoLb.Name = "infoLb";
            this.infoLb.Size = new System.Drawing.Size(111, 13);
            this.infoLb.TabIndex = 29;
            this.infoLb.Text = "Additional Information:";
            // 
            // infoTB
            // 
            this.infoTB.Location = new System.Drawing.Point(193, 426);
            this.infoTB.Name = "infoTB";
            this.infoTB.Size = new System.Drawing.Size(163, 20);
            this.infoTB.TabIndex = 28;
            // 
            // formLB
            // 
            this.formLB.AutoSize = true;
            this.formLB.Location = new System.Drawing.Point(252, 461);
            this.formLB.Name = "formLB";
            this.formLB.Size = new System.Drawing.Size(0, 13);
            this.formLB.TabIndex = 69;
            this.formLB.Visible = false;
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(51, 496);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(163, 37);
            this.backBt.TabIndex = 68;
            this.backBt.Text = "Go Back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // registerBt
            // 
            this.registerBt.Location = new System.Drawing.Point(307, 496);
            this.registerBt.Name = "registerBt";
            this.registerBt.Size = new System.Drawing.Size(163, 37);
            this.registerBt.TabIndex = 67;
            this.registerBt.Text = "Register";
            this.registerBt.UseVisualStyleBackColor = true;
            this.registerBt.Click += new System.EventHandler(this.registerBt_Click);
            // 
            // ownerLST
            // 
            this.ownerLST.FormattingEnabled = true;
            this.ownerLST.Location = new System.Drawing.Point(76, 108);
            this.ownerLST.Name = "ownerLST";
            this.ownerLST.Size = new System.Drawing.Size(394, 30);
            this.ownerLST.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(213, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 71;
            this.label1.Text = "Select Owner";
            // 
            // petLB
            // 
            this.petLB.AutoSize = true;
            this.petLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.petLB.Location = new System.Drawing.Point(213, 177);
            this.petLB.Name = "petLB";
            this.petLB.Size = new System.Drawing.Size(110, 16);
            this.petLB.TabIndex = 72;
            this.petLB.Text = "Pet Information";
            // 
            // AddPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 567);
            this.Controls.Add(this.petLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ownerLST);
            this.Controls.Add(this.formLB);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.registerBt);
            this.Controls.Add(this.infoLb);
            this.Controls.Add(this.infoTB);
            this.Controls.Add(this.registerLb);
            this.Controls.Add(this.ageLb);
            this.Controls.Add(this.ageTB);
            this.Controls.Add(this.sexLb);
            this.Controls.Add(this.sexTB);
            this.Controls.Add(this.speciesLb);
            this.Controls.Add(this.speciesTB);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.petTB);
            this.Name = "AddPet";
            this.Text = "AddPet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ageLb;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.Label sexLb;
        private System.Windows.Forms.TextBox sexTB;
        private System.Windows.Forms.Label speciesLb;
        private System.Windows.Forms.TextBox speciesTB;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.TextBox petTB;
        private System.Windows.Forms.Label registerLb;
        private System.Windows.Forms.Label infoLb;
        private System.Windows.Forms.TextBox infoTB;
        internal System.Windows.Forms.Label formLB;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Button registerBt;
        private System.Windows.Forms.ListBox ownerLST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label petLB;
    }
}