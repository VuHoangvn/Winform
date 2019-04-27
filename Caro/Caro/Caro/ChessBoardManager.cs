using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        private int currentPlayer;
        private List<Player> player;
        private TextBox playerName;
        private PictureBox mark;

        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox PlayerName { get => playerName; set => playerName = value; }
        public PictureBox Mark { get => mark; set => mark = value; }

        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox PlayerName, PictureBox mark)
        {
            this.chessBoard = chessBoard;
            this.PlayerName = PlayerName;
            this.Mark = mark;
            this.player = new List<Player>()
            {
                new Player("Seohuyn", Image.FromFile(Application.StartupPath + "\\Resources\\seohyun.jpg")),
                new Player("Ramsey", Image.FromFile(Application.StartupPath + "\\Resources\\Ramsey.jpg"))
            };
            CurrentPlayer = 0;
            changePlayer();
        }

        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch
                    };
                    btn.Click += btn_click;

                    chessBoard.Controls.Add(btn);
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(0, oldbtn.Location.Y + Cons.CHESS_HEIGHT);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;

            MarkPlayer(btn);

            changePlayer();
        }

        private void MarkPlayer(Button btn)
        {
            btn.BackgroundImage = player[currentPlayer].Mark;

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }

        private void changePlayer()
        {
            PlayerName.Text = player[currentPlayer].Name;

            Mark.Image = player[currentPlayer].Mark;
        }
        #endregion

    }
}
