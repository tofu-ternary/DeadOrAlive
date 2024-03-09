using System.Drawing;

namespace test
{
    class Room11 : Room
    {

        Image img;
        Point point = new Point(0, 0);

        Point point_key = new Point(500, 550);
        Point point_bed = new Point(90, 420);
        Point[] light_maru = { new Point(191, 80), new Point(191, 100), new Point(191, 120) };
        Point[] light_sann = { new Point(242, 80), new Point(242, 100), new Point(242, 120) };
        Point[] light_sika = { new Point(578, 80), new Point(578, 100), new Point(578, 120) };
        Point[] light_batu = { new Point(630, 80), new Point(630, 100), new Point(630, 120) };
        Point point_nazo11 = new Point(425, 520);
        Point arrowright = new Point(900, 300);
        Point arrowleft = new Point(25, 300);



        //Point pos_point = new Point(0, 0);


        public bool all = true;

        public int[] light_m = { 1, 1, 1, 1 };
        public bool l_suc = false;
        public bool seet = true;
        public bool key = false;
        public bool l_move = false;

        public bool clo_big = false;
        public bool nazo11 = true;
        public bool c_open = false;

        public bool d_cl = false;



        Ui ui = new Ui();
        Mis mis = new Mis();
        public void In(Ui ui2)
        {
            ui = ui2;
        }
        public void In3(Mis mis2)
        {
            mis = mis2;
        }

