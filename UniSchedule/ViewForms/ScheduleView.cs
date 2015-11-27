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

        private DataSet dsGroups;
        private static string connectionString = ConfigurationManager.ConnectionStrings["UniScheduleDB"].ConnectionString;

        public ScheduleView()
        {
            
            InitializeComponent();
            AttachGroupsFromDB();
        }

        private void ScheduleView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'other_schedule2DataSet.tbGroups' table. You can move, or remove it, as needed.
            this.tbGroupsTableAdapter.Fill(this.other_schedule2DataSet.tbGroups);

        }

        private void AttachGroupsFromDB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();

            SqlDataAdapter daSearch = new SqlDataAdapter("SELECT NameGroups FROM tbGroups", conn);
            dsGroups = new DataSet();
            daSearch.Fill(dsGroups, "daSearch");
            cbGroups.ValueMember = "NameGroups";
            cbGroups.DataSource = dsGroups.Tables["daSearch"];
            cbGroups.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGroups.Enabled = true;

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();


        }

        private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
