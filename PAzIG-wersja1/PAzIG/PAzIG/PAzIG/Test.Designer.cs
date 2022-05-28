namespace PAzIG
{
    partial class Test
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
            this.petLb = new System.Windows.Forms.Label();
            this.petTextBox = new System.Windows.Forms.TextBox();
            this.techLb = new System.Windows.Forms.Label();
            this.createLb = new System.Windows.Forms.Label();
            this.dateLb = new System.Windows.Forms.Label();
            this.orderBt = new System.Windows.Forms.Button();
            this.backBt = new System.Windows.Forms.Button();
            this.fromLB = new System.Windows.Forms.Label();
            this.OpisLb = new System.Windows.Forms.Label();
            this.requiredLB = new System.Windows.Forms.Label();
            this.OpisTb = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.testListLV = new System.Windows.Forms.ListView();
            this.listLB = new System.Windows.Forms.Label();
            this.TechComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // petLb
            // 
            this.petLb.AutoSize = true;
            this.petLb.Location = new System.Drawing.Point(383, 116);
            this.petLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.petLb.Name = "petLb";
            this.petLb.Size = new System.Drawing.Size(49, 16);
            this.petLb.TabIndex = 52;
            this.petLb.Text = "Pet Id*:";
            // 
            // petTextBox
            // 
            this.petTextBox.Location = new System.Drawing.Point(387, 155);
            this.petTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.petTextBox.Name = "petTextBox";
            this.petTextBox.ReadOnly = true;
            this.petTextBox.Size = new System.Drawing.Size(216, 22);
            this.petTextBox.TabIndex = 51;
            // 
            // techLb
            // 
            this.techLb.AutoSize = true;
            this.techLb.Location = new System.Drawing.Point(83, 116);
            this.techLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.techLb.Name = "techLb";
            this.techLb.Size = new System.Drawing.Size(141, 20);
            this.techLb.TabIndex = 54;
            this.techLb.Text = "Technician login*:";
            // 
            // createLb
            // 
            this.createLb.AutoSize = true;
            this.createLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createLb.Location = new System.Drawing.Point(247, 52);
            this.createLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createLb.Name = "createLb";
            this.createLb.Size = new System.Drawing.Size(163, 29);
            this.createLb.TabIndex = 55;
            this.createLb.Text = "Order A Test";
            // 
            // dateLb
            // 
            this.dateLb.AutoSize = true;
            this.dateLb.Location = new System.Drawing.Point(83, 204);
            this.dateLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(44, 16);
            this.dateLb.TabIndex = 57;
            this.dateLb.Text = "Date*:";
            // 
            // orderBt
            // 
            this.orderBt.Location = new System.Drawing.Point(387, 538);
            this.orderBt.Margin = new System.Windows.Forms.Padding(4);
            this.orderBt.Name = "orderBt";
            this.orderBt.Size = new System.Drawing.Size(217, 63);
            this.orderBt.TabIndex = 58;
            this.orderBt.Text = "Order";
            this.orderBt.UseVisualStyleBackColor = true;
            this.orderBt.Click += new System.EventHandler(this.orderBt_Click);
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(86, 538);
            this.backBt.Margin = new System.Windows.Forms.Padding(4);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(217, 63);
            this.backBt.TabIndex = 59;
            this.backBt.Text = "Go Back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // fromLB
            // 
            this.fromLB.AutoSize = true;
            this.fromLB.Location = new System.Drawing.Point(495, 62);
            this.fromLB.Name = "fromLB";
            this.fromLB.Size = new System.Drawing.Size(44, 16);
            this.fromLB.TabIndex = 60;
            this.fromLB.Text = "label1";
            this.fromLB.Visible = false;
            // 
            // OpisLb
            // 
            this.OpisLb.AutoSize = true;
            this.OpisLb.Location = new System.Drawing.Point(383, 204);
            this.OpisLb.Name = "OpisLb";
            this.OpisLb.Size = new System.Drawing.Size(80, 16);
            this.OpisLb.TabIndex = 61;
            this.OpisLb.Text = "Type of test:";
            // 
            // requiredLB
            // 
            this.requiredLB.AutoSize = true;
            this.requiredLB.Location = new System.Drawing.Point(280, 507);
            this.requiredLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.requiredLB.Name = "requiredLB";
            this.requiredLB.Size = new System.Drawing.Size(130, 16);
            this.requiredLB.TabIndex = 85;
            this.requiredLB.Text = "*required information";
            // 
            // OpisTb
            // 
            this.OpisTb.Location = new System.Drawing.Point(386, 240);
            this.OpisTb.Name = "OpisTb";
            this.OpisTb.Size = new System.Drawing.Size(218, 22);
            this.OpisTb.TabIndex = 86;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 22);
            this.dateTimePicker1.TabIndex = 87;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // testListLV
            // 
            this.testListLV.HideSelection = false;
            this.testListLV.Location = new System.Drawing.Point(87, 330);
            this.testListLV.Name = "testListLV";
            this.testListLV.Size = new System.Drawing.Size(516, 156);
            this.testListLV.TabIndex = 88;
            this.testListLV.UseCompatibleStateImageBehavior = false;
            this.testListLV.View = System.Windows.Forms.View.List;
            // 
            // listLB
            // 
            this.listLB.AutoSize = true;
            this.listLB.Location = new System.Drawing.Point(84, 300);
            this.listLB.Name = "listLB";
            this.listLB.Size = new System.Drawing.Size(321, 20);
            this.listLB.TabIndex = 89;
            this.listLB.Text = "List of tests for the technician for given day:";
            // 
            // TechComboBox
            // 
            this.TechComboBox.FormattingEnabled = true;
            this.TechComboBox.Location = new System.Drawing.Point(87, 155);
            this.TechComboBox.Name = "TechComboBox";
            this.TechComboBox.Size = new System.Drawing.Size(216, 24);
            this.TechComboBox.TabIndex = 90;
            this.TechComboBox.SelectedValueChanged += new System.EventHandler(this.TechComboBox_SelectedValueChanged);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 646);
            this.Controls.Add(this.TechComboBox);
            this.Controls.Add(this.listLB);
            this.Controls.Add(this.testListLV);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.OpisTb);
            this.Controls.Add(this.requiredLB);
            this.Controls.Add(this.OpisLb);
            this.Controls.Add(this.fromLB);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.orderBt);
            this.Controls.Add(this.dateLb);
            this.Controls.Add(this.createLb);
            this.Controls.Add(this.techLb);
            this.Controls.Add(this.petLb);
            this.Controls.Add(this.petTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label petLb;
        private System.Windows.Forms.Label techLb;
        private System.Windows.Forms.Label createLb;
        private System.Windows.Forms.Label dateLb;
        private System.Windows.Forms.Button orderBt;
        private System.Windows.Forms.Button backBt;
        internal System.Windows.Forms.Label fromLB;
        private System.Windows.Forms.Label OpisLb;
        private System.Windows.Forms.Label requiredLB;
        private System.Windows.Forms.TextBox OpisTb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.TextBox petTextBox;
        private System.Windows.Forms.ListView testListLV;
        private System.Windows.Forms.Label listLB;
        private System.Windows.Forms.ComboBox TechComboBox;
    }
}