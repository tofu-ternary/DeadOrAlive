using System.Drawing;

namespace test
{
    class Room2 : Room
    {
        Image img;
        Point point = new Point(0, 0);

        Point book_point = new Point(350, 505);
        Point book1_point = new Point(160, 275);
        Point book2_point = new Point(700, 525);
        Point book3_point = new Point(190, 340);
        Point book4_point = new Point(600, 540);
        Point entyu_point = new Point(650, 490);

        Point arrowdown = new Point(450, 500);
        Point arrowleft = new Point(25, 300);


        public bool all = true;
        public bool on = true;
        public bool off = false;

        public bool book = true;
        public bool book1 = true;
        public bool book2 = true;
        public bool book3 = true;
        public bool book4 = true;
        public bool brtsubo = false;
        public bool entyu = true;

        public bool light = false;
        public bool LOP = false;

        public bool p_stage = true;
        public bool n_stage = true;

        public bool d_cl = false;


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
                    if (on)
                    {
                        if (!brtsubo)
                        {
                            img = test.Properties.Resources.RM2_1;
                            gr.DrawImage(img, point);
                        }
                        else
                        {
                            img = test.Properties.Resources.RM2_3;
                            gr.DrawImage(img, point);
                            if (entyu)
                            {
                                img = test.Properties.Resources.entyu;
                                gr.DrawImage(img, entyu_point);
                            }
                        }
                        if (book)
                        {
                            img = test.Properties.Resources.rm2book;
                            gr.DrawImage(img, book_point);
                        }
                        if (book1)
                        {
                            img = test.Properties.Resources.rm2book1;
                            gr.DrawImage(img, book1_point);
                        }
                        if (book2)
                        {
                            img = test.Properties.Resources.rm2book2;
                            gr.DrawImage(img, book2_point);
                        }
                        if (book3)
                        {
                            img = test.Properties.Resources.rm2book3;
                            gr.DrawImage(img, book3_point);
                        }
                        if (book4)
                        {
                            img = test.Properties.Resources.rm2book4;
                            gr.DrawImage(img, book4_point);
                        }
                        if (p_stage)
                        {
                            img = test.Properties.Resources.矢印4;
                            gr.DrawImage(img, arrowdown);
                        }
                        if (n_stage)
                        {
                            img = test.Properties.Resources.矢印;
                            gr.DrawImage(img, arrowleft);
                        }
                    }
                    else if (off)
                    {
                        img = test.Properties.Resources.RM2_2;
                        gr.DrawImage(img, point);
                    }
                }
                if (light)
                {
                    img = test.Properties.Resources.rm2light;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                }
                if (LOP)
                {
                    img = test.Properties.Resources.rm2light_on_paper;
                    gr.DrawImage(img, point);
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
                if (on)
                {
                    if (x > 360 && x < 400 && y > 505 && y < 545 && book)
                    {


                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            ui.Bl((int)Ui.Items.book_1);
                            book = false;
                        }
                    }
                    else if (x > 350 && x < 450 && y > 505 && y < 605 && ui.item[ui.item_selet] == (int)Ui.Items.book_1)
                    {
                        ui.Dl(ui.item_selet);

                        book = true;
                    }
                    if (x > 160 && x < 210 && y > 290 && y < 318 && book1)
                    {


                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            ui.Bl((int)Ui.Items.item7);
                            book1 = false;
                        }
                    }
                    else if (x > 160 && x < 210 && y > 290 && y < 318 && ui.item[ui.item_selet] == (int)Ui.Items.item7)
                    {
                        ui.Dl(ui.item_selet);

                        book1 = true;
                    }


                    if (x > 705 && x < 765 && y > 535 && y < 585 && book2)
                    {


                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            ui.Bl((int)Ui.Items.item8);
                            book2 = false;
                        }
                    }
                    else if (x > 705 && x < 765 && y > 535 && y < 585 && ui.item[ui.item_selet] == (int)Ui.Items.item8)
                    {
                        ui.Dl(ui.item_selet);

                        book2 = true;
                    }
                    if (x > 195 && x < 230 && y > 345 && y < 400 && book3)
                    {


                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            ui.Bl((int)Ui.Items.item9);
                            book3 = false;
                        }
                    }
                    else if (x > 195 && x < 240 && y > 345 && y < 400 && ui.item[ui.item_selet] == (int)Ui.Items.item9)
                    {
                        ui.Dl(ui.item_selet);

                        book3 = true;
                    }
                    if (x > 605 && x < 655 && y > 550 && y < 590 && book4)
                    {


                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            ui.Bl((int)Ui.Items.item10);
                            book4 = false;
                        }
                    }
                    else if (x > 605 && x < 655 && y > 550 && y < 590 && ui.item[ui.item_selet] == (int)Ui.Items.item10)
                    {
                        ui.Dl(ui.item_selet);

                        book4 = true;
                    }
                    if (x > 790 && x < 910 && y > 330 && y < 405 && mis.qes[(int)Mis.QE.Qes5] && !brtsubo)
                    {
                        brtsubo = true;
                        Audio.Play_vase_break();
                    }
                    if (brtsubo)
                    {
                        if (x > 650 && x < 714 && y > 490 && y < 530 && entyu)
                        {


                            if (ui.item[4] == (int)Ui.Items.error)
                            {
                                ui.Bl((int)Ui.Items.item12);
                                entyu = false;
                            }
                        }
                        else if (x > 650 && x < 714 && y > 490 && y < 530 && ui.item[ui.item_selet] == (int)Ui.Items.item12)
                        {
                            ui.Dl(ui.item_selet);

                            entyu = true;
                        }
                    }
                    if (x > 350 && x < 670 && y > 1 && y < 20)
                    {
                        light = true;
                        on = false;
                    }

                    if (x > 375 && x < 460 && y > 365 && y < 385)
                    {
                        on = false;
                        off = true;
                        Audio.switch_onf_spill();
                    }

                    if (x > 475 && x < 525 && y > 500 && y < 600 && p_stage)
                    { 
                        Audio.Play_move();
                        return (int)Form1.RM.room1;

                    }
                    if (x > 20 && x < 150 && y > 300 && y < 375 && n_stage)
                    { 
                        Audio.Play_move();
                        return (int)Form1.RM.room3;

                    }
                }
                else if (off)
                {
                    if (x > 375 && x < 460 && y > 345 && y < 360)
                    {
                        on = true;
                        off = false;
                        Audio.switch_onf_spill();
                    }
                }
                if (light)
                {
                    if (x > 180 && x < 830 && y > 85 && y < 525 && ui.item[ui.item_selet] == (int)Ui.Items.item6)
                    {
                        LOP = true;
                        light = false;
                    }
                    if (x > 0 && x < 130 && y > 0 && y < 75)
                    {
                        light = false;
                        on = true;
                    }
                }
                if (LOP)
                {
                    if (x > 0 && x < 130 && y > 0 && y < 75)
                    {
                        LOP = false;
                        on = true;
                    }
                }
            }


            if (x > 0 && x < 800 && y > 600 && y < 750)
            {
                ui.Loc(x, y);
            }
            All();

            return (int)Form1.RM.room2;




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
            on = true;
            off = false;

            book = true;
            book1 = true;
            book2 = true;
            book3 = true;
            book4 = true;
            brtsubo = false;
            entyu = true;
            light = false;
            LOP = false;
            p_stage = true;
            n_stage = true;

            d_cl = false;
        }
        public void All()
        {
            if (d_cl)
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
