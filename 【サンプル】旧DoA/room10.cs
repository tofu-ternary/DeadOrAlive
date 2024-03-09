using System.Drawing;

namespace test
{
    class Room10 : Room
    {
        Image img;
        Point point = new Point(0, 0);

        Point box_point = new Point(462, 355);
        Point doba_point = new Point(400, 510);
        Point mato_point = new Point(663, 406);
        Point mato2_point = new Point(700, 367);

        Point p1_point = new Point(462, 106);
        Point p2_point = new Point(465, 146);
        Point p3_point = new Point(463, 265);
        Point p4_point = new Point(462, 273);
        Point p5_point = new Point(343, 269);
        Point p6_point = new Point(305, 266);
        Point p7_point = new Point(301, 150);
        Point p8_point = new Point(344, 108);
        Point key_point = new Point(300, 455);

        Point arrowleft = new Point(25, 300);


        public bool all = true;
        public bool all1 = true;
        public bool all2 = false;

        public bool box = true;
        public bool box2 = false;
        public bool doba = false;
        public bool mato = true;
        public bool mato2 = false;
        public bool opmato = false;
        public bool opmato2 = false;

        public bool loc = false;
        public bool loc2 = false;

        public bool p1 = false;
        public bool p2 = false;
        public bool p3 = false;
        public bool p4 = false;
        public bool p5 = false;
        public bool p6 = false;
        public bool p7 = false;
        public bool p8 = false;
        public bool pb1 = false;
        public bool pb2 = false;
        public bool pb3 = false;
        public bool pb4 = false;
        public bool pb5 = false;
        public bool pb6 = false;
        public bool pb7 = false;
        public bool pb8 = false;
        public bool pr1 = false;
        public bool pr2 = false;
        public bool pr3 = false;
        public bool pr4 = false;
        public bool pr5 = false;
        public bool pr6 = false;
        public bool pr7 = false;
        public bool pr8 = false;
        public bool py1 = false;
        public bool py2 = false;
        public bool py3 = false;
        public bool py4 = false;
        public bool py5 = false;
        public bool py6 = false;
        public bool py7 = false;
        public bool py8 = false;

        public bool key = true;

        public bool n_stage = true;

        public bool d_cl = false;

        int[] ipb = new int[10];
        int[] ipr = new int[10];
        int[] ipy = new int[10];



        Ui ui = new Ui();
        Key key_nyu = new Key();
        Mis mis = new Mis();

        public void In(Ui ui2)
        {
            ui = ui2;
        }
        public void In2(Key key2)
        {
            key_nyu = key2;
        }

        public void In3(Mis mis2)
        {
            mis = mis2;
        }


