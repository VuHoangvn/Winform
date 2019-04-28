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
        private List<List<Button>> matrix;


        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox PlayerName { get => playerName; set => playerName = value; }
        public PictureBox Mark { get => mark; set => mark = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

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
        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);


            return point;
        }

        private bool isEndGane(Button btn)
        {

            return isEndHorizontal(btn) ||isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }

        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }

            int countRight = 0;
            for (int i = point.X + 1; i < Cons.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }
            return countLeft + countRight == 5;
        }

        private bool isEndVertical(Button btn)
        {

            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }

        private bool isEndPrimary(Button btn)
        {

            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.Y - i < 0 || point.X - i < 0)
                    break;
                if (Matrix[point.Y-i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH -point.X; i++)
            {
                if (point.Y + i >= Cons.CHESS_BOARD_HEIGHT || point.X + i >= Cons.CHESS_BOARD_WIDTH)
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }

        private bool isEndSub(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.Y - i < 0 || point.X + i > Cons.CHESS_BOARD_WIDTH)
                    break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= Cons.CHESS_BOARD_HEIGHT || point.X - i < 0)
                    break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;

        }
        private void EndGame()
        {
            MessageBox.Show("End game!");
        }
        public void DrawChessBoard()
        {
            matrix = new List<List<Button>>();
            Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    btn.Click += btn_click;

                    chessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);
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

            if (isEndGane(btn))
            {
                EndGame();
            }
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
