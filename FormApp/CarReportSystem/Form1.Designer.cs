namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            cbAuther = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cbCarName = new ComboBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            rbOther = new RadioButton();
            rbImport = new RadioButton();
            rbSubaru = new RadioButton();
            rbHonda = new RadioButton();
            rbNissan = new RadioButton();
            rbToyota = new RadioButton();
            tbReport = new TextBox();
            label6 = new Label();
            btPicOpen = new Button();
            btPicDelete = new Button();
            pbPicture = new PictureBox();
            btAddReport = new Button();
            btModifyReport = new Button();
            btDeleteReport = new Button();
            label7 = new Label();
            dgvCarReport = new DataGridView();
            ofdPicFileOpen = new OpenFileDialog();
            statusStrip1 = new StatusStrip();
            tslbMessage = new ToolStripStatusLabel();
            ofdReportFileOpen = new OpenFileDialog();
            sfdReportFileSave = new SaveFileDialog();
            btClearReport = new Button();
            menuStrip1 = new MenuStrip();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).BeginInit();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14F);
            label1.Location = new Point(42, 42);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "日付:";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 14F);
            dtpDate.Location = new Point(111, 40);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 32);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14F);
            label2.Location = new Point(23, 92);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 0;
            label2.Text = "記録者:";
            // 
            // cbAuther
            // 
            cbAuther.Font = new Font("Yu Gothic UI", 14F);
            cbAuther.FormattingEnabled = true;
            cbAuther.Location = new Point(111, 89);
            cbAuther.Name = "cbAuther";
            cbAuther.Size = new Size(245, 33);
            cbAuther.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14F);
            label3.Location = new Point(29, 138);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 0;
            label3.Text = "メーカー:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 14F);
            label4.Location = new Point(42, 181);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 0;
            label4.Text = "車名:";
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 14F);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(111, 179);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(245, 33);
            cbCarName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 14F);
            label5.Location = new Point(25, 239);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 0;
            label5.Text = "レポート:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbOther);
            groupBox2.Controls.Add(rbImport);
            groupBox2.Controls.Add(rbSubaru);
            groupBox2.Controls.Add(rbHonda);
            groupBox2.Controls.Add(rbNissan);
            groupBox2.Controls.Add(rbToyota);
            groupBox2.Location = new Point(111, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 37);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Checked = true;
            rbOther.Location = new Point(304, 12);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(56, 19);
            rbOther.TabIndex = 5;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Location = new Point(238, 12);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(61, 19);
            rbImport.TabIndex = 4;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(179, 12);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 3;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(117, 12);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 2;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(62, 12);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 1;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(6, 12);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 0;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            tbReport.BorderStyle = BorderStyle.FixedSingle;
            tbReport.Location = new Point(110, 239);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(382, 124);
            tbReport.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 10F);
            label6.Location = new Point(533, 42);
            label6.Name = "label6";
            label6.Size = new Size(37, 19);
            label6.TabIndex = 6;
            label6.Text = "画像";
            // 
            // btPicOpen
            // 
            btPicOpen.BackColor = Color.LightSkyBlue;
            btPicOpen.FlatStyle = FlatStyle.Flat;
            btPicOpen.Location = new Point(611, 40);
            btPicOpen.Name = "btPicOpen";
            btPicOpen.Size = new Size(75, 23);
            btPicOpen.TabIndex = 7;
            btPicOpen.Text = "開く...";
            btPicOpen.UseVisualStyleBackColor = false;
            btPicOpen.Click += btPicOpen_Click;
            // 
            // btPicDelete
            // 
            btPicDelete.BackColor = Color.FromArgb(255, 128, 128);
            btPicDelete.FlatStyle = FlatStyle.Flat;
            btPicDelete.Location = new Point(716, 39);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(75, 23);
            btPicDelete.TabIndex = 8;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = false;
            btPicDelete.Click += btPicDelete_Click;
            // 
            // pbPicture
            // 
            pbPicture.BackColor = SystemColors.GradientInactiveCaption;
            pbPicture.Location = new Point(533, 76);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(258, 230);
            pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbPicture.TabIndex = 9;
            pbPicture.TabStop = false;
            // 
            // btAddReport
            // 
            btAddReport.BackColor = Color.LightSkyBlue;
            btAddReport.FlatStyle = FlatStyle.Flat;
            btAddReport.Location = new Point(521, 312);
            btAddReport.Name = "btAddReport";
            btAddReport.Size = new Size(75, 39);
            btAddReport.TabIndex = 7;
            btAddReport.Text = "追加";
            btAddReport.UseVisualStyleBackColor = false;
            btAddReport.Click += btAddReport_Click;
            // 
            // btModifyReport
            // 
            btModifyReport.BackColor = Color.FromArgb(255, 255, 192);
            btModifyReport.FlatStyle = FlatStyle.Flat;
            btModifyReport.Location = new Point(627, 312);
            btModifyReport.Name = "btModifyReport";
            btModifyReport.Size = new Size(75, 39);
            btModifyReport.TabIndex = 7;
            btModifyReport.Text = "修正";
            btModifyReport.UseVisualStyleBackColor = false;
            btModifyReport.Click += btModifyReport_Click;
            // 
            // btDeleteReport
            // 
            btDeleteReport.BackColor = Color.FromArgb(255, 128, 128);
            btDeleteReport.FlatStyle = FlatStyle.Flat;
            btDeleteReport.Location = new Point(735, 312);
            btDeleteReport.Name = "btDeleteReport";
            btDeleteReport.Size = new Size(75, 39);
            btDeleteReport.TabIndex = 7;
            btDeleteReport.Text = "削除";
            btDeleteReport.UseVisualStyleBackColor = false;
            btDeleteReport.Click += btDeleteReport_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 14F);
            label7.Location = new Point(39, 383);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 0;
            label7.Text = "一覧:";
            // 
            // dgvCarReport
            // 
            dgvCarReport.AllowUserToAddRows = false;
            dgvCarReport.AllowUserToDeleteRows = false;
            dgvCarReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarReport.Location = new Point(106, 383);
            dgvCarReport.MultiSelect = false;
            dgvCarReport.Name = "dgvCarReport";
            dgvCarReport.ReadOnly = true;
            dgvCarReport.RowHeadersVisible = false;
            dgvCarReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarReport.Size = new Size(730, 206);
            dgvCarReport.TabIndex = 10;
            dgvCarReport.Click += dgvCarReport_Click;
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslbMessage });
            statusStrip1.Location = new Point(0, 615);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(849, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslbMessage
            // 
            tslbMessage.Name = "tslbMessage";
            tslbMessage.Size = new Size(0, 17);
            // 
            // ofdReportFileOpen
            // 
            ofdReportFileOpen.FileName = "openFileDialog1";
            // 
            // btClearReport
            // 
            btClearReport.BackColor = Color.FromArgb(255, 255, 192);
            btClearReport.FlatStyle = FlatStyle.Flat;
            btClearReport.Location = new Point(18, 422);
            btClearReport.Name = "btClearReport";
            btClearReport.Size = new Size(75, 39);
            btClearReport.TabIndex = 12;
            btClearReport.Text = "クリア";
            btClearReport.UseVisualStyleBackColor = false;
            btClearReport.Click += btClearReport_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(849, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開くToolStripMenuItem, 保存ToolStripMenuItem, toolStripSeparator1, 色設定ToolStripMenuItem, toolStripSeparator2, 終了ToolStripMenuItem });
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(67, 20);
            ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(119, 22);
            開くToolStripMenuItem.Text = "開く...";
            開くToolStripMenuItem.Click += 開くToolStripMenuItem_Click;
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(119, 22);
            保存ToolStripMenuItem.Text = "保存...";
            保存ToolStripMenuItem.Click += 保存ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(116, 6);
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(119, 22);
            色設定ToolStripMenuItem.Text = "色設定...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(116, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.Size = new Size(119, 22);
            終了ToolStripMenuItem.Text = "終了";
            終了ToolStripMenuItem.Click += 終了ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(849, 637);
            Controls.Add(btClearReport);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(dgvCarReport);
            Controls.Add(pbPicture);
            Controls.Add(btPicDelete);
            Controls.Add(btDeleteReport);
            Controls.Add(btModifyReport);
            Controls.Add(btAddReport);
            Controls.Add(btPicOpen);
            Controls.Add(label6);
            Controls.Add(tbReport);
            Controls.Add(groupBox2);
            Controls.Add(cbCarName);
            Controls.Add(cbAuther);
            Controls.Add(dtpDate);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "試乗レポート管理システム";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private ComboBox cbAuther;
        private Label label3;
        private Label label4;
        private ComboBox cbCarName;
        private Label label5;
        private GroupBox groupBox2;
        private RadioButton rbOther;
        private RadioButton rbImport;
        private RadioButton rbSubaru;
        private RadioButton rbHonda;
        private RadioButton rbNissan;
        private RadioButton rbToyota;
        private TextBox tbReport;
        private Label label6;
        private Button btPicOpen;
        private Button btPicDelete;
        private PictureBox pbPicture;
        private Button btAddReport;
        private Button btModifyReport;
        private Button btDeleteReport;
        private Label label7;
        private DataGridView dgvCarReport;
        private OpenFileDialog ofdPicFileOpen;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslbMessage;
        private OpenFileDialog ofdReportFileOpen;
        private SaveFileDialog sfdReportFileSave;
        private Button btClearReport;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 終了ToolStripMenuItem;
    }
}
