using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaWars
{
    class User : Field
    {
        Bitmap bitmap;
        Graphics g;
        public User(int width, int height) : base(width,height)
        {
            Field AllField = new Field(width, height);
            bitmap = new Bitmap(width, height);
            g = Graphics.FromImage(bitmap);
        }
    }
}
