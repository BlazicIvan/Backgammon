using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace etf.backgammon.bi140643d
{
    public partial class GameWindow : Form
    {
        public TableView view=null;
        public Game game;

        public GameWindow()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        public void UpdateStackView(int index)
        {
            view.coinStacks[index].UpdateView();
        }

        public void DisableSelection()
        {
            view.DisableSelection();
        }

        public void WaitForMove()
        {
            if(game.CurrentPlayer.IsCPU)
            {
                timer_Move.Start();
            }
            else
            {
                view.WaitForMove();
            }
                
        }

        public void DisableDice()
        {
            btn_dice.Enabled = false;
        }

        public void EnableDice()
        {
            btn_dice.Enabled = true;
        }

        public void ShowVictory()
        {
            lbl_Info.Text = game.CurrentPlayer.ToString() + " je pobedio!";
            btn_dice.Enabled = false;
            btn_NewGame.Enabled = true;
        }

        public void WaitForRoll()
        {
            lbl_Info.Text = game.CurrentPlayer.ToString() + " baca kocku";

            if (game.CurrentPlayer.IsCPU)
            {
                btn_dice.Enabled = false;
                timer_Dice.Start();
            }
            else
            {
                btn_dice.Enabled = true;
            }

        }

        public void UpdateInfo(String CustomInfo="")
        {
            if(CustomInfo=="")
                lbl_Info.Text = game.CurrentPlayer.ToString() + " na potezu";
            else
                lbl_Info.Text = CustomInfo;
        }

        public void UpdateDice()
        {
            lbl_dice.Text = game.dice.ToString();
        }

        private void btn_dice_Click(object sender, EventArgs e)
        {
            game.RollDice();
        }

        public void UpdatePts()
        {
            lbl_Player1.Text = game.players[0].Name + ":    " + game.players[0].GetPoints() + " / " + game.players[0].GamePoints;
            lbl_Player2.Text = game.players[1].Name + ":    " + game.players[1].GetPoints() + " / " + game.players[1].GamePoints;
        }

        public void UpdateTable()
        {
            for(int i=0;i<26;i++)
            {
                UpdateStackView(i);
            }
        }
        
        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            

            if (game != null)
            {
                if (game.started)
                {
                    DialogResult dialogResult = MessageBox.Show("Prekinuti tekuću igru?", "Nova igra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                        return;
                }
                else
                    return;
            }

            if (view != null)
            {
                view.Dispose();
            }
                

            NewGameForm ngf = new NewGameForm();
            ngf.ShowDialog();
            game = ngf.getGame();

            
            game.NewRound(this);
            view = new TableView(game);
            

            Controls.Add(view);
            view.Location = new Point(10, 10);

            panel_Pts.Visible = true;
            btn_dice.Visible = true;
            lbl_dice.Visible = true;
            WaitForRoll();
        }
        

        private void timer_Dice_Tick(object sender, EventArgs e)
        {
            timer_Dice.Stop();
            game.RollDice();
        }

        private void timer_Move_Tick(object sender, EventArgs e)
        {
            timer_Move.Stop();
            view.WaitForMove();
        }
    }
}
