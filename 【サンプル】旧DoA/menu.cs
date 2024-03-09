using System.Drawing;

namespace test
{
    class Menu
    {
        Image img;
        Point point_l = new Point(700, 0);
        Point point1 = new Point(920, 5);
        Point point2 = new Point(0, 0);
        Point point3 = new Point(0, 0);
        public static bool n_menu = false;

        public bool s = false;
        //        public bool m = false;

        Point storypoint = new Point(273, 305);
        Point bpoint = new Point(270, 235);
        Point kbpoint = new Point(435, 240);

        Point rkeypoint = new Point(275, 305);
        Point bkeypoint = new Point(525, 305);
        Point ykeypoint = new Point(275, 440);
        Point okeypoint = new Point(525, 440);

        public bool keyst = false;

        public bool[] mst = { true, false, false, false, false, false, false, false, false };
        public bool[] cmst = { true, false, false, false, false, false, false, false, false };
        public bool ms6 = false;
        public bool ms7 = false;
        public bool[] stshi = { false, false, false, false, false };
        public bool[] stmemo = { false, false, false, false };
        public bool[] opkst = { false, false, false, false };
        public bool opks = true;
        public bool[] kst = { false, false, false, false, false, false, false, false, false, false };

        Room1 r1 = new Room1();
        Room3 r3 = new Room3();
        Room9 r9 = new Room9();
        Ui ui = new Ui();

        public void In(Ui ui2)
        {
            ui = ui2;
        }
        public void In1(Room1 c_r1)
        {
            r1 = c_r1;
        }
        public void In2(Room3 c_r3)
        {
            r3 = c_r3;
        }
        public void In3(Room9 c_r9)
        {
            r9 = c_r9;
        }


