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
    public partial class SubjectAdd : Form
    {

        private DataSet dsTypeOfSubject;
        private static string connectionString = ConfigurationManager.ConnectionStrings["UniScheduleDB"].ConnectionString;

        public SubjectAdd()
        {
            InitializeComponent();
        }

        private void SubjectAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'other_schedule2DataSet.tbTypesSubjects' table. You can move, or remove it, as needed.
            this.tbTypesSubjectsTableAdapter.Fill(this.other_schedule2DataSet.tbTypesSubjects);
            AttachDataToSubjectTypeCB();
            
        }

        private void AttachDataToSubjectTypeCB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT id FROM tbTypesSubjects", conn);
            dsTypeOfSubject = new DataSet();
            daSearch.Fill(dsTypeOfSubject, "daSearch");
            cbSubjectType.ValueMember = "id";
            cbSubjectType.DataSource = dsTypeOfSubject.Tables["daSearch"];
            cbSubjectType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubjectType.Enabled = true;

            

        }

        private void btnSaveSubject_Click(object sender, EventArgs e)
        {
            int subjectId;

            Int32.TryParse(cbSubjectType.Text, out subjectId);

            AddSubjectToDB(txtLongSubjectName.Text, txtShortSubjectName.Text, subjectId);
        }

        private void AddSubjectToDB(string subjectName, string subjectShortName, int typeSubjectId)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddNewSubject";
            cmd.Parameters.AddWithValue("@LongName", subjectName);
            cmd.Parameters.AddWithValue("@ShortName", subjectShortName);
            cmd.Parameters.AddWithValue("@TypeSubjectId", typeSubjectId);
            conn.Open();
            MessageBox.Show("Connection opened");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Command Executed");
            conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSubjectType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
