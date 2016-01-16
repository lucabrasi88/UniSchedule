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
    public partial class SubToSubTypeAdd : Form
    {

        private static string connectionString = ConfigurationManager.ConnectionStrings["UniScheduleDB"].ConnectionString;

        public SubToSubTypeAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;

            SqlCommand comm;

            DataRow rowSubject = ((DataTable)cbSubject.DataSource).Rows[cbSubject.SelectedIndex];
            int subjectId = (int)rowSubject["id"];

            DataRow rowSubjectType = ((DataTable)cbSubjectType.DataSource).Rows[cbSubjectType.SelectedIndex];
            int subjectTypeId = (int)rowSubjectType["id"];

            try
            {
                comm = new SqlCommand("ValidationSubToTypes", con);
                comm.Parameters.AddWithValue("@IdSubject", subjectId);
                comm.Parameters.AddWithValue("@idTypesSubject", subjectTypeId);
                comm.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlParameter returnParameter = comm.Parameters.Add("@Variable", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                comm.ExecuteNonQuery();
                int id = (int)returnParameter.Value;

                if (id == 0)
                    MessageBox.Show("Wiązanie już istnieje w bazie danych!");
                else MessageBox.Show("Zapisano poprawnie!");
            }
            catch
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd!");
            }
        }

        private void AttachDataToSubjectList()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            DataTable dt = new DataTable();
            DataSet dsSubjects;

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM tbSubjects", conn);
            dsSubjects = new DataSet();
            daSearch.Fill(dsSubjects, "daSubjects");
            dt = dsSubjects.Tables["daSubjects"];
            cbSubject.ValueMember = "id";
            cbSubject.DisplayMember = "LongNamePl";
            cbSubject.DataSource = dt;
            cbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubject.Enabled = true;
            conn.Close();

        }

        private void AttachDataToTypesList()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            DataTable dt = new DataTable();
            DataSet dsTypesSubjects;

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM tbTypesSubjects", conn);
            dsTypesSubjects = new DataSet();
            daSearch.Fill(dsTypesSubjects, "daTypesSubjects");
            dt = dsTypesSubjects.Tables["daTypesSubjects"];
            cbSubjectType.ValueMember = "id";
            cbSubjectType.DisplayMember = "NameTypes";
            cbSubjectType.DataSource = dt;
            cbSubjectType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubjectType.Enabled = true;
            conn.Close();

        }

        private void SubToSubTypeAdd_Load(object sender, EventArgs e)
        {
            AttachDataToSubjectList();
            AttachDataToTypesList();
        }

        private void cbSubjectType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
