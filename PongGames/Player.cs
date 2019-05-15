using System;
using System.Drawing;
using System.Windows.Forms;

namespace PongGames
{
    public class Player
    {
        public PictureBox Paddle;
        public bool isUpPressed, isDownPressed;
        Label scoreLabel;
        bool? wasGoingUpLastTick;
        int numberOfTicks;
        const int speed = 2, limitOfTop = 34, limitOfBottom = 367;
        #region Skor
        int _score;
        public int score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
                scoreLabel.Text = score.ToString();
            }
        }
        #endregion

        public Player(PictureBox aPaddle1, Label score_Label)
        {
            this.Paddle = aPaddle1;
            this.scoreLabel = score_Label;
        }

        #region Hareket
        internal void ProcessMove()
        {
            bool? goingUp = null;
            if (isUpPressed)
            {
                goingUp = true;
            }

            else if (isDownPressed)
            {
                if (goingUp.HasValue)
                {
                    goingUp = null;
                }
                else
                {
                    goingUp = false;
                }
            }

            #region Basılı Tutma Kontrolü
            // Basılı tuttukça hareket hızı artar
            if (wasGoingUpLastTick.HasValue)
            {
                if (!goingUp.HasValue)
                {
                    wasGoingUpLastTick = null;
                    numberOfTicks = 0;
                }
                else if (wasGoingUpLastTick.Value == goingUp.Value)
                {
                    numberOfTicks++;
                }
                else
                {
                    wasGoingUpLastTick = goingUp;
                    numberOfTicks = 1;
                }
            }

            else if (goingUp.HasValue)
            {
                wasGoingUpLastTick = goingUp;
                numberOfTicks = 1;
            }

            #endregion

            DoMove(goingUp);
        }
        #endregion

        private void DoMove(bool? goingUp)
        {
            if (goingUp.HasValue)
            {
                var moveSpeed = (int)Math.Round(speed * (float)(numberOfTicks / 13));
                if (goingUp.Value)
                {
                    moveSpeed *= -1;
                }
                Paddle.Location = new Point(Paddle.Location.X, Math.Max(limitOfTop, Math.Min(limitOfBottom, Paddle.Location.Y + moveSpeed)));
            }
        }
    }
}
