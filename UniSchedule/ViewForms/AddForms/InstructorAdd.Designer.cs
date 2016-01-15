namespace UniSchedule.ViewForms.AddForms
{
    partial class InstructorAdd
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPhoneOne = new System.Windows.Forms.TextBox();
            this.lblPhoneOne = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.cbDegree = new System.Windows.Forms.ComboBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSaveInstructor = new System.Windows.Forms.Button();
            this.tbSubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.other_schedule2DataSet = new UniSchedule.other_schedule2DataSet();
            this.tbSubjectsTableAdapter = new UniSchedule.other_schedule2DataSetTableAdapters.tbSubjectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.other_schedule2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(55, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(26, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Imię";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(251, 45);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(53, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Nazwisko";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(58, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(254, 62);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(164, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // txtPhoneOne
            // 
            this.txtPhoneOne.Location = new System.Drawing.Point(254, 175);
            this.txtPhoneOne.Name = "txtPhoneOne";
            this.txtPhoneOne.Size = new System.Drawing.Size(164, 20);
            this.txtPhoneOne.TabIndex = 7;
            // 
            // lblPhoneOne
            // 
            this.lblPhoneOne.AutoSize = true;
            this.lblPhoneOne.Location = new System.Drawing.Point(251, 158);
            this.lblPhoneOne.Name = "lblPhoneOne";
            this.lblPhoneOne.Size = new System.Drawing.Size(79, 13);
            this.lblPhoneOne.TabIndex = 5;
            this.lblPhoneOne.Text = "Numer telefonu";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(55, 103);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(89, 13);
            this.lblDegree.TabIndex = 4;
            this.lblDegree.Text = "Stopień naukowy";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(58, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(164, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(55, 158);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Adres e-mail";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Location = new System.Drawing.Point(251, 104);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(73, 13);
            this.lblRoomNo.TabIndex = 11;
            this.lblRoomNo.Text = "Numer pokoju";
            // 
            // cbDegree
            // 
            this.cbDegree.FormattingEnabled = true;
            this.cbDegree.Location = new System.Drawing.Point(58, 119);
            this.cbDegree.Name = "cbDegree";
            this.cbDegree.Size = new System.Drawing.Size(164, 21);
            this.cbDegree.TabIndex = 14;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtRoomNo.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNo.Location = new System.Drawing.Point(254, 120);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(164, 20);
            this.txtRoomNo.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(255, 224);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Powrót";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSaveInstructor
            // 
            this.btnSaveInstructor.Location = new System.Drawing.Point(147, 224);
            this.btnSaveInstructor.Name = "btnSaveInstructor";
            this.btnSaveInstructor.Size = new System.Drawing.Size(75, 23);
            this.btnSaveInstructor.TabIndex = 17;
            this.btnSaveInstructor.Text = "Zapisz";
            this.btnSaveInstructor.UseVisualStyleBackColor = true;
            this.btnSaveInstructor.Click += new System.EventHandler(this.btnSaveInstructor_Click);
            // 
            // tbSubjectsBindingSource
            // 
            this.tbSubjectsBindingSource.DataMember = "tbSubjects";
            this.tbSubjectsBindingSource.DataSource = this.other_schedule2DataSet;
            // 
            // other_schedule2DataSet
            // 
            this.other_schedule2DataSet.DataSetName = "other_schedule2DataSet";
            this.other_schedule2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbSubjectsTableAdapter
            // 
            this.tbSubjectsTableAdapter.ClearBeforeFill = true;
            // 
            // InstructorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 285);
            this.Controls.Add(this.btnSaveInstructor);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.cbDegree);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhoneOne);
            this.Controls.Add(this.lblPhoneOne);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "InstructorAdd";
            this.Text = "InstructorAdd";
            this.Load += new System.EventHandler(this.InstructorAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbSubjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.other_schedule2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPhoneOne;
        private System.Windows.Forms.Label lblPhoneOne;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.ComboBox cbDegree;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSaveInstructor;
        private other_schedule2DataSet other_schedule2DataSet;
        private System.Windows.Forms.BindingSource tbSubjectsBindingSource;
        private other_schedule2DataSetTableAdapters.tbSubjectsTableAdapter tbSubjectsTableAdapter;
    }
}