        public void Draw(Graphics gr)
        {
            if (!s)
            {
                if (n_menu)
                {
                    img = test.Properties.Resources.light_menu;
                    gr.DrawImage(img, point_l);
                    /*    if (firstsound)
                        {
                            Audio.Play_misdis();
                            firstsound = false;
                        }*/
                }
                //img = test.Properties.Resources.menu;
                /*gr.DrawImage(img, point1);　一時的措置*/
            }
            else
            {
                img = test.Properties.Resources.menu2;
                gr.DrawImage(img, point2);
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point3);
                if (!keyst)
                {

                    img = test.Properties.Resources.keystory;
                    gr.DrawImage(img, bpoint);
                    if (ui.ckey && !stshi[4] && !mst[8] && (cmst[0] || cmst[1] || cmst[2] || cmst[3] || cmst[5]))
                    {
                        mst[0] = false;
                        mst[1] = false;
                        mst[2] = false;
                        mst[3] = false;
                        mst[4] = false;
                        mst[5] = false;
                        mst[6] = false;
                        mst[7] = true;
                        cmst[0] = false;
                        cmst[1] = false;
                        cmst[2] = false;
                        cmst[3] = false;
                        cmst[4] = false;
                        cmst[5] = false;
                        cmst[6] = true;
                    }
                    else if (r3.kin_open && !mst[6] && !stshi[3] && !stmemo[3] && (cmst[0] || cmst[1] || cmst[2] || cmst[3] || cmst[4]))
                    {
                        mst[0] = false;
                        mst[1] = false;
                        mst[2] = false;
                        mst[3] = false;
                        mst[4] = false;
                        mst[5] = true;
                        cmst[0] = false;
                        cmst[1] = false;
                        cmst[2] = false;
                        cmst[3] = false;
                        cmst[4] = false;
                        cmst[5] = true;
                    }
                    else if (r3.hasigo && !stshi[2] && !stmemo[2] && (cmst[0] || cmst[1] || cmst[2] || cmst[3]))
                    {
                        mst[0] = false;
                        mst[1] = false;
                        mst[2] = false;
                        mst[3] = false;
                        mst[4] = true;
                        cmst[0] = false;
                        cmst[1] = false;
                        cmst[2] = false;
                        cmst[3] = false;
                        cmst[4] = true;
                    }
                    else if (r9.kbm && !stshi[1] && !stmemo[1] && (cmst[0] || cmst[1] || cmst[2]))
                    {
                        mst[0] = false;
                        mst[1] = false;
                        mst[2] = false;
                        mst[3] = true;
                        cmst[0] = false;
                        cmst[1] = false;
                        cmst[2] = false;
                        cmst[3] = true;
                    }
                    else if (r3.n_stage && !stshi[0] && !stmemo[0] && (cmst[0] || cmst[1]))
                    {
                        mst[0] = false;
                        mst[1] = false;
                        mst[2] = true;
                        cmst[0] = false;
                        cmst[1] = false;
                        cmst[2] = true;
                    }
                    else if (r1.kai && cmst[0])
                    {
                        mst[0] = false;
                        mst[1] = true;
                        cmst[0] = false;
                        cmst[1] = true;
                    }
                    if (opks)
                    {
                        if (ui.clkey[0])
                        {
                            opkst[0] = true;
                        }
                        if (ui.clkey[1])
                        {
                            opkst[1] = true;
                        }
                        if (ui.clkey[2])
                        {
                            opkst[2] = true;
                        }
                        if (ui.clkey[3])
                        {
                            opkst[3] = true;
                        }
                    }
                    if (mst[0])
                    {
                        img = test.Properties.Resources.story1;
                        gr.DrawImage(img, storypoint);
                    }
                    else if (mst[1])
                    {
                        img = test.Properties.Resources.story2;
                        gr.DrawImage(img, storypoint);
                    }
                    else if (mst[2])
                    {
                        img = test.Properties.Resources.story3;
                        gr.DrawImage(img, storypoint);
                    }
                    else if (mst[3])
                    {
                        img = test.Properties.Resources.story4;
                        gr.DrawImage(img, storypoint);
                    }
                    else if (mst[4])
                    {
                        img = test.Properties.Resources.story5;
                        gr.DrawImage(img, storypoint);
                    }
                    else if (mst[5])
                    {
                        img = test.Properties.Resources.story6_1;
                        gr.DrawImage(img, storypoint);
                    }
                    else if (mst[6])
                    {
                        img = test.Properties.Resources.story6_2;
                        gr.DrawImage(img, storypoint);
                    }
                    else if (mst[7])
                    {
                        img = test.Properties.Resources.story7_1;
                        gr.DrawImage(img, storypoint);
                    }
                    else if (mst[8])
                    {
                        img = test.Properties.Resources.story7_2;
                        gr.DrawImage(img, storypoint);
                    }
                    if (stshi[0])
                    {
                        img = test.Properties.Resources.st_shi1;
                        gr.DrawImage(img, storypoint);
                    }
                    else if (stshi[1])
                    {
                        img = test.Properties.Resources.st_shi2;
                        gr.DrawImage(img, storypoint);
                    }
                    else if (stshi[2])
                    {
                        img = test.Properties.Resources.st_shi3;
                        gr.DrawImage(img, storypoint);
                    }
                    else if (stshi[3])
                    {
                        img = test.Properties.Resources.st_shi4;
                        gr.DrawImage(img, storypoint);
                    }
                    else if (stshi[4])
                    {
                        img = test.Properties.Resources.st_shi5;
                        gr.DrawImage(img, storypoint);
                    }
                    if (stmemo[0])
                    {
                        img = test.Properties.Resources.st_memo1;
                        gr.DrawImage(img, storypoint);
                    }
                    else if (stmemo[1])
                    {
                        img = test.Properties.Resources.st_memo2;
                        gr.DrawImage(img, storypoint);
                    }
                    else if (stmemo[2])
                    {
                        img = test.Properties.Resources.st_memo3;
                        gr.DrawImage(img, storypoint);
                    }
                    else if (stmemo[3])
                    {
                        img = test.Properties.Resources.st_memo4;
                        gr.DrawImage(img, storypoint);
                    }
                }
                else if (keyst)
                {
                    img = test.Properties.Resources.mainstory;
                    gr.DrawImage(img, bpoint);
                    if (opks)
                    {
                        if (opkst[0])
                        {
                            img = test.Properties.Resources.krst_op;
                            gr.DrawImage(img, rkeypoint);
                        }
                        else if (!opkst[0])
                        {
                            img = test.Properties.Resources.kst_cl;
                            gr.DrawImage(img, rkeypoint);
                        }
                        if (opkst[1])
                        {
                            img = test.Properties.Resources.kbst_op;
                            gr.DrawImage(img, bkeypoint);
                        }
                        else if (!opkst[1])
                        {
                            img = test.Properties.Resources.kst_cl;
                            gr.DrawImage(img, bkeypoint);
                        }
                        if (opkst[2])
                        {
                            img = test.Properties.Resources.kyst_op;
                            gr.DrawImage(img, ykeypoint);

                        }
                        else if (!opkst[2])
                        {
                            img = test.Properties.Resources.kst_cl;
                            gr.DrawImage(img, ykeypoint);
                        }
                        if (opkst[3])
                        {
                            img = test.Properties.Resources.kost_op;
                            gr.DrawImage(img, okeypoint);

                        }
                        else if (!opkst[3])
                        {
                            img = test.Properties.Resources.kst_cl;
                            gr.DrawImage(img, okeypoint);
                        }
                    }
                    if (!opks)
                    {
                        img = test.Properties.Resources.kstse;
                        gr.DrawImage(img, kbpoint);
                        if (kst[0])
                        {
                            img = test.Properties.Resources.krstory;
                            gr.DrawImage(img, storypoint);
                        }
                        else if (kst[1])
                        {
                            img = test.Properties.Resources.krst_shi;
                            gr.DrawImage(img, storypoint);
                        }
                        else if (kst[2])
                        {
                            img = test.Properties.Resources.kbstory;
                            gr.DrawImage(img, storypoint);
                        }
                        else if (kst[3])
                        {
                            img = test.Properties.Resources.kbst_shi;
                            gr.DrawImage(img, storypoint);
                        }
                        else if (kst[4])
                        {
                            img = test.Properties.Resources.kystory;
                            gr.DrawImage(img, storypoint);
                        }
                        else if (kst[5])
                        {
                            img = test.Properties.Resources.kyst_shi;
                            gr.DrawImage(img, storypoint);
                        }
                        else if (kst[6])
                        {
                            img = test.Properties.Resources.kostory;
                            gr.DrawImage(img, storypoint);
                        }
                        else if (kst[7])
                        {
                            img = test.Properties.Resources.kost_let1;
                            gr.DrawImage(img, storypoint);
                        }
                        else if (kst[8])
                        {
                            img = test.Properties.Resources.kost_let2;
                            gr.DrawImage(img, storypoint);
                        }
                        else if (kst[9])
                        {
                            img = test.Properties.Resources.kost_let3;
                            gr.DrawImage(img, storypoint);
                        }
                    }
                }


            }


        }

