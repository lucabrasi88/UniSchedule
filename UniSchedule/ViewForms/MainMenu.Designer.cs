namespace UniSchedule
{
    partial class MainMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gbAdding = new System.Windows.Forms.GroupBox();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.rbInstructor = new System.Windows.Forms.RadioButton();
            this.rbSubject = new System.Windows.Forms.RadioButton();
            this.gbDeleting = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rbDeleteInstructorChoice = new System.Windows.Forms.RadioButton();
            this.rbDeleteSubjectChoice = new System.Windows.Forms.RadioButton();
            this.gbAdding.SuspendLayout();
            this.gbDeleting.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Przeglądaj plan zajęć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dodaj plan zajęć";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edytuj plan zajęć";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Zamknij";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // gbAdding
            // 
            this.gbAdding.Controls.Add(this.btnAddNewItem);
            this.gbAdding.Controls.Add(this.rbInstructor);
            this.gbAdding.Controls.Add(this.rbSubject);
            this.gbAdding.Location = new System.Drawing.Point(312, 71);
            this.gbAdding.Name = "gbAdding";
            this.gbAdding.Size = new System.Drawing.Size(172, 149);
            this.gbAdding.TabIndex = 4;
            this.gbAdding.TabStop = false;
            this.gbAdding.Text = "Szybkie dodawanie";
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(19, 104);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewItem.TabIndex = 2;
            this.btnAddNewItem.Text = "Dodaj";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // rbInstructor
            // 
            this.rbInstructor.AutoSize = true;
            this.rbInstructor.Location = new System.Drawing.Point(19, 66);
            this.rbInstructor.Name = "rbInstructor";
            this.rbInstructor.Size = new System.Drawing.Size(116, 17);
            this.rbInstructor.TabIndex = 1;
            this.rbInstructor.TabStop = true;
            this.rbInstructor.Text = "Nowy wykładowca";
            this.rbInstructor.UseVisualStyleBackColor = true;
            // 
            // rbSubject
            // 
            this.rbSubject.AutoSize = true;
            this.rbSubject.Location = new System.Drawing.Point(19, 42);
            this.rbSubject.Name = "rbSubject";
            this.rbSubject.Size = new System.Drawing.Size(100, 17);
            this.rbSubject.TabIndex = 0;
            this.rbSubject.TabStop = true;
            this.rbSubject.Text = "Nowy przedmiot";
            this.rbSubject.UseVisualStyleBackColor = true;
            // 
            // gbDeleting
            // 
            this.gbDeleting.Controls.Add(this.btnDelete);
            this.gbDeleting.Controls.Add(this.rbDeleteInstructorChoice);
            this.gbDeleting.Controls.Add(this.rbDeleteSubjectChoice);
            this.gbDeleting.Location = new System.Drawing.Point(542, 71);
            this.gbDeleting.Name = "gbDeleting";
            this.gbDeleting.Size = new System.Drawing.Size(172, 149);
            this.gbDeleting.TabIndex = 5;
            this.gbDeleting.TabStop = false;
            this.gbDeleting.Text = "Szybkie usuwanie";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(19, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rbDeleteInstructorChoice
            // 
            this.rbDeleteInstructorChoice.AutoSize = true;
            this.rbDeleteInstructorChoice.Location = new System.Drawing.Point(19, 66);
            this.rbDeleteInstructorChoice.Name = "rbDeleteInstructorChoice";
            this.rbDeleteInstructorChoice.Size = new System.Drawing.Size(114, 17);
            this.rbDeleteInstructorChoice.TabIndex = 1;
            this.rbDeleteInstructorChoice.TabStop = true;
            this.rbDeleteInstructorChoice.Text = "Usuń wykładowcę";
            this.rbDeleteInstructorChoice.UseVisualStyleBackColor = true;
            // 
            // rbDeleteSubjectChoice
            // 
            this.rbDeleteSubjectChoice.AutoSize = true;
            this.rbDeleteSubjectChoice.Location = new System.Drawing.Point(19, 42);
            this.rbDeleteSubjectChoice.Name = "rbDeleteSubjectChoice";
            this.rbDeleteSubjectChoice.Size = new System.Drawing.Size(98, 17);
            this.rbDeleteSubjectChoice.TabIndex = 0;
            this.rbDeleteSubjectChoice.TabStop = true;
            this.rbDeleteSubjectChoice.Text = "Usuń przedmiot";
            this.rbDeleteSubjectChoice.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 279);
            this.Controls.Add(this.gbDeleting);
            this.Controls.Add(this.gbAdding);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainMenu";
            this.Text = "UniSchedule";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.gbAdding.ResumeLayout(false);
            this.gbAdding.PerformLayout();
            this.gbDeleting.ResumeLayout(false);
            this.gbDeleting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox gbAdding;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.RadioButton rbInstructor;
        private System.Windows.Forms.RadioButton rbSubject;
        private System.Windows.Forms.GroupBox gbDeleting;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton rbDeleteInstructorChoice;
        private System.Windows.Forms.RadioButton rbDeleteSubjectChoice;
    }
}

