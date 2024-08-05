using System;
using System.Windows.Forms;

namespace MouseScrolling
{
    class Enemy : PictureBox
    {
        int speed; // = 2;
        Random random = new Random();
        bool orientation; 

        public void SetOrientation(PictureBox player)
        {
            orientation = LeftOfPlayer(player);
        }

        public bool LeftOfPlayer(PictureBox player)
        {
            if (Left < player.Left)
                return true;
            else return false;
        }

        public int SetLeft()
        {
            int newLeft = random.Next(0, 2);
            return newLeft * 1200 + random.Next(-11, -2) * 20;
        }

        public void ResetImage()
        {
            if(orientation)
            {
                Image = Properties.Resources.mouseRight;
                speed = 2;
            }
            else
            {
                Image = Properties.Resources.mouseLeft;
                speed = -2;
            }
        }

        public void MoveToPlayer()
        {
            Left += speed;
        }
    }
}