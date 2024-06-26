﻿namespace DateTimeApp {
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
            btDateCount = new Button();
            dtpDay = new DateTimePicker();
            tbDisp = new TextBox();
            nudDay = new NumericUpDown();
            btDayBefore = new Button();
            btDayAfter = new Button();
            btAge = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F);
            label1.Location = new Point(46, 37);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // btDateCount
            // 
            btDateCount.Location = new Point(185, 75);
            btDateCount.Name = "btDateCount";
            btDateCount.Size = new Size(107, 58);
            btDateCount.TabIndex = 1;
            btDateCount.Text = "今日までの日数";
            btDateCount.UseVisualStyleBackColor = true;
            btDateCount.Click += btDateCount_Click;
            // 
            // dtpDay
            // 
            dtpDay.CalendarFont = new Font("Yu Gothic UI", 18F);
            dtpDay.Font = new Font("Yu Gothic UI", 15F);
            dtpDay.Location = new Point(118, 35);
            dtpDay.Name = "dtpDay";
            dtpDay.Size = new Size(174, 34);
            dtpDay.TabIndex = 1;
            // 
            // tbDisp
            // 
            tbDisp.Font = new Font("Yu Gothic UI", 15F);
            tbDisp.Location = new Point(46, 250);
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(246, 34);
            tbDisp.TabIndex = 2;
            // 
            // nudDay
            // 
            nudDay.Font = new Font("Yu Gothic UI", 22F);
            nudDay.Location = new Point(46, 169);
            nudDay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(120, 47);
            nudDay.TabIndex = 3;
            // 
            // btDayBefore
            // 
            btDayBefore.Font = new Font("Yu Gothic UI", 18F);
            btDayBefore.Location = new Point(194, 145);
            btDayBefore.Name = "btDayBefore";
            btDayBefore.Size = new Size(98, 47);
            btDayBefore.TabIndex = 4;
            btDayBefore.Text = "日前";
            btDayBefore.UseVisualStyleBackColor = true;
            btDayBefore.Click += btDayBefore_Click;
            // 
            // btDayAfter
            // 
            btDayAfter.Font = new Font("Yu Gothic UI", 18F);
            btDayAfter.Location = new Point(194, 197);
            btDayAfter.Name = "btDayAfter";
            btDayAfter.Size = new Size(98, 47);
            btDayAfter.TabIndex = 4;
            btDayAfter.Text = "日後";
            btDayAfter.UseVisualStyleBackColor = true;
            btDayAfter.Click += btDayAfter_Click;
            // 
            // btAge
            // 
            btAge.Font = new Font("Yu Gothic UI", 18F);
            btAge.Location = new Point(298, 145);
            btAge.Name = "btAge";
            btAge.Size = new Size(94, 47);
            btAge.TabIndex = 5;
            btAge.Text = "年齢";
            btAge.UseVisualStyleBackColor = true;
            btAge.Click += btAge_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 325);
            Controls.Add(btAge);
            Controls.Add(btDayAfter);
            Controls.Add(btDayBefore);
            Controls.Add(nudDay);
            Controls.Add(tbDisp);
            Controls.Add(dtpDay);
            Controls.Add(btDateCount);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btDateCount;
        private DateTimePicker dtpDay;
        private TextBox tbDisp;
        private NumericUpDown nudDay;
        private Button btDayBefore;
        private Button btDayAfter;
        private Button btAge;
    }
}
