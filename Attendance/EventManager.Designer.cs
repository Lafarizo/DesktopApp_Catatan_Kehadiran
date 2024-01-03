namespace Attendance
{
    partial class EventManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.eventIDBox = new System.Windows.Forms.TextBox();
            this.btnDelEvent = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.eventLocBox = new System.Windows.Forms.TextBox();
            this.btnEventAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.eventAddBox = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.dataGridView2.Location = new System.Drawing.Point(50, 400);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.Size = new System.Drawing.Size(2365, 900);
            this.dataGridView2.TabIndex = 66;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.label15.Location = new System.Drawing.Point(1402, 50);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(328, 60);
            this.label15.TabIndex = 81;
            this.label15.Text = "Hapus Acara";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.label16.Location = new System.Drawing.Point(1429, 184);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 32);
            this.label16.TabIndex = 80;
            this.label16.Text = "ID";
            // 
            // eventIDBox
            // 
            this.eventIDBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eventIDBox.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventIDBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.eventIDBox.Location = new System.Drawing.Point(1483, 181);
            this.eventIDBox.Margin = new System.Windows.Forms.Padding(6);
            this.eventIDBox.Name = "eventIDBox";
            this.eventIDBox.Size = new System.Drawing.Size(500, 39);
            this.eventIDBox.TabIndex = 79;
            // 
            // btnDelEvent
            // 
            this.btnDelEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.btnDelEvent.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelEvent.ForeColor = System.Drawing.Color.White;
            this.btnDelEvent.Location = new System.Drawing.Point(1783, 313);
            this.btnDelEvent.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelEvent.Name = "btnDelEvent";
            this.btnDelEvent.Size = new System.Drawing.Size(200, 75);
            this.btnDelEvent.TabIndex = 78;
            this.btnDelEvent.Text = "Hapus";
            this.btnDelEvent.UseVisualStyleBackColor = false;
            this.btnDelEvent.Click += new System.EventHandler(this.btnDelEvent_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(659, 250);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(500, 39);
            this.dateTimePicker1.TabIndex = 77;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.label14.Location = new System.Drawing.Point(528, 250);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 32);
            this.label14.TabIndex = 76;
            this.label14.Text = "Tanggal";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.label13.Location = new System.Drawing.Point(546, 188);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 32);
            this.label13.TabIndex = 75;
            this.label13.Text = "Lokasi";
            // 
            // eventLocBox
            // 
            this.eventLocBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eventLocBox.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLocBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.eventLocBox.Location = new System.Drawing.Point(659, 188);
            this.eventLocBox.Margin = new System.Windows.Forms.Padding(6);
            this.eventLocBox.Name = "eventLocBox";
            this.eventLocBox.Size = new System.Drawing.Size(500, 39);
            this.eventLocBox.TabIndex = 74;
            // 
            // btnEventAdd
            // 
            this.btnEventAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEventAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.btnEventAdd.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventAdd.ForeColor = System.Drawing.Color.White;
            this.btnEventAdd.Location = new System.Drawing.Point(959, 313);
            this.btnEventAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnEventAdd.Name = "btnEventAdd";
            this.btnEventAdd.Size = new System.Drawing.Size(200, 75);
            this.btnEventAdd.TabIndex = 73;
            this.btnEventAdd.Text = "Tambah";
            this.btnEventAdd.UseVisualStyleBackColor = false;
            this.btnEventAdd.Click += new System.EventHandler(this.btnEventAdd_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.label10.Location = new System.Drawing.Point(558, 124);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 32);
            this.label10.TabIndex = 72;
            this.label10.Text = "Acara";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.label9.Location = new System.Drawing.Point(516, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(367, 60);
            this.label9.TabIndex = 70;
            this.label9.Text = "Tambah Acara";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.btnBack.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(50, 50);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 75);
            this.btnBack.TabIndex = 82;
            this.btnBack.Text = "Kembali";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // eventAddBox
            // 
            this.eventAddBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eventAddBox.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventAddBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.eventAddBox.Location = new System.Drawing.Point(659, 126);
            this.eventAddBox.Margin = new System.Windows.Forms.Padding(6);
            this.eventAddBox.Name = "eventAddBox";
            this.eventAddBox.Size = new System.Drawing.Size(500, 39);
            this.eventAddBox.TabIndex = 71;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.buttonReset.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(2230, 50);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(6);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(200, 75);
            this.buttonReset.TabIndex = 83;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // EventManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(2474, 1429);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.eventIDBox);
            this.Controls.Add(this.btnDelEvent);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.eventLocBox);
            this.Controls.Add(this.btnEventAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.eventAddBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "EventManager";
            this.ShowIcon = false;
            this.Text = "Catatan Kehadiran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EventManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox eventIDBox;
        private System.Windows.Forms.Button btnDelEvent;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox eventLocBox;
        private System.Windows.Forms.Button btnEventAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox eventAddBox;
        private System.Windows.Forms.Button buttonReset;
    }
}