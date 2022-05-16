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
            this.techTextBox = new System.Windows.Forms.TextBox();
            this.createLb = new System.Windows.Forms.Label();
            this.dateLb = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.orderBt = new System.Windows.Forms.Button();
            this.backBt = new System.Windows.Forms.Button();
            this.fromLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // petLb
            // 
            this.petLb.AutoSize = true;
            this.petLb.Location = new System.Drawing.Point(383, 116);
            this.petLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.petLb.Name = "petLb";
            this.petLb.Size = new System.Drawing.Size(44, 16);
            this.petLb.TabIndex = 52;
            this.petLb.Text = "Pet Id:";
            // 
            // petTextBox
            // 
            this.petTextBox.Location = new System.Drawing.Point(387, 155);
            this.petTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.petTextBox.Name = "petTextBox";
            this.petTextBox.Size = new System.Drawing.Size(216, 22);
            this.petTextBox.TabIndex = 51;
            // 
            // techLb
            // 
            this.techLb.AutoSize = true;
            this.techLb.Location = new System.Drawing.Point(83, 116);
            this.techLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.techLb.Name = "techLb";
            this.techLb.Size = new System.Drawing.Size(90, 16);
            this.techLb.TabIndex = 54;
            this.techLb.Text = "Technician Id:";
            // 
            // techTextBox
            // 
            this.techTextBox.Location = new System.Drawing.Point(87, 155);
            this.techTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.techTextBox.Name = "techTextBox";
            this.techTextBox.Size = new System.Drawing.Size(216, 22);
            this.techTextBox.TabIndex = 53;
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
            this.dateLb.Location = new System.Drawing.Point(224, 228);
            this.dateLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(39, 16);
            this.dateLb.TabIndex = 57;
            this.dateLb.Text = "Date:";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(228, 267);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(216, 22);
            this.dateTextBox.TabIndex = 56;
            // 
            // orderBt
            // 
            this.orderBt.Location = new System.Drawing.Point(387, 341);
            this.orderBt.Margin = new System.Windows.Forms.Padding(4);
            this.orderBt.Name = "orderBt";
            this.orderBt.Size = new System.Drawing.Size(217, 63);
            this.orderBt.TabIndex = 58;
            this.orderBt.Text = "Order";
            this.orderBt.UseVisualStyleBackColor = true;
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(87, 341);
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
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 431);
            this.Controls.Add(this.fromLB);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.orderBt);
            this.Controls.Add(this.dateLb);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.createLb);
            this.Controls.Add(this.techLb);
            this.Controls.Add(this.techTextBox);
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
        private System.Windows.Forms.TextBox petTextBox;
        private System.Windows.Forms.Label techLb;
        private System.Windows.Forms.TextBox techTextBox;
        private System.Windows.Forms.Label createLb;
        private System.Windows.Forms.Label dateLb;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Button orderBt;
        private System.Windows.Forms.Button backBt;
        internal System.Windows.Forms.Label fromLB;
    }
}