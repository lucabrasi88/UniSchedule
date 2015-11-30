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
            this.txtPhoneTwo = new System.Windows.Forms.TextBox();
            this.lblPhoneTwo = new System.Windows.Forms.Label();
            this.cbDegree = new System.Windows.Forms.ComboBox();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSaveInstructor = new System.Windows.Forms.Button();
            this.listbSubjects = new System.Windows.Forms.ListBox();
            this.cbSubjects = new System.Windows.Forms.ComboBox();
            this.lbSubjects = new System.Windows.Forms.Label();
            this.lbSubjectsHeader = new System.Windows.Forms.Label();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.other_schedule2DataSet = new UniSchedule.other_schedule2DataSet();
            this.tbSubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSubjectsTableAdapter = new UniSchedule.other_schedule2DataSetTableAdapters.tbSubjectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.other_schedule2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubjectsBindingSource)).BeginInit();
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
            // txtPhoneTwo
            // 
            this.txtPhoneTwo.Location = new System.Drawing.Point(58, 226);
            this.txtPhoneTwo.Name = "txtPhoneTwo";
            this.txtPhoneTwo.Size = new System.Drawing.Size(164, 20);
            this.txtPhoneTwo.TabIndex = 13;
            // 
            // lblPhoneTwo
            // 
            this.lblPhoneTwo.AutoSize = true;
            this.lblPhoneTwo.Location = new System.Drawing.Point(55, 209);
            this.lblPhoneTwo.Name = "lblPhoneTwo";
            this.lblPhoneTwo.Size = new System.Drawing.Size(88, 13);
            this.lblPhoneTwo.TabIndex = 12;
            this.lblPhoneTwo.Text = "Numer telefonu 2";
            // 
            // cbDegree
            // 
            this.cbDegree.FormattingEnabled = true;
            this.cbDegree.Location = new System.Drawing.Point(58, 119);
            this.cbDegree.Name = "cbDegree";
            this.cbDegree.Size = new System.Drawing.Size(164, 21);
            this.cbDegree.TabIndex = 14;
            this.cbDegree.SelectedIndexChanged += new System.EventHandler(this.cbDegree_SelectedIndexChanged);
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(254, 120);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(164, 20);
            this.txtRoomNo.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(196, 443);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Powrót";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSaveInstructor
            // 
            this.btnSaveInstructor.Location = new System.Drawing.Point(90, 443);
            this.btnSaveInstructor.Name = "btnSaveInstructor";
            this.btnSaveInstructor.Size = new System.Drawing.Size(75, 23);
            this.btnSaveInstructor.TabIndex = 17;
            this.btnSaveInstructor.Text = "Zapisz";
            this.btnSaveInstructor.UseVisualStyleBackColor = true;
            this.btnSaveInstructor.Click += new System.EventHandler(this.btnSaveInstructor_Click);
            // 
            // listbSubjects
            // 
            this.listbSubjects.FormattingEnabled = true;
            this.listbSubjects.Location = new System.Drawing.Point(254, 252);
            this.listbSubjects.Name = "listbSubjects";
            this.listbSubjects.Size = new System.Drawing.Size(164, 147);
            this.listbSubjects.TabIndex = 18;
            // 
            // cbSubjects
            // 
            this.cbSubjects.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbSubjectsBindingSource, "LongName", true));
            this.cbSubjects.FormattingEnabled = true;
            this.cbSubjects.Location = new System.Drawing.Point(58, 287);
            this.cbSubjects.Name = "cbSubjects";
            this.cbSubjects.Size = new System.Drawing.Size(164, 21);
            this.cbSubjects.TabIndex = 19;
            this.cbSubjects.SelectedIndexChanged += new System.EventHandler(this.cbSubjects_SelectedIndexChanged);
            // 
            // lbSubjects
            // 
            this.lbSubjects.AutoSize = true;
            this.lbSubjects.Location = new System.Drawing.Point(56, 271);
            this.lbSubjects.Name = "lbSubjects";
            this.lbSubjects.Size = new System.Drawing.Size(58, 13);
            this.lbSubjects.TabIndex = 20;
            this.lbSubjects.Text = "Przedmioty";
            // 
            // lbSubjectsHeader
            // 
            this.lbSubjectsHeader.AutoSize = true;
            this.lbSubjectsHeader.Location = new System.Drawing.Point(251, 226);
            this.lbSubjectsHeader.Name = "lbSubjectsHeader";
            this.lbSubjectsHeader.Size = new System.Drawing.Size(91, 13);
            this.lbSubjectsHeader.TabIndex = 21;
            this.lbSubjectsHeader.Text = "Lista przedmiotów";
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(58, 331);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubject.TabIndex = 22;
            this.btnAddSubject.Text = "Dodaj";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(147, 331);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSubject.TabIndex = 23;
            this.btnDeleteSubject.Text = "Usuń";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            // 
            // other_schedule2DataSet
            // 
            this.other_schedule2DataSet.DataSetName = "other_schedule2DataSet";
            this.other_schedule2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbSubjectsBindingSource
            // 
            this.tbSubjectsBindingSource.DataMember = "tbSubjects";
            this.tbSubjectsBindingSource.DataSource = this.other_schedule2DataSet;
            // 
            // tbSubjectsTableAdapter
            // 
            this.tbSubjectsTableAdapter.ClearBeforeFill = true;
            // 
            // InstructorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 493);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.lbSubjectsHeader);
            this.Controls.Add(this.lbSubjects);
            this.Controls.Add(this.cbSubjects);
            this.Controls.Add(this.listbSubjects);
            this.Controls.Add(this.btnSaveInstructor);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.cbDegree);
            this.Controls.Add(this.txtPhoneTwo);
            this.Controls.Add(this.lblPhoneTwo);
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
            ((System.ComponentModel.ISupportInitialize)(this.other_schedule2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubjectsBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtPhoneTwo;
        private System.Windows.Forms.Label lblPhoneTwo;
        private System.Windows.Forms.ComboBox cbDegree;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSaveInstructor;
        private System.Windows.Forms.ListBox listbSubjects;
        private System.Windows.Forms.ComboBox cbSubjects;
        private System.Windows.Forms.Label lbSubjects;
        private System.Windows.Forms.Label lbSubjectsHeader;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnDeleteSubject;
        private other_schedule2DataSet other_schedule2DataSet;
        private System.Windows.Forms.BindingSource tbSubjectsBindingSource;
        private other_schedule2DataSetTableAdapters.tbSubjectsTableAdapter tbSubjectsTableAdapter;
    }
}