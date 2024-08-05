using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseScrolling
{
    class Bonus : PictureBox
    {
        const int speed = 1; 
        Random random = new Random();
        public Type type;

        private void SetLocation()
        {
            Location = new Point(random.Next(0, 31) * 30, random.Next(-200, -100));
        }

        private void SetType()
        {
            int number = random.Next(0, 8);
            if (number == 0)
            {
                type = Type.Avily;
                Image = Properties.Resources.avily;
            }
            else if (number < 3)
            {
                type = Type.Coin;
                Image = Properties.Resources.coin;
            }
            else
            {
                type = Type.Star;
                Image = Properties.Resources.star;
            }

            BackColor = Color.Transparent;
        }
        public void Reload()
        {
            SetLocation();
            SetType();
        }

        public void Fail()
        {
            Top += speed;
        }
    }

    public enum Type
    {
        Star,
        Coin,
        Avily
    }
}