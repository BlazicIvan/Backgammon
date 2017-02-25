namespace etf.backgammon.bi140643d
{
    partial class NewGameForm
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
            this.whiteIcon = new System.Windows.Forms.PictureBox();
            this.tbPlayer1Name = new System.Windows.Forms.TextBox();
            this.tbPlayer2Name = new System.Windows.Forms.TextBox();
            this.blackIcon = new System.Windows.Forms.PictureBox();
            this.rbPoints1 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.rb_CPU1 = new System.Windows.Forms.RadioButton();
            this.rb_CPU2 = new System.Windows.Forms.RadioButton();
            this.rb_noCpu = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.whiteIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // whiteIcon
            // 
            this.whiteIcon.BackgroundImage = global::etf.backgammon.bi140643d.Properties.Resources.token_white;
            this.whiteIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.whiteIcon.Location = new System.Drawing.Point(12, 16);
            this.whiteIcon.Name = "whiteIcon";
            this.whiteIcon.Size = new System.Drawing.Size(32, 32);
            this.whiteIcon.TabIndex = 0;
            this.whiteIcon.TabStop = false;
            // 
            // tbPlayer1Name
            // 
            this.tbPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPlayer1Name.Location = new System.Drawing.Point(50, 22);
            this.tbPlayer1Name.MaxLength = 8;
            this.tbPlayer1Name.Name = "tbPlayer1Name";
            this.tbPlayer1Name.Size = new System.Drawing.Size(117, 26);
            this.tbPlayer1Name.TabIndex = 1;
            this.tbPlayer1Name.Text = "Igrač 1";
            this.tbPlayer1Name.TextChanged += new System.EventHandler(this.tbPlayer1Name_TextChanged);
            // 
            // tbPlayer2Name
            // 
            this.tbPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPlayer2Name.Location = new System.Drawing.Point(50, 69);
            this.tbPlayer2Name.MaxLength = 8;
            this.tbPlayer2Name.Name = "tbPlayer2Name";
            this.tbPlayer2Name.Size = new System.Drawing.Size(117, 26);
            this.tbPlayer2Name.TabIndex = 3;
            this.tbPlayer2Name.Text = "Igrač 2";
            this.tbPlayer2Name.TextChanged += new System.EventHandler(this.tbPlayer2Name_TextChanged);
            // 
            // blackIcon
            // 
            this.blackIcon.BackgroundImage = global::etf.backgammon.bi140643d.Properties.Resources.token_black;
            this.blackIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackIcon.Location = new System.Drawing.Point(12, 63);
            this.blackIcon.Name = "blackIcon";
            this.blackIcon.Size = new System.Drawing.Size(32, 32);
            this.blackIcon.TabIndex = 2;
            this.blackIcon.TabStop = false;
            // 
            // rbPoints1
            // 
            this.rbPoints1.AutoSize = true;
            this.rbPoints1.Checked = true;
            this.rbPoints1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbPoints1.Location = new System.Drawing.Point(6, 19);
            this.rbPoints1.Name = "rbPoints1";
            this.rbPoints1.Size = new System.Drawing.Size(33, 20);
            this.rbPoints1.TabIndex = 6;
            this.rbPoints1.TabStop = true;
            this.rbPoints1.Text = "1";
            this.rbPoints1.UseVisualStyleBackColor = true;
            this.rbPoints1.CheckedChanged += new System.EventHandler(this.rbPoints1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton1.Location = new System.Drawing.Point(44, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(33, 20);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.Text = "3";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton2.Location = new System.Drawing.Point(83, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(33, 20);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "5";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton3.Location = new System.Drawing.Point(122, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(33, 20);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "7";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton4.Location = new System.Drawing.Point(161, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(40, 20);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.Text = "11";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton5.Location = new System.Drawing.Point(207, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(40, 20);
            this.radioButton5.TabIndex = 11;
            this.radioButton5.Text = "15";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPoints1);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 58);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Poeni";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 174);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(267, 37);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rb_CPU1
            // 
            this.rb_CPU1.AutoSize = true;
            this.rb_CPU1.Location = new System.Drawing.Point(6, 19);
            this.rb_CPU1.Name = "rb_CPU1";
            this.rb_CPU1.Size = new System.Drawing.Size(58, 17);
            this.rb_CPU1.TabIndex = 14;
            this.rb_CPU1.Text = "Igrač 1";
            this.rb_CPU1.UseVisualStyleBackColor = true;
            // 
            // rb_CPU2
            // 
            this.rb_CPU2.AutoSize = true;
            this.rb_CPU2.Location = new System.Drawing.Point(6, 40);
            this.rb_CPU2.Name = "rb_CPU2";
            this.rb_CPU2.Size = new System.Drawing.Size(58, 17);
            this.rb_CPU2.TabIndex = 15;
            this.rb_CPU2.Text = "Igrač 2";
            this.rb_CPU2.UseVisualStyleBackColor = true;
            // 
            // rb_noCpu
            // 
            this.rb_noCpu.AutoSize = true;
            this.rb_noCpu.Checked = true;
            this.rb_noCpu.Location = new System.Drawing.Point(6, 60);
            this.rb_noCpu.Name = "rb_noCpu";
            this.rb_noCpu.Size = new System.Drawing.Size(68, 17);
            this.rb_noCpu.TabIndex = 15;
            this.rb_noCpu.TabStop = true;
            this.rb_noCpu.Text = "Bez CPU";
            this.rb_noCpu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_CPU1);
            this.groupBox2.Controls.Add(this.rb_noCpu);
            this.groupBox2.Controls.Add(this.rb_CPU2);
            this.groupBox2.Location = new System.Drawing.Point(173, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 83);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPU igrač";
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(291, 222);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPlayer2Name);
            this.Controls.Add(this.blackIcon);
            this.Controls.Add(this.tbPlayer1Name);
            this.Controls.Add(this.whiteIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova igra";
            ((System.ComponentModel.ISupportInitialize)(this.whiteIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox whiteIcon;
        private System.Windows.Forms.TextBox tbPlayer1Name;
        private System.Windows.Forms.TextBox tbPlayer2Name;
        private System.Windows.Forms.PictureBox blackIcon;
        private System.Windows.Forms.RadioButton rbPoints1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rb_CPU1;
        private System.Windows.Forms.RadioButton rb_CPU2;
        private System.Windows.Forms.RadioButton rb_noCpu;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}