using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniSchedule.ViewForms.AddForms
{
    public partial class MeetingAdd : Form
    {
        SqlCommand comm = new SqlCommand();
        SqlConnection con = new SqlConnection(connectionString);
        private static string connectionString = ConfigurationManager.ConnectionStrings["UniScheduleDB"].ConnectionString;

        public MeetingAdd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
           {
                comm = new SqlCommand("AddDateMeetings", con);
                this.comm.Parameters.AddWithValue("@Date", dtpMeeting.Value);
                this.comm.CommandType = CommandType.StoredProcedure;
                con.Open();
                comm.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. Spróbuj ponownie");
            }
        }
    }
}
