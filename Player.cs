using System;
using System.Drawing;

namespace etf.backgammon.bi140643d
{
    public class Player
    {
        private String name;
        private Color color;
        private int direction; // +1, -1
        private int points = 0;
        private int gamePoints = 0;
        private bool penalty = false;
        private bool computer;
        private Player opponent;

        public bool IsCPU
        {
            get { return computer; }
        }

        public static void MakeOpponents(Player p1, Player p2)
        {
            p1.opponent = p2;
            p2.opponent = p1;
        }

        public Player Opponent
        {
            get { return opponent; }
        }

        public bool Penalty
        {
            get { return penalty; }
            set { penalty = value; }
        }

        public int GamePoints
        {
            get { return gamePoints; }
            set { gamePoints = value; }
        }
        
        public void ResetPoints()
        {
            points = 147;
        }

        public int GetPoints()
        {
            return points;
        }
        
        public String Name
        {
            get { return name; }
        }

        public int Direction
        {
            get { return direction; }
        }

        public Color TokenColor
        {
            get { return color; }
        }

        public void AddPoints(int Points)
        {
            this.points += Points;
        }

        public void SubPoints(int Points)
        {
            if (this.points >= Points)
                this.points -= Points;
        }

        public Player(String name, Color color, int direction, bool computer)
        {
            this.name = name;
            this.color = color;
            this.direction = direction;
            this.computer = computer;
        }

        public override String ToString()
        {
            return name;
        }
    }
}
