using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniSchedule.ViewForms.StudentForms;

namespace UniSchedule.Logging
{
    public partial class LoginForm : Form
    {
        SqlCommand comm = new SqlCommand();

        private static string connectionString = ConfigurationManager.ConnectionStrings["UniScheduleDB"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
       

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.ToString();
            string password = txtPass.Text.ToString();
           // AddNewUser(login, password);
            ValidateUser(login, password);
        }

        private void InitializePassTextBox()
        {
            txtPass.PasswordChar = '*';
            txtPass.MaxLength = 15;
        }

        private void ValidateUser(string login, string password)
        {

           /* SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string passEncrypted = PassEncryption(password);

            String query = "SELECT LoginUser, PasswordUser FROM tbLoginAndPassword WHERE (LoginUser = '" + login + "') AND (PasswordUser = '" + passEncrypted + "');";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader sqldr = cmd.ExecuteReader();
            if (sqldr.Read())
            {
                this.Close();
                MainMenu mm = new MainMenu();
                mm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Password or login incorrect!");
            }

            conn.Close();  
            */
            
           // DataSet ds = new DataSet("tbLoginAndPassword");

            comm = new SqlCommand("LoginUser", con);
            this.comm.Parameters.AddWithValue("@UserName", login);
            this.comm.Parameters.AddWithValue("@PasswordUser", password);
            this.comm.CommandType = CommandType.StoredProcedure;
            con.Open();
            comm.ExecuteNonQuery();

            SqlParameter parametr = new SqlParameter();
            object flag = comm.ExecuteScalar();
            int? zm = Convert.ToInt32(flag);

            SqlDataReader sqldr = comm.ExecuteReader();
            if (zm == 1)
            {
                if (login == "NameUserAdmin")
                {
                    this.Close();
                    MainMenu mm = new MainMenu();
                    mm.ShowDialog();
                }

                else
                {
                    this.Close();
                    StudentMenu sm = new StudentMenu();
                    sm.ShowDialog();
                }
            }
            else if (zm == 0)
            {
                MessageBox.Show("Brak użytkownika o takich danych!");

            }

            con.Close();
            
        }

        public string PassEncryption(String password)
        {
            MD5CryptoServiceProvider encryptionProvider = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();

            encrypt = encryptionProvider.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
             
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        } 

        private void AddNewUser(string login, string password)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddNewUsers";
            cmd.Parameters.AddWithValue("@LoginUser", login);
            cmd.Parameters.AddWithValue("@NameUser", "Admin");
            cmd.Parameters.AddWithValue("@EmailUser", "admin@wp.pl");
            cmd.Parameters.AddWithValue("@PasswordUser", password);
            conn.Open();
            MessageBox.Show("Procedura rozpoczęta");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Zapis użytkownika zakończony powodzeniem!");
            conn.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            InitializePassTextBox();
        }
    }
}
