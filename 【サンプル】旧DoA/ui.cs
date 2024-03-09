using System.Drawing;

namespace test
{
    class Ui
    {
        public enum Items
        {
            error,
            item1,
            item2,
            item3,
            item4,
            item5,
            item6,
            item7,
            item8,
            item9,
            item10,
            item11,
            item12,
            item13,
            item14,
            item15,
            item16,
            item17,
            item18,
            item19,
            item20,
            item20_1,
            item21,
            item21_1,
            item21_2,
            item21_3,
            item22,
            item22_2,
            item23,
            item24,
            item25,
            item26,
            item27,
            item28,
            item29,
            item30,
            item31,
            item32,
            item33,
            item34,
            item35,
            item36,
            item37,
            item38,
            item39,
            icepaper_1,
            book_1
        }

        public enum Keys
        {
            red,
            bule,
            yellow,
            orange
        }
        public bool ckey = false;
        public bool[] clkey = { false, false, false, false };

        public bool[] its = new bool[40];

        public bool[] its2 = new bool[40];

        public int[] item = { 0, 0, 0, 0, 0 };

        public int item_selet = 0;

        public int d_select = 0;

        Image img = test.Properties.Resources.UI;
        Point point = new Point(0, 0);

        Point point1 = new Point(28, 647);
        Point point2 = new Point(178, 647);
        Point point3 = new Point(327, 647);
        Point point4 = new Point(477, 647);
        Point point5 = new Point(626, 647);

        Point point1_s = new Point(5, 624);
        Point point2_s = new Point(155, 624);
        Point point3_s = new Point(305, 623);
        Point point4_s = new Point(454, 623);
        Point point5_s = new Point(603, 623);

        Point[] point_key = { new Point(745, 659), new Point(765, 659), new Point(785, 659), new Point(805, 659) };
        Point point_dead = new Point(940, 680);
        Point point_hint = new Point(0, 0);


        public bool[] key = { false, false, false, false, false };
        public int dead;
        //        public int hint;

        public int wh_i;

        public bool open_3 = false;

        public bool re = false;

        public bool opbook = false;

        Mis mis = new Mis();

        public void C_mis(Mis mis2)
        {
            mis = mis2;
        }

        public void Draw(Graphics gr)
        {
            img = test.Properties.Resources.UI;
            gr.DrawImage(img, point);
            img = Item_Image(item[0]);
            gr.DrawImage(img, point1);
            img = Item_Image(item[1]);
            gr.DrawImage(img, point2);
            img = Item_Image(item[2]);
            gr.DrawImage(img, point3);
            img = Item_Image(item[3]);
            gr.DrawImage(img, point4);
            img = Item_Image(item[4]);
            gr.DrawImage(img, point5);

            img = I_num(dead);
            gr.DrawImage(img, point_dead);
            if (key[0])
            {
                clkey[0] = true;
                img = test.Properties.Resources.redkey;
                gr.DrawImage(img, point_key[0]);
            }
            if (key[1])
            {
                clkey[1] = true;
                img = test.Properties.Resources.bulekey;
                gr.DrawImage(img, point_key[1]);
            }
            if (key[2])
            {
                clkey[2] = true;
                img = test.Properties.Resources.yellowkey;
                gr.DrawImage(img, point_key[2]);

            }
            if (key[3])
            {
                clkey[3] = true;
                img = test.Properties.Resources.orangekey;
                gr.DrawImage(img, point_key[3]);

            }


            img = test.Properties.Resources.i_select;
            if (item_selet == 0)
            {
                gr.DrawImage(img, point1_s);
            }
            else if (item_selet == 1)
            {
                gr.DrawImage(img, point2_s);
            }
            else if (item_selet == 2)
            {
                gr.DrawImage(img, point3_s);
            }
            else if (item_selet == 3)
            {
                gr.DrawImage(img, point4_s);
            }
            else if (item_selet == 4)
            {
                gr.DrawImage(img, point5_s);
            }





        }

        public void Loc(int x, int y)
        {
            if (x > 25 && x < 125 && y > 650 && y < 750)
            {
                item_selet = 0;
            }
            else if (x > 175 && x < 275 && y > 650 && y < 750)
            {
                item_selet = 1;
            }
            else if (x > 325 && x < 425 && y > 650 && y < 750)
            {
                item_selet = 2;
            }
            else if (x > 480 && x < 580 && y > 650 && y < 750)
            {
                item_selet = 3;
            }
            else if (x > 620 && x < 720 && y > 650 && y < 750)
            {
                item_selet = 4;
            }


        }

