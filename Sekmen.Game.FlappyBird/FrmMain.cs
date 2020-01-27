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
            _gameEngine.MovePipe(picPipeTop, picPipeBottom);
            _gameEngine.MovePipe(picPipeTop2, picPipeBottom2);
            _gameEngine.MoveBird();
            _gameEngine.CheckGameEnd();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) _gameEngine.Jump(true);
        }

        private void FrmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) _gameEngine.Jump(false);
        }

        public void GameEnd()
        {
            timerGame.Stop();
            lblScore.Visible = false;
            lblEnd.Visible = listScores.Visible = btnStart.Visible = true;
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            //_gameEngine.MovePipe(picPipeTop, picPipeBottom, Width);
            //_gameEngine.MovePipe(picPipeTop2, picPipeBottom2, (int)(Width * 1.6));
            _gameEngine.GameStart();
        }
    }
}
