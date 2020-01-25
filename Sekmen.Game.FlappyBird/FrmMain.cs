using System;
using System.Windows.Forms;

namespace Sekmen.Game.FlappyBird
{
    public partial class FrmMain : Form
    {
        private bool _jumping = false;
        private int _pipeSpeed = 5;
        private int _gravity = 5;
        private int _score = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblEnd1.Text = @"Game Over";
            lblEnd2.Text = @"Your score: " + _score;
            lblCredits.Text = @"Credits";
            lblEnd1.Visible = lblEnd2.Visible = lblCredits.Visible = false;
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            picPipeBottom.Left -= _pipeSpeed;
            picPipeTop.Left -= _pipeSpeed;
            picFlappyBird.Top += _gravity;
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space) return;

            _jumping = true;
            _gravity = -5;
        }

        private void FrmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space) return;

            _jumping = false;
            _gravity = 5;
        }

        private void GameEnd()
        {

        }
    }
}