        /*        public void Sec(int it1,int it2,int it3,int it4,int it5)
                {
                    its[it1] = true;
                    its[it2] = true;
                    its[it3] = true;
                    its[it4] = true;
                    its[it5] = true;
                }
        */

        public void Bl(int i)
        {
            //            its2[i] = true;
            Audio.Play_itemdis();
            if (item[0] == 0)
            {
                item[0] = i;
            }
            else if (item[1] == 0)
            {
                item[1] = i;
            }
            else if (item[2] == 0)
            {
                item[2] = i;
            }
            else if (item[3] == 0)
            {
                item[3] = i;
            }
            else if (item[4] == 0)
            {
                item[4] = i;
            }
        }
        public void Dl(int i_select)
        {
            //            int c_i = item[i_select];
            item[i_select] = (int)Items.error;
            //            its2[c_i] = false;
            So();
        }

        public void So()
        {
            int[] c_item = { 0, 0, 0, 0, 0 };
            int i = 0, i2 = 0;
            while (i2 < 5)
            {
                if (item[i2] == (int)Ui.Items.error)
                {
                    i2++;
                }
                else
                {
                    c_item[i] = item[i2];
                    i++;
                    i2++;
                }
            }
            for (i = 0; i < 5; i++)
            {
                item[i] = c_item[i];
            }
            i = 0;
            i2 = 0;
        }

        public void Nl()
        {
            for (int i = 0; i < 5; i++)
            {
                item[i] = 0;
            }
            for (int i = 0; i < 4; i++)
            {
                key[i] = false;
            }
            item_selet = 0;
        }

        public int WH_i(int wh)
        {
            int i;
            for (i = 0; i < 5; i++)
            {
                if (item[i] == wh)
                {
                    return i;
                }

            }
            return i;
        }


        public void D_Cl(int it)
        {
            if (it != (int)Items.error)
            {
                switch (it)
                {
                    case (int)Items.item1:
                        d_select = (int)Items.item1;
                        break;
                    case (int)Items.item2:
                        d_select = (int)Items.item2;
                        break;
                    case (int)Items.item3:
                        d_select = (int)Items.item3;
                        break;
                    case (int)Items.item4:
                        d_select = (int)Items.item4;
                        break;
                    case (int)Items.item5:
                        d_select = (int)Items.item5;
                        break;
                    case (int)Items.item6:
                        d_select = (int)Items.item6;
                        break;
                    case (int)Items.item7:
                        d_select = (int)Items.item7;
                        break;
                    case (int)Items.item8:
                        d_select = (int)Items.item8;
                        break;
                    case (int)Items.item9:
                        d_select = (int)Items.item9;
                        break;
                    case (int)Items.item10:
                        d_select = (int)Items.item10;
                        break;
                    case (int)Items.item11:
                        d_select = (int)Items.item11;
                        break;
                    case (int)Items.item12:
                        d_select = (int)Items.item12;
                        break;
                    case (int)Items.item13:
                        d_select = (int)Items.item13;
                        break;
                    case (int)Items.item14:
                        d_select = (int)Items.item14;
                        break;
                    case (int)Items.item15:
                        d_select = (int)Items.item15;
                        break;
                    case (int)Items.item16:
                        d_select = (int)Items.item16;
                        break;
                    case (int)Items.item17:
                        d_select = (int)Items.item17;
                        break;
                    case (int)Items.item18:
                        d_select = (int)Items.item18;
                        break;
                    case (int)Items.item19:
                        d_select = (int)Items.item19;
                        break;
                    case (int)Items.item20:
                        d_select = (int)Items.item20;
                        break;
                    case (int)Items.item20_1:
                        d_select = (int)Items.item20_1;
                        break;
                    case (int)Items.item21:
                        d_select = (int)Items.item21;
                        break;
                    case (int)Items.item21_1:
                        d_select = (int)Items.item21_1;
                        break;
                    case (int)Items.item21_2:
                        d_select = (int)Items.item21_2;
                        break;
                    case (int)Items.item21_3:
                        d_select = (int)Items.item21_3;
                        break;
                    case (int)Items.item22:
                        d_select = (int)Items.item22;
                        break;
                    case (int)Items.item22_2:
                        d_select = (int)Items.item22_2;
                        break;
                    case (int)Items.item23:
                        d_select = (int)Items.item23;
                        break;
                    case (int)Items.item24:
                        d_select = (int)Items.item24;
                        break;
                    case (int)Items.item25:
                        d_select = (int)Items.item25;
                        break;
                    case (int)Items.item26:
                        d_select = (int)Items.item26;
                        break;
                    case (int)Items.item27:
                        d_select = (int)Items.item27;
                        break;
                    case (int)Items.item28:
                        d_select = (int)Items.item28;
                        break;
                    case (int)Items.item29:
                        d_select = (int)Items.item29;
                        break;
                    case (int)Items.item30:
                        d_select = (int)Items.item30;
                        break;
                    case (int)Items.item31:
                        d_select = (int)Items.item31;
                        break;
                    case (int)Items.item32:
                        d_select = (int)Items.item32;
                        break;
                    case (int)Items.item33:
                        d_select = (int)Items.item33;
                        break;
                    case (int)Items.item34:
                        d_select = (int)Items.item34;
                        break;
                    case (int)Items.item35:
                        d_select = (int)Items.item35;
                        break;
                    case (int)Items.item36:
                        d_select = (int)Items.item36;
                        break;
                    case (int)Items.item37:
                        d_select = (int)Items.item37;
                        break;
                    case (int)Items.item38:
                        d_select = (int)Items.item38;
                        break;
                    case (int)Items.item39:
                        d_select = (int)Items.item39;
                        break;
                    case (int)Items.icepaper_1:
                        d_select = (int)Items.icepaper_1;
                        break;
                    case (int)Items.book_1:
                        d_select = (int)Items.book_1;
                        break;
                    case (int)Items.error:
                        break;

                }
            }
        }

