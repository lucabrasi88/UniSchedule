namespace UniSchedule.ViewForms.AddForms
{
    partial class GroupAdd
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
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFieldOfStudies = new System.Windows.Forms.ComboBox();
            this.cbYearOfStudies = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(160, 32);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(149, 20);
            this.txtGroupName.TabIndex = 0;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(85, 35);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(69, 13);
            this.lblGroupName.TabIndex = 1;
            this.lblGroupName.Text = "Nazwa grupy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rok studiów";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kierunek";
            // 
            // cbFieldOfStudies
            // 
            this.cbFieldOfStudies.FormattingEnabled = true;
            this.cbFieldOfStudies.Location = new System.Drawing.Point(160, 61);
            this.cbFieldOfStudies.Name = "cbFieldOfStudies";
            this.cbFieldOfStudies.Size = new System.Drawing.Size(149, 21);
            this.cbFieldOfStudies.TabIndex = 6;
            // 
            // cbYearOfStudies
            // 
            this.cbYearOfStudies.FormattingEnabled = true;
            this.cbYearOfStudies.Location = new System.Drawing.Point(160, 89);
            this.cbYearOfStudies.Name = "cbYearOfStudies";
            this.cbYearOfStudies.Size = new System.Drawing.Size(149, 21);
            this.cbYearOfStudies.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Powrót";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 169);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbYearOfStudies);
            this.Controls.Add(this.cbFieldOfStudies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.txtGroupName);
            this.Name = "GroupAdd";
            this.Text = "GroupAdd";
            this.Load += new System.EventHandler(this.GroupAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFieldOfStudies;
        private System.Windows.Forms.ComboBox cbYearOfStudies;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}