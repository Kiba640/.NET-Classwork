using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class Desk
    {
        public const int minWidth = 24;
        public const int maxWidth = 96;
        public const int minDepth = 12;
        public const int maxDepth = 48;

        public int width;
        public int depth;
        public Material desktop;
        public int numberOfDrawer;

        public int getArea()
        {
            return width * depth;
        }
        public Desk()
        {
            width = 0;
            depth = 0;
        }
    }
    public enum Material
    {
        oak, laminate, pine, rosewood, veneer
    }
}
