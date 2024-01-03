using Attendance.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attendance
{
    public partial class ManageAccounts : Form
    {
        private Koneksi koneksi;
        MySqlConnection conn;

        MySqlCommand checkUname = new MySqlCommand();
        MySqlCommand cmd = new MySqlCommand();
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        string adminName = LoginForm.Session.loggedInName;

        public ManageAccounts()
        {
            InitializeComponent();

            koneksi = new Koneksi();
            conn = koneksi.conn;
        }

        public string encryptPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashB = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashB).Replace("-", "").ToLower();
            }
        }

        public void updateTable()
        {
            conn.Open();
            string query = $"SELECT * FROM users WHERE Nama != '{adminName}'";
            cmd = new MySqlCommand(query, conn);

            adapter = new MySqlDataAdapter(cmd);
            dataTable = new DataTable();

            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            conn.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = EmailBox.Text.ToString();
            string nama = NamaBox.Text.ToString();
            string pangkat = PangkatBox.Text.ToString();
            string RAWpassword = PasswordBox.Text.ToString();
            string password = encryptPassword(RAWpassword);

            if (email != "" && nama != "" && pangkat != "" && password != "")
            {
                conn.Open();
                string check = $"SELECT COUNT(*) FROM users WHERE Username = '{email}'";
                checkUname = new MySqlCommand(check, conn);
                int userCount = Convert.ToInt32(checkUname.ExecuteScalar());

                    string register = $"INSERT INTO users (Username, Nama, Jabatan, Password) VALUES ('{email}', '{nama}', '{pangkat}', '{password}')";
                    cmd = new MySqlCommand(register, conn);
                    cmd.ExecuteNonQuery();
                    EmailBox.Clear();
                    NamaBox.Clear();
                    PangkatBox.Clear();
                    PasswordBox.Clear();
                conn.Close();

                updateTable();
            }
        }



        private void Register_Load(object sender, EventArgs e)
        {
            updateTable();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminWindow adminWindowInstance = new AdminWindow();
            adminWindowInstance.Show();

            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            IDBoxDel.Clear();
            idEdit.Clear();
            namaEdit.Clear();
            pangkatEdit.Clear();
            emailEdit.Clear();
            passEdit.Clear();
            NamaBox.Clear();
            PangkatBox.Clear();
            EmailBox.Clear();
            PasswordBox.Clear();
            periksaNamaBox.Clear();
            periksaJabatanBox.Clear();
            periksaUsernameBox.Clear();
        }

            private void btnDelAcc_Click(object sender, EventArgs e)
        {
            string id = IDBoxDel.Text.ToString();

            conn.Open();
            string delAcc = $"DELETE FROM users WHERE ID = {id}";
            cmd = new MySqlCommand(delAcc, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            IDBoxDel.Clear();

            updateTable();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            string id = idEdit.Text.ToString();

            conn.Open();
            string query = $"SELECT Username, Nama, Jabatan FROM users WHERE ID = {id}";
            cmd = new MySqlCommand(query, conn);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string email = reader["Username"].ToString();
                    string nama = reader["Nama"].ToString();
                    string pangkat = reader["Jabatan"].ToString();

                    emailEdit.Text = email;
                    namaEdit.Text = nama;
                    pangkatEdit.Text = pangkat;

                    emailEdit.Enabled = true;
                    namaEdit.Enabled = true;
                    pangkatEdit.Enabled = true;
                    passEdit.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"No user found with the ID of {id}");
                    idEdit.Clear();
                }
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = idEdit.Text.ToString();
            string email = emailEdit.Text.ToString();
            string nama = namaEdit.Text.ToString();
            string pangkat = pangkatEdit.Text.ToString();
            string RAWpassword = passEdit.Text.ToString();
            string password = encryptPassword(RAWpassword);

            conn.Open();
            if (RAWpassword != "")
            {
                string editEvent = $"UPDATE users SET Username = '{email}', Nama = '{nama}', Jabatan = '{pangkat}', Password = '{password}' WHERE ID = {id}";
                cmd = new MySqlCommand(editEvent, conn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string editEvent = $"UPDATE users SET Username = '{email}', Nama = '{nama}', Jabatan = '{pangkat}' WHERE ID = {id}";
                cmd = new MySqlCommand(editEvent, conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();

            idEdit.Clear();
            emailEdit.Clear();
            namaEdit.Clear();
            passEdit.Clear();
            pangkatEdit.Clear();

            emailEdit.Enabled = false;
            namaEdit.Enabled = false;
            pangkatEdit.Enabled = false;
            passEdit.Enabled = false;

            updateTable();
        }

        private void buttonPeriksaHapus_Click(object sender, EventArgs e)
        {
            string id = IDBoxDel.Text.ToString();

            conn.Open();
            string query = $"SELECT Username, Nama, Jabatan FROM users WHERE ID = {id}";
            cmd = new MySqlCommand(query, conn);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string email = reader["Username"].ToString();
                    string nama = reader["Nama"].ToString();
                    string pangkat = reader["Jabatan"].ToString();

                    periksaUsernameBox.Text = email;
                    periksaNamaBox.Text = nama;
                    periksaJabatanBox.Text = pangkat;
                }
                else
                {
                    MessageBox.Show($"No user found with the ID of {id}");
                    idEdit.Clear();
                }
                conn.Close();
            }
        }
    }
}
