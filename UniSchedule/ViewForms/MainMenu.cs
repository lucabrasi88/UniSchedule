using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniSchedule.ViewForms.AddForms;

namespace UniSchedule
{
    public partial class MainMenu : Form
    {

      //  MainMenu mmForm;

        public MainMenu()
        {
           // mmForm = new MainMenu();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var scheduleAddWindow = new ScheduleAdd();
           // mmForm.Close();

            scheduleAddWindow.ShowDialog(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* var scheduleEditWindow = new ScheduleEdit();

          //  mmForm.Close();
            scheduleEditWindow.ShowDialog(); */
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var scheduleViewerWindow = new ScheduleView();
            

            scheduleViewerWindow.ShowDialog();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            if (rbInstructor.Checked == true)
            {
                var instructorAddForm = new InstructorAdd();
                instructorAddForm.ShowDialog();
            }
            else
            {
                var subjectAddForm = new SubjectAdd();
                subjectAddForm.ShowDialog();
            }

        }
    }
}
