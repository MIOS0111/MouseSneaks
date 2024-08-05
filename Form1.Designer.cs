namespace MouseScrolling
{
    partial class MouseSneaks
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.TimerMoveRight = new System.Windows.Forms.Timer(this.components);
            this.TimerMoveLeft = new System.Windows.Forms.Timer(this.components);
            this.TimerUp = new System.Windows.Forms.Timer(this.components);
            this.TimerDown = new System.Windows.Forms.Timer(this.components);
            this.MoveEntityTimer = new System.Windows.Forms.Timer(this.components);
            this.labelGameOver = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.staticLabelScore = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::MouseScrolling.Properties.Resources.left1;
            this.player.Location = new System.Drawing.Point(386, 422);
            this.player.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(80, 98);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // TimerMoveRight
            // 
            this.TimerMoveRight.Interval = 50;
            this.TimerMoveRight.Tick += new System.EventHandler(this.TimerMoveRight_Tick);
            // 
            // TimerMoveLeft
            // 
            this.TimerMoveLeft.Interval = 50;
            this.TimerMoveLeft.Tick += new System.EventHandler(this.TimerMoveLeft_Tick);
            // 
            // TimerUp
            // 
            this.TimerUp.Interval = 50;
            this.TimerUp.Tick += new System.EventHandler(this.TimerUp_Tick);
            // 
            // TimerDown
            // 
            this.TimerDown.Interval = 50;
            this.TimerDown.Tick += new System.EventHandler(this.TimerDown_Tick);
            // 
            // MoveEntityTimer
            // 
            this.MoveEntityTimer.Enabled = true;
            this.MoveEntityTimer.Interval = 50;
            this.MoveEntityTimer.Tick += new System.EventHandler(this.MoveEntityTimer_Tick);
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.SystemColors.GrayText;
            this.labelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameOver.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelGameOver.Location = new System.Drawing.Point(361, 182);
            this.labelGameOver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(225, 36);
            this.labelGameOver.TabIndex = 1;
            this.labelGameOver.Text = "игра окончена";
            this.labelGameOver.Visible = false;
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestart.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonRestart.Location = new System.Drawing.Point(362, 267);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(224, 39);
            this.buttonRestart.TabIndex = 2;
            this.buttonRestart.Text = "начать сначала";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // staticLabelScore
            // 
            this.staticLabelScore.AutoSize = true;
            this.staticLabelScore.BackColor = System.Drawing.Color.Transparent;
            this.staticLabelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.staticLabelScore.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.staticLabelScore.Location = new System.Drawing.Point(776, 18);
            this.staticLabelScore.Name = "staticLabelScore";
            this.staticLabelScore.Size = new System.Drawing.Size(77, 31);
            this.staticLabelScore.TabIndex = 3;
            this.staticLabelScore.Text = "счет:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelScore.Location = new System.Drawing.Point(854, 18);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(29, 31);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "0\r\n";
            // 
            // MouseSneaks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MouseScrolling.Properties.Resources.backImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.staticLabelScore);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.player);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MouseSneaks";
            this.Text = "Mouse sneaks";
            this.Load += new System.EventHandler(this.MouseScrolling_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MouseScrolling_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MouseScrolling_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer TimerMoveRight;
        private System.Windows.Forms.Timer TimerMoveLeft;
        private System.Windows.Forms.Timer TimerUp;
        private System.Windows.Forms.Timer TimerDown;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label staticLabelScore;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer MoveEntityTimer;
    }
}