        public void Draw(Graphics gr)
        {
            if (d_cl)
            {
                ui.D_draw(gr);
            }
            else
            {

                if (all)
                {
                    if (all1)
                    {
                        img = test.Properties.Resources.RM10_1;
                        gr.DrawImage(img, point);
                    }
                    if (all2)
                    {
                        img = test.Properties.Resources.RM10_2;
                        gr.DrawImage(img, point);
                    }
                    if (box)
                    {
                        img = test.Properties.Resources.rm10box;
                        gr.DrawImage(img, box_point);
                    }
                    if (box2)
                    {
                        img = test.Properties.Resources.rm10box2;
                        gr.DrawImage(img, box_point);
                    }
                    if (doba)
                    {
                        img = test.Properties.Resources.rm10doba;
                        gr.DrawImage(img, doba_point);
                    }
                    if (mato)
                    {
                        img = test.Properties.Resources.rm10mato;
                        gr.DrawImage(img, mato_point);
                    }
                    if (mato2)
                    {
                        img = test.Properties.Resources.rm10mato2;
                        gr.DrawImage(img, mato2_point);
                    }
                    if (opmato)
                    {
                        img = test.Properties.Resources.rm10opmato;
                        gr.DrawImage(img, mato_point);
                    }
                    if (opmato2)
                    {
                        img = test.Properties.Resources.rm10opmato2;
                        gr.DrawImage(img, mato_point);
                    }
                    if (loc)
                    {
                        img = test.Properties.Resources.rm10loc;
                        gr.DrawImage(img, point);
                    }
                    if (n_stage)
                    {
                        img = test.Properties.Resources.矢印;
                        gr.DrawImage(img, arrowleft);
                    }
                }
                if (loc)
                {
                    img = test.Properties.Resources.rm10loc;
                    gr.DrawImage(img, point);
                    if (pb1)
                    {
                        img = test.Properties.Resources.rm10pb1;
                        gr.DrawImage(img, p1_point);
                    }
                    if (pb2)
                    {
                        img = test.Properties.Resources.rm10pb2;
                        gr.DrawImage(img, p2_point);
                    }
                    if (pb3)
                    {
                        img = test.Properties.Resources.rm10pb3;
                        gr.DrawImage(img, p3_point);
                    }
                    if (pb4)
                    {
                        img = test.Properties.Resources.rm10pb4;
                        gr.DrawImage(img, p4_point);
                    }
                    if (pb5)
                    {
                        img = test.Properties.Resources.rm10pb5;
                        gr.DrawImage(img, p5_point);
                    }
                    if (pb6)
                    {
                        img = test.Properties.Resources.rm10pb6;
                        gr.DrawImage(img, p6_point);
                    }
                    if (pb7)
                    {
                        img = test.Properties.Resources.rm10pb7;
                        gr.DrawImage(img, p7_point);
                    }
                    if (pb8)
                    {
                        img = test.Properties.Resources.rm10pb8;
                        gr.DrawImage(img, p8_point);
                    }
                    if (pr1)
                    {
                        img = test.Properties.Resources.rm10pr1;
                        gr.DrawImage(img, p1_point);
                    }
                    if (pr2)
                    {
                        img = test.Properties.Resources.rm10pr2;
                        gr.DrawImage(img, p2_point);
                    }
                    if (pr3)
                    {
                        img = test.Properties.Resources.rm10pr3;
                        gr.DrawImage(img, p3_point);
                    }
                    if (pr4)
                    {
                        img = test.Properties.Resources.rm10pr4;
                        gr.DrawImage(img, p4_point);
                    }
                    if (pr5)
                    {
                        img = test.Properties.Resources.rm10pr5;
                        gr.DrawImage(img, p5_point);
                    }
                    if (pr6)
                    {
                        img = test.Properties.Resources.rm10pr6;
                        gr.DrawImage(img, p6_point);
                    }
                    if (pr7)
                    {
                        img = test.Properties.Resources.rm10pr7;
                        gr.DrawImage(img, p7_point);
                    }
                    if (pr8)
                    {
                        img = test.Properties.Resources.rm10pr8;
                        gr.DrawImage(img, p8_point);
                    }
                    if (py1)
                    {
                        img = test.Properties.Resources.rm10py1;
                        gr.DrawImage(img, p1_point);
                    }
                    if (py2)
                    {
                        img = test.Properties.Resources.rm10py2;
                        gr.DrawImage(img, p2_point);
                    }
                    if (py3)
                    {
                        img = test.Properties.Resources.rm10py3;
                        gr.DrawImage(img, p3_point);
                    }
                    if (py4)
                    {
                        img = test.Properties.Resources.rm10py4;
                        gr.DrawImage(img, p4_point);
                    }
                    if (py5)
                    {
                        img = test.Properties.Resources.rm10py5;
                        gr.DrawImage(img, p5_point);
                    }
                    if (py6)
                    {
                        img = test.Properties.Resources.rm10py6;
                        gr.DrawImage(img, p6_point);
                    }
                    if (py7)
                    {
                        img = test.Properties.Resources.rm10py7;
                        gr.DrawImage(img, p7_point);
                    }
                    if (py8)
                    {
                        img = test.Properties.Resources.rm10py8;
                        gr.DrawImage(img, p8_point);
                    }
                    if (py8)
                    {
                        img = test.Properties.Resources.rm10py8;
                        gr.DrawImage(img, p8_point);
                    }

                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);

                }
                if (loc2)
                {
                    img = test.Properties.Resources.rm10loc2;
                    gr.DrawImage(img, point);
                    if (key)
                    {
                        img = test.Properties.Resources.rm10key1;
                        gr.DrawImage(img, key_point);
                    }
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                }
            }
            ui.Draw(gr);
        }