        public void D_draw(Graphics gr)
        {
            switch (d_select)
            {
                case (int)Items.item1:
                    img = test.Properties.Resources.D1;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item2:
                    img = test.Properties.Resources.D2;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item3:
                    if (!open_3)
                    {
                        img = test.Properties.Resources.D3;

                    }
                    else
                    {
                        img = test.Properties.Resources.D3_2;
                    }
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item4:
                    img = test.Properties.Resources.D4;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item5:
                    img = test.Properties.Resources.D5;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item6:
                    if (!re)
                    {
                        img = test.Properties.Resources.D6;
                    }
                    else
                    {
                        img = test.Properties.Resources.D6_2;
                    }
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item7:
                    img = test.Properties.Resources.D7;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item8:
                    img = test.Properties.Resources.D8;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item9:
                    img = test.Properties.Resources.D9;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item10:
                    img = test.Properties.Resources.D10;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item11:
                    img = test.Properties.Resources.D11;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item12:
                    img = test.Properties.Resources.D12;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item13:
                    img = test.Properties.Resources.D13;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item14:
                    img = test.Properties.Resources.D14;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item15:
                    img = test.Properties.Resources.D15;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item16:
                    img = test.Properties.Resources.D16;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item17:
                    img = test.Properties.Resources.D17;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item18:
                    img = test.Properties.Resources.D18;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item19:
                    img = test.Properties.Resources.D19;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item20:
                    img = test.Properties.Resources.D20;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item20_1:
                    img = test.Properties.Resources.D20_1;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item21:
                    img = test.Properties.Resources.D21;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item21_1:
                    img = test.Properties.Resources.D21_1;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item21_2:
                    img = test.Properties.Resources.D21_2;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item21_3:
                    img = test.Properties.Resources.D21_3;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item22:
                    img = test.Properties.Resources.D22;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item22_2:
                    img = test.Properties.Resources.D22_2;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item23:
                    img = test.Properties.Resources.D23;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item24:
                    img = test.Properties.Resources.D24;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item25:
                    img = test.Properties.Resources.D25;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item26:
                    img = test.Properties.Resources.D26;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item27:
                    img = test.Properties.Resources.D27;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item28:
                    img = test.Properties.Resources.D28;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item29:
                    img = test.Properties.Resources.D29;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item30:
                    img = test.Properties.Resources.D30;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item31:
                    img = test.Properties.Resources.D31;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item32:
                    img = test.Properties.Resources.D32;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item33:
                    img = test.Properties.Resources.D33;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item34:
                    img = test.Properties.Resources.D34;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item35:
                    img = test.Properties.Resources.D35;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item36:
                    img = test.Properties.Resources.D36;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.item37:
                    img = test.Properties.Resources.D37;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                /*                case (int)Items.item38:
                                    img = test.Properties.Resources.D38;
                                    gr.DrawImage(img, point);
                                    img = test.Properties.Resources.矢印;
                                    gr.DrawImage(img, point);
                                    break;
                                case (int)Items.item39:
                                    img = test.Properties.Resources.D39;
                                    gr.DrawImage(img, point);
                                    img = test.Properties.Resources.矢印;
                                    gr.DrawImage(img, point);
                                    break;*/
                case (int)Items.icepaper_1:
                    img = test.Properties.Resources.ice1;
                    gr.DrawImage(img, point);
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.book_1:
                    if (!opbook)
                    {
                        img = test.Properties.Resources.book1;
                        gr.DrawImage(img, point);
                    }
                    else
                    {
                        img = test.Properties.Resources.book2;
                        gr.DrawImage(img, point);
                    }
                    img = test.Properties.Resources.矢印;
                    gr.DrawImage(img, point);
                    break;
                case (int)Items.error:
                    break;

            }
        }



