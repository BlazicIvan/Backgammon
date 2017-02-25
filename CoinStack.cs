using etf.backgammon.bi140643d;

namespace etf.backgammon.bi140643d
{
    public class CoinStack
    {
        private int coinCount, index;
        private Player owner = null;
        private CoinStackView view = null;

        public CoinStack Copy()
        {
            return new CoinStack(this.index, this.coinCount);
        }

        public CoinStack(int index, int initCount = 0)
        {
            this.index = index;
            coinCount = initCount;
        }

        public bool CanAdd(Player p)
        {
            return (CheckPermission(p) ||  coinCount == 1);
        }

        public bool CanRemove(Player p)
        {
            return CheckPermission(p) && coinCount > 0;
        }

        public bool AddCoin(Player p)
        {
            if(CanAdd(p))
            {
                owner = p;
                coinCount++;
                return true;
            }
            return false;
                
        }

        public bool RemoveCoin(Player p)
        {
            if (CanRemove(p))
            {
                coinCount--;
                if (coinCount == 0)
                    owner = null;
                return true;
            }
            return false;
        }

        public bool CheckPermission(Player p)
        {
            return (owner == null || p == owner);

        }


        public void AssignView(CoinStackView View)
        {
            view = View;
        }


        public Player Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public int CoinCount
        {
            get { return coinCount; }
        }

        public int Index
        {
            get { return index; }
        }

    }
}
