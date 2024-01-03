namespace Attendance
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.warning = new System.Windows.Forms.Label();
            this.passCheckbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 503);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 663);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.btnLogin.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(500, 900);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(1000, 80);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailBox.BackColor = System.Drawing.Color.White;
            this.EmailBox.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.EmailBox.Location = new System.Drawing.Point(500, 547);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(6);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(1000, 57);
            this.EmailBox.TabIndex = 3;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordBox.BackColor = System.Drawing.Color.White;
            this.PasswordBox.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.PasswordBox.Location = new System.Drawing.Point(500, 707);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(6);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(1000, 57);
            this.PasswordBox.TabIndex = 4;
            // 
            // warning
            // 
            this.warning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(512, 947);
            this.warning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(0, 48);
            this.warning.TabIndex = 5;
            // 
            // passCheckbox
            // 
            this.passCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passCheckbox.AutoSize = true;
            this.passCheckbox.Font = new System.Drawing.Font("Arial Black", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passCheckbox.Location = new System.Drawing.Point(500, 776);
            this.passCheckbox.Margin = new System.Windows.Forms.Padding(6);
            this.passCheckbox.Name = "passCheckbox";
            this.passCheckbox.Size = new System.Drawing.Size(284, 42);
            this.passCheckbox.TabIndex = 7;
            this.passCheckbox.Text = "Show Password";
            this.passCheckbox.UseVisualStyleBackColor = true;
            this.passCheckbox.CheckedChanged += new System.EventHandler(this.passCheckbox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.label3.Location = new System.Drawing.Point(812, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 100);
            this.label3.TabIndex = 8;
            this.label3.Text = "Catatan";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.label5.Location = new System.Drawing.Point(771, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(515, 100);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kehadiran";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1970, 1425);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passCheckbox);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(123)))), ((int)(((byte)(104)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Catatan Kehadiran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.CheckBox passCheckbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

