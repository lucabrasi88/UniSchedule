namespace UniSchedule.ViewForms.AddForms
{
    partial class SubjectAdd
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
            this.txtLongSubjectName = new System.Windows.Forms.TextBox();
            this.txtShortSubjectName = new System.Windows.Forms.TextBox();
            this.tbTypesSubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.other_schedule2DataSet = new UniSchedule.other_schedule2DataSet();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSaveSubject = new System.Windows.Forms.Button();
            this.lblFullSubjectName = new System.Windows.Forms.Label();
            this.lblShortSubjectName = new System.Windows.Forms.Label();
            this.tbTypesSubjectsTableAdapter = new UniSchedule.other_schedule2DataSetTableAdapters.tbTypesSubjectsTableAdapter();
            this.lblEnglishName = new System.Windows.Forms.Label();
            this.txtEnglishName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbTypesSubjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.other_schedule2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLongSubjectName
            // 
            this.txtLongSubjectName.Location = new System.Drawing.Point(91, 40);
            this.txtLongSubjectName.Name = "txtLongSubjectName";
            this.txtLongSubjectName.Size = new System.Drawing.Size(159, 20);
            this.txtLongSubjectName.TabIndex = 0;
            // 
            // txtShortSubjectName
            // 
            this.txtShortSubjectName.Location = new System.Drawing.Point(91, 83);
            this.txtShortSubjectName.Name = "txtShortSubjectName";
            this.txtShortSubjectName.Size = new System.Drawing.Size(159, 20);
            this.txtShortSubjectName.TabIndex = 1;
            // 
            // tbTypesSubjectsBindingSource
            // 
            this.tbTypesSubjectsBindingSource.DataMember = "tbTypesSubjects";
            this.tbTypesSubjectsBindingSource.DataSource = this.other_schedule2DataSet;
            // 
            // other_schedule2DataSet
            // 
            this.other_schedule2DataSet.DataSetName = "other_schedule2DataSet";
            this.other_schedule2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(175, 158);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Powrót";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSaveSubject
            // 
            this.btnSaveSubject.Location = new System.Drawing.Point(91, 158);
            this.btnSaveSubject.Name = "btnSaveSubject";
            this.btnSaveSubject.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSubject.TabIndex = 4;
            this.btnSaveSubject.Text = "Zapisz";
            this.btnSaveSubject.UseVisualStyleBackColor = true;
            this.btnSaveSubject.Click += new System.EventHandler(this.btnSaveSubject_Click);
            // 
            // lblFullSubjectName
            // 
            this.lblFullSubjectName.AutoSize = true;
            this.lblFullSubjectName.Location = new System.Drawing.Point(88, 24);
            this.lblFullSubjectName.Name = "lblFullSubjectName";
            this.lblFullSubjectName.Size = new System.Drawing.Size(124, 13);
            this.lblFullSubjectName.TabIndex = 5;
            this.lblFullSubjectName.Text = "Pełna nazwa przedmiotu";
            // 
            // lblShortSubjectName
            // 
            this.lblShortSubjectName.AutoSize = true;
            this.lblShortSubjectName.Location = new System.Drawing.Point(88, 67);
            this.lblShortSubjectName.Name = "lblShortSubjectName";
            this.lblShortSubjectName.Size = new System.Drawing.Size(141, 13);
            this.lblShortSubjectName.TabIndex = 6;
            this.lblShortSubjectName.Text = "Skrócona nazwa przedmiotu";
            // 
            // tbTypesSubjectsTableAdapter
            // 
            this.tbTypesSubjectsTableAdapter.ClearBeforeFill = true;
            // 
            // lblEnglishName
            // 
            this.lblEnglishName.AutoSize = true;
            this.lblEnglishName.Location = new System.Drawing.Point(88, 115);
            this.lblEnglishName.Name = "lblEnglishName";
            this.lblEnglishName.Size = new System.Drawing.Size(141, 13);
            this.lblEnglishName.TabIndex = 8;
            this.lblEnglishName.Text = "Angielska nazwa przedmiotu";
            // 
            // txtEnglishName
            // 
            this.txtEnglishName.Location = new System.Drawing.Point(91, 131);
            this.txtEnglishName.Name = "txtEnglishName";
            this.txtEnglishName.Size = new System.Drawing.Size(159, 20);
            this.txtEnglishName.TabIndex = 7;
            // 
            // SubjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 209);
            this.Controls.Add(this.lblEnglishName);
            this.Controls.Add(this.txtEnglishName);
            this.Controls.Add(this.lblShortSubjectName);
            this.Controls.Add(this.lblFullSubjectName);
            this.Controls.Add(this.btnSaveSubject);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtShortSubjectName);
            this.Controls.Add(this.txtLongSubjectName);
            this.Name = "SubjectAdd";
            this.Text = "SubjectAdd";
            this.Load += new System.EventHandler(this.SubjectAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTypesSubjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.other_schedule2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLongSubjectName;
        private System.Windows.Forms.TextBox txtShortSubjectName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSaveSubject;
        private System.Windows.Forms.Label lblFullSubjectName;
        private System.Windows.Forms.Label lblShortSubjectName;
        private other_schedule2DataSet other_schedule2DataSet;
        private System.Windows.Forms.BindingSource tbTypesSubjectsBindingSource;
        private other_schedule2DataSetTableAdapters.tbTypesSubjectsTableAdapter tbTypesSubjectsTableAdapter;
        private System.Windows.Forms.Label lblEnglishName;
        private System.Windows.Forms.TextBox txtEnglishName;
    }
}