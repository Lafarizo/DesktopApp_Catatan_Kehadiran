using Attendance.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attendance
{
    public partial class EventManager : Form
    {
        private Koneksi koneksi;
        MySqlConnection conn;

        MySqlCommand cmd = new MySqlCommand();
        private MySqlDataAdapter adapter;

        private DataTable dataTable;
        public EventManager()
        {
            InitializeComponent();

            koneksi = new Koneksi();
            conn = koneksi.conn;
        }

        public void updateEventTable()
        {
            conn.Open();
            string query = $"SELECT * FROM events";
            cmd = new MySqlCommand(query, conn);

            adapter = new MySqlDataAdapter(cmd);
            dataTable = new DataTable();

            adapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;

            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            conn.Close();
        }

        private void btnEventAdd_Click(object sender, EventArgs e)
        {
            string event_ = eventAddBox.Text.ToString();
            string location = eventLocBox.Text.ToString();
            string date = dateTimePicker1.Value.ToString("yy-MM-dd");

            conn.Open();
            string addEvent = $"INSERT INTO events (Acara, Lokasi, Tanggal) VALUES ('{event_}', '{location}', '{date}')";
            cmd = new MySqlCommand(addEvent, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            eventAddBox.Clear();
            eventLocBox.Clear();

            updateEventTable();
        }

        private void btnDelEvent_Click(object sender, EventArgs e)
        {
            string id = eventIDBox.Text.ToString();

            if (id != "")
            {
                conn.Open();
                string delEvent = $"DELETE FROM events WHERE ID = {id}";
                cmd = new MySqlCommand(delEvent, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                eventIDBox.Clear();

                updateEventTable();
            }
        }

        private void EventManager_Load(object sender, EventArgs e)
        {
            updateEventTable();
            dateTimePicker1.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminWindow adminWindowInstance = new AdminWindow();
            adminWindowInstance.Show();

            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            eventIDBox.Clear();
            eventAddBox.Clear();
            eventLocBox.Clear();
        }
    }
}
