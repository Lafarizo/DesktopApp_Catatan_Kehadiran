namespace Attendance
{
    partial class AdminWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminWindow));
            this.btnManageAcc = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageAttendance = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManageAcc
            // 
            this.btnManageAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(61)))), ((int)(((byte)(183)))));
            this.btnManageAcc.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAcc.ForeColor = System.Drawing.Color.White;
            this.btnManageAcc.Location = new System.Drawing.Point(1400, 950);
            this.btnManageAcc.Margin = new System.Windows.Forms.Padding(6);
            this.btnManageAcc.Name = "btnManageAcc";
            this.btnManageAcc.Size = new System.Drawing.Size(500, 100);
            this.btnManageAcc.TabIndex = 9;
            this.btnManageAcc.Text = "Anggota";
            this.btnManageAcc.UseVisualStyleBackColor = false;
            this.btnManageAcc.Click += new System.EventHandler(this.btnManageAcc_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.btnLogout.Font = new System.Drawing.Font("Arial Black", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1700, 50);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 75);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageAttendance
            // 
            this.btnManageAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(147)))), ((int)(((byte)(38)))));
            this.btnManageAttendance.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAttendance.ForeColor = System.Drawing.Color.White;
            this.btnManageAttendance.Location = new System.Drawing.Point(750, 950);
            this.btnManageAttendance.Margin = new System.Windows.Forms.Padding(6);
            this.btnManageAttendance.Name = "btnManageAttendance";
            this.btnManageAttendance.Size = new System.Drawing.Size(500, 100);
            this.btnManageAttendance.TabIndex = 14;
            this.btnManageAttendance.Text = "Kehadiran";
            this.btnManageAttendance.UseVisualStyleBackColor = false;
            this.btnManageAttendance.Click += new System.EventHandler(this.btnManageAttendance_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.btnEvents.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.White;
            this.btnEvents.Location = new System.Drawing.Point(100, 950);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(6);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(500, 100);
            this.btnEvents.TabIndex = 15;
            this.btnEvents.Text = "Acara";
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Image = global::Attendance.Properties.Resources.contact;
            this.label5.Location = new System.Drawing.Point(750, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(500, 500);
            this.label5.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Image = global::Attendance.Properties.Resources._event;
            this.label6.Location = new System.Drawing.Point(100, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(500, 500);
            this.label6.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(1400, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(500, 500);
            this.label4.TabIndex = 20;
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1974, 1429);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnManageAttendance);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageAcc);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "AdminWindow";
            this.ShowIcon = false;
            this.Text = "Catatan Kehadiran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnManageAcc;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageAttendance;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}