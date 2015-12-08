namespace UniSchedule
{
    partial class ScheduleAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFieldOfStudy = new System.Windows.Forms.ComboBox();
            this.tbFieldOfStudyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbSubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.other_schedule2DataSet = new UniSchedule.other_schedule2DataSet();
            this.tbFieldsOfStudyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFieldsOfStudyTableAdapter = new UniSchedule.other_schedule2DataSetTableAdapters.tbFieldsOfStudyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbFieldOfStudyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.other_schedule2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFieldsOfStudyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj nazwę grupy";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(180, 29);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(185, 20);
            this.txtGroupName.TabIndex = 1;
            this.txtGroupName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wybierz kierunek";
            // 
            // txtFieldOfStudy
            // 
            this.txtFieldOfStudy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbFieldsOfStudyBindingSource, "Name", true));
            this.txtFieldOfStudy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tbFieldsOfStudyBindingSource, "Name", true));
            this.txtFieldOfStudy.FormattingEnabled = true;
            this.txtFieldOfStudy.Location = new System.Drawing.Point(180, 65);
            this.txtFieldOfStudy.Name = "txtFieldOfStudy";
            this.txtFieldOfStudy.Size = new System.Drawing.Size(185, 21);
            this.txtFieldOfStudy.TabIndex = 3;
            this.txtFieldOfStudy.SelectedIndexChanged += new System.EventHandler(this.txtFieldOfStudy_SelectedIndexChanged);
            // 
            // tbFieldOfStudyBindingSource
            // 
            this.tbFieldOfStudyBindingSource.DataMember = "tbFieldOfStudy";
            // 
            // uniScheduleDBDataSet
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dalej";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Zamknij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbSubjectsBindingSource
            // 
            this.tbSubjectsBindingSource.DataMember = "tbSubjects";
            // 
            
            // 
     
            // other_schedule2DataSet
            // 
            this.other_schedule2DataSet.DataSetName = "other_schedule2DataSet";
            this.other_schedule2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFieldsOfStudyBindingSource
            // 
            this.tbFieldsOfStudyBindingSource.DataMember = "tbFieldsOfStudy";
            this.tbFieldsOfStudyBindingSource.DataSource = this.other_schedule2DataSet;
            // 
            // tbFieldsOfStudyTableAdapter
            // 
            this.tbFieldsOfStudyTableAdapter.ClearBeforeFill = true;
            // 
            // ScheduleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 155);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFieldOfStudy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleAdd";
            this.Text = "ScheduleAdd";
            this.Load += new System.EventHandler(this.ScheduleAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbFieldOfStudyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.other_schedule2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFieldsOfStudyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtFieldOfStudy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        
        private System.Windows.Forms.BindingSource tbSubjectsBindingSource;
        
        private System.Windows.Forms.BindingSource tbFieldOfStudyBindingSource;
        
        private other_schedule2DataSet other_schedule2DataSet;
        private System.Windows.Forms.BindingSource tbFieldsOfStudyBindingSource;
        private other_schedule2DataSetTableAdapters.tbFieldsOfStudyTableAdapter tbFieldsOfStudyTableAdapter;
    }
}