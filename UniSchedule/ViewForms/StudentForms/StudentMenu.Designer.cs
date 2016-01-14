namespace UniSchedule.ViewForms.StudentForms
{
    partial class StudentMenu
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
            this.btnSearchForm = new System.Windows.Forms.Button();
            this.btnPassChange = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchForm
            // 
            this.btnSearchForm.Location = new System.Drawing.Point(76, 38);
            this.btnSearchForm.Name = "btnSearchForm";
            this.btnSearchForm.Size = new System.Drawing.Size(166, 23);
            this.btnSearchForm.TabIndex = 0;
            this.btnSearchForm.Text = "Plan zajęć";
            this.btnSearchForm.UseVisualStyleBackColor = true;
            this.btnSearchForm.Click += new System.EventHandler(this.btnSearchForm_Click);
            // 
            // btnPassChange
            // 
            this.btnPassChange.Location = new System.Drawing.Point(76, 67);
            this.btnPassChange.Name = "btnPassChange";
            this.btnPassChange.Size = new System.Drawing.Size(166, 23);
            this.btnPassChange.TabIndex = 1;
            this.btnPassChange.Text = "Zmień hasło";
            this.btnPassChange.UseVisualStyleBackColor = true;
            this.btnPassChange.Click += new System.EventHandler(this.btnPassChange_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(76, 96);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(166, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Zakończ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 155);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPassChange);
            this.Controls.Add(this.btnSearchForm);
            this.Name = "StudentMenu";
            this.Text = "StudentMenu";
            this.Load += new System.EventHandler(this.StudentMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchForm;
        private System.Windows.Forms.Button btnPassChange;
        private System.Windows.Forms.Button btnClose;
    }
}