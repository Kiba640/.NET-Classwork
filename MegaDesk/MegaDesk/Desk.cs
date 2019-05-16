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


        public Desk(int width, int depth, Material material, int drawers)
        {
            this.width = width;
            this.depth = depth;
            desktop = material;
            numberOfDrawer = drawers;
        }

        public int getArea()
        {
            return width * depth;
        }
    }
    public enum Material
    {
        oak, laminate, pine, rosewood, veneer
    }
}
