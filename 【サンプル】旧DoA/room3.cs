using System.Drawing;

namespace test
{
    class Room3 : Room
    {

        Image img;
        Point point = new Point(0, 0);
        Point point_book = new Point(350, 500);
        Point point_deskc = new Point(325, 450);
        Point point_kin = new Point(454, 200);
        Point point_bal = new Point(250, 250);
        Point point_loc = new Point(750, 300);
        Point[] points_loc = { new Point(704, 320), new Point(800, 320), new Point(704, 386), new Point(800, 386), new Point(704, 452), new Point(800, 452) };

        Point[] points_locbig = { new Point(296, 162), new Point(612, 162), new Point(296, 314), new Point(612, 314), new Point(296, 466), new Point(612, 466) };
        Point point_kabe = new Point(190, 120);


        Point point_bi = new Point(300, 290);

        Point[] points_book = { new Point(146, 228), new Point(274, 291), new Point(217, 351), new Point(246, 412), new Point(165, 465) };

        Point point_nazo3 = new Point(470, 480);

        Point arrowleft = new Point(25, 300);
        Point arrowright = new Point(900, 300);

        //Point pos_point = new Point(0, 0);


        public bool all = true;

        public bool book = true;

        public int[] book_in = { 0, 0, 0, 0, 0, 0 };

        public bool kin = false;

        public bool d_c = false;

        public bool kabe = true;

        public bool nazo3 = true;


        public bool[] loc = { false, false, false, false, false, false };

        public int loc_select = 0;

        public bool loc_big1 = false;
        public bool loc_big2 = false;



        public bool nyu_big1 = false;
        public bool nyu_big2 = false;

        public bool nyu1;
        public bool nyu2;



        public bool kin_open = false;
        public bool kin_big = false;


        public bool big = false;
        public bool d_cl = false;

        public bool oke = true;
        public bool paper = true;
        public bool ito = true;
        public bool botton = false;
        public bool mato = true;

        public bool bal = true;

        public bool n_stage = false;

        public bool l_dead = false;

        public bool nyu_click = false;

        public bool hasigo = false;
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

