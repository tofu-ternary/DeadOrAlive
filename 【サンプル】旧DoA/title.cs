using System.Drawing;

namespace test
{
    class Title
    {
        Image img;
        Point point = new Point(0, 0);
        Point point1 = new Point(350, 500);
        Point point2 = new Point(924, 668);
        Point point_close = new Point(3, 673);
        Point point_nextarrow = new Point(900, 400);
        public bool start;
        public bool s = false;
        public bool qe = false;
        public bool close = false;
        public bool geme_menu = false;

        public void Draw(Graphics gr)
        {
            if (!qe)
            {
                img = test.Properties.Resources.title;
                gr.DrawImage(img, point);
                img = test.Properties.Resources.start;
                gr.DrawImage(img, point1);
                img = test.Properties.Resources.play2;
                gr.DrawImage(img, point2);
                img = test.Properties.Resources.close;
                gr.DrawImage(img, point_close);
            }
            else
            {
                if (!geme_menu)
                {
                    img = test.Properties.Resources.play;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印3;
                    gr.DrawImage(img, point_nextarrow);
                }
                else
                {
                    img = test.Properties.Resources.play_2;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                }
            }

        }

        public int Loc(int x, int y)
        {


            if (x > 400 && x < 800 && y > 400 && y < 800 && !qe)
            {
                s = true;
            }

            if (x > 925 && x < 1050 && y > 668 && y < 770 && !geme_menu)
            {
                qe = true;
                Audio.Play_menuin();
            }
            else if (x > 0 && x < 200 && y > 0 && y < 200 && !geme_menu && qe)
            {
                qe = false;
                Audio.Play_menuout();
            }

            if (!geme_menu && qe)
            {
                if (x > 900 && x < 1024 && y > 400 && y < 500)
                {
                    geme_menu = true;
                }
            }

            if (geme_menu)
            {
                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    geme_menu = false;
                }
            }


            if (x > 3 && x < 70 && y > 675 && y < 765 && !qe)
            {
                close = true;
            }
            if (s) return (int)Form1.RM.story;
            else return (int)Form1.RM.title;
        }

        public void Nl()
        {
            s = false;
            qe = false;
            close = false;
            geme_menu = false;
        }


    }
}
