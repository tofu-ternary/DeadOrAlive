using System.Drawing;

namespace test
{



    class Time
    {
        public int[] min = new int[2];
        public int[] sec = new int[2];

        Image[] img = new Image[4];
        Image timers = test.Properties.Resources.timers;

        Point[] points_time = { new Point(792, 44), new Point(832, 44), new Point(882, 44), new Point(922, 44) };

        public void T_nyu(int lm, int rm, int ls, int rs)
        {
            min[0] = lm;
            img[0] = T_image(min[0]);
            min[1] = rm;
            img[1] = T_image(min[1]);
            sec[0] = ls;
            img[2] = T_image(sec[0]);
            sec[1] = rs;
            img[3] = T_image(sec[1]);
        }

        public void Draw(Graphics gr)
        {
            gr.DrawImage(timers, 700, 0);
            for (int i = 0; i < 4; i++)
            {
                if (img[i] != null)
                {
                    gr.DrawImage(img[i], points_time[i]);
                }
            }
        }
        public Image T_image(int i)
        {
            switch (i)
            {
                case 0:
                    return test.Properties.Resources.t0;
                case 1:
                    return test.Properties.Resources.t1;
                case 2:
                    return test.Properties.Resources.t2;
                case 3:
                    return test.Properties.Resources.t3;
                case 4:
                    return test.Properties.Resources.t4;
                case 5:
                    return test.Properties.Resources.t5;
                case 6:
                    return test.Properties.Resources.t6;
                case 7:
                    return test.Properties.Resources.t7;
                case 8:
                    return test.Properties.Resources.t8;
                case 9:
                    return test.Properties.Resources.t9;
            }
            return test.Properties.Resources._null;
        }
    }
}