        public int Loc(int x, int y, int rm)
        {
            if (!s)
            {
                if (x > 702 && x < 852 && y > 0 && y < 28)
                {
                    s = true;
                    n_menu = false;
                    Audio.Play_menuin();
                }

                return rm;
            }
            else
            {
                if (!keyst)
                {
                    if (x > 270 && x < 430 && y > 235 && y < 300)
                    {
                        keyst = true;
                    }
                    if ((mst[2] || stshi[0] || stmemo[0]) && cmst[2])
                    {

                        if (x > 299 && x < 523 && y > 520 && y < 570 && mst[2])
                        {
                            mst[2] = false;
                            stshi[0] = true;
                        }
                        else if (x > 299 && x < 523 && y > 520 && y < 570 && stshi[0])
                        {
                            stshi[0] = false;
                            mst[2] = true;
                        }
                        else if (x > 548 && x < 735 && y > 520 && y < 570 && mst[2])
                        {
                            mst[2] = false;
                            stmemo[0] = true;
                        }
                        else if (x > 548 && x < 735 && y > 520 && y < 570 && stmemo[0])
                        {
                            stmemo[0] = false;
                            mst[2] = true;
                        }

                        else if (x > 299 && x < 523 && y > 520 && y < 570 && stmemo[0])
                        {
                            stmemo[0] = false;
                            stshi[0] = true;
                        }
                        else if (x > 548 && x < 735 && y > 520 && y < 570 && stshi[0])
                        {
                            stshi[0] = false;
                            stmemo[0] = true;
                        }

                    }
                    else if ((mst[3] || stshi[1] || stmemo[1]) && cmst[3])
                    {
                        if (x > 299 && x < 523 && y > 520 && y < 570 && mst[3])
                        {
                            mst[3] = false;
                            stshi[1] = true;
                        }
                        else if (x > 299 && x < 523 && y > 520 && y < 570 && stshi[1])
                        {
                            stshi[1] = false;
                            mst[3] = true;
                        }
                        else if (x > 548 && x < 735 && y > 520 && y < 570 && mst[3])
                        {
                            mst[3] = false;
                            stmemo[1] = true;
                        }
                        else if (x > 548 && x < 735 && y > 520 && y < 570 && stmemo[1])
                        {
                            stmemo[1] = false;
                            mst[3] = true;
                        }
                        else if (x > 299 && x < 523 && y > 520 && y < 570 && stmemo[1])
                        {
                            stmemo[1] = false;
                            stshi[1] = true;
                        }
                        else if (x > 548 && x < 735 && y > 520 && y < 570 && stshi[1])
                        {
                            stshi[1] = false;
                            stmemo[1] = true;
                        }
                    }
                    else if ((mst[4] || stshi[2] || stmemo[2]) && cmst[4])
                    {
                        if (x > 299 && x < 523 && y > 520 && y < 570 && mst[4])
                        {
                            mst[4] = false;
                            stshi[2] = true;
                        }
                        else if (x > 299 && x < 523 && y > 520 && y < 570 && stshi[2])
                        {
                            stshi[2] = false;
                            mst[4] = true;
                        }
                        else if (x > 548 && x < 735 && y > 520 && y < 570 && mst[4])
                        {
                            mst[4] = false;
                            stmemo[2] = true;
                        }
                        else if (x > 548 && x < 735 && y > 520 && y < 570 && stmemo[2])
                        {
                            stmemo[2] = false;
                            mst[4] = true;
                        }
                        else if (x > 299 && x < 523 && y > 520 && y < 570 && stmemo[2])
                        {
                            stmemo[2] = false;
                            stshi[2] = true;
                        }
                        else if (x > 548 && x < 735 && y > 520 && y < 570 && stshi[2])
                        {
                            stshi[2] = false;
                            stmemo[2] = true;
                        }
                    }
                    else if ((mst[5] || mst[6] || stshi[3] || stmemo[3]) && cmst[5])
                    {
                        if (x > 473 && x < 620 && y > 465 && y < 510 && mst[5])
                        {
                            mst[5] = false;
                            mst[6] = true;
                            ms6 = true;
                        }
                        else if (x > 473 && x < 620 && y > 465 && y < 510 && mst[6])
                        {
                            mst[6] = false;
                            mst[5] = true;
                            ms6 = false;
                        }
                        else if (x > 299 && x < 523 && y > 520 && y < 570 && mst[5])
                        {
                            mst[5] = false;
                            stshi[3] = true;
                        }
                        else if (x > 299 && x < 523 && y > 520 && y < 570 && stshi[3] && !ms6)
                        {
                            stshi[3] = false;
                            mst[5] = true;
                        }
                        else if (x > 548 && x < 735 && y > 520 && y < 570 && mst[5])
                        {
                            mst[5] = false;
                            stmemo[3] = true;
                        }
                        else if (x > 548 && x < 735 && y > 520 && y < 570 && stmemo[3] && !ms6)
                        {
                            stmemo[3] = false;
                            mst[5] = true;
                        }
                        else if (x > 299 && x < 523 && y > 520 && y < 570 && mst[6])
                        {
                            mst[6] = false;
                            stshi[3] = true;
                        }
                        else if (x > 299 && x < 523 && y > 520 && y < 570 && stshi[3] && ms6)
                        {
                            stshi[3] = false;
                            mst[6] = true;
                        }
                        else if (x > 548 && x < 735 && y > 520 && y < 570 && mst[6])
                        {
                            mst[6] = false;
                            stmemo[3] = true;
                        }
                        else if (x > 548 && x < 735 && y > 520 && y < 570 && stmemo[3] && ms6)
                        {
                            stmemo[3] = false;
                            mst[6] = true;
                        }
                        else if (x > 299 && x < 523 && y > 520 && y < 570 && stmemo[3])
                        {
                            stmemo[3] = false;
                            stshi[3] = true;
                        }
                        else if (x > 548 && x < 735 && y > 520 && y < 570 && stshi[3])
                        {
                            stshi[3] = false;
                            stmemo[3] = true;
                        }
                    }
                    else if ((mst[7] || mst[8] || stshi[4]) && cmst[6])
                    {
                        if (x > 548 && x < 735 && y > 520 && y < 570 && mst[7])
                        {
                            mst[7] = false;
                            mst[8] = true;
                            ms7 = true;
                        }
                        else if (x > 548 && x < 735 && y > 520 && y < 570 && mst[8])
                        {
                            mst[8] = false;
                            mst[7] = true;
                            ms7 = false;
                        }
                        else if (x > 299 && x < 523 && y > 520 && y < 570 && mst[7])
                        {
                            mst[7] = false;
                            stshi[4] = true;
                        }
                        else if (x > 433 && x < 620 && y > 520 && y < 570 && stshi[4] && !ms7)
                        {
                            stshi[4] = false;
                            mst[7] = true;
                        }
                        else if (x > 299 && x < 523 && y > 520 && y < 570 && mst[8])
                        {
                            mst[8] = false;
                            stshi[4] = true;
                        }
                        else if (x > 433 && x < 620 && y > 520 && y < 570 && stshi[4] && ms7)
                        {
                            stshi[4] = false;
                            mst[8] = true;
                        }
                    }
                }
                else if (keyst)
                {
                    if (x > 270 && x < 430 && y > 235 && y < 300)
                    {
                        keyst = false;
                    }
                    if (opks)
                    {
                        if (opkst[0])
                        {
                            if (x > 290 && x < 490 && y > 335 && y < 400)
                            {
                                kst[0] = true;
                                opks = false;
                            }
                        }
                        if (opkst[1])
                        {
                            if (x > 510 && x < 710 && y > 335 && y < 400)
                            {
                                kst[2] = true;
                                opks = false;
                            }
                        }
                        if (opkst[2])
                        {
                            if (x > 290 && x < 490 && y > 475 && y < 540)
                            {
                                kst[4] = true;
                                opks = false;
                            }
                        }
                        if (opkst[3])
                        {
                            if (x > 510 && x < 710 && y > 475 && y < 540)
                            {
                                kst[6] = true;
                                opks = false;
                            }
                        }
                    }
                    else if (!opks)
                    {
                        if (kst[0] || kst[1])
                        {
                            if (x > 433 && x < 635 && y > 520 && y < 570 && kst[0])
                            {
                                kst[0] = false;
                                kst[1] = true;
                            }
                            else if (x > 433 && x < 635 && y > 520 && y < 570 && kst[1])
                            {
                                kst[1] = false;
                                kst[0] = true;
                            }
                        }
                        else if (kst[2] || kst[3])
                        {
                            if (x > 433 && x < 635 && y > 520 && y < 570 && kst[2])
                            {
                                kst[2] = false;
                                kst[3] = true;
                            }
                            else if (x > 433 && x < 635 && y > 520 && y < 570 && kst[3])
                            {
                                kst[3] = false;
                                kst[2] = true;
                            }
                        }
                        else if (kst[4] || kst[5])
                        {
                            if (x > 433 && x < 635 && y > 520 && y < 570 && kst[4])
                            {
                                kst[4] = false;
                                kst[5] = true;
                            }
                            else if (x > 433 && x < 635 && y > 520 && y < 570 && kst[5])
                            {
                                kst[5] = false;
                                kst[4] = true;
                            }
                        }
                        else if (kst[6] || kst[7] || kst[8] || kst[9])
                        {
                            if (x > 412 && x < 635 && y > 520 && y < 570 && kst[6])
                            {
                                kst[6] = false;
                                kst[7] = true;
                            }
                            else if (x > 299 && x < 523 && y > 520 && y < 570 && (kst[7] || kst[8] || kst[9]))
                            {
                                kst[7] = false;
                                kst[8] = false;
                                kst[9] = false;
                                kst[6] = true;
                            }
                            else if (x > 548 && x < 735 && y > 520 && y < 570 && kst[7])
                            {
                                kst[7] = false;
                                kst[8] = true;
                            }
                            else if (x > 535 && x < 628 && y > 520 && y < 570 && kst[8])
                            {
                                kst[8] = false;
                                kst[7] = true;
                            }
                            else if (x > 640 && x < 735 && y > 520 && y < 570 && kst[8])
                            {
                                kst[8] = false;
                                kst[9] = true;
                            }
                            else if (x > 535 && x < 628 && y > 520 && y < 570 && kst[9])
                            {
                                kst[9] = false;
                                kst[8] = true;
                            }
                            else if (x > 640 && x < 735 && y > 520 && y < 570 && kst[9])
                            {
                                kst[9] = false;
                                kst[7] = true;
                            }

                        }
                        if (x > 435 && x < 570 && y > 235 && y < 300)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                kst[i] = false;
                            }
                            opks = true;

                        }
                    }


                }

