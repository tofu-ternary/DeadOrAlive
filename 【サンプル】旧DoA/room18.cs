using System.Drawing;

namespace test
{
    class Room18 : Room
    {

        Image img;
        Point point = new Point(0, 0);
        Point point_maki = new Point(100, 100);

        Point arrowright = new Point(900, 300);
        Point arrowleft = new Point(25, 300);
        Point arrowdown = new Point(160, 480);


        //Point pos_point = new Point(0, 0);


        public bool all = true;

        public bool boxbig = false;
        public bool maki = true;

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
                img = test.Properties.Resources.RM18;
                gr.DrawImage(img, point);



                img = test.Properties.Resources.矢印;
                gr.DrawImage(img, arrowleft);
                img = test.Properties.Resources.矢印3;
                gr.DrawImage(img, arrowright);
                img = test.Properties.Resources.矢印4;
                gr.DrawImage(img, arrowdown);
            }
            else if (/*!all && !nyu && */d_cl)
            {
                ui.D_draw(gr);
            }
            else if (boxbig)
            {
                img = test.Properties.Resources.rm18box;
                gr.DrawImage(img, point);

                if (maki)
                {
                    img = test.Properties.Resources.rm18maki;
                    gr.DrawImage(img, point_maki);
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

                if (x > 410 && x < 725 && y > 460 && y < 540)
                {
                    Audio.Play_slide_door();
                    boxbig = true;
                }

                if (x > 20 && x < 150 && y > 300 && y < 375)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room19;
                }
                if (x > 900 && x < 1025 && y > 300 && y < 375)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room17;
                }
                if (x > 170 && x < 250 && y > 480 && y < 580)
                {
                    Audio.Play_move();
                    return (int)Form1.RM.room13;
                }
            }
            else if (/*!all && !nyu && */d_cl)
            {
                d_cl = ui.D_loc(x, y);
            }
            else if (boxbig)
            {
                if (x > 130 && x < 850 && y > 120 && y < 515)
                {
                    if (maki)
                    {
                        if (ui.item[4] == (int)Ui.Items.error)
                        {
                            maki = false;
                            ui.Bl((int)Ui.Items.item15);
                        }
                    }
                    else if (!maki && ui.item[ui.item_selet] == (int)Ui.Items.item15)
                    {
                        ui.Dl(ui.item_selet);
                        maki = true;
                    }
                }
                if (x > 0 && x < 200 && y > 0 && y < 200)
                {
                    boxbig = false;
                }
            }




            if (x > 0 && x < 800 && y > 600 && y < 750)
            {
                ui.Loc(x, y);
            }

            All();
            return (int)Form1.RM.room18;
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
            boxbig = false;
            maki = true;
            d_cl = false;
        }

        public void All()
        {
            if (d_cl || boxbig)
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
