namespace UniSchedule.ViewForms.StudentForms
{
    partial class PasswordChange
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
            this.btnSaveNewPass = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNew = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveNewPass
            // 
            this.btnSaveNewPass.Location = new System.Drawing.Point(42, 152);
            this.btnSaveNewPass.Name = "btnSaveNewPass";
            this.btnSaveNewPass.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNewPass.TabIndex = 0;
            this.btnSaveNewPass.Text = "Zapisz";
            this.btnSaveNewPass.UseVisualStyleBackColor = true;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(39, 47);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(49, 13);
            this.lblCurrent.TabIndex = 1;
            this.lblCurrent.Text = "Aktualne";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 4;
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(53, 102);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(35, 13);
            this.lblNew.TabIndex = 3;
            this.lblNew.Text = "Nowe";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(157, 152);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Powrót";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 211);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.btnSaveNewPass);
            this.Name = "PasswordChange";
            this.Text = "PasswordChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveNewPass;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Button btnBack;
    }
}