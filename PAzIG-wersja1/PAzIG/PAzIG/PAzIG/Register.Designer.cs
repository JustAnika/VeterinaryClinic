namespace PAzIG
{
    partial class Register
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
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.firstNameLb = new System.Windows.Forms.Label();
            this.lastNameLb = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.phoneLb = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.registerBt = new System.Windows.Forms.Button();
            this.registerLb = new System.Windows.Forms.Label();
            this.backBt = new System.Windows.Forms.Button();
            this.formLB = new System.Windows.Forms.Label();
            this.ownerLb = new System.Windows.Forms.Label();
            this.petLB = new System.Windows.Forms.Label();
            this.infoLb = new System.Windows.Forms.Label();
            this.infoTB = new System.Windows.Forms.TextBox();
            this.ageLb = new System.Windows.Forms.Label();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.sexLb = new System.Windows.Forms.Label();
            this.speciesLb = new System.Windows.Forms.Label();
            this.speciesTB = new System.Windows.Forms.TextBox();
            this.nameLb = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.requiredLB = new System.Windows.Forms.Label();
            this.sexLstBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(292, 177);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(163, 20);
            this.firstNameTB.TabIndex = 0;
            // 
            // firstNameLb
            // 
            this.firstNameLb.AutoSize = true;
            this.firstNameLb.Location = new System.Drawing.Point(289, 145);
            this.firstNameLb.Name = "firstNameLb";
            this.firstNameLb.Size = new System.Drawing.Size(64, 13);
            this.firstNameLb.TabIndex = 3;
            this.firstNameLb.Text = "First Name:*";
            // 
            // lastNameLb
            // 
            this.lastNameLb.AutoSize = true;
            this.lastNameLb.Location = new System.Drawing.Point(289, 231);
            this.lastNameLb.Name = "lastNameLb";
            this.lastNameLb.Size = new System.Drawing.Size(65, 13);
            this.lastNameLb.TabIndex = 5;
            this.lastNameLb.Text = "Last Name:*";
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(292, 263);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(163, 20);
            this.lastNameTB.TabIndex = 4;
            // 
            // phoneLb
            // 
            this.phoneLb.AutoSize = true;
            this.phoneLb.Location = new System.Drawing.Point(289, 306);
            this.phoneLb.Name = "phoneLb";
            this.phoneLb.Size = new System.Drawing.Size(45, 13);
            this.phoneLb.TabIndex = 9;
            this.phoneLb.Text = "Phone:*";
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(292, 332);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(163, 20);
            this.phoneTB.TabIndex = 8;
            // 
            // registerBt
            // 
            this.registerBt.Location = new System.Drawing.Point(292, 422);
            this.registerBt.Name = "registerBt";
            this.registerBt.Size = new System.Drawing.Size(163, 43);
            this.registerBt.TabIndex = 20;
            this.registerBt.Text = "Register";
            this.registerBt.UseVisualStyleBackColor = true;
            this.registerBt.Click += new System.EventHandler(this.registerBt_Click);
            // 
            // registerLb
            // 
            this.registerLb.AutoSize = true;
            this.registerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerLb.Location = new System.Drawing.Point(159, 37);
            this.registerLb.Name = "registerLb";
            this.registerLb.Size = new System.Drawing.Size(204, 24);
            this.registerLb.TabIndex = 21;
            this.registerLb.Text = "Register New Patient";
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(292, 497);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(163, 43);
            this.backBt.TabIndex = 60;
            this.backBt.Text = "Go Back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // formLB
            // 
            this.formLB.AutoSize = true;
            this.formLB.Location = new System.Drawing.Point(236, 602);
            this.formLB.Name = "formLB";
            this.formLB.Size = new System.Drawing.Size(0, 13);
            this.formLB.TabIndex = 66;
            this.formLB.Visible = false;
            // 
            // ownerLb
            // 
            this.ownerLb.AutoSize = true;
            this.ownerLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ownerLb.Location = new System.Drawing.Point(350, 99);
            this.ownerLb.Name = "ownerLb";
            this.ownerLb.Size = new System.Drawing.Size(50, 16);
            this.ownerLb.TabIndex = 72;
            this.ownerLb.Text = "Owner";
            // 
            // petLB
            // 
            this.petLB.AutoSize = true;
            this.petLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.petLB.Location = new System.Drawing.Point(103, 99);
            this.petLB.Name = "petLB";
            this.petLB.Size = new System.Drawing.Size(30, 16);
            this.petLB.TabIndex = 83;
            this.petLB.Text = "Pet";
            // 
            // infoLb
            // 
            this.infoLb.AutoSize = true;
            this.infoLb.Location = new System.Drawing.Point(47, 477);
            this.infoLb.Name = "infoLb";
            this.infoLb.Size = new System.Drawing.Size(111, 13);
            this.infoLb.TabIndex = 82;
            this.infoLb.Text = "Additional Information:";
            // 
            // infoTB
            // 
            this.infoTB.Location = new System.Drawing.Point(50, 509);
            this.infoTB.Name = "infoTB";
            this.infoTB.Size = new System.Drawing.Size(163, 20);
            this.infoTB.TabIndex = 81;
            // 
            // ageLb
            // 
            this.ageLb.AutoSize = true;
            this.ageLb.Location = new System.Drawing.Point(47, 398);
            this.ageLb.Name = "ageLb";
            this.ageLb.Size = new System.Drawing.Size(29, 13);
            this.ageLb.TabIndex = 80;
            this.ageLb.Text = "Age:";
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(50, 430);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(163, 20);
            this.ageTB.TabIndex = 79;
            // 
            // sexLb
            // 
            this.sexLb.AutoSize = true;
            this.sexLb.Location = new System.Drawing.Point(47, 306);
            this.sexLb.Name = "sexLb";
            this.sexLb.Size = new System.Drawing.Size(32, 13);
            this.sexLb.TabIndex = 78;
            this.sexLb.Text = "Sex:*";
            // 
            // speciesLb
            // 
            this.speciesLb.AutoSize = true;
            this.speciesLb.Location = new System.Drawing.Point(47, 231);
            this.speciesLb.Name = "speciesLb";
            this.speciesLb.Size = new System.Drawing.Size(52, 13);
            this.speciesLb.TabIndex = 76;
            this.speciesLb.Text = "Species:*";
            // 
            // speciesTB
            // 
            this.speciesTB.Location = new System.Drawing.Point(50, 263);
            this.speciesTB.Name = "speciesTB";
            this.speciesTB.Size = new System.Drawing.Size(163, 20);
            this.speciesTB.TabIndex = 75;
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(47, 145);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(42, 13);
            this.nameLb.TabIndex = 74;
            this.nameLb.Text = "Name:*";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(50, 177);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(163, 20);
            this.nameTB.TabIndex = 73;
            // 
            // requiredLB
            // 
            this.requiredLB.AutoSize = true;
            this.requiredLB.Location = new System.Drawing.Point(50, 562);
            this.requiredLB.Name = "requiredLB";
            this.requiredLB.Size = new System.Drawing.Size(103, 13);
            this.requiredLB.TabIndex = 84;
            this.requiredLB.Text = "*required information";
            // 
            // sexLstBox
            // 
            this.sexLstBox.FormattingEnabled = true;
            this.sexLstBox.Items.AddRange(new object[] {
            "K",
            "M",
            "N"});
            this.sexLstBox.Location = new System.Drawing.Point(50, 332);
            this.sexLstBox.Name = "sexLstBox";
            this.sexLstBox.Size = new System.Drawing.Size(120, 49);
            this.sexLstBox.TabIndex = 85;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 605);
            this.Controls.Add(this.sexLstBox);
            this.Controls.Add(this.requiredLB);
            this.Controls.Add(this.petLB);
            this.Controls.Add(this.infoLb);
            this.Controls.Add(this.infoTB);
            this.Controls.Add(this.ageLb);
            this.Controls.Add(this.ageTB);
            this.Controls.Add(this.sexLb);
            this.Controls.Add(this.speciesLb);
            this.Controls.Add(this.speciesTB);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.ownerLb);
            this.Controls.Add(this.formLB);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.registerLb);
            this.Controls.Add(this.registerBt);
            this.Controls.Add(this.phoneLb);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.lastNameLb);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameLb);
            this.Controls.Add(this.firstNameTB);
            this.Name = "Register";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Label firstNameLb;
        private System.Windows.Forms.Label lastNameLb;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.Label phoneLb;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Button registerBt;
        private System.Windows.Forms.Label registerLb;
        private System.Windows.Forms.Button backBt;
        internal System.Windows.Forms.Label formLB;
        private System.Windows.Forms.Label ownerLb;
        private System.Windows.Forms.Label petLB;
        private System.Windows.Forms.Label infoLb;
        private System.Windows.Forms.TextBox infoTB;
        private System.Windows.Forms.Label ageLb;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.Label sexLb;
        private System.Windows.Forms.Label speciesLb;
        private System.Windows.Forms.TextBox speciesTB;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label requiredLB;
        private System.Windows.Forms.CheckedListBox sexLstBox;
    }
}