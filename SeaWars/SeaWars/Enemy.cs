using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeaWars
{
    class Enemy : Field

    {
        Bitmap bitmap;
        Graphics g;
        public Enemy(int width, int height) : base(width, height)
        {
            bitmap = new Bitmap(width, height);
            g = Graphics.FromImage(bitmap);
        }

        public Bitmap getEnemyStep()
        {
            int x, y;
            do
            {
                Thread.Sleep(1);
                Random random = new Random(DateTime.Now.Millisecond);
                x = random.Next(1, base.vertical);
                y = random.Next(1, base.horisontal);

            } while (base.Matrix[x, y] == 1);
            base.Matrix[x, y] = 1;
            for (int i = 1; i < base.vertical; i++)
            {
                for (int j = 1; j < base.horisontal; j++)
                {
                    if (base.Matrix[i,j] == 0)
                    {
                        g.DrawRectangle(base.line, i * base.sq, j * base.sq, base.sq, base.sq);
                    }
                    else
                    {
                        g.FillRectangle(base.LakeShot, i * base.sq, j * base.sq, base.sq, base.sq);
                    }
                }
            }


            return bitmap;
        }
    }
}
