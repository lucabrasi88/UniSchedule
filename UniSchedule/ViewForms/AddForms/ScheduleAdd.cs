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
    public partial class ScheduleAdd : Form
    {

        private DataSet dsFieldsOfStudy;
        private static string connectionString = ConfigurationManager.ConnectionStrings["UniScheduleDB"].ConnectionString;

        public ScheduleAdd()
        {
            InitializeComponent();
            AttachDataToFieldsOfStudyCB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScheduleAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string groupName = txtGroupName.Text;
            string fieldOfStudy = txtFieldOfStudy.Text;

            var activeAddForm = new ScheduleAdd();
            var editForm = new ScheduleEdit(groupName, fieldOfStudy);
            Form.ActiveForm.Close();
            editForm.ShowDialog();
            

        }

        private void GetFieldValues()
        {
            /* txtGroupName.Text ?? string groupName = txtGroupName.Text : ;
            string fieldOfStudy = txtFieldOfStudy.Text; */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFieldOfStudy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AttachDataToFieldsOfStudyCB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT Name FROM tbFieldsOfStudy", conn);
            dsFieldsOfStudy = new DataSet();
            daSearch.Fill(dsFieldsOfStudy, "daSearch");
            txtFieldOfStudy.ValueMember = "Name";
            txtFieldOfStudy.DataSource = dsFieldsOfStudy.Tables["daSearch"];
            txtFieldOfStudy.DropDownStyle = ComboBoxStyle.DropDownList;
            txtFieldOfStudy.Enabled = true;

            conn.Close();
        
        
        }
    }
}