        public int Loc(int x, int y)
        {
            if (d_cl)
            {
                d_cl = ui.D_loc(x, y);
            }
            else
            {
                if (all)
                {
                    if (x > 715 && x < 750 && y > 375 && y < 435 && ui.item[ui.item_selet] == (int)Ui.Items.item29)
                    {
                        ui.Dl(ui.item_selet);

                        mato2 = true;
                        mato = false;
                        opmato = true;
                        Audio.Play_mato_put();
                    }
                    if (x > 670 && x < 690 && y > 410 && y < 435 && opmato)
                    {
                        opmato = false;
                        opmato2 = true;
                        mis.n_mis = true;
                        mis.qes[(int)Mis.QE.Qes12] = true;
                        Audio.Play_misdis();
                    }
                    if (x > 450 && x < 590 && y > 410 && y < 525 && box)
                    {
                        box = false;
                        box2 = true;
                        doba = true;
                        Audio.Play_object_lie();
                    }
                    if (x > 40 && x < 90 && y > 590 && y < 605 && all1)
                    {
                        all1 = false;
                        all2 = true;
                    }
                    if (x > 635 && x < 740 && y > 450 && y < 520)
                    {
                        all = false;
                        loc = true;
                    }
                    if (x > 20 && x < 150 && y > 300 && y < 375 && n_stage)
                    {
                        Audio.Play_move();
                        return (int)Form1.RM.room11;
                    }

                }
                if (loc)
                {
                    int i,
                        pb = 0,
                        pr = 0,
                        py = 0;
                    if (x > 470 && x < 525 && y > 135 && y < 195 && !p1)
                    {
                        pb1 = true;
                        p1 = true;
                        ipb[1] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 470 && x < 525 && y > 135 && y < 195 && pb1 && p1)
                    {
                        pb1 = false;
                        pr1 = true;
                        ipb[1] = 0;
                        ipr[1] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 470 && x < 525 && y > 135 && y < 195 && pr1 && p1)
                    {
                        pr1 = false;
                        py1 = true;
                        ipr[1] = 0;
                        ipy[1] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 470 && x < 525 && y > 135 && y < 195 && py1 && p1)
                    {
                        py1 = false;
                        pb1 = true;
                        ipy[1] = 0;
                        ipb[1] = 1;
                        Audio.Play_triangle_change();
                    }
                    if (x > 530 && x < 590 && y > 200 && y < 260 && !p2)
                    {
                        pb2 = true;
                        p2 = true;
                        ipb[2] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 530 && x < 590 && y > 200 && y < 260 && pb2 && p2)
                    {
                        pb2 = false;
                        pr2 = true;
                        ipb[2] = 0;
                        ipr[2] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 530 && x < 590 && y > 200 && y < 260 && pr2 && p2)
                    {
                        pr2 = false;
                        py2 = true;
                        ipr[2] = 0;
                        ipy[2] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 530 && x < 590 && y > 200 && y < 260 && py2 && p2)
                    {
                        py2 = false;
                        pb2 = true;
                        ipy[2] = 0;
                        ipb[2] = 1;
                        Audio.Play_triangle_change();
                    }
                    if (x > 530 && x < 590 && y > 270 && y < 330 && !p3)
                    {
                        pb3 = true;
                        p3 = true;
                        ipb[3] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 530 && x < 590 && y > 270 && y < 330 && pb3 && p3)
                    {
                        pb3 = false;
                        pr3 = true;
                        ipb[3] = 0;
                        ipr[3] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 530 && x < 590 && y > 270 && y < 330 && pr3 && p3)
                    {
                        pr3 = false;
                        py3 = true;
                        ipr[3] = 0;
                        ipy[3] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 530 && x < 590 && y > 270 && y < 330 && py3 && p3)
                    {
                        py3 = false;
                        pb3 = true;
                        ipy[3] = 0;
                        ipb[3] = 1;
                        Audio.Play_triangle_change();
                    }
                    if (x > 460 && x < 520 && y > 330 && y < 390 && !p4)
                    {
                        pb4 = true;
                        p4 = true;
                        ipb[4] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 460 && x < 520 && y > 330 && y < 390 && pb4 && p4)
                    {
                        pb4 = false;
                        pr4 = true;
                        ipb[4] = 0;
                        ipr[4] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 460 && x < 520 && y > 330 && y < 390 && pr4 && p4)
                    {
                        pr4 = false;
                        py4 = true;
                        ipr[4] = 0;
                        ipy[4] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 460 && x < 520 && y > 330 && y < 390 && py4 && p4)
                    {
                        py4 = false;
                        pb4 = true;
                        ipy[4] = 0;
                        ipb[4] = 1;
                        Audio.Play_triangle_change();
                    }
                    if (x > 395 && x < 455 && y > 330 && y < 390 && !p5)
                    {
                        pb5 = true;
                        p5 = true;
                        ipb[5] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 395 && x < 455 && y > 330 && y < 390 && pb5 && p5)
                    {
                        pb5 = false;
                        pr5 = true;
                        ipb[5] = 0;
                        ipr[5] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 395 && x < 455 && y > 330 && y < 390 && pr5 && p5)
                    {
                        pr5 = false;
                        py5 = true;
                        ipr[5] = 0;
                        ipy[5] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 395 && x < 455 && y > 330 && y < 390 && py5 && p5)
                    {
                        py5 = false;
                        pb5 = true;
                        ipy[5] = 0;
                        ipb[5] = 1;
                        Audio.Play_triangle_change();
                    }
                    if (x > 330 && x < 390 && y > 270 && y < 330 && !p6)
                    {
                        pb6 = true;
                        p6 = true;
                        ipb[6] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 330 && x < 390 && y > 270 && y < 330 && pb6 && p6)
                    {
                        pb6 = false;
                        pr6 = true;
                        ipb[6] = 0;
                        ipr[6] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 330 && x < 390 && y > 270 && y < 330 && pr6 && p6)
                    {
                        pr6 = false;
                        py6 = true;
                        ipr[6] = 0;
                        ipy[6] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 330 && x < 390 && y > 270 && y < 330 && py6 && p6)
                    {
                        py6 = false;
                        pb6 = true;
                        ipy[6] = 0;
                        ipb[6] = 1;
                        Audio.Play_triangle_change();
                    }
                    if (x > 325 && x < 385 && y > 200 && y < 260 && !p7)
                    {
                        pb7 = true;
                        p7 = true;
                        ipb[7] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 325 && x < 385 && y > 200 && y < 260 && pb7 && p7)
                    {
                        pb7 = false;
                        pr7 = true;
                        ipb[7] = 0;
                        ipr[7] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 325 && x < 385 && y > 200 && y < 260 && pr7 && p7)
                    {
                        pr7 = false;
                        py7 = true;
                        ipr[7] = 0;
                        ipy[7] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 325 && x < 385 && y > 200 && y < 260 && py7 && p7)
                    {
                        py7 = false;
                        pb7 = true;
                        ipy[7] = 0;
                        ipb[7] = 1;
                        Audio.Play_triangle_change();
                    }
                    if (x > 390 && x < 450 && y > 135 && y < 195 && !p8)
                    {
                        pb8 = true;
                        p8 = true;
                        ipb[8] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 390 && x < 450 && y > 135 && y < 195 && pb8 && p8)
                    {
                        pb8 = false;
                        pr8 = true;
                        ipb[8] = 0;
                        ipr[8] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 390 && x < 450 && y > 135 && y < 195 && pr8 && p8)
                    {
                        pr8 = false;
                        py8 = true;
                        ipr[8] = 0;
                        ipy[8] = 1;
                        Audio.Play_triangle_change();
                    }
                    else if (x > 390 && x < 450 && y > 135 && y < 195 && py8 && p8)
                    {
                        py8 = false;
                        pb8 = true;
                        ipy[8] = 0;
                        ipb[8] = 1;
                        Audio.Play_triangle_change();
                    }
                    for (i = 1; i <= 8; i++)
                    {
                        pb += ipb[i];
                        pr += ipr[i];
                        py += ipy[i];
                    }
                    if (x > 0 && x < 130 && y > 0 && y < 75)
                    {
                        loc = false;
                        all = true;
                    }
                    if (pb == 4 && pr == 3 && py == 1)
                    {
                        loc = false;
                        loc2 = true;
                        Audio.Play_slide_door();
                    }

                }
                if (loc2)
                {
                    if (x > 350 && x < 510 && y > 540 && y < 585 && key)
                    {


                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            ui.Bl((int)Ui.Items.item31);
                            key = false;
                        }
                    }
                    else if (x > 350 && x < 510 && y > 540 && y < 585 && ui.item[ui.item_selet] == (int)Ui.Items.item31)
                    {
                        ui.Dl(ui.item_selet);

                        key = true;
                    }
                    if (x > 0 && x < 130 && y > 0 && y < 75)
                    {
                        loc2 = false;
                        all = true;
                    }
                }

            }


