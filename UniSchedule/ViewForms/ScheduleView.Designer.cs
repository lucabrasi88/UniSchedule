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
            this.cbGroups = new System.Windows.Forms.ComboBox();
            this.tbGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.other_schedule2DataSet = new UniSchedule.other_schedule2DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbGroupsTableAdapter = new UniSchedule.other_schedule2DataSetTableAdapters.tbGroupsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.other_schedule2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGroups
            // 
            this.cbGroups.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbGroupsBindingSource, "NameGroups", true));
            this.cbGroups.FormattingEnabled = true;
            this.cbGroups.Location = new System.Drawing.Point(152, 63);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.Size = new System.Drawing.Size(161, 21);
            this.cbGroups.TabIndex = 0;
            this.cbGroups.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
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
            this.label1.Location = new System.Drawing.Point(71, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz grupę";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(74, 148);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 225);
            this.listBox1.TabIndex = 2;
            // 
            // tbGroupsTableAdapter
            // 
            this.tbGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Załaduj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Powrót";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ScheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 453);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGroups);
            this.Name = "ScheduleView";
            this.Text = "ScheduleView";
            this.Load += new System.EventHandler(this.ScheduleView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.other_schedule2DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private other_schedule2DataSet other_schedule2DataSet;
        private System.Windows.Forms.BindingSource tbGroupsBindingSource;
        private other_schedule2DataSetTableAdapters.tbGroupsTableAdapter tbGroupsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}