        bool a;
        public void Draw(Graphics gr)
        {

            /*   if (!a) {
                   a = true;
       ui.Bl(14);
    kin = true;
           }*/
            if (all)
            {
                img = test.Properties.Resources.RM3;
                gr.DrawImage(img, point);
                for (int i = 0; i < 6; i++)
                {
                    if (loc[i])
                    {

                        img = test.Properties.Resources.rm3Loc_open1;
                        gr.DrawImage(img, points_loc[i]);
                    }
                }
                if (!d_c)
                {
                    img = test.Properties.Resources.rm3desk_char;
                    gr.DrawImage(img, point_deskc);
                }
                else
                {
                    img = test.Properties.Resources.rm3desk_char2;
                    gr.DrawImage(img, point_deskc);
                }

                if (book && d_c)
                {
                    img = test.Properties.Resources.rm3book;
                    gr.DrawImage(img, point_book);
                }

                if (kin && kin_open)
                {
                    img = test.Properties.Resources.rm3hide_open;
                    gr.DrawImage(img, point_kin);
                }
                else if (kin && !kin_open)
                {
                    img = test.Properties.Resources.rm3hide;
                    gr.DrawImage(img, point_kin);
                }

                if (nazo3)
                {
                    img = test.Properties.Resources.rm3nazo3;
                    gr.DrawImage(img, point_nazo3);
                }

                for (int i = 0; i < 5; i++)
                {
                    if (book_in[i] != 0)
                    {
                        switch (book_in[i])
                        {
                            case 1:
                                img = test.Properties.Resources.rm3book1;
                                break;
                            case 2:
                                img = test.Properties.Resources.rm3book2;
                                break;
                            case 3:
                                img = test.Properties.Resources.rm3book3;
                                break;
                            case 4:
                                img = test.Properties.Resources.rm3book4;
                                break;
                            case 5:
                                img = test.Properties.Resources.rm3book5;
                                break;
                        }
                        gr.DrawImage(img, points_book[i]);

                    }
                }


                if (n_stage)
                {
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, arrowleft);
                }
                img = test.Properties.Resources.矢印3;
                gr.DrawImage(img, arrowright);



            }
            else if (/*!all && !nyu && */d_cl)
            {
                ui.D_draw(gr);
            }
            else if (loc_big2)
            {
                switch (loc_select)
                {
                    case 0:
                        img = test.Properties.Resources.rm3bigloc_open2;
                        gr.DrawImage(img, point);
                        if (ito)
                        {
                            img = test.Properties.Resources.rm3ito;
                            gr.DrawImage(img, point_bi);

                        }
                        break;
                    case 1:
                        img = test.Properties.Resources.rm3bigloc_open2;
                        gr.DrawImage(img, point);
                        if (paper)
                        {
                            img = test.Properties.Resources.rm3paper;
                            gr.DrawImage(img, point_bi);

                        }

                        break;
                    case 2:
                        img = test.Properties.Resources.rm3bigloc_open2;
                        gr.DrawImage(img, point);
                        if (mato)
                        {
                            img = test.Properties.Resources.rm3mato;
                            gr.DrawImage(img, point_bi);

                        }

                        break;
                    case 3:
                        img = test.Properties.Resources.rm3bigloc_open2;
                        gr.DrawImage(img, point);
                        if (kabe)
                        {
                            img = test.Properties.Resources.rm3kabe;
                            gr.DrawImage(img, point_kabe);
                        }
                        else
                        {
                            img = test.Properties.Resources.rm3botton;
                            gr.DrawImage(img, point_bi);
                        }
                        break;
                    case 4:
                        img = test.Properties.Resources.rm3bigloc_open2;
                        gr.DrawImage(img, point);
                        if (oke)
                        {
                            img = test.Properties.Resources.rm3oke;
                            gr.DrawImage(img, point_bi);

                        }

                        break;
                    case 5:


                        break;
                    default:
                        break;

                }
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);

            }
            else if (loc_big1)
            {

                img = test.Properties.Resources.rm3bigloc;
                gr.DrawImage(img, point);
                key_nyu.Draw(gr, 0);
                for (int i = 0; i < 5; i++)
                {
                    if (loc[i])
                    {
                        img = test.Properties.Resources.rm3bigloc_open;
                        gr.DrawImage(img, points_locbig[i]);

                    }

                }
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);

            }
            else if (kin_big)
            {
                if (kin_open)
                {
                    img = test.Properties.Resources.rm3hidebigopen;
                    gr.DrawImage(img, point);
                }
                else
                {
                    img = test.Properties.Resources.rm3hidebig;
                    gr.DrawImage(img, point);
                    key_nyu.Draw(gr, 1);
                }
                if (bal && kin_open)
                {
                    img = test.Properties.Resources.rm3bal;
                    gr.DrawImage(img, point_bal);
                }

                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);
            }
            else if (nyu2)
            {
                img = test.Properties.Resources.rm3door;
                gr.DrawImage(img, point);
                key_nyu.Draw(gr, 0);

                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);
            }

            ui.Draw(gr);
        }
        public int Loc(int x, int y)
        {
            if (all)
            {
                if (x > 450 && x < 520 && y > 425 && y < 525 && nazo3)
                {
                    mis.n_mis = true;
                    nazo3 = false;
                    mis.qes[(int)Mis.QE.Qes3] = true;
                    Audio.Play_misdis();
                }
                else if (x > 415 && x < 525 && y > 450 && y < 525 && !d_c)
                {
                    d_c = true;
                    Audio.Play_chair_move();
                }

                if (x > 350 && x < 400 && y > 495 && y < 525 && d_c && book)
                {
                    if (ui.item[4] == (int)Ui.Items.error)
                    {
                        ui.Bl((int)Ui.Items.item11);
                        book = false;
                    }
                }
                else if ((x > 350 && x < 400 && y > 495 && y < 525 && ui.item[ui.item_selet] == (int)Ui.Items.item11))
                {
                    ui.Dl(ui.item_selet);

                    book = true;
                }

                if (x > 650 && x < 885 && y > 320 && y < 515)
                {
                    loc_big1 = true;
                }
                if (x > 454 && x < 600 && y > 200 && y < 300 && kin && !kin_open)
                {
                    kin_big = true;
                    nyu1 = true;
                }
                else if (x > 454 && x < 600 && y > 200 && y < 300 && kin && kin_open)
                {
                    kin_big = true;
                }

                if (x > 0 && x < 75 && y > 300 && y < 500 && !n_stage)
                {
                    nyu2 = true;
                }

                if (x > 900 && x < 1025 && y > 300 && y < 375)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room2;
 
                }
                if (x > 20 && x < 150 && y > 300 && y < 375 && n_stage)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room4;
                }



                if (x > 150 && x < 170 && y > 230 && y < 270 && !kin)
                {
                    if (book_in[0] == 0)
                    {
                        if (ui.item[ui.item_selet] == ((int)Ui.Items.item7))
                        {
                            book_in[0] = 1;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item8))
                        {
                            book_in[0] = 2;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item9))
                        {
                            book_in[0] = 3;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item10))
                        {
                            book_in[0] = 4;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item11))
                        {
                            book_in[0] = 5;
                            ui.Dl(ui.item_selet);
                        }

                    }
                    else
                    {
                        switch (book_in[0])
                        {
                            case 1:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[0] = 0;
                                    ui.Bl((int)Ui.Items.item7);
                                }
                                break;
                            case 2:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[0] = 0;
                                    ui.Bl((int)Ui.Items.item8);
                                }
                                break;
                            case 3:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[0] = 0;
                                    ui.Bl((int)Ui.Items.item9);
                                }
                                break;
                            case 4:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[0] = 0;
                                    ui.Bl((int)Ui.Items.item10);
                                }
                                break;
                            case 5:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[0] = 0;
                                    ui.Bl((int)Ui.Items.item11);
                                }
                                break;
                        }
                    }
                }

                if (x > 275 && x < 295 && y > 290 && y < 340 && !kin)
                {
                    if (book_in[1] == 0)
                    {
                        if (ui.item[ui.item_selet] == ((int)Ui.Items.item7))
                        {
                            book_in[1] = 1;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item8))
                        {
                            book_in[1] = 2;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item9))
                        {
                            book_in[1] = 3;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item10))
                        {
                            book_in[1] = 4;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item11))
                        {
                            book_in[1] = 5;
                            ui.Dl(ui.item_selet);
                        }

                    }
                    else
                    {
                        switch (book_in[1])
                        {
                            case 1:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[1] = 0;
                                    ui.Bl((int)Ui.Items.item7);
                                }
                                break;
                            case 2:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[1] = 0;
                                    ui.Bl((int)Ui.Items.item8);
                                }
                                break;
                            case 3:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[1] = 0;
                                    ui.Bl((int)Ui.Items.item9);
                                }
                                break;
                            case 4:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[1] = 0;
                                    ui.Bl((int)Ui.Items.item10);
                                }
                                break;
                            case 5:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[1] = 0;
                                    ui.Bl((int)Ui.Items.item11);
                                }
                                break;
                        }
                    }
                }
                if (x > 215 && x < 235 && y > 350 && y < 395 && !kin)
                {
                    if (book_in[2] == 0)
                    {
                        if (ui.item[ui.item_selet] == ((int)Ui.Items.item7))
                        {
                            book_in[2] = 1;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item8))
                        {
                            book_in[2] = 2;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item9))
                        {
                            book_in[2] = 3;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item10))
                        {
                            book_in[2] = 4;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item11))
                        {
                            book_in[2] = 5;
                            ui.Dl(ui.item_selet);
                        }
                    }
                    else
                    {
                        switch (book_in[2])
                        {
                            case 1:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[2] = 0;
                                    ui.Bl((int)Ui.Items.item7);
                                }
                                break;
                            case 2:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[2] = 0;
                                    ui.Bl((int)Ui.Items.item8);
                                }
                                break;
                            case 3:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[2] = 0;
                                    ui.Bl((int)Ui.Items.item9);
                                }
                                break;
                            case 4:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[2] = 0;
                                    ui.Bl((int)Ui.Items.item10);
                                }
                                break;
                            case 5:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[2] = 0;
                                    ui.Bl((int)Ui.Items.item11);
                                }
                                break;
                        }
                    }
                }                //Point(185, 150), new Point(275, 225), new Point(225, 300), new Point(250, 385), new Point(210, 470)};
                if (x > 245 && x < 265 && y > 395 && y < 455 && !kin)
                {
                    if (book_in[3] == 0)
                    {
                        if (ui.item[ui.item_selet] == ((int)Ui.Items.item7))
                        {
                            book_in[3] = 1;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item8))
                        {
                            book_in[3] = 2;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item9))
                        {
                            book_in[3] = 3;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item10))
                        {
                            book_in[3] = 4;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item11))
                        {
                            book_in[3] = 5;
                            ui.Dl(ui.item_selet);
                        }
                    }
                    else
                    {
                        switch (book_in[3])
                        {
                            case 1:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[3] = 0;
                                    ui.Bl((int)Ui.Items.item7);
                                }
                                break;
                            case 2:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[3] = 0;
                                    ui.Bl((int)Ui.Items.item8);
                                }
                                break;
                            case 3:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[3] = 0;
                                    ui.Bl((int)Ui.Items.item9);
                                }
                                break;
                            case 4:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[3] = 0;
                                    ui.Bl((int)Ui.Items.item10);
                                }
                                break;
                            case 5:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[3] = 0;
                                    ui.Bl((int)Ui.Items.item11);
                                }
                                break;
                        }
                    }
                }
                if (x > 165 && x < 185 && y > 465 && y < 500 && !kin)
                {
                    if (book_in[4] == 0)
                    {
                        if (ui.item[ui.item_selet] == ((int)Ui.Items.item7))
                        {
                            book_in[4] = 1;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item8))
                        {
                            book_in[4] = 2;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item9))
                        {
                            book_in[4] = 3;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item10))
                        {
                            book_in[4] = 4;
                            ui.Dl(ui.item_selet);
                        }
                        else if (ui.item[ui.item_selet] == ((int)Ui.Items.item11))
                        {
                            book_in[4] = 5;
                            ui.Dl(ui.item_selet);
                        }
                    }
                    else
                    {
                        switch (book_in[4])
                        {
                            case 1:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[4] = 0;
                                    ui.Bl((int)Ui.Items.item7);
                                }
                                break;
                            case 2:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[4] = 0;
                                    ui.Bl((int)Ui.Items.item8);
                                }
                                break;
                            case 3:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[4] = 0;
                                    ui.Bl((int)Ui.Items.item9);
                                }
                                break;
                            case 4:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[4] = 0;
                                    ui.Bl((int)Ui.Items.item10);
                                }
                                break;
                            case 5:
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    book_in[4] = 0;
                                    ui.Bl((int)Ui.Items.item11);
                                }
                                break;
                        }
                    }
                }
                if (book_in[0] == 5 && book_in[1] == 1 && book_in[2] == 4 && book_in[3] == 2 && book_in[4] == 3 && !kin)
                {
                    kin = true;
                        Audio.Play_moneybox_open();

                }




            }
            else if (/*!all&& !nyu &&*/ d_cl)
            {
                d_cl = ui.D_loc(x, y);
            }
            else if (loc_big2)
            {
                if (x > 350 && x < 600 && y > 300 && y < 580)
                {
                    switch (loc_select)
                    {
                        case 0:
                            if (ito)
                            {
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    ito = false;
                                    ui.Bl((int)Ui.Items.item5);
                                }
                            }
                            else if (ui.item[ui.item_selet] == (int)Ui.Items.item5 && !ito)
                            {
                                ui.Dl(ui.item_selet);
                                ito = true;

                            }
                            break;
                        case 1:
                            if (paper)
                            {
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    paper = false;
                                    ui.Bl((int)Ui.Items.item6);
                                }
                            }
                            else if (ui.item[ui.item_selet] == (int)Ui.Items.item6 && !paper)
                            {
                                ui.Dl(ui.item_selet);
                                paper = true;
                            }
                            break;
                        case 2:
                            if (mato)
                            {
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    mato = false;
                                    ui.Bl((int)Ui.Items.item29);
                                }
                            }
                            else if (ui.item[ui.item_selet] == (int)Ui.Items.item29 && !mato)
                            {
                                ui.Dl(ui.item_selet);

                                mato = true;
                            }
                            break;
                        case 3:
                            if (!hasigo && !kabe)
                            {
                                hasigo = true;
                                Menu.n_menu = true;
                                Audio.Play_menudis();
                                Audio.Play_stairs_open();
                            }

                            if (ui.item[ui.item_selet] == (int)Ui.Items.item14 && kabe)
                            {
                                kabe = false;
                            }
                            break;
                        case 4:
                            if (oke)
                            {
                                if (ui.item[4] == (int)Ui.Items.error)
                                {
                                    oke = false;
                                    ui.Bl((int)Ui.Items.item21);
                                }

                            }
                            else if (ui.item[ui.item_selet] == (int)Ui.Items.item21 && !oke)
                            {
                                ui.Dl(ui.item_selet);

                                oke = true;
                            }
                            break;
                        case 5:

                            break;
                    }
                }
                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    loc_big2 = false;
                    loc_big1 = true;
                }
            }
            else if (loc_big1)//new Point(325, 200), new Point(630, 200), new Point(325, 400), new Point(630, 400), new Point(325, 600), new Point(630, 600)
            {

                if (x > 296 && x < 611 && y > 163 && y < 308)
                {
                    if (loc[0])
                    {
                        loc_big1 = false;
                        loc_big2 = true;
                        loc_select = 0;
                        Audio.Play_locker_open();
                    }
                }
                else if (x > 617 && x < 932 && y > 163 && y < 308)
                {
                    if (loc[1])
                    {
                        loc_big1 = false;
                        loc_big2 = true;
                        loc_select = 1;
                        Audio.Play_locker_open();
                    }
                }
                else if (x > 296 && x < 611 && y > 315 && y < 460)
                {
                    if (loc[2])
                    {
                        loc_big1 = false;
                        loc_big2 = true;
                        loc_select = 2;
                        Audio.Play_locker_open();
                    }
                }
                else if (x > 617 && x < 932 && y > 315 && y < 460)
                {
                    if (loc[3])
                    {
                        loc_big1 = false;
                        loc_big2 = true;
                        loc_select = 3;
                        Audio.Play_locker_open();
                    }
                }
                else if (x > 296 && x < 611 && y > 466 && y < 612)
                {
                    if (loc[4])
                    {
                        loc_big1 = false;
                        loc_big2 = true;
                        loc_select = 4;
                        Audio.Play_locker_open();
                    }
                }
                else if (x > 617 && x < 932 && y > 466 && y < 612)
                {
                    /*                    if (loc[5])
                                        {

                                        }
                    */
                }
                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    loc_big1 = false;
                }
                if (x > 250 && x < 270 && y > 311 && y < 334)
                {
                    nyu_click = true;
                }

            }
            else if (kin_big)
            {
                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    kin_big = false;
                    nyu1 = false;
                }
                if (nyu1)
                {
                    if (x > 605 && x < 637 && y > 360 && y < 395)
                    {
                        nyu_click = true;
                    }
                }
                if (kin_open)
                {
                    if (x > 390 && x < 610 && y > 300 && y < 525 && bal)
                    {
                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            bal = false;
                            ui.Bl((int)Ui.Items.item19);
                        }
                    }
                    else if (x > 390 && x < 610 && y > 300 && y < 525 && ui.item[ui.item_selet] == (int)Ui.Items.item19 && !bal)
                    {
                        ui.Dl(ui.item_selet);

                        bal = true;
                    }
                }
            }


            if (nyu2)
            {
                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    nyu2 = false;
                }
                if (x > 725 && x < 850 && y > 375 && y < 425)
                {
                    nyu_click = true;
                }
            }





            if (x > 0 && x < 800 && y > 600 && y < 750)
            {
                ui.Loc(x, y);
            }

            All();

            return (int)Form1.RM.room3;



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

        public void S_good(string str_nyu)
        {
            string str1 = "miss";
            string str2 = "news";
            string str3 = "1314";
            string str4 = "gott";
            string str5 = "not8";

            string str6 = "hit";
            string str7 = "9e6z";

            if (loc_big1)
            {
                if (str_nyu == str1)
                {
                    loc[0] = true;
                    Audio.Play_success();
                }
                else if (str_nyu == str2)
                {
                    loc[1] = true;
                    Audio.Play_success();
                }
                else if (str_nyu == str3)
                {
                    loc[2] = true;
                    Audio.Play_success();
                }
                else if (str_nyu == str4)
                {
                    loc[3] = true;
                    Audio.Play_success();

                }
                else if (str_nyu == str5)
                {
                    loc[4] = true;
                    Audio.Play_success();
                }
                else
                {
                    loc[5] = true;
                    l_dead = true;

                    loc_big1 = false;

                    Audio.Play_failed();

                }
                nyu_click = false;
                key_nyu.Nl();

            }
            else if (nyu1)
            {
                if (str_nyu == str6)
                {
                    kin_open = true;
                    Menu.n_menu = true;
                    Audio.Play_menudis();
                    Audio.Play_success();
                }
                else
                {
                    Audio.Play_failed();
                }
                nyu_click = false;
                key_nyu.Nl();
            }
            else if (nyu2)
            {
                if (str_nyu == str7)
                {
                    n_stage = true;
                    nyu2 = false;
                    Menu.n_menu = true;
                    Audio.Play_menudis();
                    Audio.Play_success();
                }
                else
                {
                    Audio.Play_failed();
                }
                nyu_click = false;
                key_nyu.Nl();
            }
            All();
        }

        public override void Nl()
        {
            all = true;
            book = true;
            kin = false;
            d_c = false;
            kabe = true;
            nazo3 = true;
            loc_select = 0;
            loc_big1 = false;
            loc_big2 = false;
            nyu_big1 = false;
            nyu_big2 = false;
            nyu1 = false;
            nyu2 = false;
            kin_open = false;
            kin_big = false;
            big = false;
            d_cl = false;
            oke = true;
            paper = true;
            ito = true;
            botton = false;
            mato = true;
            bal = true;
            n_stage = false;
            nyu_click = false;
            hasigo = false;
            for (int i = 0; i < 5; i++)
            {
                loc[i] = false;
                book_in[i] = 0;
            }
        }

        public void All()
        {
            if (d_cl || loc_big1 || loc_big2 || kin_big || nyu_big1 || nyu_big2 || nyu1 || nyu2)
            {
                all = false;
            }
            else
            {
                all = true;
            }
        }

        public Ui N_ui()
        {
            return ui;
        }

    }
}