using spaceshooter.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaceshooter
{
    public abstract class Sprite
    {
        protected int centerX;
        protected int centerY;
        protected List<Point> displayPoints;
        protected char displayPixel;

        public abstract void InitializeShape();

        public List<Point> DisplayPoints
        {
            get { return displayPoints; }
        }

        public int CenterX
        {
            get { return centerX; }
            set
            {
                centerX = value;
                InitializeShape();
            }
        }

        public int CenterY
        {
            get { return centerY; }
            set
            {
                centerY = value;
                InitializeShape();
            }
        }
    }
}
