using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris {
    public partial class Jogo : Form {
        public Graphics gameGraphics;
        private GameStateHandler gameStateHandler;

        public Jogo(GameStateHandler stateHandler)
        {
            gameStateHandler = stateHandler;
            InitializeComponent();
        }

        private void Jogo_Paint(object sender, PaintEventArgs e)
        {
            // Nada!
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            gameGraphics = this.CreateGraphics();
        }

        private void Jogo_KeyUp(object sender, KeyEventArgs e)
        {
            gameStateHandler.ListenMovement(e);
        }
    }
}
