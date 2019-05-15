using PongGames.Properties;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace PongGames
{
    public partial class Form1 : Form
    {
        Player p1;
        Player p2;
        Ball ball;

        public Form1()
        {
            InitializeComponent();
            p1 = new Player(Paddle1, score1);
            p2 = new Player(Paddle2, score2);
            ball = new Ball(Ball, p1, p2);
        }
        
        #region Panel Movable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void element_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        #region Cancel Process

        private void CloseBox_Click(object sender, EventArgs e) => Environment.Exit(1);

        private void CloseBox_MouseHover(object sender, EventArgs e) => CloseBox.Image = Resources.cancelhover;

        private void CloseBox_MouseLeave(object sender, EventArgs e) => CloseBox.Image = Resources.cancel;

        #endregion

        #region KeyDown - KeyUp - CheckKeys

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            CheckKeys(e, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            CheckKeys(e, false);
        }

        private void CheckKeys(KeyEventArgs e, bool isDown)
        {
            switch (e.KeyCode)
            {
                #region Player1
                case Keys.W:
                    p1.isUpPressed = isDown;
                    break;
                case Keys.S:
                    p1.isDownPressed = isDown;
                    break;
                #endregion

                #region Player2
                case Keys.Up:
                    p2.isUpPressed = isDown;
                    break;
                case Keys.Down:
                    p2.isDownPressed = isDown;
                    break;
                #endregion
            }
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            p1.ProcessMove();
            p2.ProcessMove();
            ball.ProcessMove();
        }
    }
}