            if (x > 0 && x < 800 && y > 600 && y < 750)
            {
                ui.Loc(x, y);
            }
            All();

            return (int)Form1.RM.room10;




        }

        public void D_Loc(int x, int y)
        {

            if (x > 25 && x < 125 && y > 650 && y < 750)
            {
                if (ui.item[0] != (int)Ui.Items.error)
                {
                    d_cl = true;
                    all = false;
                    ui.D_Cl(ui.item[0]);
                }
            }
            else if (x > 175 && x < 275 && y > 650 && y < 750)
            {
                if (ui.item[1] != (int)Ui.Items.error)
                {
                    d_cl = true;
                    all = false;
                    ui.D_Cl(ui.item[1]);
                }
            }
            else if (x > 325 && x < 425 && y > 650 && y < 750)
            {
                if (ui.item[2] != (int)Ui.Items.error)
                {
                    d_cl = true;
                    all = false;
                    ui.D_Cl(ui.item[2]);
                }
            }
            else if (x > 480 && x < 580 && y > 650 && y < 750)
            {
                if (ui.item[3] != (int)Ui.Items.error)
                {
                    d_cl = true;
                    all = false;
                    ui.D_Cl(ui.item[3]);
                }
            }
            else if (x > 620 && x < 720 && y > 650 && y < 750)
            {
                if (ui.item[4] != (int)Ui.Items.error)
                {
                    d_cl = true;
                    all = false;
                    ui.D_Cl(ui.item[4]);
                }
            }
        }

        public override void Nl()
        {
            all = true;
            all1 = true;
            all2 = false;

            box = true;
            box2 = false;
            doba = false;
            mato = true;
            mato2 = false;
            opmato = false;
            opmato2 = false;

            loc = false;
            loc2 = false;

            p1 = false;
            p2 = false;
            p3 = false;
            p4 = false;
            p5 = false;
            p6 = false;
            p7 = false;
            p8 = false;
            pb1 = false;
            pb2 = false;
            pb3 = false;
            pb4 = false;
            pb5 = false;
            pb6 = false;
            pb7 = false;
            pb8 = false;
            pr1 = false;
            pr2 = false;
            pr3 = false;
            pr4 = false;
            pr5 = false;
            pr6 = false;
            pr7 = false;
            pr8 = false;
            py1 = false;
            py2 = false;
            py3 = false;
            py4 = false;
            py5 = false;
            py6 = false;
            py7 = false;
            py8 = false;

            key = true;

            n_stage = true;

            d_cl = false;
        }
        public void All()
        {
            if (d_cl || loc || loc2)
            {
                all = false;
            }
            else
            {
                all = true;
            }
        }

    }
}