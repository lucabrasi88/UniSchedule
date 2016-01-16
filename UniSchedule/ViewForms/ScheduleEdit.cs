﻿using System;
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
        private DataSet dsInsSub;
        private DataSet dsInstructors;
        private DataSet dsGroupNames;
        private DataSet dsClassrooms;
        private DataSet dsMeetings;
        private static string connectionString = ConfigurationManager.ConnectionStrings["UniScheduleDB"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
            
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
            AttachDataToClassrooms();
            AttachDataToGroupName();
            AttachDataToHours();
            AttachDataToInsSub();
            AttachDataToMeetings();
            

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
            DataRow rowClassroom = ((DataTable)cbClassroom.DataSource).Rows[cbClassroom.SelectedIndex];
            int classroomId = (int)rowClassroom["id"];
            DataRow rowGroup = ((DataTable)cbGroupName.DataSource).Rows[cbGroupName.SelectedIndex];
            int groupId = (int)rowGroup["id"];
            DataRow rowHour = ((DataTable)cbHour.DataSource).Rows[cbHour.SelectedIndex];
            int hourId = (int)rowHour["id"];
            DataRow rowMeeting = ((DataTable)cbDay.DataSource).Rows[cbDay.SelectedIndex];
            int meetingId = (int)rowMeeting["id"];
            DataRow rowSubInst = ((DataTable)cbSubject.DataSource).Rows[cbSubject.SelectedIndex];
            int subjectId = (int)rowSubInst["id"];

            try
            {
                SqlCommand comm = new SqlCommand("ValidationSchedule", conn);
                comm.Parameters.AddWithValue("@ClassroomId", classroomId.ToString());
                comm.Parameters.AddWithValue("@GroupsId", groupId.ToString());
                comm.Parameters.AddWithValue("@HoursId", hourId.ToString());
                comm.Parameters.AddWithValue("@MeetingsId", meetingId.ToString());
                comm.Parameters.AddWithValue("@SubInstId ", subjectId.ToString());
                comm.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlParameter returnParameter = comm.Parameters.Add("@Variable", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                comm.ExecuteNonQuery();
                int id = (int)returnParameter.Value;

                    if (id == 0)
                        MessageBox.Show("Wykładowca ma już zajęcia o tej godzinie!");
                    else if(id == 2)
                        MessageBox.Show("Nie można zapisać! Istnieje już taka pozycja w systemie.");
                    else if(id == 3)
                        MessageBox.Show("Sala już jest zajęta o tej godzinie!");
                    else if(id == 1)
                        MessageBox.Show("Zapisano pomyślnie!");
            }

            catch
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd!");
            }

            finally
            {
                conn.Close();
            }
        }

        private void AttachDataToHours()
        {
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM tbHours", conn);
            dsHours = new DataSet();
            daSearch.Fill(dsHours, "daHours");
            cbHour.ValueMember = "id";
            cbHour.DisplayMember = "Hours_";
            cbHour.DataSource = dsHours.Tables["daHours"];
            cbHour.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHour.Enabled = true;
            conn.Close();
        
        }

        private void AttachDataToGroupName()
        {
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM [ViewGroups]", conn);
            dsGroupNames = new DataSet();
            daSearch.Fill(dsGroupNames, "daGroupNames");
            cbGroupName.ValueMember = "id";
            cbGroupName.DisplayMember = "Text";
            cbGroupName.DataSource = dsGroupNames.Tables["daGroupNames"];
            cbGroupName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGroupName.Enabled = true;
            conn.Close();

        }

        private void AttachDataToClassrooms()
        {
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM tbClassroom", conn);
            dsClassrooms = new DataSet();
            daSearch.Fill(dsClassrooms, "daClassrooms");
            cbClassroom.ValueMember = "id";
            cbClassroom.DisplayMember = "Number";
            cbClassroom.DataSource = dsClassrooms.Tables["daClassrooms"];
            cbClassroom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClassroom.Enabled = true;
            conn.Close();

        }

        private void AttachDataToMeetings()
        {
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM [ViewMeetings]", conn);
            dsMeetings = new DataSet();
            daSearch.Fill(dsMeetings, "daMeetings");
            cbDay.ValueMember = "id";
            cbDay.DisplayMember = "Date";
            cbDay.DataSource = dsMeetings.Tables["daMeetings"];
            cbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDay.Enabled = true;
            conn.Close();

        }

        private void AttachDataToInsSub()
        {
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT * FROM [ViewInsSubj]", conn);
            dsInsSub = new DataSet();
            daSearch.Fill(dsInsSub, "daInsSub");
            cbSubject.ValueMember = "id";
            cbSubject.DisplayMember = "Text";
            cbSubject.DataSource = dsInsSub.Tables["daInsSub"];
            cbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSubject.Enabled = true;
            conn.Close();

        }

        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
