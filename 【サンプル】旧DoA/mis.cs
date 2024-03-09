using System.Drawing;

namespace test
{
    class Mis
    {
        public enum QE : int
        {
            Qes1,
            Qes2,
            Qes3,
            Qes4,
            Qes5,
            Qes6,
            Qes7,
            Qes8,
            Qes9,
            Qes10,
            Qes11,
            Qes12,
            Qes13,
            Qes14,
            Qes15,
            Qes16,
            Qes17,
            Error
        }

        Image img;
        Point point = new Point(920, 60);
        Point point_l = new Point(854, 0);
        Point point1 = new Point(0, 0);
        Point point2 = new Point(0, 0);

        Point[] points_loc = {new Point(250,177), new Point(705,177),
                              new Point(250,255),new Point(705,255),
                                new Point(250,337),new Point(705,337),
                                new Point(250,417),new Point(705,417),
                                new Point(250,494),new Point(705,494),
                                new Point(250,577),new Point(705,577),
                                new Point(250,658),new Point(705,658)};

        public bool mis = false;
        public bool mis2 = false;
        public bool[] qes = new bool[18];

        public bool n_mis = false;

        public int select_qes = (int)QE.Error;

        //    private bool firstsound = true;

        int mis_num = 14;

        public void Draw(Graphics gr)
        {
            if (!mis)
            {
                if (n_mis)
                {
                    img = test.Properties.Resources.light_mis;
                    gr.DrawImage(img, point_l);
                    /*    if (firstsound)
                        {
                            Audio.Play_misdis();
                            firstsound = false;
                        }*/
                }
            }
            else
            {
                //              firstsound = true;
                if (select_qes == (int)QE.Error)
                {
                    img = test.Properties.Resources.mistery1;
                    gr.DrawImage(img, point1);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point2);
                }

                for (int i = 0; i < mis_num; i++)
                {
                    if (!qes[i])
                    {
                        img = test.Properties.Resources.misteryloc;
                        gr.DrawImage(img, points_loc[i]);
                    }
                }

                switch (select_qes)
                {
                    case (int)QE.Qes1:
                        img = test.Properties.Resources.mis1;
                        gr.DrawImage(img, point1);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point2);
                        break;
                    case (int)QE.Qes2:
                        img = test.Properties.Resources.mis2;
                        gr.DrawImage(img, point1);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point2);
                        break;

                    case (int)QE.Qes3:
                        img = test.Properties.Resources.mis3;
                        gr.DrawImage(img, point1);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point2);
                        break;

