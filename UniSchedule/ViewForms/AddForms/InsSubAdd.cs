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
    public partial class InsSubAdd : Form
    {

        private static string connectionString = ConfigurationManager.ConnectionStrings["UniScheduleDB"].ConnectionString;

        public InsSubAdd()
        {
            InitializeComponent();
        }

        private void InsSubAdd_Load(object sender, EventArgs e)
        {
            AttachDataToInstructorsList();
            AttachDataToSubjectList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;

            SqlCommand comm;

            DataRow rowInstructor = ((DataTable)cbInstructor.DataSource).Rows[cbInstructor.SelectedIndex];
            int instructorId = (int)rowInstructor["id"];

            DataRow rowSubject = ((DataTable)cbSubject.DataSource).Rows[cbSubject.SelectedIndex];
            int subjectId = (int)rowSubject["id"];

            try
           {
                comm = new SqlCommand("ValidationSubjectIbstructor", con);
                comm.Parameters.AddWithValue("@IdInstructor", instructorId);
                comm.Parameters.AddWithValue("@IdSubToSubTyp", subjectId);
                comm.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlParameter returnParameter = comm.Parameters.Add("@Error", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                comm.ExecuteNonQuery();
                int id = (int)returnParameter.Value;

                if (id == 1)
                    MessageBox.Show("Podana data już istnieje w bazie danych!");
                else MessageBox.Show("Data zapisana poprawnie!");
            }
            catch
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd!");
            }

            finally
            {
                con.Close();
            }
        }

        private void AttachDataToInstructorsList()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            DataTable dt = new DataTable();
            DataSet dsInstructors;

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM [ViewInstructors]", conn);
            dsInstructors = new DataSet();
            daSearch.Fill(dsInstructors, "daInstructors");
            dt = dsInstructors.Tables["daInstructors"];
            cbInstructor.ValueMember = "id";
            cbInstructor.DisplayMember = "Text";
            cbInstructor.DataSource = dt;
            cbInstructor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbInstructor.Enabled = true;
            conn.Close();

        }

        private void AttachDataToSubjectList()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            DataTable dt = new DataTable();
            DataSet dsSubjects;

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM [SubjectsAndView]", conn);
            dsSubjects = new DataSet();
            daSearch.Fill(dsSubjects, "daInstructors");
            dt = dsSubjects.Tables["daInstructors"];
            cbSubject.ValueMember = "id";
            cbSubject.DisplayMember = "Text";
            cbSubject.DataSource = dt;
            cbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubject.Enabled = true;
            conn.Close();

        }
    }
}
