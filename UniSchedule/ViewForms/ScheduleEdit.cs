using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniSchedule
{
    public partial class ScheduleEdit : Form
    {
        public static ScheduleEdit SEInstance;
        public ScheduleEdit()
        {
            
            InitializeComponent();

           // lbSubjects.DataSource;
        }

        public string groupName;
        public string fieldOfStudy;

        public ScheduleEdit(string _groupName, string _fieldOfStudy)
        {
            this.groupName = _groupName;
            this.fieldOfStudy = _fieldOfStudy;
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void ScheduleEdit_Load(object sender, EventArgs e)
        {
            SetControlsVisibility();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           /* var menuForm = new MainMenu();
            Form.ActiveForm.Close();
            menuForm.Show(); */

            this.Close();
        }

        private void SetControlsVisibility()
        {
            if (this.groupName != null && this.fieldOfStudy != null)
            {
                lbGroupName.Visible = true;
                lbGroupName.Text = this.groupName;
                lbFieldOfStudies.Visible = true;
                lbFieldOfStudies.Text = this.fieldOfStudy;
                cbGroupName.Visible = false;
            }

            else
            {
                cbGroupName.Visible = true;
                lbGroupName.Visible = false;

            }
        }

        private void btnDeleteFormSchedule_Click(object sender, EventArgs e)
        {
            lbDailySchedule.SelectedItems.Remove(lbDailySchedule.SelectedItem);
            lbDailySchedule.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {

        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
