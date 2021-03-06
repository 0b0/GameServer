﻿namespace GameServer
{
    partial class SettingsForm
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
            this.svrSettings = new System.Windows.Forms.TabControl();
            this.mysqlSettings = new System.Windows.Forms.TabPage();
            this.testConnection = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mysqlBase = new System.Windows.Forms.TextBox();
            this.mysqlHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mysqlPass = new System.Windows.Forms.TextBox();
            this.mysqlLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mysqlPort = new System.Windows.Forms.TextBox();
            this.svrSettings.SuspendLayout();
            this.mysqlSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // svrSettings
            // 
            this.svrSettings.Controls.Add(this.mysqlSettings);
            this.svrSettings.Controls.Add(this.tabPage2);
            this.svrSettings.Location = new System.Drawing.Point(12, 12);
            this.svrSettings.Name = "svrSettings";
            this.svrSettings.SelectedIndex = 0;
            this.svrSettings.Size = new System.Drawing.Size(342, 237);
            this.svrSettings.TabIndex = 0;
            // 
            // mysqlSettings
            // 
            this.mysqlSettings.Controls.Add(this.testConnection);
            this.mysqlSettings.Controls.Add(this.button1);
            this.mysqlSettings.Controls.Add(this.groupBox2);
            this.mysqlSettings.Controls.Add(this.groupBox1);
            this.mysqlSettings.Location = new System.Drawing.Point(4, 22);
            this.mysqlSettings.Name = "mysqlSettings";
            this.mysqlSettings.Padding = new System.Windows.Forms.Padding(3);
            this.mysqlSettings.Size = new System.Drawing.Size(334, 211);
            this.mysqlSettings.TabIndex = 0;
            this.mysqlSettings.Text = "MySql";
            this.mysqlSettings.UseVisualStyleBackColor = true;
            // 
            // testConnection
            // 
            this.testConnection.Location = new System.Drawing.Point(86, 174);
            this.testConnection.Name = "testConnection";
            this.testConnection.Size = new System.Drawing.Size(103, 23);
            this.testConnection.TabIndex = 11;
            this.testConnection.Text = "Testuj połączenie";
            this.testConnection.UseVisualStyleBackColor = true;
            this.testConnection.Click += new System.EventHandler(this.testConnection_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mysqlPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.mysqlBase);
            this.groupBox2.Controls.Add(this.mysqlHost);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 77);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Host i baza danych";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Baza: ";
            // 
            // mysqlBase
            // 
            this.mysqlBase.Location = new System.Drawing.Point(54, 45);
            this.mysqlBase.Name = "mysqlBase";
            this.mysqlBase.Size = new System.Drawing.Size(180, 20);
            this.mysqlBase.TabIndex = 2;
            // 
            // mysqlHost
            // 
            this.mysqlHost.Location = new System.Drawing.Point(54, 19);
            this.mysqlHost.Name = "mysqlHost";
            this.mysqlHost.Size = new System.Drawing.Size(180, 20);
            this.mysqlHost.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Host: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mysqlPass);
            this.groupBox1.Controls.Add(this.mysqlLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane logowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasło: ";
            // 
            // mysqlPass
            // 
            this.mysqlPass.Location = new System.Drawing.Point(54, 45);
            this.mysqlPass.Name = "mysqlPass";
            this.mysqlPass.PasswordChar = '•';
            this.mysqlPass.Size = new System.Drawing.Size(180, 20);
            this.mysqlPass.TabIndex = 4;
            this.mysqlPass.UseSystemPasswordChar = true;
            // 
            // mysqlLogin
            // 
            this.mysqlLogin.Location = new System.Drawing.Point(54, 19);
            this.mysqlLogin.Name = "mysqlLogin";
            this.mysqlLogin.Size = new System.Drawing.Size(180, 20);
            this.mysqlLogin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(252, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mysqlPort
            // 
            this.mysqlPort.Location = new System.Drawing.Point(240, 19);
            this.mysqlPort.Name = "mysqlPort";
            this.mysqlPort.Size = new System.Drawing.Size(76, 20);
            this.mysqlPort.TabIndex = 5;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 259);
            this.Controls.Add(this.svrSettings);
            this.Name = "SettingsForm";
            this.Text = "Ustawienia";
            this.svrSettings.ResumeLayout(false);
            this.mysqlSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl svrSettings;
        private System.Windows.Forms.TabPage mysqlSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mysqlPass;
        private System.Windows.Forms.TextBox mysqlLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mysqlBase;
        private System.Windows.Forms.TextBox mysqlHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button testConnection;
        private System.Windows.Forms.TextBox mysqlPort;
    }
}