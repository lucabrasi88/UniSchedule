namespace UniSchedule.ViewForms.DeleteForms
{
    partial class InstructorDelete
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
            this.btnDeleteInstructor = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbInstructors = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDeleteInstructor
            // 
            this.btnDeleteInstructor.Location = new System.Drawing.Point(102, 83);
            this.btnDeleteInstructor.Name = "btnDeleteInstructor";
            this.btnDeleteInstructor.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteInstructor.TabIndex = 1;
            this.btnDeleteInstructor.Text = "Usuń";
            this.btnDeleteInstructor.UseVisualStyleBackColor = true;
            this.btnDeleteInstructor.Click += new System.EventHandler(this.btnDeleteInstructor_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(210, 83);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Powrót";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbInstructors
            // 
            this.cbInstructors.FormattingEnabled = true;
            this.cbInstructors.Location = new System.Drawing.Point(102, 42);
            this.cbInstructors.Name = "cbInstructors";
            this.cbInstructors.Size = new System.Drawing.Size(183, 21);
            this.cbInstructors.TabIndex = 3;
            this.cbInstructors.SelectedIndexChanged += new System.EventHandler(this.cbInstructors_SelectedIndexChanged);
            // 
            // InstructorDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 153);
            this.Controls.Add(this.cbInstructors);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteInstructor);
            this.Name = "InstructorDelete";
            this.Text = "InstructorDelete";
            this.Load += new System.EventHandler(this.InstructorDelete_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteInstructor;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbInstructors;
    }
}