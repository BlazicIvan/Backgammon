using System;

namespace etf.backgammon.bi140643d
{
    public class Dice
    {
        private static int a = 429493445, c = 907633385, m = int.MaxValue;
        private static String diceStr = "⚀⚁⚂⚃⚄⚅";
        private int[] diceRes;
        private int next;


        private int randInt()
        {
            next = (a * next + c) % m;
            return 1 + (Math.Abs(next) % 6);
        }

        public Dice()
        {
            next = DateTime.Now.Second % 6;
            diceRes = new int[2];
            diceRes[0] = diceRes[1] = 0;
        }

        public int[] Roll()
        {
            int[] numbers = new int[2];

            for (int i = 0; i < 2; i++)
            {
                numbers[i] = randInt();
                while (numbers[i] == diceRes[i])
                    numbers[i] = randInt();
            }

            diceRes = numbers;

            return numbers;
        }

        public int[] Result
        {
            get{ return diceRes; }
        }

        public int this[int index]
        {
            get
            {
                return diceRes[index];
            }

            set
            {
                diceRes[index] = value;
            }
        }

        public void Reset()
        {
            this[0] = this[1] = 0;
        }

        public bool CheckDoubleDice()
        {
            return (this[0] == this[1]) && (this[0] != 0);
        }

        public override String ToString()
        {
            if (diceRes[0] != 0 && diceRes[1] != 0)
                return diceStr[diceRes[0]-1] + " " + diceStr[diceRes[1]-1];
            else if (diceRes[0] == 0 && diceRes[1] == 0)
                return "";
            else
            {
                int index = (diceRes[0] != 0 ? 0 : 1);
                return ""+diceStr[diceRes[index]-1];
            }
        }

    }
}
