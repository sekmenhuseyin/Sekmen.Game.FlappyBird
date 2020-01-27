using System;
using System.Windows.Forms;

namespace Sekmen.Game.FlappyBird
{
    public partial class FrmMain : Form
    {
        private GameEngine _gameEngine;
        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _gameEngine = new GameEngine(this);
            BtnRestart_Click(sender, e);
        }

        private void TimerGame_Tick(object sender, EventArgs e)
        {
            lblScore.Text = @"Score: " + _gameEngine.Score;

            _gameEngine.MovePipe(picPipeTop, picPipeBottom);
            _gameEngine.MovePipe(picPipeTop2, picPipeBottom2);
            picFlappyBird.Top += _gameEngine.Gravity;
            _gameEngine.CheckGameEnd();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space) return;

            _gameEngine.Jumping = true;
            _gameEngine.Gravity = -5;
        }

        private void FrmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space) return;

            _gameEngine.Jumping = false;
            _gameEngine.Gravity = 5;
        }

        public void GameEnd()
        {
            timerGame.Stop();
            lblScore.Visible = false;
            lblEnd.Visible = listScores.Visible = btnStart.Visible = true;
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            _gameEngine.Score = 0;
            picPipeTop.Left = picPipeBottom.Left = Width + picPipeTop.Width;
            picPipeTop2.Left = picPipeBottom2.Left = (int)(Width * 1.6) + picPipeTop2.Width;
            lblEnd.Visible = listScores.Visible = btnStart.Visible = false;
            lblScore.Visible = true;
            picFlappyBird.Top = 0;
            timerGame.Start();
            Focus();
        }
    }
}
