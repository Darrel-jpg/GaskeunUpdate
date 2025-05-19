namespace Gaskeun_.View
{
    partial class UsersData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            cbStatus = new ComboBox();
            label4 = new Label();
            tbNoHp = new TextBox();
            label3 = new Label();
            tbEmail = new TextBox();
            label2 = new Label();
            btnHapus = new Button();
            btnUpdate = new Button();
            tbUsername = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Username = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            NoHp = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(cbStatus);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbNoHp);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnHapus);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(29, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 969);
            panel1.TabIndex = 0;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Tahoma", 12F);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Aktif", "Nonaktif" });
            cbStatus.Location = new Point(61, 501);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(156, 32);
            cbStatus.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(61, 474);
            label4.Name = "label4";
            label4.Size = new Size(66, 24);
            label4.TabIndex = 32;
            label4.Text = "Status";
            // 
            // tbNoHp
            // 
            tbNoHp.BorderStyle = BorderStyle.FixedSingle;
            tbNoHp.Font = new Font("Tahoma", 12F);
            tbNoHp.Location = new Point(61, 405);
            tbNoHp.Multiline = true;
            tbNoHp.Name = "tbNoHp";
            tbNoHp.Size = new Size(410, 31);
            tbNoHp.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(61, 378);
            label3.Name = "label3";
            label3.Size = new Size(65, 24);
            label3.TabIndex = 30;
            label3.Text = "No HP";
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Font = new Font("Tahoma", 12F);
            tbEmail.Location = new Point(61, 308);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(410, 31);
            tbEmail.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(61, 281);
            label2.Name = "label2";
            label2.Size = new Size(59, 24);
            label2.TabIndex = 28;
            label2.Text = "Email";
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(33, 52, 72);
            btnHapus.Cursor = Cursors.Hand;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 114, 184);
            btnHapus.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 114, 184);
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Arial Rounded MT Bold", 14F);
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(307, 669);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(125, 52);
            btnHapus.TabIndex = 27;
            btnHapus.Text = "Remove";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(33, 52, 72);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 114, 184);
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 114, 184);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 14F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(107, 669);
            btnUpdate.Margin = new Padding(190, 3, 3, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 52);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.Font = new Font("Tahoma", 12F);
            tbUsername.Location = new Point(61, 216);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(410, 31);
            tbUsername.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(61, 189);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 16;
            label6.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(597, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(1013, 969);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Username, Email, NoHp, Status });
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(31, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 60;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(951, 807);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // NoHp
            // 
            NoHp.DataPropertyName = "NoHp";
            NoHp.HeaderText = "No HP";
            NoHp.MinimumWidth = 6;
            NoHp.Name = "NoHp";
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 60);
            label1.Name = "label1";
            label1.Size = new Size(187, 30);
            label1.TabIndex = 2;
            label1.Text = "Data Pelanggan";
            // 
            // UsersData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UsersData";
            Size = new Size(1637, 1025);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox tbUsername;
        private Label label6;
        private Button btnHapus;
        private Button btnUpdate;
        private Label label4;
        private TextBox tbNoHp;
        private Label label3;
        private TextBox tbEmail;
        private Label label2;
        private ComboBox cbStatus;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn NoHp;
        private DataGridViewTextBoxColumn Status;
    }
}
