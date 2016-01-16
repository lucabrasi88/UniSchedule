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
          //  this.tbTypesSubjectsTableAdapter.Fill(this.other_schedule2DataSet.tbTypesSubjects);
            // AttachDataToSubjectTypeCB();
            
        }

      /*  private void AttachDataToSubjectTypeCB()
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

            

        } */

        private void btnSaveSubject_Click(object sender, EventArgs e)
        {
            RestoreValidFields();

            if (ValidateSubjectData())
            {
                 AddSubjectToDB(txtLongSubjectName.Text, txtShortSubjectName.Text, txtEnglishName.Text);
            }
        }

        private void AddSubjectToDB(string subjectName, string subjectShortName, string subjectEnglishName)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;

            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddNewSubject";
                cmd.Parameters.AddWithValue("@LongNamePl", subjectName);
                cmd.Parameters.AddWithValue("@ShortName", subjectShortName);
                cmd.Parameters.AddWithValue("@EnglishName", subjectEnglishName);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Przedmiot zapisano pomyślnie.");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd!");
            }

            txtLongSubjectName.Clear();
            txtShortSubjectName.Clear();
            txtEnglishName.Clear();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSubjectType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateSubjectData()
        {
            bool valid = true;

            if (String.IsNullOrEmpty(txtLongSubjectName.Text.ToString()))
            {
                valid = false;
                txtLongSubjectName.BackColor = Color.Red;
            }

            if (String.IsNullOrEmpty(txtShortSubjectName.Text.ToString()))
            {
                valid = false;
                txtShortSubjectName.BackColor = Color.Red;
            }

            if (String.IsNullOrEmpty(txtEnglishName.Text.ToString()))
            {
                valid = false;
                txtEnglishName.BackColor = Color.Red;
            }

            if (valid == false)
                MessageBox.Show("Uzupełnij wymagane pola!", "Uwaga!", MessageBoxButtons.OK);

            return valid;
        }

        private void RestoreValidFields()
        {
            txtLongSubjectName.BackColor = Color.White;
            txtShortSubjectName.BackColor = Color.White;
            txtEnglishName.BackColor = Color.White;
        }

    }
}
