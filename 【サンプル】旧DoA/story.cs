using System.Drawing;

namespace test
{
    class story
    {
        Image img;
        Point point = new Point(0, 0);
        Point storypoint = new Point(210, 305);
        Point namepoint = new Point(300, 210);
        Point endstpoint = new Point(180, 610);
        Point urastpoint = new Point(646, 523);
        Point bpoint = new Point(350, 580);


        public bool end = false;
        public bool enst = false;
        public bool afst = false;
        public bool urast = false;
        public bool urst = false;
        public bool[] mst = { false, false, false, false, false, false, false, false, false };
        public bool ms6 = false;
        public bool ms7 = false;
        public bool[] stshi = { false, false, false, false, false };
        public bool[] stmemo = { false, false, false, false };
        public bool[] kst = { false, false, false, false, false, false, false, false, false, false };
        public bool[] ustken = { false, false, false, false, false, false, false, false, false, false };
        public bool[] ustsei = { false, false, false, false, false };
        public bool[] usttou = { false, false };
        public bool[] ustkako = { false, false, false, false, false };


        Room1 r1 = new Room1();
        Room3 r3 = new Room3();
        Room9 r9 = new Room9();
        Ui ui = new Ui();
        End ed = new End();
        Title t = new Title();
        public void In(Ui ui2)
        {
            ui = ui2;
        }
        public void In2(End end)
        {
            ed = end;
        }
        public void In3(Title title)
        {
            t = title;
        }
        public void In4(Room1 c_r1)
        {
            r1 = c_r1;
        }
        public void In5(Room3 c_r3)
        {
            r3 = c_r3;
        }
        public void In6(Room9 c_r9)
        {
            r9 = c_r9;
        }
        public void Draw(Graphics gr)
        {
            if (!end)
            {
                img = test.Properties.Resources.black;
                gr.DrawImage(img, point);

                if (t.s)
                {
                    img = test.Properties.Resources.prologue;
                    gr.DrawImage(img, point);
                }
                if (ed.d_s)
                {
                    img = test.Properties.Resources.storyS;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.white;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.endstoryS;
                    gr.DrawImage(img, point);
                }
                else if (ed.d_a)
                {
                    img = test.Properties.Resources.storyA;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.white;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.endstoryA;
                    gr.DrawImage(img, point);
                }
                else if (ed.d_b)
                {
                    img = test.Properties.Resources.storyB;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.white;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.endstoryB;
                    gr.DrawImage(img, point);
                }
                else if (ed.d_c)
                {
                    img = test.Properties.Resources.storyC;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.white;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.endstoryC;
                    gr.DrawImage(img, point);
                }
                else if (ed.d_bad)
                {
                    img = test.Properties.Resources.storyBAD;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.white;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.endstoryBAD;
                    gr.DrawImage(img, point);
                }
                else if (ed.d_dead)
                {
                    img = test.Properties.Resources.storyDEAD;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.white;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.endstoryDEAD;
                    gr.DrawImage(img, point);
                }
                else if (ed.d_end)
                {
                    img = test.Properties.Resources.storyEND;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.white;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.endstoryEND;
                    gr.DrawImage(img, point);
                }
            }
            if (end)
            {
                if (!afst)
                {
                    img = test.Properties.Resources.afstoryse;
                    gr.DrawImage(img, point);
                    if (ed.d_s)
                    {
                        img = test.Properties.Resources.afendstoryse_s;
                        gr.DrawImage(img, endstpoint);
                        img = test.Properties.Resources.afstoryse_ura;
                        gr.DrawImage(img, urastpoint);

                    }
                    else if (ed.d_a)
                    {
                        img = test.Properties.Resources.afendstoryse_a;
                        gr.DrawImage(img, endstpoint);
                    }
                    else if (ed.d_b)
                    {
                        img = test.Properties.Resources.afendstoryse_b;
                        gr.DrawImage(img, endstpoint);
                    }
                    else if (ed.d_c)
                    {
                        img = test.Properties.Resources.afendstoryse_c;
                        gr.DrawImage(img, endstpoint);
                    }
                    else if (ed.d_bad)
                    {
                        img = test.Properties.Resources.afendstoryse_BAD;
                        gr.DrawImage(img, endstpoint);
                    }
                    else if (ed.d_dead)
                    {
                        img = test.Properties.Resources.afendstoryse_DEAD;
                        gr.DrawImage(img, endstpoint);
                    }
                    else if (ed.d_end)
                    {
                        img = test.Properties.Resources.afendstoryse_END;
                        gr.DrawImage(img, endstpoint);
                    }
                }
                else if (afst)
                {
                    if (!urast && !enst)
                    {
                        img = test.Properties.Resources.afstory;
                        gr.DrawImage(img, point);
                        img = test.Properties.Resources.sback;
                        gr.DrawImage(img, bpoint);
                        if (mst[0])
                        {
                            img = test.Properties.Resources.story1;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst1;
                            gr.DrawImage(img, namepoint);
                        }
                        if (mst[1])
                        {
                            img = test.Properties.Resources.story2;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst2;
                            gr.DrawImage(img, namepoint);
                        }
                        if (mst[2])
                        {
                            img = test.Properties.Resources.story3;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst3;
                            gr.DrawImage(img, namepoint);
                        }
                        if (mst[3])
                        {
                            img = test.Properties.Resources.story4;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst4;
                            gr.DrawImage(img, namepoint);
                        }
                        if (mst[4])
                        {
                            img = test.Properties.Resources.story5;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst5;
                            gr.DrawImage(img, namepoint);
                        }
                        if (mst[5])
                        {
                            img = test.Properties.Resources.story6_1;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst6;
                            gr.DrawImage(img, namepoint);
                        }
                        if (mst[6])
                        {
                            img = test.Properties.Resources.story6_2;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst6;
                            gr.DrawImage(img, namepoint);
                        }
                        if (mst[7])
                        {
                            img = test.Properties.Resources.story7_1;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst7;
                            gr.DrawImage(img, namepoint);
                        }
                        if (mst[8])
                        {
                            img = test.Properties.Resources.story7_2;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst7;
                            gr.DrawImage(img, namepoint);
                        }
                        if (stshi[0])
                        {
                            img = test.Properties.Resources.st_shi1;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst3;
                            gr.DrawImage(img, namepoint);
                        }
                        else if (stshi[1])
                        {
                            img = test.Properties.Resources.st_shi2;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst4;
                            gr.DrawImage(img, namepoint);
                        }
                        else if (stshi[2])
                        {
                            img = test.Properties.Resources.st_shi3;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst5;
                            gr.DrawImage(img, namepoint);
                        }
                        else if (stshi[3])
                        {
                            img = test.Properties.Resources.st_shi4;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst6;
                            gr.DrawImage(img, namepoint);
                        }
                        else if (stshi[4])
                        {
                            img = test.Properties.Resources.st_shi5;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst7;
                            gr.DrawImage(img, namepoint);
                        }
                        if (stmemo[0])
                        {
                            img = test.Properties.Resources.st_memo1;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst3;
                            gr.DrawImage(img, namepoint);
                        }
                        else if (stmemo[1])
                        {
                            img = test.Properties.Resources.st_memo2;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst4;
                            gr.DrawImage(img, namepoint);
                        }
                        else if (stmemo[2])
                        {
                            img = test.Properties.Resources.st_memo3;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst5;
                            gr.DrawImage(img, namepoint);
                        }
                        else if (stmemo[3])
                        {
                            img = test.Properties.Resources.st_memo4;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorymst6;
                            gr.DrawImage(img, namepoint);
                        }
                        if (kst[0])
                        {
                            img = test.Properties.Resources.krstory;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorykr;
                            gr.DrawImage(img, namepoint);
                        }
                        else if (kst[1])
                        {
                            img = test.Properties.Resources.krst_shi;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorykr;
                            gr.DrawImage(img, namepoint);
                        }
                        else if (kst[2])
                        {
                            img = test.Properties.Resources.kbstory;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorykb;
                            gr.DrawImage(img, namepoint);
                        }
                        else if (kst[3])
                        {
                            img = test.Properties.Resources.kbst_shi;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstorykb;
                            gr.DrawImage(img, namepoint);
                        }
                        else if (kst[4])
                        {
                            img = test.Properties.Resources.kystory;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstoryky;
                            gr.DrawImage(img, namepoint);
                        }
                        else if (kst[5])
                        {
                            img = test.Properties.Resources.kyst_shi;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstoryky;
                            gr.DrawImage(img, namepoint);
                        }
                        else if (kst[6])
                        {
                            img = test.Properties.Resources.kostory;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstoryko;
                            gr.DrawImage(img, namepoint);
                        }
                        else if (kst[7])
                        {
                            img = test.Properties.Resources.kost_let1;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstoryko;
                            gr.DrawImage(img, namepoint);
                        }
                        else if (kst[8])
                        {
                            img = test.Properties.Resources.kost_let2;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstoryko;
                            gr.DrawImage(img, namepoint);
                        }
                        else if (kst[9])
                        {
                            img = test.Properties.Resources.kost_let3;
                            gr.DrawImage(img, storypoint);
                            img = test.Properties.Resources.afstoryko;
                            gr.DrawImage(img, namepoint);
                        }

                    }
                    else if (enst)
                    {
                        if (ed.d_s)
                        {
                            img = test.Properties.Resources.storyS;
                            gr.DrawImage(img, point);
                            img = test.Properties.Resources.white;
                            gr.DrawImage(img, point);
                            img = test.Properties.Resources.endstoryS;
                            gr.DrawImage(img, point);
                        }
                        else if (ed.d_a)
                        {
                            img = test.Properties.Resources.storyA;
                            gr.DrawImage(img, point);
                            img = test.Properties.Resources.white;
                            gr.DrawImage(img, point);
                            img = test.Properties.Resources.endstoryA;
                            gr.DrawImage(img, point);
                        }
                        else if (ed.d_b)
                        {
                            img = test.Properties.Resources.storyB;
                            gr.DrawImage(img, point);
                            img = test.Properties.Resources.white;
                            gr.DrawImage(img, point);
                            img = test.Properties.Resources.endstoryB;
                            gr.DrawImage(img, point);
                        }
                        else if (ed.d_c)
                        {
                            img = test.Properties.Resources.storyC;
                            gr.DrawImage(img, point);
                            img = test.Properties.Resources.white;
                            gr.DrawImage(img, point);
                            img = test.Properties.Resources.endstoryC;
                            gr.DrawImage(img, point);
                        }
                        else if (ed.d_bad)
                        {
                            img = test.Properties.Resources.storyBAD;
                            gr.DrawImage(img, point);
                            img = test.Properties.Resources.white;
                            gr.DrawImage(img, point);
                            img = test.Properties.Resources.endstoryBAD;
                            gr.DrawImage(img, point);
                        }
                        else if (ed.d_dead)
                        {
                            img = test.Properties.Resources.storyDEAD;
                            gr.DrawImage(img, point);
                            img = test.Properties.Resources.white;
                            gr.DrawImage(img, point);
                            img = test.Properties.Resources.endstoryDEAD;
                            gr.DrawImage(img, point);
                        }
                        else if (ed.d_end)
                        {
                            img = test.Properties.Resources.storyEND;
                            gr.DrawImage(img, point);
                            img = test.Properties.Resources.white;
                            gr.DrawImage(img, point);
                            img = test.Properties.Resources.endstoryEND;
                            gr.DrawImage(img, point);
                        }
                    }
                    else if (urast)
                    {
                        if (!urst)
                        {
                            img = test.Properties.Resources.uraafstory;
                            gr.DrawImage(img, point);
                        }
                        else if (urst)
                        {
                            img = test.Properties.Resources.afstory;
                            gr.DrawImage(img, point);
                            img = test.Properties.Resources.sback;
                            gr.DrawImage(img, bpoint);
                            if (ustken[0])
                            {
                                img = test.Properties.Resources.ken_shi1;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstoryken;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustken[1])
                            {
                                img = test.Properties.Resources.ken_shi2;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstoryken;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustken[2])
                            {
                                img = test.Properties.Resources.ken_shi3;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstoryken;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustken[3])
                            {
                                img = test.Properties.Resources.ken_shi4;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstoryken;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustken[4])
                            {
                                img = test.Properties.Resources.ken_shi5;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstoryken;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustken[5])
                            {
                                img = test.Properties.Resources.ken_shi6;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstoryken;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustken[6])
                            {
                                img = test.Properties.Resources.ken_shi7;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstoryken;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustken[7])
                            {
                                img = test.Properties.Resources.ken_shi8;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstoryken;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustken[8])
                            {
                                img = test.Properties.Resources.ken_shi9;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstoryken;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustken[9])
                            {
                                img = test.Properties.Resources.ken_shi10;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstoryken;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustsei[0])
                            {
                                img = test.Properties.Resources.sei_sto1;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstorysei;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustsei[1])
                            {
                                img = test.Properties.Resources.sei_sto2;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstorysei;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustsei[2])
                            {
                                img = test.Properties.Resources.sei_sto3;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstorysei;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustsei[3])
                            {
                                img = test.Properties.Resources.sei_sto4;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstorysei;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustsei[4])
                            {
                                img = test.Properties.Resources.sei_sto5;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstorysei;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustkako[0])
                            {
                                img = test.Properties.Resources.kako_sto1;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstorykako;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustkako[1])
                            {
                                img = test.Properties.Resources.kako_sto2;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstorykako;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustkako[2])
                            {
                                img = test.Properties.Resources.kako_sto3;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstorykako;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustkako[3])
                            {
                                img = test.Properties.Resources.kako_sto4;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstorykako;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (ustkako[4])
                            {
                                img = test.Properties.Resources.kako_sto5;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstorykako;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (usttou[0])
                            {
                                img = test.Properties.Resources.tou_sto1;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstorytou;
                                gr.DrawImage(img, namepoint);
                            }
                            else if (usttou[1])
                            {
                                img = test.Properties.Resources.tou_sto2;
                                gr.DrawImage(img, storypoint);
                                img = test.Properties.Resources.afstorytou;
                                gr.DrawImage(img, namepoint);
                            }

                        }
                    }
                }

            }
        }
        public int Loc(int x, int y)
        {
            if (end)
            {

                if (!afst)
                {
                    if (!urast)
                    {
                        if (x > 435 && x < 500 && y > 225 && y < 260)
                        {
                            mst[0] = true;
                            afst = true;
                        }
                        else if (x > 320 && x < 385 && y > 255 && y < 290)
                        {
                            mst[1] = true;
                            afst = true;
                        }
                        else if (x > 635 && x < 700 && y > 255 && y < 290 && r3.n_stage)
                        {
                            mst[2] = true;
                            afst = true;
                        }
                        else if (x > 320 && x < 385 && y > 295 && y < 325 && r9.kbm)
                        {
                            mst[3] = true;
                            afst = true;
                        }
                        else if (x > 635 && x < 700 && y > 295 && y < 325 && r3.hasigo)
                        {
                            mst[4] = true;
                            afst = true;
                        }
                        else if (x > 320 && x < 385 && y > 330 && y < 365 && r3.kin_open)
                        {
                            mst[5] = true;
                            afst = true;
                        }
                        else if (x > 635 && x < 700 && y > 330 && y < 365 && ui.ckey)
                        {
                            mst[7] = true;
                            afst = true;
                        }
                        else if (x > 190 && x < 295 && y > 485 && y < 525 && ui.clkey[0])
                        {
                            kst[0] = true;
                            afst = true;
                        }
                        else if (x > 190 && x < 295 && y > 555 && y < 595 && ui.clkey[1])
                        {
                            kst[2] = true;
                            afst = true;
                        }
                        else if (x > 505 && x < 610 && y > 485 && y < 525 && ui.clkey[2])
                        {
                            kst[4] = true;
                            afst = true;
                        }
                        else if (x > 505 && x < 610 && y > 555 && y < 595 && ui.clkey[3])
                        {
                            kst[6] = true;
                            afst = true;
                        }
                        else if (x > 500 && x < 565 && y > 615 && y < 645 && ed.d_s)
                        {
                            enst = true;
                            afst = true;
                        }
                        else if (x > 500 && x < 565 && y > 615 && y < 645 && ed.d_a)
                        {
                            enst = true;
                            afst = true;
                        }
                        else if (x > 500 && x < 565 && y > 615 && y < 645 && ed.d_b)
                        {
                            enst = true;
                            afst = true;
                        }
                        else if (x > 500 && x < 565 && y > 615 && y < 645 && ed.d_c)
                        {
                            enst = true;
                            afst = true;
                        }
                        else if (x > 550 && x < 615 && y > 615 && y < 645 && ed.d_bad)
                        {
                            enst = true;
                            afst = true;
                        }
                        else if (x > 550 && x < 615 && y > 615 && y < 645 && ed.d_dead)
                        {
                            enst = true;
                            afst = true;
                        }
                        else if (x > 550 && x < 615 && y > 615 && y < 645 && ed.d_end)
                        {
                            enst = true;
                            afst = true;
                        }
                        else if (x > 646 && x < 786 && y > 525 && y < 665 && ed.d_s)
                        {
                            urast = true;
                            afst = true;
                        }
                    }

                }
                else if (afst)
                {

                    if (mst[2] || stshi[0] || stmemo[0])
                    {

                        if (x > 236 && x < 460 && y > 520 && y < 570 && mst[2])
                        {
                            mst[2] = false;
                            stshi[0] = true;
                        }
                        else if (x > 236 && x < 460 && y > 520 && y < 570 && stshi[0])
                        {
                            stshi[0] = false;
                            mst[2] = true;
                        }
                        else if (x > 485 && x < 672 && y > 520 && y < 570 && mst[2])
                        {
                            mst[2] = false;
                            stmemo[0] = true;
                        }
                        else if (x > 485 && x < 672 && y > 520 && y < 570 && stmemo[0])
                        {
                            stmemo[0] = false;
                            mst[2] = true;
                        }

                        else if (x > 236 && x < 460 && y > 520 && y < 570 && stmemo[0])
                        {
                            stmemo[0] = false;
                            stshi[0] = true;
                        }
                        else if (x > 485 && x < 672 && y > 520 && y < 570 && stshi[0])
                        {
                            stshi[0] = false;
                            stmemo[0] = true;
                        }

                    }
                    else if (mst[3] || stshi[1] || stmemo[1])
                    {
                        if (x > 236 && x < 460 && y > 520 && y < 570 && mst[3])
                        {
                            mst[3] = false;
                            stshi[1] = true;
                        }
                        else if (x > 236 && x < 460 && y > 520 && y < 570 && stshi[1])
                        {
                            stshi[1] = false;
                            mst[3] = true;
                        }
                        else if (x > 485 && x < 672 && y > 520 && y < 570 && mst[3])
                        {
                            mst[3] = false;
                            stmemo[1] = true;
                        }
                        else if (x > 485 && x < 672 && y > 520 && y < 570 && stmemo[1])
                        {
                            stmemo[1] = false;
                            mst[3] = true;
                        }
                        else if (x > 236 && x < 460 && y > 520 && y < 570 && stmemo[1])
                        {
                            stmemo[1] = false;
                            stshi[1] = true;
                        }
                        else if (x > 485 && x < 672 && y > 520 && y < 570 && stshi[1])
                        {
                            stshi[1] = false;
                            stmemo[1] = true;
                        }
                    }
                    else if (mst[4] || stshi[2] || stmemo[2])
                    {
                        if (x > 236 && x < 460 && y > 520 && y < 570 && mst[4])
                        {
                            mst[4] = false;
                            stshi[2] = true;
                        }
                        else if (x > 236 && x < 460 && y > 520 && y < 570 && stshi[2])
                        {
                            stshi[2] = false;
                            mst[4] = true;
                        }
                        else if (x > 485 && x < 672 && y > 520 && y < 570 && mst[4])
                        {
                            mst[4] = false;
                            stmemo[2] = true;
                        }
                        else if (x > 485 && x < 672 && y > 520 && y < 570 && stmemo[2])
                        {
                            stmemo[2] = false;
                            mst[4] = true;
                        }
                        else if (x > 236 && x < 460 && y > 520 && y < 570 && stmemo[2])
                        {
                            stmemo[2] = false;
                            stshi[2] = true;
                        }
                        else if (x > 485 && x < 672 && y > 520 && y < 570 && stshi[2])
                        {
                            stshi[2] = false;
                            stmemo[2] = true;
                        }
                    }
                    if (mst[5] || mst[6] || stshi[3] || stmemo[3])
                    {
                        if (x > 410 && x < 557 && y > 465 && y < 510 && mst[5])
                        {
                            mst[5] = false;
                            mst[6] = true;
                            ms6 = true;
                        }
                        else if (x > 410 && x < 557 && y > 465 && y < 510 && mst[6])
                        {
                            mst[6] = false;
                            mst[5] = true;
                            ms6 = false;
                        }
                        else if (x > 236 && x < 460 && y > 520 && y < 570 && mst[5])
                        {
                            mst[5] = false;
                            stshi[3] = true;
                        }
                        else if (x > 236 && x < 460 && y > 520 && y < 570 && stshi[3] && !ms6)
                        {
                            stshi[3] = false;
                            mst[5] = true;
                        }
                        else if (x > 485 && x < 672 && y > 520 && y < 570 && mst[5])
                        {
                            mst[5] = false;
                            stmemo[3] = true;
                        }
                        else if (x > 485 && x < 672 && y > 520 && y < 570 && stmemo[3] && !ms6)
                        {
                            stmemo[3] = false;
                            mst[5] = true;
                        }
                        else if (x > 236 && x < 460 && y > 520 && y < 570 && mst[6])
                        {
                            mst[6] = false;
                            stshi[3] = true;
                        }
                        else if (x > 236 && x < 460 && y > 520 && y < 570 && stshi[3] && ms6)
                        {
                            stshi[3] = false;
                            mst[6] = true;
                        }
                        else if (x > 485 && x < 672 && y > 520 && y < 570 && mst[6])
                        {
                            mst[6] = false;
                            stmemo[3] = true;
                        }
                        else if (x > 485 && x < 672 && y > 520 && y < 570 && stmemo[3] && ms6)
                        {
                            stmemo[3] = false;
                            mst[6] = true;
                        }
                        else if (x > 236 && x < 460 && y > 520 && y < 570 && stmemo[3])
                        {
                            stmemo[3] = false;
                            stshi[3] = true;
                        }
                        else if (x > 485 && x < 672 && y > 520 && y < 570 && stshi[3])
                        {
                            stshi[3] = false;
                            stmemo[3] = true;
                        }
                    }
                    else if (mst[7] || mst[8] || stshi[4])
                    {
                        if (x > 485 && x < 672 && y > 520 && y < 570 && mst[7])
                        {
                            mst[7] = false;
                            mst[8] = true;
                            ms7 = true;
                        }
                        else if (x > 485 && x < 672 && y > 520 && y < 570 && mst[8])
                        {
                            mst[8] = false;
                            mst[7] = true;
                            ms7 = false;
                        }
                        else if (x > 236 && x < 460 && y > 520 && y < 570 && mst[7])
                        {
                            mst[7] = false;
                            stshi[4] = true;
                        }
                        else if (x > 307 && x < 557 && y > 520 && y < 570 && stshi[4] && !ms7)
                        {
                            stshi[4] = false;
                            mst[7] = true;
                        }
                        else if (x > 236 && x < 460 && y > 520 && y < 570 && mst[8])
                        {
                            mst[8] = false;
                            stshi[4] = true;
                        }
                        else if (x > 307 && x < 557 && y > 520 && y < 570 && stshi[4] && ms7)
                        {
                            stshi[4] = false;
                            mst[8] = true;
                        }
                    }

                    if (kst[0] || kst[1])
                    {
                        if (x > 307 && x < 635 && y > 520 && y < 570 && kst[0])
                        {
                            kst[0] = false;
                            kst[1] = true;
                        }
                        else if (x > 307 && x < 635 && y > 520 && y < 570 && kst[1])
                        {
                            kst[1] = false;
                            kst[0] = true;
                        }
                    }
                    if (kst[2] || kst[3])
                    {
                        if (x > 307 && x < 635 && y > 520 && y < 570 && kst[2])
                        {
                            kst[2] = false;
                            kst[3] = true;
                        }
                        else if (x > 307 && x < 635 && y > 520 && y < 570 && kst[3])
                        {
                            kst[3] = false;
                            kst[2] = true;
                        }
                    }
                    if (kst[4] || kst[5])
                    {
                        if (x > 307 && x < 635 && y > 520 && y < 570 && kst[4])
                        {
                            kst[4] = false;
                            kst[5] = true;
                        }
                        else if (x > 307 && x < 635 && y > 520 && y < 570 && kst[5])
                        {
                            kst[5] = false;
                            kst[4] = true;
                        }
                    }
                    if (kst[6] || kst[7] || kst[8] || kst[9])
                    {
                        if (x > 349 && x < 635 && y > 520 && y < 570 && kst[6])
                        {
                            kst[6] = false;
                            kst[7] = true;
                        }
                        else if (x > 236 && x < 460 && y > 520 && y < 570 && (kst[7] || kst[8] || kst[9]))
                        {
                            kst[7] = false;
                            kst[8] = false;
                            kst[9] = false;
                            kst[6] = true;
                        }
                        else if (x > 485 && x < 672 && y > 520 && y < 570 && kst[7])
                        {
                            kst[7] = false;
                            kst[8] = true;
                        }
                        else if (x > 472 && x < 565 && y > 520 && y < 570 && kst[8])
                        {
                            kst[8] = false;
                            kst[7] = true;
                        }
                        else if (x > 577 && x < 672 && y > 520 && y < 570 && kst[8])
                        {
                            kst[8] = false;
                            kst[9] = true;
                        }
                        else if (x > 480 && x < 565 && y > 520 && y < 570 && kst[9])
                        {
                            kst[9] = false;
                            kst[8] = true;
                        }
                        else if (x > 577 && x < 672 && y > 520 && y < 570 && kst[9])
                        {
                            kst[9] = false;
                            kst[7] = true;
                        }
                    }
                    if (urast)
                    {
                        if (!urst)
                        {
                            if (x > 225 && x < 365 && y > 315 && y < 370)
                            {
                                urst = true;
                                ustken[0] = true;
                            }
                            else if (x > 480 && x < 620 && y > 315 && y < 370)
                            {
                                urst = true;
                                ustsei[0] = true;
                            }
                            else if (x > 225 && x < 365 && y > 465 && y < 520)
                            {
                                urst = true;
                                usttou[0] = true;
                            }
                            else if (x > 480 && x < 620 && y > 465 && y < 520)
                            {
                                urst = true;
                                ustkako[0] = true;
                            }
                            else if (x > 646 && x < 786 && y > 525 && y < 665)
                            {
                                urast = false;
                                afst = false;
                            }
                        }
                        if (urst)
                        {
                            if (ustken[0] || ustken[1] || ustken[2] || ustken[3] || ustken[4] || ustken[5] || ustken[6] || ustken[7] || ustken[8] || ustken[9])
                            {
                                if (x > 349 && x < 635 && y > 520 && y < 570 && ustken[0])
                                {
                                    ustken[0] = false;
                                    ustken[1] = true;
                                }
                                else if (x > 236 && x < 460 && y > 520 && y < 570 && (ustken[1] || ustken[2] || ustken[3] || ustken[4] || ustken[5] || ustken[6] || ustken[7] || ustken[8] || ustken[9]))
                                {
                                    ustken[0] = true;
                                    for (int i = 1; i < 10; i++)
                                    {
                                        ustken[i] = false;
                                    }
                                }
                                else if (x > 485 && x < 672 && y > 520 && y < 570 && ustken[1])
                                {
                                    ustken[1] = false;
                                    ustken[2] = true;
                                }
                                else if (x > 472 && x < 565 && y > 520 && y < 570 && ustken[2])
                                {
                                    ustken[2] = false;
                                    ustken[1] = true;
                                }
                                else if (x > 577 && x < 672 && y > 520 && y < 570 && ustken[2])
                                {
                                    ustken[2] = false;
                                    ustken[3] = true;
                                }
                                else if (x > 480 && x < 565 && y > 520 && y < 570 && ustken[3])
                                {
                                    ustken[3] = false;
                                    ustken[2] = true;
                                }
                                else if (x > 577 && x < 672 && y > 520 && y < 570 && ustken[3])
                                {
                                    ustken[3] = false;
                                    ustken[4] = true;
                                }
                                else if (x > 472 && x < 565 && y > 520 && y < 570 && ustken[4])
                                {
                                    ustken[4] = false;
                                    ustken[3] = true;
                                }
                                else if (x > 577 && x < 672 && y > 520 && y < 570 && ustken[4])
                                {
                                    ustken[4] = false;
                                    ustken[5] = true;
                                }
                                else if (x > 480 && x < 565 && y > 520 && y < 570 && ustken[5])
                                {
                                    ustken[5] = false;
                                    ustken[4] = true;
                                }
                                else if (x > 577 && x < 672 && y > 520 && y < 570 && ustken[5])
                                {
                                    ustken[5] = false;
                                    ustken[6] = true;
                                }
                                else if (x > 472 && x < 565 && y > 520 && y < 570 && ustken[6])
                                {
                                    ustken[6] = false;
                                    ustken[5] = true;
                                }
                                else if (x > 577 && x < 672 && y > 520 && y < 570 && ustken[6])
                                {
                                    ustken[6] = false;
                                    ustken[7] = true;
                                }
                                else if (x > 480 && x < 565 && y > 520 && y < 570 && ustken[7])
                                {
                                    ustken[7] = false;
                                    ustken[6] = true;
                                }
                                else if (x > 577 && x < 672 && y > 520 && y < 570 && ustken[7])
                                {
                                    ustken[7] = false;
                                    ustken[8] = true;
                                }
                                else if (x > 480 && x < 565 && y > 520 && y < 570 && ustken[8])
                                {
                                    ustken[8] = false;
                                    ustken[7] = true;
                                }
                                else if (x > 577 && x < 672 && y > 520 && y < 570 && ustken[8])
                                {
                                    ustken[8] = false;
                                    ustken[9] = true;
                                }
                                else if (x > 485 && x < 672 && y > 520 && y < 570 && ustken[9])
                                {
                                    ustken[9] = false;
                                    ustken[8] = true;
                                }
                            }
                            if (ustsei[0] || ustsei[1] || ustsei[2] || ustsei[3] || ustsei[4])
                            {
                                if (x > 349 && x < 635 && y > 520 && y < 570 && ustsei[0])
                                {
                                    ustsei[0] = false;
                                    ustsei[1] = true;
                                }
                                else if (x > 236 && x < 460 && y > 520 && y < 570 && (ustsei[1] || ustsei[2] || ustsei[3] || ustsei[4]))
                                {
                                    ustsei[0] = true;
                                    for (int i = 1; i < 5; i++)
                                    {
                                        ustsei[i] = false;
                                    }
                                }
                                else if (x > 485 && x < 672 && y > 520 && y < 570 && ustsei[1])
                                {
                                    ustsei[1] = false;
                                    ustsei[2] = true;
                                }
                                else if (x > 472 && x < 565 && y > 520 && y < 570 && ustsei[2])
                                {
                                    ustsei[2] = false;
                                    ustsei[1] = true;
                                }
                                else if (x > 577 && x < 672 && y > 520 && y < 570 && ustsei[2])
                                {
                                    ustsei[2] = false;
                                    ustsei[3] = true;
                                }
                                else if (x > 480 && x < 565 && y > 520 && y < 570 && ustsei[3])
                                {
                                    ustsei[3] = false;
                                    ustsei[2] = true;
                                }
                                else if (x > 577 && x < 672 && y > 520 && y < 570 && ustsei[3])
                                {
                                    ustsei[3] = false;
                                    ustsei[4] = true;
                                }
                                else if (x > 485 && x < 672 && y > 520 && y < 570 && ustsei[4])
                                {
                                    ustsei[4] = false;
                                    ustsei[3] = true;
                                }
                            }
                            if (usttou[0] || usttou[1])
                            {
                                if (x > 349 && x < 635 && y > 520 && y < 570 && usttou[0])
                                {
                                    usttou[0] = false;
                                    usttou[1] = true;
                                }
                                else if (x > 349 && x < 635 && y > 520 && y < 570 && usttou[1])
                                {
                                    usttou[1] = false;
                                    usttou[0] = true;
                                }
                            }
                            if (ustkako[0] || ustkako[1] || ustkako[2] || ustkako[3] || ustkako[4])
                            {
                                if (x > 349 && x < 635 && y > 520 && y < 570 && ustkako[0])
                                {
                                    ustkako[0] = false;
                                    ustkako[1] = true;
                                }
                                else if (x > 236 && x < 460 && y > 520 && y < 570 && (ustkako[1] || ustkako[2] || ustkako[3] || ustkako[4]))
                                {
                                    ustkako[0] = true;
                                    for (int i = 1; i < 5; i++)
                                    {
                                        ustkako[i] = false;
                                    }
                                }
                                else if (x > 485 && x < 672 && y > 520 && y < 570 && ustkako[1])
                                {
                                    ustkako[1] = false;
                                    ustkako[2] = true;
                                }
                                else if (x > 472 && x < 565 && y > 520 && y < 570 && ustkako[2])
                                {
                                    ustkako[2] = false;
                                    ustkako[1] = true;
                                }
                                else if (x > 577 && x < 672 && y > 520 && y < 570 && ustkako[2])
                                {
                                    ustkako[2] = false;
                                    ustkako[3] = true;
                                }
                                else if (x > 480 && x < 565 && y > 520 && y < 570 && ustkako[3])
                                {
                                    ustkako[3] = false;
                                    ustkako[2] = true;
                                }
                                else if (x > 577 && x < 672 && y > 520 && y < 570 && ustkako[3])
                                {
                                    ustkako[3] = false;
                                    ustkako[4] = true;
                                }
                                else if (x > 485 && x < 672 && y > 520 && y < 570 && ustkako[4])
                                {
                                    ustkako[4] = false;
                                    ustkako[3] = true;
                                }
                            }
                        }
                    }
                    if (x > 350 && x < 560 && y > 580 && y < 640 && !urst)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            mst[i] = false;
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
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            kst[i] = false;
                        }
                        afst = false;
                    }
                    if (x > 350 && x < 560 && y > 580 && y < 640 && urst)
                    {
                        urst = false;
                        for (int i = 0; i < 5; i++)
                        {
                            ustsei[i] = false;
                            ustkako[i] = false;
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            ustken[i] = false;
                        }
                        usttou[0] = false;
                        usttou[1] = false;
                    }

                }
            }

            if (x > 0 && x < 1024 && y > 0 && y < 768 && t.s && !end)
            {
                t.s = false;
                return (int)Form1.RM.room1;
            }
            else if (x > 960 && x < 1024 && y > 680 && y < 768 && ((!t.s && !end) || enst))
            {
                Audio.Stop_endstorya();
                Audio.Stop_endstoryb();
                Audio.Stop_endstoryc();
                Audio.Stop_endstoryd();
                Audio.Stop_endstorye();
                Audio.Stop_endstoryf();
                Audio.Stop_endstoryg();
                return (int)Form1.RM.title;
            }
            else if (x > 0 && x < 65 && y > 680 && y < 768 && end)
            {
                Audio.Stop_endstorya();
                Audio.Stop_endstoryb();
                Audio.Stop_endstoryc();
                Audio.Stop_endstoryd();
                Audio.Stop_endstorye();
                Audio.Stop_endstoryf();
                Audio.Stop_endstoryg();
                end = false;
                return (int)Form1.RM.title;
            }
            else if (x > 825 && x < 935 && y > 690 && y < 755 && ((!t.s && !end) || enst))
            {
                end = true;
                afst = false;
                enst = false;
                return (int)Form1.RM.story;
            }
            else
            {
                return (int)Form1.RM.story;
            }

        }
        public void Nl()//タイトル画面に戻ってきた時のフラグ初期化（基本的には宣言したものすべて）
        {
            end = false;
            enst = false;
            afst = false;
            urast = false;
            urst = false;
            mst[0] = false;
            for (int i = 1; i < 9; i++)
            {
                mst[i] = false;
            }
            ms6 = false;
            ms7 = false;
            for (int i = 0; i < 5; i++)
            {
                stshi[i] = false;
                ustsei[i] = false;
                ustkako[i] = false;
            }
            for (int i = 0; i < 4; i++)
            {
                stmemo[i] = false;
            }
            for (int i = 0; i < 10; i++)
            {
                kst[i] = false;
                ustken[i] = false;
            }
            usttou[0] = false;
            usttou[1] = false;
        }


    }
}
