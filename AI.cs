using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace etf.backgammon.bi140643d
{
    public class AI
    {
  
        class Node
        {
            public Table table;
            public Player creator;
            public int[] diceRes;
            public List<Node> children;

            public int value; // Minimax value

            public Node(Table table, int[] diceRes, Player creator, int minmaxValue)
            {
                children = null;
                this.diceRes = diceRes;
                this.table = table;
                value = minmaxValue;
            }



            public void CalculateChildren()
            {
                List<int[]> transfers;
                for(int d1 = 1; d1 <= 6; d1++)
                {
                    for(int d2 = 1; d2 <= 6; d2++)
                    {
                        int[] dice = { d1, d2 };

                        transfers = CalcPossibleMoves(table, creator.Opponent, dice);

                        foreach(int[] move in transfers)
                        {
                            Table t = table.Copy();
                            t.TransferCoins(creator.Opponent, move[0], move[1]);
                            children.Add(new Node(t, dice, creator.Opponent,0));
                        }
                    }
                }
            }
        }



        class MiniMax
        {
            public Node root;
            public int treeDepth;

            public MiniMax()
            {
                root = null;
            }


            public void Calculate(Table table, int[] diceRes, Player p, int depth)
            {
                if(root == null)
                {
                    treeDepth = depth;
                    root = new Node(table, diceRes, p,0);
                    Queue<Node> q = new Queue<Node>();

                    Node cur = root;
                    cur.CalculateChildren();
                    
                    while (depth>0)
                    {
                        foreach (Node c in cur.children)
                            q.Enqueue(c);

                        while (q.Count>0)
                        {
                            cur = q.Dequeue();
                            cur.CalculateChildren();
                        }
                        depth--;
                    }
                }
            }

        }


        public static int[] CalcBestMove(Table table, int[] diceRes, Player p, int depth)
        {
            int[] res;
            MiniMax tree = new MiniMax();
            tree.Calculate(table, diceRes, p, depth);
            bool max = true;
            int minmax;
            Node cur = tree.root, next;

            while (depth > 0)
            {
                next = cur.children[0];
                minmax = next.value;

                foreach(Node child in cur.children)
                {
                    if((max && child.value > minmax) ||(!max && child.value < minmax))
                    {
                        next = child;
                        minmax = child.value;
                    }
                }

                cur = next;
                max = !max;
                depth--;
            }

            res = null;
            return res;
        }


        public static int PossibleMoveCount(Game game)
        {
            Player p = game.CurrentPlayer;

            int count = CalcPossibleMoves(game.table, p, game.dice.Result, p.Penalty, game.PenaltyIndex).Count;
            
            if (count == 0)
                MessageBox.Show(p.ToString() + " nema mogućih poteza!");
            
            return count;
        }


        public static List<int[]> CalcPossibleMoves(Table table, Player p, int[] diceRes, bool penalty = false, int penaltyIndex = -1)
        {
            List<int[]> res = new List<int[]>();

            if (p.Penalty)
            {
                int i = penaltyIndex;
                for (int j = 1; j < 25; j++)
                {
                    if (table.IsTransferValid(p, i, j, diceRes))
                        res.Add(new int[] { i, j });
                }
            }

            for (int i = 1; i < 25; i++)
            {
                if (table.GameTable[i].CheckPermission(p))
                {
                    for (int j = 1; j < 25; j++)
                    {
                        if (table.IsTransferValid(p, i, j, diceRes))
                            res.Add(new int[] { i, j });
                    }
                }
            }

            return res;
        }

    }
}
