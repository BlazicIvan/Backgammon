using System;

namespace etf.backgammon.bi140643d
{
    public class Table
    {
        CoinStack[] gameTable;

        private Table()
        {

        }

        public Table(Player[] players)
        {
            gameTable = new CoinStack[26];

            for(int i = 0; i<26;i++)
            {
                gameTable[i] = new CoinStack(i);
            }

            int[,] init = new int[,] { { 6, 5 }, { 8, 3 }, { 13, 5 }, { 24, 2 } };

            for(int i=0; i<4; i++)
            {
                for(int j=0;j<init[i,1];j++)
                {
                    gameTable[init[i, 0]].AddCoin(players[0]);
                    gameTable[25-init[i, 0]].AddCoin(players[1]);
                }
            }


        }

        public Table Copy()
        {
            Table copy = new Table();
            for (int i = 0; i < 26; i++)
                copy.gameTable[i] = gameTable[i].Copy();
            return copy;
        }

        public bool IsTransferValid(Player p, int SourceIndex, int DestIndex, int[] offsets)
        {
            int offset = SourceIndex - DestIndex;
            return gameTable[SourceIndex].CanRemove(p) && gameTable[DestIndex].CanAdd(p) && (Math.Sign(offset) == p.Direction)
            && (Math.Abs(offset) == offsets[0] || Math.Abs(offset) == offsets[1] /*|| Math.Abs(offset) == offsets[0] + offsets[1]*/);
        }

        public bool TransferCoins(Player p, int SourceIndex, int DestIndex)
        {
            return gameTable[SourceIndex].RemoveCoin(p) && gameTable[DestIndex].AddCoin(p);
        }

        public CoinStack[] GameTable
        {
            get { return gameTable; }
        }


    }
}
