using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Entities
{
    public static class ColorHelper
    {
        public static Color GetColorById(int id)
        {
            switch (id)
            {
                case 1:
                    return Color.Blue;
                case 2:
                    return Color.Green;
                case 3:
                    return Color.Magenta;
                case 4:
                    return Color.Red;
                case 5:
                    return Color.Yellow;
                case 6:
                    return Color.Orange;
                case 7:
                    return Color.Brown;
                default:
                    return Color.White;
            }
        }
    }
}
