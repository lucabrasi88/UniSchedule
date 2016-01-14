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

namespace UniSchedule
{
    public partial class ScheduleView : Form
    {

       // private DataSet dsGroups;
        private DataSet dsId;
        private DataSet dsYears;
        private DataSet dsFields;
        private DataSet dsInstructor;
        private static string connectionString = ConfigurationManager.ConnectionStrings["UniScheduleDB"].ConnectionString;

        public ScheduleView()
        {
            
            InitializeComponent();
            
        }

        private void ScheduleView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'other_schedule2DataSet.tbGroups' table. You can move, or remove it, as needed.
           // this.tbGroupsTableAdapter.Fill(this.other_schedule2DataSet.tbGroups);
            AttachAllFields();
        }

       /* private void AttachGroupsFromDB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT NameGroups FROM tbGroups", conn);
            dsGroups = new DataSet();
            daSearch.Fill(dsGroups, "daSearch");
            cbYearsOfStudies.ValueMember = "NameGroups";
            cbYearsOfStudies.DataSource = dsGroups.Tables["daSearch"];
            cbYearsOfStudies.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYearsOfStudies.Enabled = true;

            conn.Close();
        } */

        private int GetFieldsOfStudyIdByName(string fieldOfStudyName)
        {
            int fieldOfStudyId = 0;
            String selectIdByName = String.Empty;

            selectIdByName = "SELECT id FROM tbFieldsOfStudy WHERE Name = " + "'" + fieldOfStudyName + "'";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter(selectIdByName, conn);
            dsId = new DataSet();
            daSearch.Fill(dsId, "daSearch");
            conn.Close();
            Int32.TryParse(dsId.Tables[0].Rows[0][0].ToString(), out fieldOfStudyId);

            if (fieldOfStudyId != 0)
                return fieldOfStudyId;
            else throw new InvalidOperationException();


        }

        private int GetYearOfStudyIdByName(string yearOfStudyName)
        {
            int yearOfStudyId = 0;
            String selectIdByName = String.Empty;

            selectIdByName = "SELECT id FROM tbYearOfStudy WHERE YearOfStudyName = " + "'" + yearOfStudyName + "'";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter(selectIdByName, conn);
            dsId = new DataSet();
            daSearch.Fill(dsId, "daSearch");
            conn.Close();
            Int32.TryParse(dsId.Tables[0].Rows[0][0].ToString(), out yearOfStudyId);

            if (yearOfStudyId != 0)
                return yearOfStudyId;
            else throw new InvalidOperationException();


        }

        private void SearchSchedule()
        {
            listBox1.Items.Clear();

            int fieldOfStudyId = GetFieldsOfStudyIdByName(cbFieldOfStudy.Text.ToString());
            int yearOfStudyId = GetYearOfStudyIdByName(cbYearsOfStudies.Text.ToString());

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SearchSchedule";

            SqlParameter dateFrom = new SqlParameter("@DateFrom", SqlDbType.Date);
            SqlParameter dateTo = new SqlParameter("@DateTo", SqlDbType.Date);

            dateFrom.Value = dtpFrom.Value;
            dateTo.Value = dtpTo.Value;

            cmd.Parameters.Add(dateFrom);
            cmd.Parameters.Add(dateTo);
            cmd.Parameters.AddWithValue("@SurnameInstructors", cbInstructor.Text.ToString());
            cmd.Parameters.AddWithValue("@YearOfStudy", yearOfStudyId);
            cmd.Parameters.AddWithValue("@FieldsOfStudy", fieldOfStudyId);
            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(ds, "myTable");
            dt = ds.Tables["myTable"];
            MessageBox.Show("Procedura rozpoczęta");
            cmd.ExecuteNonQuery();
            foreach (DataRow row in dt.Rows)
            {
                listBox1.Items.Add(row["Date"].ToString() + " - " + row["Hours"].ToString() + " - " + row["Name Groups"].ToString() + " - " + row["Subject"].ToString() + " - " + row["Type subject"].ToString() + " - " + row["Surname"].ToString() + " - " + row["Field of study"].ToString());
            }
            MessageBox.Show("Zapis zakończony powodzeniem!");
           // listBox1.DataSource = dt;
            
            cmd.Dispose();
            conn.Close();

            

        }

        private void AttachYearsOfStudiesFromDB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT YearOfStudyName FROM tbYearOfStudy", conn);
            dsYears = new DataSet();
            daSearch.Fill(dsYears, "daSearch");
            cbYearsOfStudies.ValueMember = "YearOfStudyName";
            cbYearsOfStudies.DataSource = dsYears.Tables["daSearch"];
            cbYearsOfStudies.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYearsOfStudies.Enabled = true;
            conn.Close();
        }

        private void AttachFieldsOfStudiesFromDB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT Name FROM tbFieldsofStudy", conn);
            dsFields = new DataSet();
            daSearch.Fill(dsFields, "daSearch");
            cbFieldOfStudy.ValueMember = "Name";
            cbFieldOfStudy.DataSource = dsFields.Tables["daSearch"];
            cbFieldOfStudy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFieldOfStudy.Enabled = true;
            conn.Close();
        }

        private void AttachInstructorsSurnamesFromDB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT Surname FROM tbInstructors", conn);
            dsInstructor = new DataSet();
            daSearch.Fill(dsInstructor, "daSearch");
            cbInstructor.ValueMember = "Surname";
            cbInstructor.DataSource = dsInstructor.Tables["daSearch"];
            cbInstructor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbInstructor.Enabled = true;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            this.Close();


        }

        private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchSchedule();
        }

        private void AttachAllFields()
        {
            AttachFieldsOfStudiesFromDB();
            AttachInstructorsSurnamesFromDB();
            AttachYearsOfStudiesFromDB();
        }
    }
}