        public bool D_loc(int x, int y)
        {

            switch (d_select)
            {
                case (int)Items.item1:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item2:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item3:
                    if (x > 330 && x < 670 && y > 200 && y < 490)
                    {
                        if (!open_3)
                        {
                            Audio.Play_valve_set();
                            open_3 = true;
                        }
                        else
                        {
                            mis.n_mis = true;
                            mis.qes[(int)Mis.QE.Qes2] = true;
                            Audio.Play_misdis();
                            wh_i = WH_i((int)Items.item3);
                            Dl(wh_i);


                            return false;
                        }

                    }
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item4:
                    if (x > 550 && x < 605 && y > 20 && y < 63)
                    {
                        mis.n_mis = true;
                        mis.qes[(int)Mis.QE.Qes1] = true;
                        Audio.Play_misdis();
                        wh_i = WH_i((int)Items.item4);
                        Dl(wh_i);

                        return false;
                    }

                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item5:

                    if (x > 300 && x < 500 && y > 200 && y < 400)
                    {
                        mis.n_mis = true;
                        mis.qes[(int)Mis.QE.Qes4] = true;
                        Audio.Play_misdis();
                        wh_i = WH_i((int)Items.item5);
                        Dl(wh_i);

                        return false;
                    }

                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item6:
                    if (x > 205 && x < 240 && y > 345 && y < 390 && !re)
                    {
                        Audio.Play_book_open();
                        re = true;
                    }
                    else if (x > 645 && x < 685 && y > 90 && y < 130 && re)
                    {
                        Audio.Play_book_open();
                        re = false;
                    }

                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item7:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item8:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item9:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item10:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item11:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item12:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item13:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item14:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item15:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item16:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item17:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item18:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item19:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item20:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item20_1:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item21:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item21_1:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item21_2:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item21_3:
                    if (x > 155 && x < 650 && y > 80 && y < 495 && item[item_selet] == (int)Ui.Items.item20)
                    {
                        Dl(item_selet);

                        Bl((int)Ui.Items.item20_1);
                        ckey = true;
                        Menu.n_menu = true;
                        Audio.Play_menudis();
                        return true;

                    }
                    else if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item22:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item22_2:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item23:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item24:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item25:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item26:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item27:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item28:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item29:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item30:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item31:
                    if (x > 200 && x < 640 && y > 50 && y < 580 && item[item_selet] == (int)Ui.Items.item32)
                    {
                        Audio.Play_mato_put();
                        Dl(item_selet);
                        wh_i = WH_i((int)Items.item31);
                        Dl(wh_i);
                        Bl((int)Ui.Items.item33);
                        return false;
                    }
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item32:
                    if (x > 200 && x < 640 && y > 50 && y < 580 && item[item_selet] == (int)Ui.Items.item31)
                    {
                        Audio.Play_mato_put();
                        Dl(item_selet);
                        wh_i = WH_i((int)Items.item32);
                        Dl(wh_i);
                        Bl((int)Ui.Items.item33);
                        return false;
                    }
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item33:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item34:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item35:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item36:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item37:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item38:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.item39:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.icepaper_1:
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.book_1:
                    if (x > 225 && x < 520 && y > 50 && y < 570)
                    {
                        if (!opbook)
                        {
                            Audio.Play_book_open();
                            opbook = true;
                        }
                        else
                        {

                            mis.n_mis = true;
                            mis.qes[(int)Mis.QE.Qes9] = true;
                            Audio.Play_misdis();
                            wh_i = WH_i((int)Items.book_1);
                            Dl(wh_i);


                            return false;
                        }

                    }
                    if (x > 0 && x < 200 && y > 0 && y < 200)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                case (int)Items.error:
                    break;


                    //                    return true;
            }

            return true;
        }

