using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tetris
{
    public class GameStateHandler {


        private Block currentBlock;
        public Block CurrentBlock {
            get { return currentBlock; }
            set {
                currentBlock = value;
                currentBlock.Reset();

            }
        }

        public Scenario Scenario { get; }
        public Stack Stack { get; } 

        public bool GameOver { get; private set; }
    
        public GameStateHandler() {
            Scenario = new Scenario(22, 10);
            Stack = new Stack();
            CurrentBlock = Stack.GetAndUpdate();
        }

        private bool IsItFits() {
            foreach(Position p in CurrentBlock.TilePositions()) {

                if (!Scenario.IsEmpty(p.Row, p.Column)) {
                    return false;
                }
            }

            return true;
        }

        public void RotateBlockCW() {
            CurrentBlock.RotateCW();
            if (!IsItFits()) {
                CurrentBlock.RotateCCW();
            }
        }

        public void RotateBlockCCW() {
            CurrentBlock.RotateCCW();
            if (!IsItFits()) {
                CurrentBlock.RotateCW();
            }
        }

        public void MoveBlockLeft() {
            CurrentBlock.Move(0, -1);
            if (!IsItFits()) {
                CurrentBlock.Move(0, 1);
            }
        }

        public void MoveBlockRight() {
            CurrentBlock.Move(0, 1);
            if (!IsItFits()) {
                CurrentBlock.Move(0, -1);
            }
        }

        private bool IsGameOver() {
            return !(Scenario.IsRowEmpty(0) && Scenario.IsRowEmpty(1));
        }

        private void PlaceBlock() {
            foreach(Position p in CurrentBlock.TilePositions()) {
                Scenario[p.Row, p.Column] = CurrentBlock.Id;
            }

            Scenario.ClearFullRows();

            if(IsGameOver()) {
                GameOver = true;
            } else {
                CurrentBlock = Stack.GetAndUpdate();
            }
        }

        public void MoveBlockDown() {
            CurrentBlock.Move(1, 0);
            if (!IsItFits()) {
                CurrentBlock.Move(-1, 0);
                PlaceBlock();
            }
        }
    }
}
