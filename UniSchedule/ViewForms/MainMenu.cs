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
using UniSchedule.ViewForms.DeleteForms;

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

            var scheduleEditWindow = new ScheduleEdit();

            //  mmForm.Close();
            scheduleEditWindow.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var scheduleEditWindow = new ScheduleEdit();

          //  mmForm.Close();
            scheduleEditWindow.ShowDialog();
            
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
            else if(rbSubject.Checked == true)
            {
                var subjectAddForm = new SubjectAdd();
                subjectAddForm.ShowDialog();
            }
            else if (rbNewGroup.Checked == true)
            {
                var groupAddForm = new GroupAdd();
                groupAddForm.ShowDialog();
            }
            else if (rbNewMeeting.Checked == true)
            {
                var meetingAddForm = new MeetingAdd();
                meetingAddForm.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rbDeleteInstructorChoice.Checked == true)
            {
                var instructorDeleteForm = new InstructorDelete();
                instructorDeleteForm.ShowDialog();
            }
            else
            {
                var subjectDeleteForm = new SubjectDelete();
                subjectDeleteForm.ShowDialog();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void rbInstructor_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
