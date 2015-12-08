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
            this.tbSubjectsTableAdapter.Fill(this.other_schedule2DataSet.tbSubjects);
            AttachDataToDegreeId();
            AttachDataToSubjectsList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveInstructor_Click(object sender, EventArgs e)
        {
            RestoreValidFields();

            if (ValidateInstructorData())
            {
                if (listbSubjects.Items.Count == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Czy chcesz zapisać wykładowcę bez podpiętych przedmiotów?", "Brak podpiętych przedmiotów!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        AddInstructorToDB();
                        ClearAllInstructorData();
                    }
                    else this.Close();
                }
            }
            
            
        }

        private void AddInstructorToDB()
        {
            string[] instructorDataToSave = GetAllInstructorData().ToArray();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddNewInstructors";
            cmd.Parameters.AddWithValue("@Name", instructorDataToSave[0]);
            cmd.Parameters.AddWithValue("@Surname", instructorDataToSave[1]);
            cmd.Parameters.AddWithValue("@IdDegree", instructorDataToSave[2]);
            cmd.Parameters.AddWithValue("@OfficeNo", instructorDataToSave[3]);
            cmd.Parameters.AddWithValue("@Email", instructorDataToSave[4]);
            cmd.Parameters.AddWithValue("@Phone1", instructorDataToSave[5]);
            cmd.Parameters.AddWithValue("@Phone2", instructorDataToSave[6]);
            conn.Open();
            MessageBox.Show("Procedura rozpoczęta");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Zapis zakończony powodzeniem!");
            conn.Close();

            
            int instructorId = GetInstructorIdByEmail(instructorDataToSave[4]);

            foreach (var subject in listbSubjects.Items)
            {
                int subjectId = GetSubjectIdBySubjectName(subject.ToString());
                SaveInstructorsSubjectsDependencies(instructorId, subjectId);
            }

        }

        private void SaveInstructorsSubjectsDependencies(int instId, int subId)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddSubIns";
            cmd.Parameters.AddWithValue("@IdSub", subId);
            cmd.Parameters.AddWithValue("@IdIns", instId);
            conn.Open();
            MessageBox.Show("Procedura rozpoczęta");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Zapis zakończony powodzeniem!");
            conn.Close();
        }

        private List<string> GetAllInstructorData()
        {
            List<string> instructorData = new List<string>();

            instructorData.Add(txtName.Text);
            instructorData.Add(txtSurname.Text);
            instructorData.Add(cbDegree.Text.ToString());
            instructorData.Add(txtRoomNo.Text.ToString());
            instructorData.Add(txtEmail.Text);
            instructorData.Add(txtPhoneOne.Text);
            instructorData.Add(txtPhoneTwo.Text);

            return instructorData;
        }

        private void AttachDataToDegreeId()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT id FROM tbDegree", conn);
            dsDegreeId = new DataSet();
            daSearch.Fill(dsDegreeId, "daSearch");
            cbDegree.ValueMember = "id";
            cbDegree.DataSource = dsDegreeId.Tables["daSearch"];
            cbDegree.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDegree.Enabled = true;

            
        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AttachDataToSubjectsList()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT LongName FROM tbSubjects", conn);
            dsSubjects = new DataSet();
            daSearch.Fill(dsSubjects, "daSearch");
            cbSubjects.ValueMember = "LongName";
            cbSubjects.DataSource = dsSubjects.Tables["daSearch"];
            cbSubjects.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubjects.Enabled = true;
            conn.Close();
            
        }

        private void AttachDataToSubjectTypesList()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT NameTypes FROM tbTypesSubjects", conn);
            dsSubjectTypes = new DataSet();
            daSearch.Fill(dsSubjectTypes, "daSearch");
            cbSubjectTypes.ValueMember = "NameTypes";
            cbSubjectTypes.DataSource = dsSubjects.Tables["daSearch"];
            cbSubjectTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubjectTypes.Enabled = true;
            conn.Close();

        }

        private void cbDegree_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if(!listbSubjects.Items.Contains(cbSubjects.SelectedValue.ToString()))
                listbSubjects.Items.Add(cbSubjects.SelectedValue.ToString());
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            listbSubjects.Items.Remove(listbSubjects.SelectedItem);
        }

        private void AttachInstructorToSubjects(string instructorUniqueEmail, List<string> attachedSubjects, List<string> attachedSubjectsTypes)
        {

        }

        private int GetInstructorIdByEmail(string instructorEmail)
        {
            int instructorId = 0;
            String selectIdByEmail = String.Empty;

            selectIdByEmail = "SELECT id FROM tbInstructors WHERE Email = " + "'" + instructorEmail + "'";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter(selectIdByEmail, conn);
            dsId = new DataSet();
            daSearch.Fill(dsId, "daSearch");
            conn.Close();
            Int32.TryParse(dsId.Tables[0].Rows[0][0].ToString(), out instructorId);
         
            if (instructorId != 0)
                return instructorId;
            else throw new InvalidOperationException();
                 

        }

        private int GetSubjectIdBySubjectName(string subjectName)
        {
            int subjectId = 0;
            String selectIdBySubjectName;

            selectIdBySubjectName = "SELECT id FROM tbSubjects WHERE LongName = " + "'" + subjectName + "'";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter(selectIdBySubjectName, conn);
            dsId = new DataSet();
            daSearch.Fill(dsId, "daSearch");
            conn.Close();
            Int32.TryParse(dsId.Tables[0].Rows[0][0].ToString(), out subjectId);

            if (subjectId != 0)
                return subjectId;
            else throw new InvalidOperationException();
        }

       /* private int GetSubjectTypeIdBySubjectType(string subjectType)
        {
            int subjectType = 0;
            String selectIdBysubjectType;

            selectIdByEmail = "SELECT id FROM tbTypesSubjects WHERE NameTypes = " + instructorEmail;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter(selectIdByEmail, conn);
            dsId = new DataSet();
            daSearch.Fill(dsSubjects, "daSearch");
            conn.Close();
            Int32.TryParse(daSearch.ToString(), out instructorId);

            if (instructorId != 0)
                return instructorId;
            else throw new InvalidOperationException();
                 
        } */

        private void cbSubjectTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateInstructorData()
        {
            bool valid = true;

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
            txtPhoneTwo.Text = String.Empty;
            txtRoomNo.Text = String.Empty;
            listbSubjects.Items.Clear();
        }

        private void RestoreValidFields()
        {
            txtName.BackColor = Color.White;
            txtSurname.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
        }

    }
}
