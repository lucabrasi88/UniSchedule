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

            DataTable dt = new DataTable();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM [ViewInstructors]", conn);
            dsInstructors = new DataSet();
            daSearch.Fill(dsInstructors, "daInstructors");
            dt = dsInstructors.Tables["daInstructors"];
            cbInstructors.ValueMember = "id";
            cbInstructors.DisplayMember = "Text";
            cbInstructors.DataSource = dt;
            cbInstructors.DropDownStyle = ComboBoxStyle.DropDownList;
            cbInstructors.Enabled = true;
            conn.Close();

        }

        private void btnDeleteInstructor_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;

            try
            {
                SqlCommand comm;

                DataRow row = ((DataTable)cbInstructors.DataSource).Rows[cbInstructors.SelectedIndex];
                int Id = (int)row["id"];

                comm = new SqlCommand("DellInstructorsAndSubjectInstructor", con);
                comm.Parameters.AddWithValue("@IdInstructor", Id.ToString());
                comm.CommandType = CommandType.StoredProcedure;
                con.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Usunięto wykładowcę!");
                
            }

            catch
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd!");
            }

            finally
            {
                con.Close();
            }

            AttachDataToInstructorsList();
        }

        private void AttachDataToFieldId()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            DataTable dt = new DataTable();
            DataSet dsField = new DataSet();


            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT id, Name FROM tbFieldsOfStudy", conn);

            daSearch.Fill(dsField, "fieldTable");
            dt = dsField.Tables["fieldTable"];
            cbInstructors.ValueMember = "id";
            cbInstructors.DisplayMember = "Name";
            // cbDegree.DataSource = dsDegreeId.Tables["daSearch"];
            cbInstructors.DataSource = dt;
            cbInstructors.DropDownStyle = ComboBoxStyle.DropDownList;
            cbInstructors.Enabled = true;
        }

        private void cbInstructors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