        //        bool a = true;
        public void Draw(Graphics gr)
        {
            /*           if (a)
                       {
                           ui.Bl((int)Ui.Items.item28);
                           ui.Bl((int)Ui.Items.item33);
                           a = false;
                       }*/
            if (all)
            {
                img = test.Properties.Resources.RM11;
                gr.DrawImage(img, point);

                if (key)
                {
                    img = test.Properties.Resources.rm11redkey;
                    gr.DrawImage(img, point_key);
                }

                if (seet)
                {
                    img = test.Properties.Resources.rm11bed_1;
                    gr.DrawImage(img, point_bed);
                }
                else
                {
                    img = test.Properties.Resources.rm11bed_2;
                    gr.DrawImage(img, point_bed);
                }

                switch (light_m[0])
                {

                    case 0:
                        img = test.Properties.Resources.rm11light_maru;
                        gr.DrawImage(img, light_maru[0]);
                        break;
                    case 1:
                        img = test.Properties.Resources.rm11light_maru;
                        gr.DrawImage(img, light_maru[1]);
                        break;
                    case 2:
                        img = test.Properties.Resources.rm11light_maru;
                        gr.DrawImage(img, light_maru[2]);
                        break;
                }
                switch (light_m[1])
                {

                    case 0:
                        img = test.Properties.Resources.rm11light_sann;
                        gr.DrawImage(img, light_sann[0]);
                        break;
                    case 1:
                        img = test.Properties.Resources.rm11light_sann;
                        gr.DrawImage(img, light_sann[1]);
                        break;
                    case 2:
                        img = test.Properties.Resources.rm11light_sann;
                        gr.DrawImage(img, light_sann[2]);
                        break;
                }
                switch (light_m[2])
                {

                    case 0:
                        img = test.Properties.Resources.rm11light_sika;
                        gr.DrawImage(img, light_sika[0]);
                        break;
                    case 1:
                        img = test.Properties.Resources.rm11light_sika;
                        gr.DrawImage(img, light_sika[1]);
                        break;
                    case 2:
                        img = test.Properties.Resources.rm11light_sika;
                        gr.DrawImage(img, light_sika[2]);
                        break;

                }
                switch (light_m[3])
                {
                    case 0:
                        img = test.Properties.Resources.rm11light_batu;
                        gr.DrawImage(img, light_batu[0]);
                        break;
                    case 1:
                        img = test.Properties.Resources.rm11light_batu;
                        gr.DrawImage(img, light_batu[1]);
                        break;
                    case 2:
                        img = test.Properties.Resources.rm11light_batu;
                        gr.DrawImage(img, light_batu[2]);
                        break;
                }



                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, arrowleft);
                img = test.Properties.Resources.矢印3;
                gr.DrawImage(img, arrowright);
            }
            else if (/*!all && !nyu && */d_cl)
            {
                ui.D_draw(gr);
            }
            else if (l_move)
            {
                img = test.Properties.Resources.rm11l_move;
                gr.DrawImage(img, point);
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);
            }
            else if (clo_big)
            {
                if (c_open)
                {
                    img = test.Properties.Resources.rm11clos_open;
                    gr.DrawImage(img, point);
                    if (nazo11)
                    {
                        img = test.Properties.Resources.rm11nazo11;
                        gr.DrawImage(img, point_nazo11);
                    }
                }
                else
                {
                    img = test.Properties.Resources.rm11clos;
                    gr.DrawImage(img, point);
                }
                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, point);
            }

            ui.Draw(gr);
        }
        public int Loc(int x, int y)
        {
            if (all)
            {

                if (x > 90 && x < 195 && y > 500 && y < 555 && seet)
                {
                    seet = false;
                    Audio.Play_bed_move();
                }
                if (x > 340 && x < 525 && y > 205 && y < 311 && !l_suc)
                {
                    l_move = true;
                }
                if (x > 500 && x < 575 && y > 550 && y < 600 && l_suc && key)
                {
                    key = false;
                    ui.key[0] = true;
                    Menu.n_menu = true;
                    Audio.Play_menudis();
                }
                if (x > 710 && x < 896 && y > 290 && y < 475)
                {
                    clo_big = true;
                }

                if (x > 20 && x < 150 && y > 300 && y < 375)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room12;
                }
                if (x > 900 && x < 1025 && y > 300 && y < 375)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room10;
                }
            }
            else if (/*!all && !nyu && */d_cl)
            {
                d_cl = ui.D_loc(x, y);
            }
            else if (l_move)
            {
                if (x > 128 && x < 170 && y > 160 && y < 278 && light_m[0] != 0)
                {
                    Audio.Play_light_move();
                    light_m[0]--;
                }
                else if (x > 330 && x < 375 && y > 160 && y < 278 && light_m[1] != 0)
                {
                    Audio.Play_light_move();
                    light_m[1]--;
                }
                else if (x > 525 && x < 572 && y > 160 && y < 278 && light_m[2] != 0)
                {
                    Audio.Play_light_move();
                    light_m[2]--;
                }
                else if (x > 700 && x < 745 && y > 160 && y < 278 && light_m[3] != 0)
                {
                    Audio.Play_light_move();
                    light_m[3]--;
                }

                if (x > 128 && x < 170 && y > 425 && y < 558 && light_m[0] != 2)
                {
                    Audio.Play_light_move();
                    light_m[0]++;
                }
                else if (x > 330 && x < 375 && y > 425 && y < 558 && light_m[1] != 2)
                {
                    Audio.Play_light_move();
                    light_m[1]++;
                }
                else if (x > 525 && x < 572 && y > 425 && y < 558 && light_m[2] != 2)
                {
                    Audio.Play_light_move();
                    light_m[2]++;
                }
                else if (x > 700 && x < 745 && y > 425 && y < 558 && light_m[3] != 2)
                {
                    Audio.Play_light_move();
                    light_m[3]++;
                }
                if (light_m[0] == 1 && light_m[1] == 1 && light_m[2] == 0 && light_m[3] == 2 && !l_suc)
                {
                    Audio.Play_fall_key();
                    l_suc = true;
                    key = true;
                    l_move = false;
                }

                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    l_move = false;
                }
            }
            else if (clo_big)
            {
                if (c_open)
                {
                    if (nazo11)
                    {
                        if (x > 425 && x < 600 && y > 540 && y < 605)
                        {
                            mis.n_mis = true;
                            mis.qes[(int)Mis.QE.Qes11] = true;
                            Audio.Play_misdis();
                            nazo11 = false;
                        }

                    }
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        c_open = false;
                        clo_big = false;
                    }
                }
                else
                {
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        clo_big = false;
                    }
                    else if (x > 5 && x < 1010 && y > 0 && y < 615)
                    {
                        Audio.Play_slide_door();
                        c_open = true;
                    }
                }
            }


            if (x > 0 && x < 800 && y > 600 && y < 750)
            {
                ui.Loc(x, y);
            }

            All();
            return (int)Form1.RM.room11;
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
        /*
        public void S_good(string str)
        {
            string str2 = "abcd";
            if (str == str2)
            {

            }
            else
            {

            }
            All();
        }
        */
        public override void Nl()
        {
            all = true;

            for (int i = 0; i < 4; i++)
            {
                light_m[i] = 1;
            }
            l_suc = false;
            seet = true;
            key = false;
            l_move = false;

            clo_big = false;
            nazo11 = true;
            c_open = false;

            d_cl = false;
        }

        public void All()
        {
            if (d_cl || l_move || clo_big)
            {
                all = false;
            }
            else
            {
                all = true;
            }
        }
        /*
        public Ui N_ui()
        {
            return ui;
        }
        */
    }
}
