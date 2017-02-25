using System;
using System.Windows.Forms;
using System.Collections.Generic;
using etf.backgammon.bi140643d;

namespace etf.backgammon.bi140643d
{
    public class Game
    {
        public Player[] players;
        public int maxPoints, round;
        public int currentIndex=0;
        public Dice dice;
        public Table table;
        public GameWindow window;
        public int moves=2;
        public int[] firstRoll;
        public bool started, doubleDice;

        public Game(Player[] players, int MaxPoints)
        {
            this.players = players;
            this.maxPoints = MaxPoints;
            firstRoll = new int[2];
            dice = new Dice();
        }

        
        public Player CurrentPlayer
        {
            get { return players[currentIndex]; }
            
        }

        public Player OtherPlayer
        {
            get { return players[(currentIndex+1)%2]; }

        }

        public int PenaltyIndex
        {
            get { return 25 * (1 - currentIndex); }
        }

        public int OtherPenaltyIndex
        {
            get { return 25 * (currentIndex); }
        }

        public void NewRound(GameWindow window)
        {
            this.window = window;

            table = new Table(players);

            foreach (Player p in players)
                p.ResetPoints();

            window.UpdatePts();
            window.UpdateDice();
            window.UpdateInfo();
            
        }

        public void EndRound()
        {
            round++;
            if(maxPoints==round)
            {
                MessageBox.Show(CurrentPlayer.Name + " je pobedio!");
                window.UpdateInfo("Kraj igre");
                window.DisableDice();
                window.DisableSelection();
            }
            else
            {
                MessageBox.Show(CurrentPlayer.Name + " dobija poen.");
                NewRound(window);
                window.UpdateTable();
                window.DisableSelection();
                window.EnableDice();
                started = false;

            }
        }

        public void StartGame()
        {
            round = 0;
            started = true;
            doubleDice = false;
            dice[0] = firstRoll[currentIndex];
            dice[1] = 0;
            window.DisableDice();
            window.UpdateInfo(CurrentPlayer.ToString() + " počinje, pomera za " + dice[0] + " polja");
            window.WaitForMove();
        }

        private void NextPlayer()
        {
            if(!doubleDice)
                currentIndex = (currentIndex + 1) % 2;
            moves = 2;

            dice.Reset();

            window.DisableSelection();
            window.WaitForRoll();
        }

        public void RollDice()
        {
            dice.Roll();
            
            if (!started)
            {

                int diceIndex = (new Random().Next()) % 2;
                dice[(diceIndex + 1) % 2] = 0;
                window.UpdateDice();

                if (firstRoll[0] == 0)
                {
                    firstRoll[0] = dice.Result[diceIndex];
                    currentIndex = 1;
                    window.WaitForRoll();
                }
                else
                {
                    firstRoll[1] = dice.Result[diceIndex];
                    currentIndex = (firstRoll[0] > firstRoll[1] ? 0 : 1);
                    StartGame();
                }
            }
            else
            {
                doubleDice = dice.CheckDoubleDice();
                window.UpdateDice();
                window.UpdateInfo();
                window.DisableDice();
 
                if (AI.PossibleMoveCount(this) == 0)
                {
                    NextPlayer();
                }
                else
                {
                    window.WaitForMove();
                }
            }

            
        }

        

        public void Move(int sourceIndex, int destIndex)
        {
            
            int offset = Math.Abs(sourceIndex - destIndex);
            

            if (table.GameTable[destIndex].Owner != CurrentPlayer && table.GameTable[destIndex].Owner != null)
            {
                table.TransferCoins(OtherPlayer, destIndex, OtherPenaltyIndex);
                OtherPlayer.AddPoints(destIndex);
                OtherPlayer.Penalty = true;
                window.UpdateStackView(OtherPenaltyIndex);
            }

            table.TransferCoins(CurrentPlayer, sourceIndex, destIndex);
            window.UpdateStackView(sourceIndex);
            window.UpdateStackView(destIndex);

            if (table.GameTable[PenaltyIndex].CoinCount == 0)
                CurrentPlayer.Penalty = false;


            CurrentPlayer.SubPoints(offset);
            window.UpdatePts();
            
            if(CheckVictory(destIndex))
            {
                CurrentPlayer.GamePoints += 1;
                EndRound();
                return;
            }
            

            if (offset == dice[0] + dice[1])
            {
                moves = 0;
            }
            else
            {
                moves--;
                if (offset == dice.Result[0])
                {
                    dice[0] = 0;
                }
                    
                else
                {
                    dice[1] = 0;
                }
                window.UpdateDice();
            }

            if(AI.PossibleMoveCount(this) == 0)
            {
                moves = 0;
            }
                        
            if (moves==0)
            {
                NextPlayer();
            }
            else
            {
                window.WaitForMove();
            }

        }

        public bool CheckVictory(int destIndex)
        {
            int coins = 0;
            int startIndex = currentIndex * 18 + 1;
            int endIndex = 5 + startIndex;

            if(startIndex <= destIndex && endIndex >= destIndex)
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    if (table.GameTable[i].Owner == CurrentPlayer)
                    {
                        coins += table.GameTable[i].CoinCount;
                    }
                }
            }
            return coins == 15;

        }
        
    }
}
