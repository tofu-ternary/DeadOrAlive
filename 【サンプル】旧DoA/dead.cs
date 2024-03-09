using System.Drawing;

namespace test
{
    class Dead
    {
        public void Draw(Graphics gr)
        {
            Image img;
            Point point = new Point(0, 0);

            img = test.Properties.Resources.dead;
            gr.DrawImage(img, point);
        }
        public bool Loc(int x, int y)
        {
            if (x > 0 && x < 1050 && y > 0 && y < 768)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Nl()
        {
        }
    }
}
