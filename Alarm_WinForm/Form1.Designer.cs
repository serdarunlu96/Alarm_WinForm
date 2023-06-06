namespace Alarm_WinForm
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            nudDakika = new NumericUpDown();
            nudSaniye = new NumericUpDown();
            label3 = new Label();
            lblKalanSure = new Label();
            btnAlarmKur = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)nudDakika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSaniye).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 35);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Dakika";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 35);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Saniye";
            // 
            // nudDakika
            // 
            nudDakika.Location = new Point(52, 59);
            nudDakika.Name = "nudDakika";
            nudDakika.Size = new Size(120, 23);
            nudDakika.TabIndex = 2;
            // 
            // nudSaniye
            // 
            nudSaniye.Location = new Point(193, 59);
            nudSaniye.Name = "nudSaniye";
            nudSaniye.Size = new Size(120, 23);
            nudSaniye.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 147);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 4;
            label3.Text = "KALAN SURE";
            // 
            // lblKalanSure
            // 
            lblKalanSure.AutoSize = true;
            lblKalanSure.BackColor = SystemColors.ActiveCaptionText;
            lblKalanSure.Font = new Font("Segoe UI", 39.75F, FontStyle.Regular, GraphicsUnit.World);
            lblKalanSure.ForeColor = Color.Lime;
            lblKalanSure.Location = new Point(90, 172);
            lblKalanSure.MaximumSize = new Size(200, 60);
            lblKalanSure.MinimumSize = new Size(150, 60);
            lblKalanSure.Name = "lblKalanSure";
            lblKalanSure.Size = new Size(173, 60);
            lblKalanSure.TabIndex = 5;
            lblKalanSure.Text = "00:00:00";
            // 
            // btnAlarmKur
            // 
            btnAlarmKur.Location = new Point(53, 103);
            btnAlarmKur.Name = "btnAlarmKur";
            btnAlarmKur.Size = new Size(260, 23);
            btnAlarmKur.TabIndex = 6;
            btnAlarmKur.Text = "ALARM KUR";
            btnAlarmKur.UseVisualStyleBackColor = true;
            btnAlarmKur.Click += btnAlarmKur_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 269);
            Controls.Add(btnAlarmKur);
            Controls.Add(lblKalanSure);
            Controls.Add(label3);
            Controls.Add(nudSaniye);
            Controls.Add(nudDakika);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ALARM";
            ((System.ComponentModel.ISupportInitialize)nudDakika).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSaniye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown nudDakika;
        private NumericUpDown nudSaniye;
        private Label label3;
        private Label lblKalanSure;
        private Button btnAlarmKur;
        private System.Windows.Forms.Timer timer1;
    }
}