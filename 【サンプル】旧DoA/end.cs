using System.Drawing;

namespace test
{
    class End
    {
        public bool all = false;

        public bool d_s = false;
        public bool d_a = false;
        public bool d_b = false;
        public bool d_c = false;
        public bool d_bad = false;
        public bool d_dead = false;
        public bool d_end = false;


        public int dead = 0;
        public bool end = false;

        public void Draw(Graphics gr)
        {
            Image img;
            Point point = new Point(0, 0);

            if (d_end)
            {
                img = test.Properties.Resources.storyEND;
                gr.DrawImage(img, point);
                Audio.Play_endstoryg();
                Audio.Stop_bgm();
            }
            if (d_bad)
            {
                img = test.Properties.Resources.storyBAD;
                gr.DrawImage(img, point);
                Audio.Play_endstorye();
                Audio.Stop_bgm();
            }
            if (d_dead)
            {
                img = test.Properties.Resources.storyDEAD;
                gr.DrawImage(img, point);
                Audio.Play_endstoryd();
                Audio.Stop_bgm();
            }
            if (d_c)
            {
                img = test.Properties.Resources.storyC;
                gr.DrawImage(img, point);
                Audio.Play_endstoryc();
                Audio.Stop_bgm();
            }
            if (d_b)
            {
                img = test.Properties.Resources.storyB;
                gr.DrawImage(img, point);
                Audio.Play_endstoryb();
                Audio.Stop_bgm();
            }
            if (d_a)
            {
                img = test.Properties.Resources.storyA;
                gr.DrawImage(img, point);
                Audio.Play_endstorya();
                Audio.Stop_bgm();
            }
            if (d_s)
            {
                img = test.Properties.Resources.storyS;
                gr.DrawImage(img, point);
                Audio.Play_endstoryf();
                Audio.Stop_bgm();
            }


        }
        public int Loc(int x, int y)
        {
            if (x > 0 && x < 1050 && y > 0 && y < 768)
            {
                end = false;
                return (int)Form1.RM.story;
            }
            else
            {
                return (int)Form1.RM.end;
            }
        }
        public void Nl()
        {
            d_s = false;
            d_a = false;
            d_b = false;
            d_c = false;
            d_bad = false;
            d_dead = false;
            d_end = false;
        }

    }
}