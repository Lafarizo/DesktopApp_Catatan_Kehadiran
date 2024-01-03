using Attendance.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attendance
{
    public partial class AttendanceManager : Form
    {
        private Koneksi koneksi;
        MySqlConnection conn;

        MySqlCommand cmd = new MySqlCommand();
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        public AttendanceManager()
        {
            InitializeComponent();

            koneksi = new Koneksi();
            conn = koneksi.conn;
        }

        public void updateTable()
        {
            conn.Open();
            string query = $"SELECT * FROM attendance";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string status = null;

            if (rbHadirAdd.Checked)
            {
                status = "Hadir";
            }
            else if (rbIzinAdd.Checked)
            {
                status = "Izin";
            }
            else if (rbAbsentAdd.Checked)
            {
                status = "Bolos";
            }
            else if (rbTelatAdd.Checked)
            {
                status = "Sakit";
            }

            string nama = addAttBox.Text.ToString();

            string event_ = cbAddAtt.Text;

            conn.Open();
            string absen = $"INSERT INTO attendance (Nama, Acara, Status) VALUES ('{nama}', '{event_}', '{status}')";
            cmd = new MySqlCommand(absen, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            addAttBox.Clear();

            updateTable();

            rbHadirAdd.Checked = false;
            rbIzinAdd.Checked = false;
            rbAbsentAdd.Checked = false;
            rbTelatAdd.Checked = false;
            addAttBox.Clear();
            cbAddAtt.Text = string.Empty;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string status = null;

            if (rbHadirEdit.Checked)
            {
                status = "Hadir";
            }
            else if (rbIzinEdit.Checked)
            {
                status = "Izin";
            }
            else if (rbAbsentEdit.Checked)
            {
                status = "Bolos";
            }
            else if (rbTelatEdit.Checked)
            {
                status = "Sakit";
            }

            string id = IDBoxEdit.Text.ToString();

            conn.Open();
            string editAbsen = $"UPDATE attendance SET Status = '{status}' WHERE ID = {id}";
            cmd = new MySqlCommand(editAbsen, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            IDBoxEdit.Clear();

            updateTable();

            rbHadirEdit.Checked = false;
            rbIzinEdit.Checked = false;
            rbAbsentEdit.Checked = false;
            rbTelatEdit.Checked = false;
            IDBoxEdit.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = IDBoxDel.Text.ToString();

            if (id != "")
            {
                conn.Open();
                string delAbsen = $"DELETE FROM attendance WHERE ID = {id}";
                cmd = new MySqlCommand(delAbsen, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                updateTable();
                IDBoxDel.Clear();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                        saveFileDialog.FilterIndex = 1;

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;

                            using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
                            {
                                // Menambahkan baris informasi pemisah kolom yang digunakan
                                sw.WriteLine("sep=,");

                                // Menulis header dataGridView1
                                foreach (DataGridViewColumn column in dataGridView1.Columns)
                                {
                                    sw.Write("\"" + column.HeaderText.Replace("\"", "\"\"") + "\",");
                                }
                                sw.WriteLine();

                                // Menulis data dataGridView1
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        sw.Write("\"" + cell.Value?.ToString().Replace("\"", "\"\"") + "\",");
                                    }
                                    sw.WriteLine();
                                }

                                // Menambahkan baris kosong sebagai pemisah antara dataGridView1 dan dataGridView2
                                sw.WriteLine();

                             
                              
                            }

                            MessageBox.Show("Data berhasil diekspor!.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal diekspor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Data kosong!", "Export Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AttendanceManager_Load(object sender, EventArgs e)
        {;
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
            IDBoxEdit.Clear();
            addAttBox.Clear();
            cbAddAtt.Text = string.Empty;
            rbHadirEdit.Checked = false;
            rbIzinEdit.Checked = false;
            rbAbsentEdit.Checked = false;
            rbTelatEdit.Checked = false;
            rbHadirAdd.Checked = false;
            rbIzinAdd.Checked = false;
            rbAbsentAdd.Checked = false;
            rbTelatAdd.Checked = false;
        }
    }
}
