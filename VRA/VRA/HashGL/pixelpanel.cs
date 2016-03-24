using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace VRA.HashGL
{
    public class pixelpanel
    {
        public int width;
        public int height;
        public int width2;
        public int r1;
        public int r2;
        public int r3;
        public int x;
        public int y;
        public int z;
        public Color cred;
        
        

        public System.Windows.Forms.PictureBox pic;

        public int draw()
        {
            Bitmap b = new Bitmap(pic.Width,pic.Height);
            
            for (int wi = 0;wi < (width + 1)-(hf/10)z; wi++)
            {
                for (int he = 0; he < (height + 1)-z; he++)
                {
                    try {
                        b.SetPixel(wi + x, he + y, cred);
                    }
                    catch { }
                }
            }
            pic.Image = b;


            return 0;
        }

        public int draw(shader s)
        {

            return 10;
        }
    }
}
