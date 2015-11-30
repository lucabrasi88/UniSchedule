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

namespace UniSchedule.ViewForms.DeleteForms
{
    public partial class SubjectDelete : Form
    {

        private DataSet dsSubjects;
        private static string connectionString = ConfigurationManager.ConnectionStrings["UniScheduleDB"].ConnectionString;

        public SubjectDelete()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
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

        }

        private void SubjectDelete_Load(object sender, EventArgs e)
        {
            AttachDataToSubjectsList();
        }
    }
}
