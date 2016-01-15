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

namespace UniSchedule.ViewForms.StudentForms
{
    public partial class PasswordChange : Form
    {
        string login = string.Empty;
        string pass = string.Empty;

        
        private static string connectionString = ConfigurationManager.ConnectionStrings["UniScheduleDB"].ConnectionString;

        public PasswordChange()
        {
            InitializeComponent();
        }

        public PasswordChange(string _login, string _pass)
        {
            this.login = _login;
            this.pass = _pass;
            InitializeComponent();
            
        }

        private void PasswordChange_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
            textBox1.MaxLength = 10;

            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 10;
        }

        private void btnSaveNewPass_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;

            try
            {
                if (textBox1.Text.ToString() == pass)
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateUserPass";
                    cmd.Parameters.AddWithValue("@LoginUser", login);
                    cmd.Parameters.AddWithValue("@PasswordUser", textBox2.Text.ToString());
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hasło zmienione pomyślnie!");
                    conn.Close();
                }

                else
                {
                    MessageBox.Show("Niepoprawne dane!");
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
