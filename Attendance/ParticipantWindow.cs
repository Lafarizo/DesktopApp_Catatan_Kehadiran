using Attendance.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Attendance
{
    public partial class ParticipantWindow : Form
    {
        private Koneksi koneksi;
        MySqlConnection conn;

        MySqlCommand cmd = new MySqlCommand();
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        string loggedInEmail = LoginForm.Session.loggedInEmail;
        string loggedInName = LoginForm.Session.loggedInName;

        public ParticipantWindow()
        {
            InitializeComponent();

            koneksi = new Koneksi();
            conn = koneksi.conn;
        }

        public void updateTable()
        {
            string query = $"SELECT * FROM attendance WHERE nama = '{loggedInName}'";
            cmd = new MySqlCommand(query, conn);

            adapter = new MySqlDataAdapter(cmd);
            dataTable = new DataTable();

            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.HeaderText == "id")
                {
                    column.Visible = false;
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }


        private void Member_Load(object sender, EventArgs e)
        {
            lblNama.Text = $"{loggedInName}";
            conn.Open();

            updateTable();

            string query = "SELECT * FROM events";
            cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            
            conn.Close();
        }

        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm.Session.destroySession();

            LoginForm loginWindowInstance = new LoginForm();
            loginWindowInstance.Show();

            this.Close();
        }
    }
}
