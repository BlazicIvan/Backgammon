using System;
using System.Windows.Forms;
using etf.backgammon.bi140643d;

namespace etf.backgammon.bi140643d
{
    public partial class NewGameForm : Form
    {
        private Game newGame;
        private int pts;

        public NewGameForm()
        {
            InitializeComponent();
            pts = 1;
        }

        private bool CheckSettings()
        {
            if(tbPlayer1Name.Text == tbPlayer2Name.Text)
            {
                MessageBox.Show("Igrači moraju imati različita imena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public Game getGame()
        {
            return newGame;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if(CheckSettings())
            {
                Player[] players = new Player[2];
                players[0] = new Player(tbPlayer1Name.Text, System.Drawing.Color.White, +1, rb_CPU1.Checked);
                players[1] = new Player(tbPlayer2Name.Text, System.Drawing.Color.Black, -1, rb_CPU2.Checked);

                Player.MakeOpponents(players[0], players[1]);

                newGame = new Game(players,pts);
                Close();
            }
        }

        private void rbPoints1_CheckedChanged(object sender, EventArgs e)
        {
            pts = Int32.Parse(rbPoints1.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pts = Int32.Parse(radioButton1.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pts = Int32.Parse(radioButton2.Text);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pts = Int32.Parse(radioButton3.Text);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pts = Int32.Parse(radioButton4.Text);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pts = Int32.Parse(radioButton5.Text);
        }

        private void tbPlayer1Name_TextChanged(object sender, EventArgs e)
        {
            rb_CPU1.Text = tbPlayer1Name.Text;
        }

        private void tbPlayer2Name_TextChanged(object sender, EventArgs e)
        {
            rb_CPU2.Text = tbPlayer2Name.Text;
        }
    }
}
