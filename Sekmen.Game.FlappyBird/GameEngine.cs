using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Sekmen.Game.FlappyBird
{
    public class GameEngine
    {
        public int Gravity = Speed;
        public bool Jumping;
        public int PipeSpeed = Speed;
        public int Score;
        private const int Speed = 5;

        /// <summary>
        /// https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-int-number-in-c
        /// Every time you do new Random() it is initialized .
        /// This means that in a tight loop you get the same value lots of times.
        /// You should keep a single Random instance and keep using Next on the same instance.
        /// </summary>
        private static readonly RandomNumberGenerator Generator = RandomNumberGenerator.Create();

        private readonly FrmMain _frmMain;
        private readonly int _pipeWidth;

        public GameEngine(FrmMain frmMain)
        {
            _frmMain = frmMain;
            _pipeWidth = frmMain.picPipeBottom.Width;
        }

        /// <summary>
        /// Generates really random number
        /// </summary>
        /// <param name="min">start integer inclusive</param>
        /// <param name="max">end integer exclusive</param>
        /// <returns></returns>
        public static int GetRandomNumber(int min = 0, int max = 100)
        {
            uint scale = uint.MaxValue;
            while (scale == uint.MaxValue)
            {
                // Get four random bytes.
                byte[] fourBytes = new byte[4];
                Generator.GetBytes(fourBytes);

                // Convert that into an uint.
                scale = BitConverter.ToUInt32(fourBytes, 0);
            }
            // Add min to the scaled difference between max and min.
            return (int)(min + (max - min) * (scale / (double)uint.MaxValue));
        }

        public void CheckGameEnd()
        {
            var bounds = new Rectangle(_frmMain.picFlappyBird.Bounds.X + 3,
                _frmMain.picFlappyBird.Bounds.Y + 3,
                _frmMain.picFlappyBird.Bounds.Width - 6,
                _frmMain.picFlappyBird.Bounds.Height - 6);

            // ReSharper disable once InvertIf
            if (bounds.Top < -100 ||
                bounds.IntersectsWith(_frmMain.picGround.Bounds) ||
                bounds.IntersectsWith(_frmMain.picPipeBottom.Bounds) ||
                bounds.IntersectsWith(_frmMain.picPipeTop.Bounds) ||
                bounds.IntersectsWith(_frmMain.picPipeBottom2.Bounds) ||
                bounds.IntersectsWith(_frmMain.picPipeTop2.Bounds))
            {
                _frmMain.GameEnd();
                _frmMain.btnStart.Focus();
            }
        }

        public void GameStart()
        {
            Score = 0;
            Gravity = 0;
            PipeSpeed = 0;
            MoveBird(true);
            _frmMain.lblEnd.Visible = _frmMain.listScores.Visible = _frmMain.btnStart.Visible = false;
            _frmMain.lblScore.Visible = true;
            _frmMain.timerGame.Start();
            _frmMain.Focus();
        }

        public void Jump(bool jumping)
        {
            Jumping = jumping;
            Gravity = jumping ? -Speed : Speed;
        }

        public void MoveBird(bool reset = false)
        {
            _frmMain.picFlappyBird.Top = reset ? 0 : _frmMain.picFlappyBird.Top + Gravity;
        }

        public void MovePipe(Control pipeTop, Control pipeBottom)
        {
            pipeTop.Left = pipeBottom.Left -= PipeSpeed;
            if (pipeTop.Left >= -_pipeWidth) return;

            pipeTop.Left = pipeBottom.Left = _frmMain.Width + _pipeWidth;
            int rnd = GetRandomNumber(-250, -100);
            pipeTop.Top = rnd;
            pipeBottom.Top = pipeTop.Top + 450;

            Score += 1;
            _frmMain.lblScore.Text = @"Score: " + Score;
        }

        public void MovePipe(Control pipeTop, Control pipeBottom, int left)
        {
            pipeTop.Left = pipeBottom.Left = left;
        }
    }
}