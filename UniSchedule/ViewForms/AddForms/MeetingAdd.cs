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
                

                comm = new SqlCommand("ValidationMeetings", con);
                comm.Parameters.AddWithValue("@Date", dtpMeeting.Value.Date);
                comm.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlParameter returnParameter = comm.Parameters.Add("@Error", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                comm.ExecuteNonQuery();
                int id = (int)returnParameter.Value;

                if (id == 1)
                    MessageBox.Show("Podana data już istnieje w bazie danych!");
                else MessageBox.Show("Data zapisana poprawnie!");

                con.Close();
            }
            catch
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd!");
            }
        }
    }
}
