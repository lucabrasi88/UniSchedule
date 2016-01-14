using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniSchedule.ViewForms.StudentForms
{
    public partial class StudentMenu : Form
    {
        public string login = String.Empty;
        public string pass = String.Empty;
        public string email = String.Empty;


        public StudentMenu()
        {
            InitializeComponent();
        }

        public StudentMenu(string _login, string _pass, string _email)
        {
            this.login = _login;
            this.pass = _pass;
            this.email = _email;
        }

        private void btnSearchForm_Click(object sender, EventArgs e)
        {
            var scheduleViewerWindow = new ScheduleView();


            scheduleViewerWindow.ShowDialog();
        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnPassChange_Click(object sender, EventArgs e)
        {
            var passChangeWindow = new PasswordChange();


            passChangeWindow.ShowDialog();
        }
        
    }
}
