using System;
using System.Windows.Forms;
using System.Drawing;

namespace PongGames
{
    public class Ball
    {
        private PictureBox ball;
        int xSpeed, ySpeed;
        const int limitOfTop = 34, limitOfBottom = 500, limitOfLeft = 5, limitOfRight = 981;
        Random rnd = new Random();
        Player p1, p2;

        public Ball(PictureBox aBall, Player leftPlayer, Player rightPlayer)
        {
            // genel tanımlanmış nesneleri method içerisinde atama
            this.ball = aBall;
            this.p1 = leftPlayer;
            this.p2 = rightPlayer;
            
            // Mutlak değerleri toplamı 3'ten küçük yada eşittir olana kadar rastgele değer gönderme
            // 0 değerini engelleyip başlangıç konumunda kalmaması için
            do
            {
                xSpeed = rnd.Next(-3, 3);
                ySpeed = rnd.Next(-3, 3);
            } while (Math.Abs(xSpeed) + Math.Abs(ySpeed) <= 3);
        }
        #region Top Hareket Sınırı ve Hız
        internal void ProcessMove()
        {
            var locY = Math.Max(limitOfTop, Math.Min(limitOfBottom, ball.Location.Y + ySpeed));
            ball.Location = new Point(ball.Location.X + xSpeed, locY);

            // Tavan ve Taban için kontrol
            if (ball.Location.Y == limitOfTop)
            {
                ySpeed = +2;
            }
            else if (ball.Location.Y == limitOfBottom)
            {
                ySpeed = -2;
            }

            // Skor için kontrol
            if (ball.Location.X <= limitOfLeft)
            {
                BallSpeed(p2);
            }
            else if (ball.Location.X >= limitOfRight)
            {
                BallSpeed(p1);
            }

            // Paddle'a çarptığında geri dönüş fonksiyonu
            if (p1.Paddle.Bounds.IntersectsWith(ball.Bounds)
                || p2.Paddle.Bounds.IntersectsWith(ball.Bounds))
                xSpeed *= -1;
        }
        #endregion

        public void BallSpeed(Player player)
        {
            player.score++;
            ball.Location = new Point((limitOfLeft + limitOfRight) / 2,
                (limitOfTop + limitOfBottom) / 2);
            
            // Mutlak değerleri toplamı 3'ten küçük yada eşittir olana kadar rastgele değer gönderme
            // 0 değerini engelleyip başlangıç konumunda kalmaması için
            do
            {
                xSpeed = rnd.Next(-3, 3);
                ySpeed = rnd.Next(-3, 3);
            } while (Math.Abs(xSpeed) + Math.Abs(ySpeed) <= 3 || Math.Abs(xSpeed) <= 1);
        }
    }
}
