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

        private int width;
        private int depth;
        private Material desktop;
        private int numberOfDrawer;


        Desk(int width, int depth, Material material, int drawers)
        {
            this.width = width;
            this.depth = depth;
            desktop = material;
            numberOfDrawer = drawers;
        }

    }
    public enum Material
    {
        oak = 200, laminate = 100, pine = 50, rosewood = 300, veneer = 125
    }
}
