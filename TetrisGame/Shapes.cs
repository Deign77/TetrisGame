using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    class Shapes
    {
        public static List<Brush> shapeColours = new List<Brush> { Brushes.White, Brushes.Orange, Brushes.DarkBlue, Brushes.Cyan, Brushes.Red, Brushes.Green, Brushes.Purple, Brushes.Yellow };

        public static List<Point[]> shapeList = new List<Point[]> { new Point[] {new Point(0, 5)},
            new Point[] { new Point(1, 4), new Point(0, 4), new Point(2, 4), new Point(3, 4) }, // I
            new Point[] { new Point(1, 5), new Point(0, 5), new Point(2, 5), new Point(2, 4) }, // J
            new Point[] { new Point(1, 4), new Point(0, 4), new Point(2, 4), new Point(2, 5) }, // L 
            new Point[] { new Point(1, 4), new Point(0, 4), new Point(0, 5), new Point(1, 5) }, // O
            new Point[] { new Point(1, 5), new Point(0, 5), new Point(0, 6), new Point(1, 4) }, // S
            new Point[] { new Point(1, 5), new Point(0, 5), new Point(1, 4), new Point(1, 6) }, // T         
            new Point[] { new Point(1, 5), new Point(0, 5), new Point(0, 4), new Point(1, 6) }  // Z
        };

        public static Bitmap CreateImages(int chosenColour, int bitmapwidth, int bitmapheight, Point[] points)
        {
            Bitmap newmap = new Bitmap(bitmapwidth * 40, bitmapheight * 40);
            Graphics grfx = Graphics.FromImage(newmap);

            grfx.FillRectangle(Brushes.Black, 0, 0, newmap.Width, newmap.Height);

            for (int i = 0; i < 4; i++)
                grfx.FillRectangle(shapeColours[chosenColour], points[i].Y * 40 - 1, points[i].X * 40 - 1, 40 - 1, 40 - 1);

            return newmap;
        }

        public static List<Point[]> shapeImageList = shapeList.Select(b => b.Select(m => new Point(m.X, m.Y - 4)).ToArray()).ToList();

        public static List<Bitmap> shapeImages = new List<Bitmap> { new Bitmap(10, 10),
            ResizeBitmap(new Bitmap(CreateImages(1, 4, 1, shapeImageList[1].Select(m => new Point(m.Y, m.X)).ToArray())), 80, 20),
            ResizeBitmap(new Bitmap(CreateImages(2, 3, 2, shapeImageList[3].Select(m => new Point(m.Y, m.X)).ToArray())), 60, 40),
            ResizeBitmap(new Bitmap(CreateImages(3, 3, 2, shapeImageList[2].Select(m => new Point(m.Y, m.X)).ToArray())), 60, 40),
            ResizeBitmap(new Bitmap(CreateImages(4, 2, 2, shapeImageList[4])), 40, 40),
            ResizeBitmap(new Bitmap(CreateImages(5, 3, 2, shapeImageList[5])), 60, 40),
            ResizeBitmap(new Bitmap(CreateImages(6, 3, 2, shapeImageList[6])), 60, 40),
            ResizeBitmap(new Bitmap(CreateImages(7, 3, 2, shapeImageList[7])), 60, 40)
        };

        public static Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }
            return result;
        }
    }
}
