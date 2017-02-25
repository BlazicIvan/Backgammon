using etf.backgammon.bi140643d;
using System.Windows.Forms;
using System.Drawing;


namespace etf.backgammon.bi140643d
{
    public class CoinStackView : Panel
    {

        private CoinStack subject;
        private PictureBox[] sprites;
        private TableView parent;
        private bool selected, invert, penalty;
        private Image blackSprite = Properties.Resources.token_black;
        private Image whiteSprite = Properties.Resources.token_white;
        private Image sprite;
        private ToolTip indexBubble;
        private Label overflowLabel;

        private const int viewLimit = 5;
        private const int labelXOffset = 10;
        private const int labelYOffset = 20;


        public CoinStackView(TableView ParentTable ,CoinStack SubjectStack, bool invert, bool penalty=false)
        {
            InitializeComponent();
            sprite = whiteSprite;
            parent = ParentTable;
            subject = SubjectStack;
            Width = sprite.Width+2;
            Height = viewLimit * 50 + 2;
            sprites = new PictureBox[viewLimit];
            BackColor = Color.Transparent;
            selected = false;
            this.invert = invert;
            this.penalty = penalty;

            indexBubble = new ToolTip();
            indexBubble.IsBalloon = true;
            indexBubble.UseFading = false;
            indexBubble.ShowAlways = true;
            

            for (int i = 0; i < viewLimit; i++)
            {
                sprites[i] = new PictureBox();
                sprites[i].Width = sprite.Width;
                sprites[i].Height = sprite.Height;
                sprites[i].Image = sprite;
                sprites[i].SendToBack();
                sprites[i].MouseEnter += new System.EventHandler(this.CoinStackView_MouseEnter);
                sprites[i].MouseLeave += new System.EventHandler(this.CoinStackView_MouseLeave);
                sprites[i].MouseClick += new System.Windows.Forms.MouseEventHandler(this.CoinStackView_MouseClick);

                Controls.Add(sprites[i]);
                sprites[i].Location = new Point(0, i * sprite.Height);
            }


            overflowLabel = new Label();
            overflowLabel.Font = new Font("Arial", 14, FontStyle.Bold);
            if(invert)
                overflowLabel.Location = new Point(Location.X + labelXOffset, Location.Y + labelYOffset);
            else
                overflowLabel.Location = new Point(Location.X + labelXOffset, Location.Y + Height - labelYOffset*2);
            overflowLabel.Visible = false;
            Controls.Add(overflowLabel);


            UpdateView();
            BringToFront();
        }


        public void UpdateView()
        {
            if(subject.Owner != null)
            {
                sprite = (subject.Owner.TokenColor == Color.White ? whiteSprite : blackSprite);
            }
            
            for (int i = 0; i < viewLimit; i++)
            {
                sprites[i].Image = sprite;

                if (i < subject.CoinCount)
                    sprites[(invert ? (viewLimit - i - 1) : i)].Visible = true;
                else
                    sprites[(invert ? (viewLimit - i - 1) : i)].Visible = false;
            }



            if (subject.CoinCount > viewLimit)
            {
                int overflow = subject.CoinCount - viewLimit;
                overflowLabel.Text = "+" + (overflow+1);
                sprites[(invert ? 0 : (viewLimit - 1))].Visible = false;
            }

            overflowLabel.Visible = subject.CoinCount > viewLimit;


        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CoinStackView
            // 
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CoinStackView_MouseClick);
            this.MouseEnter += new System.EventHandler(this.CoinStackView_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.CoinStackView_MouseLeave);
            this.ResumeLayout(false);

        }


        private void CoinStackView_MouseEnter(object sender, System.EventArgs e)
        {
            
            if(!penalty && parent.NotifyHovered(subject.Index))
            {
                indexBubble.Show(subject.Index.ToString(), parent.game.window, Location.X + Width / 2, Location.Y);
                if (selected)
                    BorderStyle = BorderStyle.Fixed3D;
                else
                    BorderStyle = BorderStyle.FixedSingle;
            }

        }

        private void CoinStackView_MouseLeave(object sender, System.EventArgs e)
        {
            indexBubble.Hide(parent.game.window);
            if (!selected && !penalty)
                BorderStyle = BorderStyle.None;
        }

        private void CoinStackView_MouseClick(object sender, MouseEventArgs e)
        {
            parent.NotifySelected(subject.Index);
            indexBubble.Hide(parent.game.window);
        }

        public void SetSelected(bool selected)
        {
            this.selected = selected;
            
            if (penalty) return;

            if(selected)
            {
                BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                BorderStyle = BorderStyle.None;
            }
        }

        public CoinStack Subject { get { return subject; } }
    }
}
