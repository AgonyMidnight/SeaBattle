using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaWars
{
    class Field
    {
        Bitmap bitmap;
        Graphics g;
        public Pen line = new Pen(Color.DarkBlue, 2);
        public SolidBrush whi = new SolidBrush(Color.White);
        public SolidBrush LakeShot = new SolidBrush(Color.DarkRed);
        public SolidBrush LoseShot = new SolidBrush(Color.Gray);


        public int horisontal = 11, vertical = 11, sq = 40;
        public int[,] Matrix = new int[11, 11];

        public Field(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            g = Graphics.FromImage(bitmap);
        }

        public Bitmap getStartField()
        {

            for (int i = 0; i< vertical; i++)
            {
                for(int j = 0; j < horisontal; j++)
                {
                    if ( (i == 0) && (j == 0))
                    {
                        g.FillRectangle(whi, i * sq, j * sq, sq, sq);
                    }
                    else if ((i!= 0)&& (j!=0))
                    {
                        g.DrawRectangle(line, i * sq, j * sq, sq, sq);
                    }
                    Matrix[i, j] = 0;
                }
            }

            return bitmap;
        }
        public Bitmap getFieldNow()
        {
            for (int i = 1; i< vertical; i++)
            {
                for (int j = 1; j < horisontal; j++)
                {
                    if (Matrix[i, j] == 0)
                    {
                        g.DrawRectangle(line, i * sq, j * sq, sq, sq);
                    }
                    else
                    {
                        g.FillRectangle(LakeShot, i * sq, j * sq, sq, sq);
                    }
                }
            }
            return bitmap;
        }
    }
}
