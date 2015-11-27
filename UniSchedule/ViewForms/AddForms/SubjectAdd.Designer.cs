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
            this.cbSubjectType = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSaveSubject = new System.Windows.Forms.Button();
            this.lblFullSubjectName = new System.Windows.Forms.Label();
            this.lblShortSubjectName = new System.Windows.Forms.Label();
            this.lblSubjectType = new System.Windows.Forms.Label();
            this.other_schedule2DataSet = new UniSchedule.other_schedule2DataSet();
            this.tbTypesSubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbTypesSubjectsTableAdapter = new UniSchedule.other_schedule2DataSetTableAdapters.tbTypesSubjectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.other_schedule2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTypesSubjectsBindingSource)).BeginInit();
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
            // cbSubjectType
            // 
            this.cbSubjectType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbTypesSubjectsBindingSource, "id", true));
            this.cbSubjectType.FormattingEnabled = true;
            this.cbSubjectType.Location = new System.Drawing.Point(91, 123);
            this.cbSubjectType.Name = "cbSubjectType";
            this.cbSubjectType.Size = new System.Drawing.Size(159, 21);
            this.cbSubjectType.TabIndex = 2;
            this.cbSubjectType.SelectedIndexChanged += new System.EventHandler(this.cbSubjectType_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(175, 167);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Powrót";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSaveSubject
            // 
            this.btnSaveSubject.Location = new System.Drawing.Point(91, 167);
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
            // lblSubjectType
            // 
            this.lblSubjectType.AutoSize = true;
            this.lblSubjectType.Location = new System.Drawing.Point(88, 107);
            this.lblSubjectType.Name = "lblSubjectType";
            this.lblSubjectType.Size = new System.Drawing.Size(79, 13);
            this.lblSubjectType.TabIndex = 7;
            this.lblSubjectType.Text = "Typ przedmiotu";
            // 
            // other_schedule2DataSet
            // 
            this.other_schedule2DataSet.DataSetName = "other_schedule2DataSet";
            this.other_schedule2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbTypesSubjectsBindingSource
            // 
            this.tbTypesSubjectsBindingSource.DataMember = "tbTypesSubjects";
            this.tbTypesSubjectsBindingSource.DataSource = this.other_schedule2DataSet;
            // 
            // tbTypesSubjectsTableAdapter
            // 
            this.tbTypesSubjectsTableAdapter.ClearBeforeFill = true;
            // 
            // SubjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 242);
            this.Controls.Add(this.lblSubjectType);
            this.Controls.Add(this.lblShortSubjectName);
            this.Controls.Add(this.lblFullSubjectName);
            this.Controls.Add(this.btnSaveSubject);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbSubjectType);
            this.Controls.Add(this.txtShortSubjectName);
            this.Controls.Add(this.txtLongSubjectName);
            this.Name = "SubjectAdd";
            this.Text = "SubjectAdd";
            this.Load += new System.EventHandler(this.SubjectAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.other_schedule2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTypesSubjectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLongSubjectName;
        private System.Windows.Forms.TextBox txtShortSubjectName;
        private System.Windows.Forms.ComboBox cbSubjectType;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSaveSubject;
        private System.Windows.Forms.Label lblFullSubjectName;
        private System.Windows.Forms.Label lblShortSubjectName;
        private System.Windows.Forms.Label lblSubjectType;
        private other_schedule2DataSet other_schedule2DataSet;
        private System.Windows.Forms.BindingSource tbTypesSubjectsBindingSource;
        private other_schedule2DataSetTableAdapters.tbTypesSubjectsTableAdapter tbTypesSubjectsTableAdapter;
    }
}