        public void D_Nl()
        {
            open_3 = false;
            ckey = false;
            for(int i = 0;i < 4;i++)
            {
                clkey[i] = false;
            }
        }

        private Image Item_Image(int it)
        {

            if (it != (int)Items.error)
            {
                switch (it)
                {
                    case (int)Items.item1:
                        return test.Properties.Resources.item1;
                    case (int)Items.item2:
                        return test.Properties.Resources.item2;
                    case (int)Items.item3:
                        return test.Properties.Resources.item3;
                    case (int)Items.item4:
                        return test.Properties.Resources.item4;
                    case (int)Items.item5:
                        return test.Properties.Resources.item5;
                    case (int)Items.item6:
                        return test.Properties.Resources.item6;
                    case (int)Items.item7:
                        return test.Properties.Resources.item7;
                    case (int)Items.item8:
                        return test.Properties.Resources.item8;
                    case (int)Items.item9:
                        return test.Properties.Resources.item9;
                    case (int)Items.item10:
                        return test.Properties.Resources.item10;
                    case (int)Items.item11:
                        return test.Properties.Resources.item11;
                    case (int)Items.item12:
                        return test.Properties.Resources.item12;
                    case (int)Items.item13:
                        return test.Properties.Resources.item13;
                    case (int)Items.item14:
                        return test.Properties.Resources.item14;
                    case (int)Items.item15:
                        return test.Properties.Resources.item15;
                    case (int)Items.item16:
                        return test.Properties.Resources.item16;
                    case (int)Items.item17:
                        return test.Properties.Resources.item17;
                    case (int)Items.item18:
                        return test.Properties.Resources.item18;
                    case (int)Items.item19:
                        return test.Properties.Resources.item19;
                    case (int)Items.item20:
                        return test.Properties.Resources.item20;
                    case (int)Items.item20_1:
                        return test.Properties.Resources.item20_1;
                    case (int)Items.item21:
                        return test.Properties.Resources.item21;
                    case (int)Items.item21_1:
                        return test.Properties.Resources.item21_1;
                    case (int)Items.item21_2:
                        return test.Properties.Resources.item21_2;
                    case (int)Items.item21_3:
                        return test.Properties.Resources.item21_3;
                    case (int)Items.item22:
                        return test.Properties.Resources.item22;
                    case (int)Items.item22_2:
                        return test.Properties.Resources.item22_2;
                    case (int)Items.item23:
                        return test.Properties.Resources.item23;
                    case (int)Items.item24:
                        return test.Properties.Resources.item24;
                    case (int)Items.item25:
                        return test.Properties.Resources.item25;
                    case (int)Items.item26:
                        return test.Properties.Resources.item26;
                    case (int)Items.item27:
                        return test.Properties.Resources.item27;
                    case (int)Items.item28:
                        return test.Properties.Resources.item28;
                    case (int)Items.item29:
                        return test.Properties.Resources.item29;
                    case (int)Items.item30:
                        return test.Properties.Resources.item30;
                    case (int)Items.item31:
                        return test.Properties.Resources.item31;
                    case (int)Items.item32:
                        return test.Properties.Resources.item32;
                    case (int)Items.item33:
                        return test.Properties.Resources.item33;
                    case (int)Items.item34:
                        return test.Properties.Resources.item34;
                    case (int)Items.item35:
                        return test.Properties.Resources.item35;
                    case (int)Items.item36:
                        return test.Properties.Resources.item36;
                    case (int)Items.item37:
                        return test.Properties.Resources.item37;
                    /*                    case (int)Items.item38:
                                            return test.Properties.Resources.item38;
                                        case (int)Items.item39:
                                            return test.Properties.Resources.item39;*/
                    case (int)Items.icepaper_1:
                        return test.Properties.Resources.i_ice1;
                    case (int)Items.book_1:
                        return test.Properties.Resources.book_1;
                    case (int)Items.error:
                        break;

                }
            }
            return test.Properties.Resources._null;

        }

        public Image I_num(int i)
        {
            switch (i)
            {
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
                case 0:
                    return test.Properties.Resources.t0;

            }
            return test.Properties.Resources._null;
        }


    }
}
