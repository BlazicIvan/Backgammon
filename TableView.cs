using etf.backgammon.bi140643d;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Threading;

namespace etf.backgammon.bi140643d
{
    public class TableView : Panel
    {
        public Table subject;
        public CoinStackView[] coinStacks;
        private int sourceIndex, destIndex;
        private Image back;
        public Game game;

        const int penaltyX = 325;
        const int penaltyY = 15;
        const int sprWidth = 50;

        public TableView(Game subjectGame)
        {
            game = subjectGame;
            this.subject = game.table;
            coinStacks = new CoinStackView[26];
            sourceIndex = destIndex = -1;
            BorderStyle = BorderStyle.FixedSingle;
            back = Properties.Resources.bck;
            BackgroundImage = back;
            

            int xoffset;
            

            Width = back.Width;
            Height = back.Height;

            Enabled = false;
            
            for (int i = 0;i<26;i++)
            {
                

                coinStacks[i] = new CoinStackView(this,subject.GameTable[i], (i<13), (i==0 || i== 25));
                subject.GameTable[i].AssignView(coinStacks[i]);
                Controls.Add(coinStacks[i]);
                
                if (i < 1 || i >24)
                {
                    coinStacks[i].Location = new Point(penaltyX, penaltyY + ((i==0 ? 0:1) * (coinStacks[i].Height + 10)));
                    coinStacks[i].Enabled = false;
                    coinStacks[i].BorderStyle = BorderStyle.Fixed3D;
                    coinStacks[i].BackColor = Color.DarkGray;
                }
                else
                {
                    xoffset = 0;

                    if (i > 6 && i < 13)
                        xoffset = -100;

                    if (i > 18)
                        xoffset = 100;

                    if (i < 13)
                        coinStacks[i].Location = new Point(xoffset + Width - ((i) * sprWidth), Height - coinStacks[i].Height);
                    else
                        coinStacks[i].Location = new Point(xoffset + (i - 13) * sprWidth, 0);

                }
            }


            sourceIndex = destIndex = -1;
        }

        public bool NotifyHovered(int index)
        {
            if (sourceIndex == -1)
                return subject.GameTable[index].CanRemove(game.CurrentPlayer);
            else
                return subject.IsTransferValid(game.CurrentPlayer, sourceIndex, index, game.dice.Result);
        }

        public bool NotifySelected(int index)
        {
            bool result = false;

            if (sourceIndex == -1)
            {
                if (coinStacks[index].Subject.CanRemove(game.CurrentPlayer))
                {
                    sourceIndex = index;
                    coinStacks[index].SetSelected(true);
                    result = true;
                }
                else
                {
                    result = false;
                }
                        
            }
            else
            {
                coinStacks[sourceIndex].SetSelected(false);

                if (subject.IsTransferValid(game.players[game.currentIndex], sourceIndex, index, game.dice.Result))
                {
                    destIndex = index;
                    game.Move(sourceIndex, destIndex);
                    
                    result = true;
                }
                else
                {
                    result = false;
                    WaitForMove();
                }
                
                destIndex = -1;

            }
            return result;

        }

        private void UpdateView()
        {
            for (int i = 0; i < 24; i++)
                coinStacks[i].UpdateView();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }


        public void WaitForMove()
        {
            

            if (game.CurrentPlayer.Penalty)
            {
                sourceIndex = game.PenaltyIndex;
            }
            else
            {
                sourceIndex = -1;
            }

            if (game.CurrentPlayer.IsCPU)
            {
                List<int[]> allMoves = AI.CalcPossibleMoves(game.table, game.CurrentPlayer, game.dice.Result, game.CurrentPlayer.Penalty, game.PenaltyIndex);
                int[] move = allMoves[0];
                game.Move(move[0], move[1]);
            }
            else
            {
                Enabled = true;
            }

        }

        public void DisableSelection()
        {
            Enabled = false;
        }

    }
}
