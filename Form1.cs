using MouseScrolling.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MouseScrolling
{
    public partial class MouseSneaks : Form
    {
        const int speed = 4; //шаг при движении
        bool inJump = false; //принимает значение true, если игрок находится в состоянии прыжка. 
        int counterMove = 0;//счетчик движения (нужно для анимации)
        Image[] moveRight = { Resources.right1, Resources.right2,
        Resources.right3, Resources.right4 }; //для анимации движения
        Image[] moveLeft = { Resources.left1, Resources.left2,// (через гифку было слишком сильное мерцание)
        Resources.left3, Resources.left4};
        Enemy[] enemys;
        Bonus[] bonuses;
        int score = 0;
        WindowsMediaPlayer coinSound;
        WindowsMediaPlayer jumpSound;
        WindowsMediaPlayer gameOverSound;
        public MouseSneaks()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private WindowsMediaPlayer AddSound(string url)// загрузка звуков
        {
            var wmp = new WindowsMediaPlayer();
            wmp.URL = url;
            wmp.settings.volume = 100;
            return wmp;
        }

        private void MouseScrolling_KeyDown(object sender, KeyEventArgs e) //обработка клавиш
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                TimerMoveLeft.Start();
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                TimerMoveRight.Start();
            }
            else if (e.KeyCode == Keys.W && !inJump)
                Jump();
        }

        private void MouseScrolling_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                player.Image = Resources.left1;
                TimerMoveLeft.Stop();
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                player.Image = Resources.right1;
                TimerMoveRight.Stop();
            }
            counterMove = 0;
        }

        private void MouseScrolling_Load(object sender, EventArgs e) //действия при загрузке формы
        {
            enemys = new Enemy[3]; //враги
            bonuses = new Bonus[3]; //бонусы 
            for (int i = 0; i < 3; i++)
            {
                enemys[i] = new Enemy();
                enemys[i].Size = new Size(50, 50);
                enemys[i].Location = new Point(enemys[i].SetLeft(), 460);
                enemys[i].BackColor = Color.Transparent;
                enemys[i].SetOrientation(player);
                enemys[i].ResetImage();
                enemys[i].SizeMode = PictureBoxSizeMode.StretchImage;
                enemys[i].TabIndex = 0;
                enemys[i].TabStop = false;
                enemys[i].Visible = true;
                this.Controls.Add(enemys[i]);
                bonuses[i] = new Bonus();
                bonuses[i].Size = new Size(70, 70);
                bonuses[i].Reload();
                bonuses[i].SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(bonuses[i]);
            }
        }

        private void TimerMoveRight_Tick(object sender, EventArgs e)  // движение
        {
            if (player.Left < 850) player.Left += speed;
            if (inJump) player.Image = moveRight[1];// в прыжке анимация не проигрывается
            else AnimationMove(moveRight);
        }

        private void TimerMoveLeft_Tick(object sender, EventArgs e)
        {
            if (player.Left > 10) player.Left -= speed;
            if (inJump) player.Image = moveLeft[1];
            else AnimationMove(moveLeft);
        }

        private void AnimationMove(Image[] moveArray)
        {
            counterMove++;
            player.Image = moveArray[counterMove];
            counterMove = counterMove % 3;
        }

        public void Jump() //прыжок
        {
            inJump = true;
            TimerUp.Start();
            jumpSound = AddSound(@"C:\Users\pro\Desktop\Project\MouseScrolling\gameFiles\jumpSound.mp3");
        }//при инициализации WMP проигрывается звук, поэтому не стал добавлять сразу при загрузке формы

        private void TimerUp_Tick(object sender, EventArgs e) 
        {
            player.Top -= speed * 5;
            if (player.Top < 200)
            {
                TimerUp.Stop();
                TimerDown.Start();
            }
        }

        private void TimerDown_Tick(object sender, EventArgs e)
        {
            player.Top += speed * 5;
            if (player.Top > 415)
            {
                TimerDown.Stop();
                inJump = false;
            }
        }

        private void MoveEntityTimer_Tick(object sender, EventArgs e) // движение врагов
        {
            for(var i = 0; i < 3; i++) 
            {
                enemys[i].MoveToPlayer();
                bonuses[i].Fail();
                if (enemys[i].Bounds.IntersectsWith(player.Bounds))
                {
                    if (TimerDown.Enabled) //враги должны уничтожаться только тогда, когда игрок падает на них сверху
                    {
                        score++;
                        labelScore.Text = score.ToString();
                        enemys[i].Left = enemys[i].SetLeft();
                        enemys[i].SetOrientation(player);
                        enemys[i].ResetImage();
                        coinSound = AddSound(@"C:\Users\pro\Desktop\Project\MouseScrolling\gameFiles\coinSound.mp3");
                    }
                    else GameOver();
                }

                if (bonuses[i].Top >= 600)
                    bonuses[i].Reload();
                if (bonuses[i].Bounds.IntersectsWith(player.Bounds))
                {
                    switch (bonuses[i].type)
                    {
                        case (Type.Avily):
                            GameOver();
                            break;
                        case (Type.Coin):
                            ScoreUpdate(bonuses[i], 3);
                            break;
                        case (Type.Star):
                            ScoreUpdate(bonuses[i], 1);
                            break;

                    }
                }
            }
        }

        private void ScoreUpdate(Bonus bonus, int i)
        {
            bonus.Reload();
            score += i;
            labelScore.Text = score.ToString();
            coinSound = AddSound(@"C:\Users\pro\Desktop\Project\MouseScrolling\gameFiles\coinSound.mp3");
        }

        private void GameOver()
        {
            labelGameOver.Visible = true;
            buttonRestart.Visible = true;
            player.Visible = false;
            MoveEntityTimer.Stop();
            gameOverSound = AddSound("C:\\Users\\pro\\Desktop\\Project\\MouseScrolling\\gameFiles\\gameOverSound.mp3");
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i ++)
            {
                enemys[i].Left = enemys[i].SetLeft();
                enemys[i].SetOrientation(player);
                enemys[i].ResetImage();
                bonuses[i].Reload();
            }
            player.Visible = true;
            player.Location = new Point(386, 422);
            MoveEntityTimer.Start();
            labelGameOver.Visible = false;
            buttonRestart.Visible = false;
            score = 0;
            labelScore.Text = "0";
        }
    }   
}