                if (x > 300 && x < 670 && y > 600 && y < 735)
                {
                    s = false;


                    return (int)Form1.RM.title;
                }
                else if (x > 0 && x < 200 && y > 0 && y < 200 && keyst)
                {
                    opks = true;
                    kst[0] = false;
                    kst[1] = false;
                    kst[2] = false;
                    kst[3] = false;
                    kst[4] = false;
                    kst[5] = false;
                    kst[6] = false;
                    kst[7] = false;
                    kst[8] = false;
                    kst[9] = false;
                    s = false;
                    Audio.Play_menuout();
                }
                else if (x > 0 && x < 200 && y > 0 && y < 200 && !keyst)
                {
                    s = false;
                    Audio.Play_menuout();
                }

                return rm;
            }

        }

        public void Nl()
        {
            n_menu = false;
            s = false;

            keyst = false;
            mst[0] = true;
            cmst[0] = true;
            for (int i = 1; i < 9; i++)
            {
                mst[i] = false;
                cmst[i] = false;
            }
            ms6 = false;
            ms7 = false;
            for (int i = 0; i < 5; i++)
            {
                stshi[i] = false;
            }
            for (int i = 0; i < 4; i++)
            {
                stmemo[i] = false;
                opkst[i] = false;
            }
            opks = true;
            for (int i = 0; i < 10; i++)
            {
                kst[i] = false;
            }
        }

    }


}
