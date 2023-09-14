using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Stack {

        private readonly Block[] blocks = new Block[] {
            new JBlock(),
            new OBlock(),
            new LBlock(),
            new TBlock(),
            new ZBlock(),
            new IBlock(),
            new SBlock()
        };

        private readonly Random random = new Random();

        public Block NextBlock { get; private set; }

        public Stack() {
            NextBlock = RandomBlock();
        }

        private Block RandomBlock() {
            return blocks[random.Next(blocks.Length)];
        }

        public Block GetAndUpdate() {
            Block block = NextBlock;

            do {
                NextBlock = RandomBlock();
            } while (block.Id == NextBlock.Id);

            return block;
        }

    }
}
