namespace DatabaseConnectedW05
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FlightInfo = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.cmbAirplane = new System.Windows.Forms.ComboBox();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbFlightNum = new System.Windows.Forms.TextBox();
            this.tbAirline = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserInfo = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.cmbUserFlight = new System.Windows.Forms.ComboBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserRefresh = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.FlightInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.UserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FlightInfo);
            this.tabControl1.Controls.Add(this.UserInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 551);
            this.tabControl1.TabIndex = 0;
            // 
            // FlightInfo
            // 
            this.FlightInfo.Controls.Add(this.dataGridView1);
            this.FlightInfo.Controls.Add(this.btnRefresh);
            this.FlightInfo.Controls.Add(this.btnDelete);
            this.FlightInfo.Controls.Add(this.btnUpdate);
            this.FlightInfo.Controls.Add(this.btnAdd);
            this.FlightInfo.Controls.Add(this.cmbSelect);
            this.FlightInfo.Controls.Add(this.cmbAirplane);
            this.FlightInfo.Controls.Add(this.tbDestination);
            this.FlightInfo.Controls.Add(this.tbFlightNum);
            this.FlightInfo.Controls.Add(this.tbAirline);
            this.FlightInfo.Controls.Add(this.label4);
            this.FlightInfo.Controls.Add(this.label3);
            this.FlightInfo.Controls.Add(this.label2);
            this.FlightInfo.Controls.Add(this.label1);
            this.FlightInfo.Location = new System.Drawing.Point(4, 22);
            this.FlightInfo.Name = "FlightInfo";
            this.FlightInfo.Padding = new System.Windows.Forms.Padding(3);
            this.FlightInfo.Size = new System.Drawing.Size(868, 451);
            this.FlightInfo.TabIndex = 0;
            this.FlightInfo.Text = "Flight Info";
            this.FlightInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(156, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 150);
            this.dataGridView1.TabIndex = 27;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(575, 429);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(178, 23);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(638, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(477, 179);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(523, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // cmbSelect
            // 
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Location = new System.Drawing.Point(523, 104);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(178, 21);
            this.cmbSelect.TabIndex = 22;
            // 
            // cmbAirplane
            // 
            this.cmbAirplane.FormattingEnabled = true;
            this.cmbAirplane.Items.AddRange(new object[] {
            "Airbus 320",
            "Boeing 777",
            "Boeing 544",
            "jet 56"});
            this.cmbAirplane.Location = new System.Drawing.Point(156, 211);
            this.cmbAirplane.Name = "cmbAirplane";
            this.cmbAirplane.Size = new System.Drawing.Size(121, 21);
            this.cmbAirplane.TabIndex = 21;
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(156, 157);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(121, 20);
            this.tbDestination.TabIndex = 20;
            // 
            // tbFlightNum
            // 
            this.tbFlightNum.Location = new System.Drawing.Point(156, 112);
            this.tbFlightNum.Name = "tbFlightNum";
            this.tbFlightNum.Size = new System.Drawing.Size(121, 20);
            this.tbFlightNum.TabIndex = 19;
            // 
            // tbAirline
            // 
            this.tbAirline.Location = new System.Drawing.Point(156, 71);
            this.tbAirline.Name = "tbAirline";
            this.tbAirline.Size = new System.Drawing.Size(121, 20);
            this.tbAirline.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Airplane Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Flight Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Airline";
            // 
            // UserInfo
            // 
            this.UserInfo.Controls.Add(this.dataGridView2);
            this.UserInfo.Controls.Add(this.btnUserRefresh);
            this.UserInfo.Controls.Add(this.btnUserDelete);
            this.UserInfo.Controls.Add(this.btnUserUpdate);
            this.UserInfo.Controls.Add(this.btnUserAdd);
            this.UserInfo.Controls.Add(this.cmbUser);
            this.UserInfo.Controls.Add(this.cmbUserFlight);
            this.UserInfo.Controls.Add(this.tbAge);
            this.UserInfo.Controls.Add(this.tbAddress);
            this.UserInfo.Controls.Add(this.tbEmail);
            this.UserInfo.Controls.Add(this.tbName);
            this.UserInfo.Controls.Add(this.label9);
            this.UserInfo.Controls.Add(this.label8);
            this.UserInfo.Controls.Add(this.label7);
            this.UserInfo.Controls.Add(this.label6);
            this.UserInfo.Controls.Add(this.label5);
            this.UserInfo.Location = new System.Drawing.Point(4, 22);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.UserInfo.Size = new System.Drawing.Size(918, 525);
            this.UserInfo.TabIndex = 1;
            this.UserInfo.Text = "User Info";
            this.UserInfo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Flight Num";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(141, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(141, 77);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(121, 20);
            this.tbEmail.TabIndex = 6;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(141, 118);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(121, 20);
            this.tbAddress.TabIndex = 7;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(141, 168);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(121, 20);
            this.tbAge.TabIndex = 8;
            // 
            // cmbUserFlight
            // 
            this.cmbUserFlight.FormattingEnabled = true;
            this.cmbUserFlight.Location = new System.Drawing.Point(141, 208);
            this.cmbUserFlight.Name = "cmbUserFlight";
            this.cmbUserFlight.Size = new System.Drawing.Size(121, 21);
            this.cmbUserFlight.TabIndex = 9;
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(587, 117);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(187, 21);
            this.cmbUser.TabIndex = 10;
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Location = new System.Drawing.Point(633, 29);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(75, 23);
            this.btnUserAdd.TabIndex = 11;
            this.btnUserAdd.Text = "Add New";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Location = new System.Drawing.Point(557, 206);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUserUpdate.TabIndex = 12;
            this.btnUserUpdate.Text = "Update";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(736, 208);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(75, 23);
            this.btnUserDelete.TabIndex = 13;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserRefresh
            // 
            this.btnUserRefresh.Location = new System.Drawing.Point(694, 473);
            this.btnUserRefresh.Name = "btnUserRefresh";
            this.btnUserRefresh.Size = new System.Drawing.Size(173, 23);
            this.btnUserRefresh.TabIndex = 14;
            this.btnUserRefresh.Text = "Refresh";
            this.btnUserRefresh.UseVisualStyleBackColor = true;
            this.btnUserRefresh.Click += new System.EventHandler(this.btnUserRefresh_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(61, 291);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(786, 150);
            this.dataGridView2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 604);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.FlightInfo.ResumeLayout(false);
            this.FlightInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.UserInfo.ResumeLayout(false);
            this.UserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage FlightInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.ComboBox cmbAirplane;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.TextBox tbFlightNum;
        private System.Windows.Forms.TextBox tbAirline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage UserInfo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnUserRefresh;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.ComboBox cmbUserFlight;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