                    case (int)QE.Qes4:
                        img = test.Properties.Resources.mis4;
                        gr.DrawImage(img, point1);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point2);
                        break;

                    case (int)QE.Qes5:
                        img = test.Properties.Resources.mis5;
                        gr.DrawImage(img, point1);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point2);
                        break;

                    case (int)QE.Qes6:
                        img = test.Properties.Resources.mis6;
                        gr.DrawImage(img, point1);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point2);
                        break;

                    case (int)QE.Qes7:
                        img = test.Properties.Resources.mis7;
                        gr.DrawImage(img, point1);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point2);
                        break;

                    case (int)QE.Qes8:
                        img = test.Properties.Resources.mis8;
                        gr.DrawImage(img, point1);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point2);
                        break;

                    case (int)QE.Qes9:
                        img = test.Properties.Resources.mis9;
                        gr.DrawImage(img, point1);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point2);
                        break;

                    case (int)QE.Qes10:
                        img = test.Properties.Resources.mis10;
                        gr.DrawImage(img, point1);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point2);
                        break;

                    case (int)QE.Qes11:
                        img = test.Properties.Resources.mis11;
                        gr.DrawImage(img, point1);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point2);
                        break;

                    case (int)QE.Qes12:
                        img = test.Properties.Resources.mis12;
                        gr.DrawImage(img, point1);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point2);
                        break;

                    case (int)QE.Qes13:
                        img = test.Properties.Resources.mis13;
                        gr.DrawImage(img, point1);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point2);
                        break;

                    case (int)QE.Qes14:
                        img = test.Properties.Resources.mis14;
                        gr.DrawImage(img, point1);
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, point2);
                        break;
                    case (int)QE.Error:
                    default:
                        break;
                }

            }


        }

        public int Loc(int x, int y, int rm)
        {

            if (rm != (int)Form1.RM.title)
            {
                //qへ
                if (x > 855 && x < 1005 && y > 0 && y < 28 && !mis && !mis2)
                {
                    mis = true;
                    n_mis = false;
                    Audio.Play_misin();
                }

                //q1
                if (x > 162 && x < 448 && y > 178 && y < 226 && mis && !mis2 && qes[(int)QE.Qes1])
                {
                    select_qes = (int)QE.Qes1;
                    mis2 = true;
                }
                if (x > 580 && x < 865 && y > 178 && y < 226 && mis && !mis2 && qes[(int)QE.Qes2])
                {
                    select_qes = (int)QE.Qes2;
                    mis2 = true;
                }
                if (x > 162 && x < 448 && y > 257 && y < 305 && mis && !mis2 && qes[(int)QE.Qes3])
                {
                    select_qes = (int)QE.Qes3;
                    mis2 = true;
                }
                if (x > 580 && x < 865 && y > 257 && y < 305 && mis && !mis2 && qes[(int)QE.Qes4])
                {
                    select_qes = (int)QE.Qes4;
                    mis2 = true;
                }
                if (x > 162 && x < 448 && y > 338 && y < 385 && mis && !mis2 && qes[(int)QE.Qes5])
                {
                    select_qes = (int)QE.Qes5;
                    mis2 = true;
                }
                if (x > 580 && x < 865 && y > 338 && y < 385 && mis && !mis2 && qes[(int)QE.Qes6])
                {
                    select_qes = (int)QE.Qes6;
                    mis2 = true;
                }
                if (x > 162 && x < 448 && y > 417 && y < 467 && mis && !mis2 && qes[(int)QE.Qes7])
                {
                    select_qes = (int)QE.Qes7;
                    mis2 = true;
                }
                if (x > 580 && x < 865 && y > 417 && y < 467 && mis && !mis2 && qes[(int)QE.Qes8])
                {
                    select_qes = (int)QE.Qes8;
                    mis2 = true;
                }
                if (x > 162 && x < 448 && y > 498 && y < 545 && mis && !mis2 && qes[(int)QE.Qes9])
                {
                    select_qes = (int)QE.Qes9;
                    mis2 = true;
                }
                if (x > 580 && x < 865 && y > 498 && y < 545 && mis && !mis2 && qes[(int)QE.Qes10])
                {
                    select_qes = (int)QE.Qes10;
                    mis2 = true;
                }
                if (x > 162 && x < 448 && y > 575 && y < 625 && mis && !mis2 && qes[(int)QE.Qes11])
                {
                    select_qes = (int)QE.Qes11;
                    mis2 = true;
                }
                if (x > 580 && x < 865 && y > 575 && y < 625 && mis && !mis2 && qes[(int)QE.Qes12])
                {
                    select_qes = (int)QE.Qes12;
                    mis2 = true;
                }
                if (x > 162 && x < 448 && y > 658 && y < 705 && mis && !mis2 && qes[(int)QE.Qes13])
                {
                    select_qes = (int)QE.Qes13;
                    mis2 = true;
                }
                if (x > 580 && x < 865 && y > 658 && y < 705 && mis && !mis2 && qes[(int)QE.Qes14])
                {
                    select_qes = (int)QE.Qes14;
                    mis2 = true;
                }


                //戻る
                if (x > 0 && x < 200 && y > 0 && y < 100 && mis && !mis2)
                {
                    mis = false;
                    Audio.Play_misout();
                }


                //選択されてません
                if (mis && !mis2)
                {
                    select_qes = (int)QE.Error;
                }

                //<戻る
                if (x > 0 && x < 200 && y > 0 && y < 100 && mis && mis2)
                {
                    mis2 = false;
                    select_qes = (int)QE.Error;
                }

            }

            return rm;
        }

        public void Nl()
        {
            for (int i = 0; i < 14; i++)
            {
                qes[i] = false;
            }
        }

    }
}

