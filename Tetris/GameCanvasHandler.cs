using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Timer = System.Windows.Forms.Timer;

namespace Tetris {
    class GameCanvasHandler {

        private Bitmap offScreenBitmap;
        private Graphics bitmapGraph;
        private Graphics screenGraph;

        private Timer Frame {  get; set; }
        private Panel PanelJogo { get; set; }

        public GameCanvasHandler(ref Timer frame ,ref Panel panel) {
            PanelJogo = panel;
            Frame = frame;
            offScreenBitmap = new Bitmap(670, 1340);
            GameStateHandler GameState = new GameStateHandler();
        }

        public void StartGame() {
            GameStateHandler GameState = new GameStateHandler();
            bitmapGraph = Graphics.FromImage(offScreenBitmap);
            screenGraph = PanelJogo.CreateGraphics();
            Frame.Enabled = true;
        }
        
       
    }
}
