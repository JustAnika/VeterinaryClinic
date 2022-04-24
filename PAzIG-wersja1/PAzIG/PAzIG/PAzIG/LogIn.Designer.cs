namespace PAzIG
{
    partial class LogIn
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBT = new System.Windows.Forms.Button();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.nameLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBT
            // 
            this.loginBT.Location = new System.Drawing.Point(132, 206);
            this.loginBT.Margin = new System.Windows.Forms.Padding(4);
            this.loginBT.Name = "loginBT";
            this.loginBT.Size = new System.Drawing.Size(123, 43);
            this.loginBT.TabIndex = 0;
            this.loginBT.Text = "Log In";
            this.loginBT.UseVisualStyleBackColor = true;
            this.loginBT.Click += new System.EventHandler(this.loginBT_Click);
            // 
            // loginTB
            // 
            this.loginTB.AllowDrop = true;
            this.loginTB.Location = new System.Drawing.Point(60, 89);
            this.loginTB.Margin = new System.Windows.Forms.Padding(4);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(269, 22);
            this.loginTB.TabIndex = 3;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(60, 149);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(269, 22);
            this.passwordTB.TabIndex = 4;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // nameLB
            // 
            this.nameLB.AutoSize = true;
            this.nameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLB.Location = new System.Drawing.Point(56, 34);
            this.nameLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLB.Name = "nameLB";
            this.nameLB.Size = new System.Drawing.Size(254, 20);
            this.nameLB.TabIndex = 6;
            this.nameLB.Text = "Welcome to veterinary clinic!";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 289);
            this.Controls.Add(this.nameLB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.loginBT);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogIn";
            this.Text = "Vet Clinic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBT;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label nameLB;
    }
}

