using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace GameTestJump.Classes
{
    public class platform
    {
        Image sprite;
        public transform transform;
        public int sizeX;
        public int sizeY;
        public bool isTouchedByPlayer;

        public platform(PointF pos)
        {
            sprite = Properties.Resources.ButtonExtraWide_Pink;
            sizeX = 125;
            sizeY = 15;
            transform = new transform(pos, new Size(sizeX, sizeY));
            isTouchedByPlayer = false;

        }

        public void DrawSprite(Graphics g)
        {
            g.DrawImage(sprite, transform.position.X, transform.position.Y, transform.size.Width, transform.size.Height);
        }
    }
}
