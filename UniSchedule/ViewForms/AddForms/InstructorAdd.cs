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
        private static string connectionString = ConfigurationManager.ConnectionStrings["UniScheduleDB"].ConnectionString;
        

        public InstructorAdd()
        {
            InitializeComponent();
        }

        private void InstructorAdd_Load(object sender, EventArgs e)
        {
            AttachDataToDegreeId();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveInstructor_Click(object sender, EventArgs e)
        {
            AddInstructorToDB();
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
            MessageBox.Show("Connection opened");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Command Executed");
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
    }
}
