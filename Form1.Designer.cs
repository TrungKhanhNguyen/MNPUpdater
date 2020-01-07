namespace MNPUpdate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBulkIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBulkOut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDailyIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDailyOut = new System.Windows.Forms.TextBox();
            this.btnBulkIn = new System.Windows.Forms.Button();
            this.btnBulkOut = new System.Windows.Forms.Button();
            this.btnDailyIn = new System.Windows.Forms.Button();
            this.btnDailyOut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimerStart = new System.Windows.Forms.Button();
            this.btnTimerStop = new System.Windows.Forms.Button();
            this.txtBulkTimer = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtDailyTimer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 36);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "MNP INFO UPDATER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(534, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 29);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtBulkIn
            // 
            this.txtBulkIn.Location = new System.Drawing.Point(16, 59);
            this.txtBulkIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtBulkIn.Name = "txtBulkIn";
            this.txtBulkIn.Size = new System.Drawing.Size(221, 22);
            this.txtBulkIn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "BulkSync";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "BulkSync-Out";
            // 
            // txtBulkOut
            // 
            this.txtBulkOut.Location = new System.Drawing.Point(16, 104);
            this.txtBulkOut.Margin = new System.Windows.Forms.Padding(4);
            this.txtBulkOut.Name = "txtBulkOut";
            this.txtBulkOut.Size = new System.Drawing.Size(221, 22);
            this.txtBulkOut.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "DailyFiles";
            // 
            // txtDailyIn
            // 
            this.txtDailyIn.Location = new System.Drawing.Point(288, 59);
            this.txtDailyIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtDailyIn.Name = "txtDailyIn";
            this.txtDailyIn.Size = new System.Drawing.Size(221, 22);
            this.txtDailyIn.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "DailyFiles-Out";
            // 
            // txtDailyOut
            // 
            this.txtDailyOut.Location = new System.Drawing.Point(288, 104);
            this.txtDailyOut.Margin = new System.Windows.Forms.Padding(4);
            this.txtDailyOut.Name = "txtDailyOut";
            this.txtDailyOut.Size = new System.Drawing.Size(221, 22);
            this.txtDailyOut.TabIndex = 7;
            // 
            // btnBulkIn
            // 
            this.btnBulkIn.BackColor = System.Drawing.Color.Silver;
            this.btnBulkIn.FlatAppearance.BorderSize = 0;
            this.btnBulkIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBulkIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBulkIn.Location = new System.Drawing.Point(244, 59);
            this.btnBulkIn.Name = "btnBulkIn";
            this.btnBulkIn.Size = new System.Drawing.Size(37, 23);
            this.btnBulkIn.TabIndex = 9;
            this.btnBulkIn.Text = "...";
            this.btnBulkIn.UseVisualStyleBackColor = false;
            this.btnBulkIn.Click += new System.EventHandler(this.btnBulkIn_Click);
            // 
            // btnBulkOut
            // 
            this.btnBulkOut.BackColor = System.Drawing.Color.Silver;
            this.btnBulkOut.FlatAppearance.BorderSize = 0;
            this.btnBulkOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBulkOut.Location = new System.Drawing.Point(244, 103);
            this.btnBulkOut.Name = "btnBulkOut";
            this.btnBulkOut.Size = new System.Drawing.Size(37, 23);
            this.btnBulkOut.TabIndex = 10;
            this.btnBulkOut.Text = "...";
            this.btnBulkOut.UseVisualStyleBackColor = false;
            this.btnBulkOut.Click += new System.EventHandler(this.btnBulkOut_Click);
            // 
            // btnDailyIn
            // 
            this.btnDailyIn.BackColor = System.Drawing.Color.Silver;
            this.btnDailyIn.FlatAppearance.BorderSize = 0;
            this.btnDailyIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailyIn.Location = new System.Drawing.Point(516, 59);
            this.btnDailyIn.Name = "btnDailyIn";
            this.btnDailyIn.Size = new System.Drawing.Size(37, 23);
            this.btnDailyIn.TabIndex = 11;
            this.btnDailyIn.Text = "...";
            this.btnDailyIn.UseVisualStyleBackColor = false;
            this.btnDailyIn.Click += new System.EventHandler(this.btnDailyIn_Click);
            // 
            // btnDailyOut
            // 
            this.btnDailyOut.BackColor = System.Drawing.Color.Silver;
            this.btnDailyOut.FlatAppearance.BorderSize = 0;
            this.btnDailyOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailyOut.Location = new System.Drawing.Point(516, 103);
            this.btnDailyOut.Name = "btnDailyOut";
            this.btnDailyOut.Size = new System.Drawing.Size(37, 23);
            this.btnDailyOut.TabIndex = 12;
            this.btnDailyOut.Text = "...";
            this.btnDailyOut.UseVisualStyleBackColor = false;
            this.btnDailyOut.Click += new System.EventHandler(this.btnDailyOut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bulk Timer";
            // 
            // btnTimerStart
            // 
            this.btnTimerStart.BackColor = System.Drawing.Color.Chocolate;
            this.btnTimerStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimerStart.FlatAppearance.BorderSize = 0;
            this.btnTimerStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerStart.ForeColor = System.Drawing.Color.White;
            this.btnTimerStart.Location = new System.Drawing.Point(288, 133);
            this.btnTimerStart.Name = "btnTimerStart";
            this.btnTimerStart.Size = new System.Drawing.Size(75, 23);
            this.btnTimerStart.TabIndex = 15;
            this.btnTimerStart.Text = "Start";
            this.btnTimerStart.UseVisualStyleBackColor = false;
            this.btnTimerStart.Click += new System.EventHandler(this.btnTimerStart_Click);
            // 
            // btnTimerStop
            // 
            this.btnTimerStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTimerStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimerStop.Enabled = false;
            this.btnTimerStop.FlatAppearance.BorderSize = 0;
            this.btnTimerStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimerStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimerStop.ForeColor = System.Drawing.Color.White;
            this.btnTimerStop.Location = new System.Drawing.Point(369, 133);
            this.btnTimerStop.Name = "btnTimerStop";
            this.btnTimerStop.Size = new System.Drawing.Size(75, 23);
            this.btnTimerStop.TabIndex = 16;
            this.btnTimerStop.Text = "Stop";
            this.btnTimerStop.UseVisualStyleBackColor = false;
            this.btnTimerStop.Click += new System.EventHandler(this.btnTimerStop_Click);
            // 
            // txtBulkTimer
            // 
            this.txtBulkTimer.BackColor = System.Drawing.SystemColors.Window;
            this.txtBulkTimer.Location = new System.Drawing.Point(90, 133);
            this.txtBulkTimer.Name = "txtBulkTimer";
            this.txtBulkTimer.Size = new System.Drawing.Size(54, 22);
            this.txtBulkTimer.TabIndex = 17;
            this.txtBulkTimer.Text = "1440";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtDailyTimer
            // 
            this.txtDailyTimer.Location = new System.Drawing.Point(227, 133);
            this.txtDailyTimer.Name = "txtDailyTimer";
            this.txtDailyTimer.Size = new System.Drawing.Size(55, 22);
            this.txtDailyTimer.TabIndex = 19;
            this.txtDailyTimer.Text = "60";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(151, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Daily Timer";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(571, 167);
            this.Controls.Add(this.txtDailyTimer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBulkTimer);
            this.Controls.Add(this.btnTimerStop);
            this.Controls.Add(this.btnTimerStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDailyOut);
            this.Controls.Add(this.btnDailyIn);
            this.Controls.Add(this.btnBulkOut);
            this.Controls.Add(this.btnBulkIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDailyOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDailyIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBulkOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBulkIn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBulkIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBulkOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDailyIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDailyOut;
        private System.Windows.Forms.Button btnBulkIn;
        private System.Windows.Forms.Button btnBulkOut;
        private System.Windows.Forms.Button btnDailyIn;
        private System.Windows.Forms.Button btnDailyOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTimerStart;
        private System.Windows.Forms.Button btnTimerStop;
        private System.Windows.Forms.TextBox txtBulkTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtDailyTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer2;
    }
}

