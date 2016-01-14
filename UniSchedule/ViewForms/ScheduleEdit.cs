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
    public partial class ScheduleEdit : Form
    {

        private DataSet dsHours;
        private DataSet dsSubjects;
        private DataSet dsInstructors;
        private static string connectionString = ConfigurationManager.ConnectionStrings["UniScheduleDB"].ConnectionString;

        public static ScheduleEdit SEInstance;
        public ScheduleEdit()
        {
            
            InitializeComponent();

           // lbSubjects.DataSource;
        }

        public string groupName;
        public string fieldOfStudy;

        public ScheduleEdit(string _groupName, string _fieldOfStudy)
        {
            this.groupName = _groupName;
            this.fieldOfStudy = _fieldOfStudy;
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void ScheduleEdit_Load(object sender, EventArgs e)
        {
            LoadSubjectsHours();
            LoadSubjects();

           // SetControlsVisibility();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           /* var menuForm = new MainMenu();
            Form.ActiveForm.Close();
            menuForm.Show(); */

            this.Close();
        }

       /* private void SetControlsVisibility()
        {
            if (this.groupName != null && this.fieldOfStudy != null)
            {
                lbGroupName.Visible = true;
                lbGroupName.Text = this.groupName;
                lbFieldOfStudies.Visible = true;
                lbFieldOfStudies.Text = this.fieldOfStudy;
                cbGroupName.Visible = false;
            }

            else
            {
                cbGroupName.Visible = true;
                lbGroupName.Visible = false;

            }
        } */

        private void btnDeleteFormSchedule_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {

        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subjectName = cbSubject.SelectedItem.ToString();

            StringBuilder getSubjectIdBySubjectNameQuery = new StringBuilder("SELECT id FROM tbSubjects WHERE LongName =");
            getSubjectIdBySubjectNameQuery.Append(subjectName);
            


        }

        private void LoadSubjectsHours()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT Hours_ FROM tbHours", conn);
            dsHours = new DataSet();
            daSearch.Fill(dsHours, "daSearch");
            cbHour.ValueMember = "Hours_";
            cbHour.DataSource = dsHours.Tables["daSearch"];
            cbHour.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHour.Enabled = true;
            conn.Close();
        }

        private void LoadSubjects()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT LongNamePl FROM tbSubjects", conn);
            dsSubjects = new DataSet();
            daSearch.Fill(dsSubjects, "daSearch");
            cbSubject.ValueMember = "LongName";
            cbSubject.DataSource = dsSubjects.Tables["daSearch"];
            cbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubject.Enabled = true;
            conn.Close();
        }

        private void LoadInstructors()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT LongName FROM tbSubjects", conn);
            dsSubjects = new DataSet();
            daSearch.Fill(dsSubjects, "daSearch");
            cbSubject.ValueMember = "LongName";
            cbSubject.DataSource = dsSubjects.Tables["daSearch"];
            cbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubject.Enabled = true;
            conn.Close();
        }

       /* private void LoadInstructorDependedOnSubject(int instructorId)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            StringBuilder getInstructorsNameByIdQuery = new StringBuilder("SELECT (Name + ' ' + Surname) AS Instructor FROM tbInstructors WHERE =");
            getInstructorsNameByIdQuery.Append(instructorId.ToString());

            SqlDataAdapter daSearch = new SqlDataAdapter(getInstructorsNameByIdQuery.ToString(), conn);
            dsInstructors = new DataSet();
            daSearch.Fill(dsSubjects, "daSearch");
            cbInstructor.ValueMember = "LongName";
            cbInstructor.DataSource = dsInstructors.Tables["daSearch"];
            cbInstructor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbInstructor.Enabled = true;
            conn.Close();
        } */

        private void cbInstructor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToSchedule_Click(object sender, EventArgs e)
        {

        }
    }
}
