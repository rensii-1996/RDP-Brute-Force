namespace FastRDP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            startStopScan = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            numericThreads = new NumericUpDown();
            label2 = new Label();
            numericTimeout = new NumericUpDown();
            label3 = new Label();
            numericThreadTimeout = new NumericUpDown();
            portsList = new RichTextBox();
            label4 = new Label();
            hostsList = new RichTextBox();
            label5 = new Label();
            resultGridView = new DataGridView();
            Hostname = new DataGridViewTextBoxColumn();
            Port = new DataGridViewTextBoxColumn();
            User = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Error = new DataGridViewTextBoxColumn();
            usernameTextBox = new TextBox();
            passwordsTextBox = new TextBox();
            usernamesBtn = new Button();
            passwordsBtn = new Button();
            label6 = new Label();
            label7 = new Label();
            usernamesOFD = new OpenFileDialog();
            passwordsOFD = new OpenFileDialog();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericThreads).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTimeout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericThreadTimeout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultGridView).BeginInit();
            SuspendLayout();
            // 
            // startStopScan
            // 
            startStopScan.Location = new Point(12, 12);
            startStopScan.Name = "startStopScan";
            startStopScan.Size = new Size(100, 23);
            startStopScan.TabIndex = 0;
            startStopScan.Text = "Start Scan";
            startStopScan.UseVisualStyleBackColor = true;
            startStopScan.Click += startStopScan_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 12);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 2;
            label1.Text = "Max. Threads";
            // 
            // numericThreads
            // 
            numericThreads.Location = new Point(128, 30);
            numericThreads.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericThreads.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericThreads.Name = "numericThreads";
            numericThreads.Size = new Size(65, 23);
            numericThreads.TabIndex = 3;
            numericThreads.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 56);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 4;
            label2.Text = "Scan Timeout";
            // 
            // numericTimeout
            // 
            numericTimeout.Location = new Point(128, 74);
            numericTimeout.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericTimeout.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericTimeout.Name = "numericTimeout";
            numericTimeout.Size = new Size(65, 23);
            numericTimeout.TabIndex = 5;
            numericTimeout.Value = new decimal(new int[] { 250, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 100);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 6;
            label3.Text = "Thread Timeout";
            // 
            // numericThreadTimeout
            // 
            numericThreadTimeout.Location = new Point(128, 118);
            numericThreadTimeout.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericThreadTimeout.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericThreadTimeout.Name = "numericThreadTimeout";
            numericThreadTimeout.Size = new Size(65, 23);
            numericThreadTimeout.TabIndex = 7;
            numericThreadTimeout.Value = new decimal(new int[] { 250, 0, 0, 0 });
            // 
            // portsList
            // 
            portsList.Location = new Point(234, 30);
            portsList.Name = "portsList";
            portsList.Size = new Size(100, 111);
            portsList.TabIndex = 8;
            portsList.Text = "3389";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 12);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 9;
            label4.Text = "Scan Ports";
            // 
            // hostsList
            // 
            hostsList.Location = new Point(351, 30);
            hostsList.Name = "hostsList";
            hostsList.Size = new Size(195, 111);
            hostsList.TabIndex = 10;
            hostsList.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(351, 9);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 11;
            label5.Text = "IP / Hostname to scan";
            // 
            // resultGridView
            // 
            resultGridView.AllowUserToAddRows = false;
            resultGridView.AllowUserToDeleteRows = false;
            resultGridView.AllowUserToOrderColumns = true;
            resultGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            resultGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            resultGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultGridView.Columns.AddRange(new DataGridViewColumn[] { Hostname, Port, User, Password, Status, Error });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            resultGridView.DefaultCellStyle = dataGridViewCellStyle4;
            resultGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            resultGridView.Location = new Point(12, 147);
            resultGridView.Name = "resultGridView";
            resultGridView.ReadOnly = true;
            resultGridView.RowTemplate.Height = 25;
            resultGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            resultGridView.Size = new Size(776, 291);
            resultGridView.TabIndex = 12;
            resultGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Hostname
            // 
            Hostname.HeaderText = "IP/Hostname";
            Hostname.Name = "Hostname";
            Hostname.ReadOnly = true;
            // 
            // Port
            // 
            Port.HeaderText = "Port";
            Port.Name = "Port";
            Port.ReadOnly = true;
            // 
            // User
            // 
            User.HeaderText = "User";
            User.Name = "User";
            User.ReadOnly = true;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Error
            // 
            Error.HeaderText = "Error";
            Error.Name = "Error";
            Error.ReadOnly = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(552, 56);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(129, 23);
            usernameTextBox.TabIndex = 13;
            usernameTextBox.Text = "users.txt";
            // 
            // passwordsTextBox
            // 
            passwordsTextBox.Location = new Point(552, 117);
            passwordsTextBox.Name = "passwordsTextBox";
            passwordsTextBox.Size = new Size(129, 23);
            passwordsTextBox.TabIndex = 14;
            passwordsTextBox.Text = "passwords.txt";
            // 
            // usernamesBtn
            // 
            usernamesBtn.Location = new Point(687, 56);
            usernamesBtn.Name = "usernamesBtn";
            usernamesBtn.Size = new Size(75, 23);
            usernamesBtn.TabIndex = 15;
            usernamesBtn.Text = "Open";
            usernamesBtn.UseVisualStyleBackColor = true;
            usernamesBtn.Click += usernamesBtn_Click;
            // 
            // passwordsBtn
            // 
            passwordsBtn.Location = new Point(687, 118);
            passwordsBtn.Name = "passwordsBtn";
            passwordsBtn.Size = new Size(75, 23);
            passwordsBtn.TabIndex = 16;
            passwordsBtn.Text = "Open";
            passwordsBtn.UseVisualStyleBackColor = true;
            passwordsBtn.Click += passwordsBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(552, 30);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 17;
            label6.Text = "Select users file";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(552, 92);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 18;
            label7.Text = "Select passwords file";
            // 
            // usernamesOFD
            // 
            usernamesOFD.FileName = "users.txt";
            // 
            // passwordsOFD
            // 
            passwordsOFD.FileName = "passwords.txt";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(199, 76);
            label8.Name = "label8";
            label8.Size = new Size(23, 15);
            label8.TabIndex = 19;
            label8.Text = "ms";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(199, 122);
            label9.Name = "label9";
            label9.Size = new Size(23, 15);
            label9.TabIndex = 20;
            label9.Text = "ms";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(passwordsBtn);
            Controls.Add(usernamesBtn);
            Controls.Add(passwordsTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(resultGridView);
            Controls.Add(label5);
            Controls.Add(hostsList);
            Controls.Add(label4);
            Controls.Add(portsList);
            Controls.Add(numericThreadTimeout);
            Controls.Add(label3);
            Controls.Add(numericTimeout);
            Controls.Add(label2);
            Controls.Add(numericThreads);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(startStopScan);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FastRDP v3.0 GUI";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericThreads).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTimeout).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericThreadTimeout).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startStopScan;
        private PictureBox pictureBox1;
        private Label label1;
        private NumericUpDown numericThreads;
        private Label label2;
        private NumericUpDown numericTimeout;
        private Label label3;
        private NumericUpDown numericThreadTimeout;
        private RichTextBox portsList;
        private Label label4;
        private RichTextBox hostsList;
        private Label label5;
        private DataGridView resultGridView;
        private DataGridViewTextBoxColumn Hostname;
        private DataGridViewTextBoxColumn Port;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn Password;
        private TextBox usernameTextBox;
        private TextBox passwordsTextBox;
        private Button usernamesBtn;
        private Button passwordsBtn;
        private Label label6;
        private Label label7;
        private OpenFileDialog usernamesOFD;
        private OpenFileDialog passwordsOFD;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Error;
        private Label label8;
        private Label label9;
    }
}
