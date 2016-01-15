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

    

    public partial class InstructorAdd : Form
    {

        private DataSet dsDegreeId;
        private DataSet dsSubjects;
        private DataSet dsId;
        private DataSet dsSubjectTypes;
        private static string connectionString = ConfigurationManager.ConnectionStrings["UniScheduleDB"].ConnectionString; 
        

        public InstructorAdd()
        {
            InitializeComponent();
        }

        private void InstructorAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'other_schedule2DataSet.tbSubjects' table. You can move, or remove it, as needed.
            // this.tbSubjectsTableAdapter.Fill(this.other_schedule2DataSet.tbSubjects);
            AttachDataToDegreeId();
         //   AttachDataToSubjectsList();
        }

      /*  private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        } */

        private void btnSaveInstructor_Click(object sender, EventArgs e)
        {
            // RestoreValidFields();

            if (ValidateInstructorData())
            {
                
                    AddInstructorToDB();
                
            }
            
            
        }

        private void AddInstructorToDB()
        {
            string[] instructorDataToSave = GetAllInstructorData().ToArray();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;

            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddNewInstructor";
                cmd.Parameters.AddWithValue("@Name", instructorDataToSave[0]);
                cmd.Parameters.AddWithValue("@Surname", instructorDataToSave[1]);
                cmd.Parameters.AddWithValue("@IdDegree", instructorDataToSave[2]);
                cmd.Parameters.AddWithValue("@OfficeNo", instructorDataToSave[3]);
                cmd.Parameters.AddWithValue("@Email", instructorDataToSave[4]);
                cmd.Parameters.AddWithValue("@Phone1", instructorDataToSave[5]);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Zapis zakończony powodzeniem!");
                conn.Close();
            }

            catch
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd!");
            }

            finally
            {
                RestoreValidFields();
            }
            
            

        }

       /* private void SaveInstructorsSubjectsDependencies(int instId, int subId)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;

            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddSubIns";
                cmd.Parameters.AddWithValue("@IdSub", subId);
                cmd.Parameters.AddWithValue("@IdSubToSubTyp", instId);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Zapis zakończony powodzeniem!");
                conn.Close();
            }

            catch
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. Spróbuj ponownie.");
            }
        } */

        private List<string> GetAllInstructorData()
        {
            List<string> instructorData = new List<string>();

            DataRow row = ((DataTable)cbDegree.DataSource).Rows[cbDegree.SelectedIndex];
            int Id = (int)row["id"];

            instructorData.Add(txtName.Text);
            instructorData.Add(txtSurname.Text);
            instructorData.Add(Id.ToString());
            instructorData.Add(txtRoomNo.Text.ToString());
            instructorData.Add(txtEmail.Text);
            instructorData.Add(txtPhoneOne.Text);
            

            return instructorData;
        }

        private void AttachDataToDegreeId()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            
            DataTable dt = new DataTable();
            

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT id, DegreeLong FROM tbDegree", conn);
            dsDegreeId = new DataSet();
            daSearch.Fill(dsDegreeId, "degreeTable");
            dt = dsDegreeId.Tables["degreeTable"];
            cbDegree.ValueMember = "id";
            cbDegree.DisplayMember = "DegreeLong";
           // cbDegree.DataSource = dsDegreeId.Tables["daSearch"];
            cbDegree.DataSource = dt;
            cbDegree.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDegree.Enabled = true;
            
            

            
        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        

        private void cbDegree_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            
        }

        private void AttachInstructorToSubjects(string instructorUniqueEmail, List<string> attachedSubjects, List<string> attachedSubjectsTypes)
        {

        }
       

        private void cbSubjectTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private bool ValidateInstructorData()
        {
            bool valid = true;
            RestoreValidFields();

            if (String.IsNullOrEmpty(txtName.Text.ToString()))
            {
                valid = false;
                txtName.BackColor = Color.Red;
            }

            if (String.IsNullOrEmpty(txtSurname.Text.ToString()))
            {
                valid = false;
                txtSurname.BackColor = Color.Red;
            }

            if (String.IsNullOrEmpty(txtEmail.Text.ToString()))
            {
                valid = false;
                txtEmail.BackColor = Color.Red;
            }

            if (String.IsNullOrEmpty(txtPhoneOne.Text.ToString()))
            {
                valid = false;
                txtPhoneOne.BackColor = Color.Red;
            }

            if (String.IsNullOrEmpty(txtRoomNo.Text.ToString()))
            {
                valid = false;
                txtRoomNo.BackColor = Color.Red;
            }

            if(valid == false)
                MessageBox.Show("Uzupełnij wymagane pola!", "Uwaga!", MessageBoxButtons.OK);

            return valid;
        }

        private void ClearAllInstructorData()
        {
            txtName.Text = String.Empty;
            txtSurname.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPhoneOne.Text = String.Empty;
            txtRoomNo.Text = String.Empty;
            
        }

        private void RestoreValidFields()
        {
            txtName.BackColor = Color.White;
            txtSurname.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            txtPhoneOne.BackColor = Color.White;
            txtRoomNo.BackColor = Color.White;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
