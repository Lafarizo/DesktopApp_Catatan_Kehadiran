using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance.Class;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Attendance
{
    public partial class LoginForm : Form
    {
        private Koneksi koneksi;
        MySqlConnection conn;

        public class Session
        {
            public static string loggedInEmail { get; private set; }

            public static string loggedInName { get; private set; }

            public static string loggedInEvent { get; private set; }

            public static void SetLoggedInUser(string email, string name, string event_)
            {
                loggedInEmail = email;
                loggedInName = name;
                loggedInEvent = event_;
            }

            public static void destroySession()
            {
                loggedInEmail = null;
            }
        }

        private bool verifyPass(string password, string encryptedPass)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                string passInput = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                return passInput == encryptedPass;
            }
        }

        public LoginForm()
        {
            InitializeComponent();

            koneksi = new Koneksi();
            conn = koneksi.conn;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = EmailBox.Text.Trim();
            string password = PasswordBox.Text.Trim();

            if (email != "" && password != "")
            {
                conn.Open();

                string query = "SELECT Password FROM users WHERE Username = @Username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", email);

                string encryptedPass = null;

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        encryptedPass = reader["Password"].ToString();
                    }
                }

                if (encryptedPass != null && verifyPass(password, encryptedPass))
                {
                    string getNama = "SELECT Nama FROM users WHERE Username = @Username";
                    string getPangkat = "SELECT Jabatan FROM users WHERE Username = @Username";
                    MySqlCommand getNamaCmd = new MySqlCommand(getNama, conn);
                    MySqlCommand getPangkatCmd = new MySqlCommand(getPangkat, conn);
                    getNamaCmd.Parameters.AddWithValue("@Username", email);
                    getPangkatCmd.Parameters.AddWithValue("@Username", email);

                    string nama = null;
                    string event_ = null;


                    using (MySqlDataReader getNamaReader = getNamaCmd.ExecuteReader())
                    {
                        if (getNamaReader.Read())
                        {
                            nama = getNamaReader["Nama"].ToString();
                        }
                    }

                    Session.SetLoggedInUser(email, nama, event_);

                    using (MySqlDataReader getPangkatReader = getPangkatCmd.ExecuteReader())
                    {
                        if (getPangkatReader.Read())
                        {
                            string pangkat = getPangkatReader["Jabatan"].ToString();

                            if (pangkat == "admin")
                            {
                                var adminWindow = new AdminWindow();
                                adminWindow.Show();
                                warning.Text = null;
                            }
                            else
                            {
                                var participantWindow = new ParticipantWindow();
                                participantWindow.Show();
                                warning.Text = null;
                            }
                            this.Hide();
                        }
                    }
                }
                else
                {
                    EmailBox.Text = null;
                    PasswordBox.Text = null;
                    string peringatan = "Email atau Password salah!";
                    MessageBox.Show(peringatan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
                conn.Close();
            }
            else
            {
                string peringatan = "Email dan Password harus diisi!";
                MessageBox.Show(peringatan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = '*';
        }

        private void passCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (passCheckbox.Checked)
            {
                PasswordBox.PasswordChar = '\0';
            }
            else
            {
                PasswordBox.PasswordChar = '*';
            }
        }
    }
}
