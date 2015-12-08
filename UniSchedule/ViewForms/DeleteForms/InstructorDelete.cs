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

namespace UniSchedule.ViewForms.DeleteForms
{
    public partial class InstructorDelete : Form
    {

        private DataSet dsInstructors;
        private static string connectionString = ConfigurationManager.ConnectionStrings["UniScheduleDB"].ConnectionString;

        public InstructorDelete()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InstructorDelete_Load(object sender, EventArgs e)
        {
            AttachDataToInstructorsList();
        }

        private void AttachDataToInstructorsList()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT Name, Surname FROM tbInstructors", conn);
            dsInstructors = new DataSet();
            daSearch.Fill(dsInstructors, "daSearch");
            cbInstructors.ValueMember = "Surname";
            cbInstructors.DataSource = dsInstructors.Tables["daSearch"];
            cbInstructors.DropDownStyle = ComboBoxStyle.DropDownList;
            cbInstructors.Enabled = true;
            conn.Close();

        }

        private void btnDeleteInstructor_Click(object sender, EventArgs e)
        {
           /* SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;


            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteInstructor";
            cmd.Parameters.AddWithValue("@LongName", cbSubjects.Text.ToString());
            conn.Open();
            MessageBox.Show("Connection opened");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Command Executed");
            AttachDataToInstructorsList()
            cbInstructors.Refresh();
            conn.Close(); */
        }
    }
}
