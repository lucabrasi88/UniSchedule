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
    public partial class GroupAdd : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["UniScheduleDB"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand comm;

        public GroupAdd()
        {
            InitializeComponent();
        }

        private void GroupAdd_Load(object sender, EventArgs e)
        {
            AttachDataToFieldId();
            AttachDataToYearId();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> fosData = GetAllFieldsOfStudiesData();

                if (!fosData.Any(x => String.IsNullOrEmpty(x)))
                {
                    comm = new SqlCommand("ValidationGroups", con);
                    this.comm.Parameters.AddWithValue("@Groups", fosData[0]);
                    this.comm.Parameters.AddWithValue("@IdField", fosData[1]);
                    this.comm.Parameters.AddWithValue("@IdYear", fosData[2]);
                    this.comm.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlParameter returnParameter = comm.Parameters.Add("@Error", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    comm.ExecuteNonQuery();
                    int id = (int)returnParameter.Value;

                    if (id == 1)
                        MessageBox.Show("Podana data już istnieje w bazie danych!");
                    else MessageBox.Show("Data zapisana poprawnie!");
                }

                else MessageBox.Show("Przed zapisem wypełnij wszystkie pola!");

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
            cbFieldOfStudies.ValueMember = "id";
            cbFieldOfStudies.DisplayMember = "Name";
            // cbDegree.DataSource = dsDegreeId.Tables["daSearch"];
            cbFieldOfStudies.DataSource = dt;
            cbFieldOfStudies.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFieldOfStudies.Enabled = true;
        }

        private void AttachDataToYearId()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();


            DataTable dt = new DataTable();
            DataSet dsYear = new DataSet();


            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT id, YearOfStudyName FROM tbYearOfStudy", conn);

            daSearch.Fill(dsYear, "yearTable");
            dt = dsYear.Tables["yearTable"];
            cbYearOfStudies.ValueMember = "id";
            cbYearOfStudies.DisplayMember = "YearOfStudyName";
            // cbDegree.DataSource = dsDegreeId.Tables["daSearch"];
            cbYearOfStudies.DataSource = dt;
            cbYearOfStudies.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYearOfStudies.Enabled = true;
        }

        private List<string> GetAllFieldsOfStudiesData()
        {
            List<string> fieldsOfStudiesData = new List<string>();

            DataRow rowField = ((DataTable)cbFieldOfStudies.DataSource).Rows[cbFieldOfStudies.SelectedIndex];
            int fieldId = (int)rowField["id"];

            DataRow rowYear = ((DataTable)cbYearOfStudies.DataSource).Rows[cbYearOfStudies.SelectedIndex];
            int yearId = (int)rowYear["id"];

            fieldsOfStudiesData.Add(txtGroupName.Text.ToString());
            fieldsOfStudiesData.Add(fieldId.ToString());
            fieldsOfStudiesData.Add(yearId.ToString());
            


            return fieldsOfStudiesData;
        }
    }
}
