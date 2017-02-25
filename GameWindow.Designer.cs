namespace etf.backgammon.bi140643d
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.btn_dice = new System.Windows.Forms.Button();
            this.lbl_dice = new System.Windows.Forms.Label();
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.lbl_Info = new System.Windows.Forms.TextBox();
            this.panel_Pts = new System.Windows.Forms.Panel();
            this.lbl_Player2 = new System.Windows.Forms.Label();
            this.lbl_Player1 = new System.Windows.Forms.Label();
            this.timer_Dice = new System.Windows.Forms.Timer(this.components);
            this.timer_Move = new System.Windows.Forms.Timer(this.components);
            this.panel_Info.SuspendLayout();
            this.panel_Pts.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_dice
            // 
            this.btn_dice.Enabled = false;
            this.btn_dice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_dice.Location = new System.Drawing.Point(718, 329);
            this.btn_dice.Name = "btn_dice";
            this.btn_dice.Size = new System.Drawing.Size(254, 77);
            this.btn_dice.TabIndex = 0;
            this.btn_dice.Text = "Baci kocku";
            this.btn_dice.UseVisualStyleBackColor = true;
            this.btn_dice.Click += new System.EventHandler(this.btn_dice_Click);
            // 
            // lbl_dice
            // 
            this.lbl_dice.AutoSize = true;
            this.lbl_dice.BackColor = System.Drawing.Color.White;
            this.lbl_dice.Font = new System.Drawing.Font("Segoe UI Symbol", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dice.Location = new System.Drawing.Point(45, 72);
            this.lbl_dice.Name = "lbl_dice";
            this.lbl_dice.Size = new System.Drawing.Size(165, 106);
            this.lbl_dice.TabIndex = 2;
            this.lbl_dice.Text = "⚅⚅";
            this.lbl_dice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dice.Visible = false;
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_NewGame.Location = new System.Drawing.Point(718, 412);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(254, 71);
            this.btn_NewGame.TabIndex = 3;
            this.btn_NewGame.Text = "Nova igra";
            this.btn_NewGame.UseVisualStyleBackColor = true;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // panel_Info
            // 
            this.panel_Info.BackColor = System.Drawing.Color.White;
            this.panel_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Info.Controls.Add(this.lbl_Info);
            this.panel_Info.Controls.Add(this.panel_Pts);
            this.panel_Info.Controls.Add(this.lbl_dice);
            this.panel_Info.Location = new System.Drawing.Point(718, 12);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(254, 311);
            this.panel_Info.TabIndex = 4;
            // 
            // lbl_Info
            // 
            this.lbl_Info.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_Info.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Info.Enabled = false;
            this.lbl_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Info.Location = new System.Drawing.Point(18, 11);
            this.lbl_Info.Multiline = true;
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.ReadOnly = true;
            this.lbl_Info.ShortcutsEnabled = false;
            this.lbl_Info.Size = new System.Drawing.Size(220, 58);
            this.lbl_Info.TabIndex = 4;
            this.lbl_Info.Text = "Počnite novu igru";
            this.lbl_Info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_Pts
            // 
            this.panel_Pts.Controls.Add(this.lbl_Player2);
            this.panel_Pts.Controls.Add(this.lbl_Player1);
            this.panel_Pts.Location = new System.Drawing.Point(3, 206);
            this.panel_Pts.Name = "panel_Pts";
            this.panel_Pts.Size = new System.Drawing.Size(246, 100);
            this.panel_Pts.TabIndex = 3;
            this.panel_Pts.Visible = false;
            // 
            // lbl_Player2
            // 
            this.lbl_Player2.AutoSize = true;
            this.lbl_Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Player2.Location = new System.Drawing.Point(10, 65);
            this.lbl_Player2.Name = "lbl_Player2";
            this.lbl_Player2.Size = new System.Drawing.Size(161, 25);
            this.lbl_Player2.TabIndex = 8;
            this.lbl_Player2.Text = "Igrač   :  147/15";
            this.lbl_Player2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Player1
            // 
            this.lbl_Player1.AutoSize = true;
            this.lbl_Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Player1.Location = new System.Drawing.Point(10, 40);
            this.lbl_Player1.Name = "lbl_Player1";
            this.lbl_Player1.Size = new System.Drawing.Size(161, 25);
            this.lbl_Player1.TabIndex = 3;
            this.lbl_Player1.Text = "Igrač   :  147/15";
            this.lbl_Player1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer_Dice
            // 
            this.timer_Dice.Interval = 2000;
            this.timer_Dice.Tick += new System.EventHandler(this.timer_Dice_Tick);
            // 
            // timer_Move
            // 
            this.timer_Move.Interval = 2000;
            this.timer_Move.Tick += new System.EventHandler(this.timer_Move_Tick);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.btn_NewGame);
            this.Controls.Add(this.btn_dice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backgammon";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_Info.ResumeLayout(false);
            this.panel_Info.PerformLayout();
            this.panel_Pts.ResumeLayout(false);
            this.panel_Pts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dice;
        private System.Windows.Forms.Label lbl_dice;
        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Label lbl_Player2;
        private System.Windows.Forms.Label lbl_Player1;
        private System.Windows.Forms.Panel panel_Pts;
        private System.Windows.Forms.TextBox lbl_Info;
        private System.Windows.Forms.Timer timer_Dice;
        private System.Windows.Forms.Timer timer_Move;
    }
}

