using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniSchedule.Logging;
using UniSchedule.ViewForms.AddForms;
using UniSchedule.ViewForms.DeleteForms;

namespace UniSchedule
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InstructorDelete frmLogin = new InstructorDelete();
            frmLogin.Show();

            Application.Run();
            // Application.Run(new LoginForm());
        }
    }
}
