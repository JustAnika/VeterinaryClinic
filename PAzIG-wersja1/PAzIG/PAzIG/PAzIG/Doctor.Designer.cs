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
            this.historyLV = new System.Windows.Forms.ListView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.allDateCecb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // patientLst
            // 
            this.patientLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientLst.BackColor = System.Drawing.SystemColors.Info;
            this.patientLst.ForeColor = System.Drawing.Color.Purple;
            this.patientLst.HideSelection = false;
            this.patientLst.Location = new System.Drawing.Point(46, 109);
            this.patientLst.Name = "patientLst";
            this.patientLst.Size = new System.Drawing.Size(207, 260);
            this.patientLst.TabIndex = 4;
            this.patientLst.UseCompatibleStateImageBehavior = false;
            this.patientLst.View = System.Windows.Forms.View.List;
            this.patientLst.SelectedIndexChanged += new System.EventHandler(this.patientLst_SelectedIndexChanged);
            // 
            // editVisitBt
            // 
            this.editVisitBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editVisitBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editVisitBt.BackColor = System.Drawing.Color.Lime;
            this.editVisitBt.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.editVisitBt.FlatAppearance.BorderSize = 0;
            this.editVisitBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.editVisitBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.editVisitBt.ForeColor = System.Drawing.Color.Purple;
            this.editVisitBt.Location = new System.Drawing.Point(440, 45);
            this.editVisitBt.Name = "editVisitBt";
            this.editVisitBt.Size = new System.Drawing.Size(126, 37);
            this.editVisitBt.TabIndex = 7;
            this.editVisitBt.Text = "Edit Visit";
            this.editVisitBt.UseVisualStyleBackColor = false;
            this.editVisitBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // editBt
            // 
            this.editBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editBt.BackColor = System.Drawing.Color.Lime;
            this.editBt.ForeColor = System.Drawing.Color.Purple;
            this.editBt.Location = new System.Drawing.Point(250, 45);
            this.editBt.Name = "editBt";
            this.editBt.Size = new System.Drawing.Size(126, 37);
            this.editBt.TabIndex = 6;
            this.editBt.Text = "Edit Pet";
            this.editBt.UseVisualStyleBackColor = false;
            this.editBt.Click += new System.EventHandler(this.editBt_Click);
            // 
            // orderBt
            // 
            this.orderBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.orderBt.BackColor = System.Drawing.Color.Lime;
            this.orderBt.ForeColor = System.Drawing.Color.Purple;
            this.orderBt.Location = new System.Drawing.Point(627, 45);
            this.orderBt.Name = "orderBt";
            this.orderBt.Size = new System.Drawing.Size(126, 37);
            this.orderBt.TabIndex = 8;
            this.orderBt.Text = "Order A Test";
            this.orderBt.UseVisualStyleBackColor = false;
            this.orderBt.Click += new System.EventHandler(this.orderBt_Click);
            // 
            // logOutBt
            // 
            this.logOutBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logOutBt.BackColor = System.Drawing.Color.Lime;
            this.logOutBt.ForeColor = System.Drawing.Color.Purple;
            this.logOutBt.Location = new System.Drawing.Point(329, 406);
            this.logOutBt.Name = "logOutBt";
            this.logOutBt.Size = new System.Drawing.Size(126, 37);
            this.logOutBt.TabIndex = 9;
            this.logOutBt.Text = "Log Out";
            this.logOutBt.UseVisualStyleBackColor = false;
            this.logOutBt.Click += new System.EventHandler(this.logOutBt_Click);
            // 
            // petBT
            // 
            this.petBT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.petBT.BackColor = System.Drawing.Color.Lime;
            this.petBT.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.petBT.FlatAppearance.BorderSize = 0;
            this.petBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.petBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.petBT.ForeColor = System.Drawing.Color.Purple;
            this.petBT.Location = new System.Drawing.Point(65, 45);
            this.petBT.Name = "petBT";
            this.petBT.Size = new System.Drawing.Size(126, 37);
            this.petBT.TabIndex = 10;
            this.petBT.Text = "Add Pet";
            this.petBT.UseVisualStyleBackColor = false;
            this.petBT.Click += new System.EventHandler(this.petBT_Click);
            // 
            // visitLst
            // 
            this.visitLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitLst.BackColor = System.Drawing.SystemColors.Info;
            this.visitLst.ForeColor = System.Drawing.Color.Purple;
            this.visitLst.HideSelection = false;
            this.visitLst.Location = new System.Drawing.Point(282, 109);
            this.visitLst.Margin = new System.Windows.Forms.Padding(2);
            this.visitLst.Name = "visitLst";
            this.visitLst.Size = new System.Drawing.Size(264, 260);
            this.visitLst.TabIndex = 11;
            this.visitLst.UseCompatibleStateImageBehavior = false;
            this.visitLst.View = System.Windows.Forms.View.List;
            // 
            // loginInfoLb
            // 
            this.loginInfoLb.AutoSize = true;
            this.loginInfoLb.Location = new System.Drawing.Point(677, 426);
            this.loginInfoLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginInfoLb.Name = "loginInfoLb";
            this.loginInfoLb.Size = new System.Drawing.Size(29, 13);
            this.loginInfoLb.TabIndex = 12;
            this.loginInfoLb.Text = "login";
            this.loginInfoLb.Visible = false;
            // 
            // historyLV
            // 
            this.historyLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyLV.BackColor = System.Drawing.SystemColors.Info;
            this.historyLV.ForeColor = System.Drawing.Color.Purple;
            this.historyLV.HideSelection = false;
            this.historyLV.Location = new System.Drawing.Point(568, 109);
            this.historyLV.Margin = new System.Windows.Forms.Padding(2);
            this.historyLV.Name = "historyLV";
            this.historyLV.Size = new System.Drawing.Size(215, 259);
            this.historyLV.TabIndex = 13;
            this.historyLV.UseCompatibleStateImageBehavior = false;
            this.historyLV.View = System.Windows.Forms.View.List;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Purple;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(283, 381);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // allDateCecb
            // 
            this.allDateCecb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allDateCecb.AutoSize = true;
            this.allDateCecb.ForeColor = System.Drawing.Color.Lime;
            this.allDateCecb.Location = new System.Drawing.Point(460, 381);
            this.allDateCecb.Margin = new System.Windows.Forms.Padding(2);
            this.allDateCecb.Name = "allDateCecb";
            this.allDateCecb.Size = new System.Drawing.Size(102, 17);
            this.allDateCecb.TabIndex = 15;
            this.allDateCecb.Text = "wszytskie wizyty";
            this.allDateCecb.UseVisualStyleBackColor = true;
            this.allDateCecb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(808, 484);
            this.Controls.Add(this.allDateCecb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.historyLV);
            this.Controls.Add(this.loginInfoLb);
            this.Controls.Add(this.visitLst);
            this.Controls.Add(this.petBT);
            this.Controls.Add(this.logOutBt);
            this.Controls.Add(this.orderBt);
            this.Controls.Add(this.editVisitBt);
            this.Controls.Add(this.editBt);
            this.Controls.Add(this.patientLst);
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
        private System.Windows.Forms.ListView historyLV;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox allDateCecb;
    }
}