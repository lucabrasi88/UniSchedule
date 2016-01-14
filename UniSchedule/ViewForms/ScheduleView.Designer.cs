namespace UniSchedule
{
    partial class ScheduleView
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
            this.cbYearsOfStudies = new System.Windows.Forms.ComboBox();
            this.tbGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.other_schedule2DataSet = new UniSchedule.other_schedule2DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbGroupsTableAdapter = new UniSchedule.other_schedule2DataSetTableAdapters.tbGroupsTableAdapter();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFieldOfStudy = new System.Windows.Forms.Label();
            this.cbFieldOfStudy = new System.Windows.Forms.ComboBox();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.cbInstructor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.other_schedule2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cbYearsOfStudies
            // 
            this.cbYearsOfStudies.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbGroupsBindingSource, "NameGroups", true));
            this.cbYearsOfStudies.FormattingEnabled = true;
            this.cbYearsOfStudies.Location = new System.Drawing.Point(142, 37);
            this.cbYearsOfStudies.Name = "cbYearsOfStudies";
            this.cbYearsOfStudies.Size = new System.Drawing.Size(161, 21);
            this.cbYearsOfStudies.TabIndex = 0;
            this.cbYearsOfStudies.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
            // 
            // tbGroupsBindingSource
            // 
            this.tbGroupsBindingSource.DataMember = "tbGroups";
            this.tbGroupsBindingSource.DataSource = this.other_schedule2DataSet;
            // 
            // other_schedule2DataSet
            // 
            this.other_schedule2DataSet.DataSetName = "other_schedule2DataSet";
            this.other_schedule2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rok studiów";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(59, 213);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(489, 225);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbGroupsTableAdapter
            // 
            this.tbGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(267, 164);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Powrót";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(348, 37);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 5;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(321, 40);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(21, 13);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "Od";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(348, 77);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 7;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(321, 79);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(21, 13);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "Do";
            // 
            // lblFieldOfStudy
            // 
            this.lblFieldOfStudy.AutoSize = true;
            this.lblFieldOfStudy.Location = new System.Drawing.Point(78, 79);
            this.lblFieldOfStudy.Name = "lblFieldOfStudy";
            this.lblFieldOfStudy.Size = new System.Drawing.Size(49, 13);
            this.lblFieldOfStudy.TabIndex = 10;
            this.lblFieldOfStudy.Text = "Kierunek";
            // 
            // cbFieldOfStudy
            // 
            this.cbFieldOfStudy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbGroupsBindingSource, "NameGroups", true));
            this.cbFieldOfStudy.FormattingEnabled = true;
            this.cbFieldOfStudy.Location = new System.Drawing.Point(142, 76);
            this.cbFieldOfStudy.Name = "cbFieldOfStudy";
            this.cbFieldOfStudy.Size = new System.Drawing.Size(161, 21);
            this.cbFieldOfStudy.TabIndex = 9;
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Location = new System.Drawing.Point(56, 118);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(71, 13);
            this.lblInstructor.TabIndex = 12;
            this.lblInstructor.Text = "Wykładowca";
            // 
            // cbInstructor
            // 
            this.cbInstructor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbGroupsBindingSource, "NameGroups", true));
            this.cbInstructor.FormattingEnabled = true;
            this.cbInstructor.Location = new System.Drawing.Point(142, 115);
            this.cbInstructor.Name = "cbInstructor";
            this.cbInstructor.Size = new System.Drawing.Size(161, 21);
            this.cbInstructor.TabIndex = 11;
            // 
            // ScheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 522);
            this.Controls.Add(this.lblInstructor);
            this.Controls.Add(this.cbInstructor);
            this.Controls.Add(this.lblFieldOfStudy);
            this.Controls.Add(this.cbFieldOfStudy);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbYearsOfStudies);
            this.Name = "ScheduleView";
            this.Text = "ScheduleView";
            this.Load += new System.EventHandler(this.ScheduleView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.other_schedule2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbYearsOfStudies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private other_schedule2DataSet other_schedule2DataSet;
        private System.Windows.Forms.BindingSource tbGroupsBindingSource;
        private other_schedule2DataSetTableAdapters.tbGroupsTableAdapter tbGroupsTableAdapter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFieldOfStudy;
        private System.Windows.Forms.ComboBox cbFieldOfStudy;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.ComboBox cbInstructor;
    }
}