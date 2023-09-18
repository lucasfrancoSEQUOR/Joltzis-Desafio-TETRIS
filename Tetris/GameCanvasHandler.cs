using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Timer = System.Windows.Forms.Timer;
using Tetris.Entities;

namespace Tetris {
    public class GameCanvasHandler
    {
        private readonly int _pixelSize;
        private IEnumerable<Position> oldPos;

        public GameCanvasHandler(int pixelSize)
        {
            _pixelSize = pixelSize;
        }

        public void Draw(Graphics graphics, ref int xPos, ref int yPos, Color color, bool jumpLine = false)
        {
            if (jumpLine)
            {
                xPos = 0;
                yPos += _pixelSize;
                return;
            }

            SolidBrush brush = new SolidBrush(color);

            graphics.FillRectangle(brush, new Rectangle(xPos, yPos, _pixelSize, _pixelSize));
            graphics.DrawRectangle(new(new SolidBrush(Color.Black)), new Rectangle(xPos, yPos, _pixelSize, _pixelSize));

            xPos += _pixelSize;
        }

        public Scenario MergeCurrentTileWithScenario(Scenario scenario, IEnumerable<Position> currentTile, int tileId)
        {
            foreach (Position p in currentTile)
                scenario[p.Row, p.Column] = tileId;

            return scenario;
        }

        public void Paint(Graphics graphics, Scenario scenario, IEnumerable<Position> currentTile, int tileId)
        {
            oldPos = currentTile;

            int xPos = 0;
            int yPos = -2 * _pixelSize;

            scenario = (Scenario)scenario.Clone();

            scenario = MergeCurrentTileWithScenario(scenario, currentTile, tileId);

            for (int i = 0; i < scenario.Rows; i++)
            {
                for (int j = 0; j < scenario.Columns; j++)
                    Draw(graphics, ref xPos, ref yPos, ColorHelper.GetColorById(scenario[i, j]));

                Draw(graphics, ref xPos, ref yPos, Color.White, true);
            }
        }
    }
}
