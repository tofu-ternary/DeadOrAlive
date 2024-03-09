using System;
using System.Drawing;
using System.Windows.Forms;



namespace test
{
    public partial class Form1 : Form
    {
        //使う部屋の番号割り当て
        //上から０、１、２と対応していく
        //(int)Form1.RM.何々って感じで使う
        public enum RM : int
        {
            title,
            room1,
            room2,
            room3,
            room4,
            room5,
            room6,
            room7,
            room8,
            room9,
            room10,
            room11,
            room12,
            room13,
            room14,
            room15,
            room16,
            room17,
            room18,
            room19,
            end,
            story
        }
        //現在の部屋の場所（変数）
        public int room = //17;
        (int)RM.title;
        string str1;
        //死んだか
        public bool dead;

        public bool end;

        public bool c_bgm = false;
        //初期
        public bool start = true;

        //インスタンス生成（クラスで宣言してたものを表現）自分で作った部屋なども追加して
        Title c = new Title();
        Room1 r1 = new Room1();
        Room2 r2 = new Room2();
        Room3 r3 = new Room3();
        Room4 r4 = new Room4();
        Room5 r5 = new Room5();
        Room6 r6 = new Room6();
        Room7 r7 = new Room7();
        Room8 r8 = new Room8();
        Room9 r9 = new Room9();
        Room10 r10 = new Room10();
        Room11 r11 = new Room11();
        Room12 r12 = new Room12();
        Room13 r13 = new Room13();
        Room14 r14 = new Room14();
        Room15 r15 = new Room15();
        Room16 r16 = new Room16();
        Room17 r17 = new Room17();
        Room18 r18 = new Room18();
        Room19 r19 = new Room19();
        End ed = new End();
        story st = new story();
        Ui ui = new Ui();
        Ui ui2 = new Ui();
        Menu m = new Menu();
        Mis mis = new Mis();
        Key key = new Key();
        Key c_key = new Key();
        Dead d = new Dead();
        Time t = new Time();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//ゲームが始まったら（追加なし）
        {/*
            ui.key[0] = true;
            ui.key[1] = true;
            ui.key[2] = true;
            ui.key[3] = true;
            ui.clkey[0] = true;
            ui.clkey[1] = true;
            ui.clkey[2] = true;
            ui.clkey[3] = true;
            */
           // ui.Bl((int)Ui.Items.item20_1);
           // room = 6;
            timer1.Interval = 100;
            timer1.Start();
            timer2.Interval = 1000;

            Audio.Load();
            //endb.controls.stop();
            /*
            axWindowsMediaPlayer1.settings.autoStart = true;
            //オーディオファイルを指定する（自動的に再生される）
            axWindowsMediaPlayer1.URL ="test.Properties.Resources.bgm.mp3";
            //player.controls.play();
            /*
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.settings.volume = 10;
            //オーディオファイルを指定する（自動的に再生される）
            axWindowsMediaPlayer1.URL = "test.Properties.Resources.魔王魂__ピアノ23";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            //    axWindowsMediaPlayer1.Ctlcontrols.stop();
            */

            c.start = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)//フォームの描写
        {

            //            Font f = new Font("MSゴシック", 50);
            //              Point p = new Point(0, 0);


            Graphics gr = e.Graphics;



            if (!dead)
            {

                if (!m.s && !mis.mis)
                {
                    switch (room)//自分の作る部屋のケースだけに追加
                    {
                        case (int)RM.title:
                            c.Draw(gr);
                            start = true;
                            if (c.close)
                            {
                                this.Close();
                            }
                            Audio.Stop_bgm();
                            Audio.Play_title();
                            break;
                        case (int)RM.room1:
                            Audio.Stop_title();
                            Audio.Play_bgm();
                            if (start)
                            {
                                timeLeft = 3600;
                                timer2.Start();
                                mint = 6;
                                mino = 0;
                                sect = 0;
                                seco = 0;
                                t.T_nyu(mint, mino, sect, seco);
                                t.Draw(gr);
                                start = false;
                            }
                            r1.In(ui);
                            r1.In2(key);
                            ui.C_mis(mis);
                            /*                        if (!timer)
                                                    {
                                                        sw.Start();
                                                        timer = false;
                                                        t_start = true;
                                                        t_stop = false;


                                                    }
                            */
                            r1.Draw(gr);
                            if (r1.all)
                            {
                                key.Nl();
                            }
                            break;
                        case (int)RM.room2:
                            r2.In(ui);
                            r2.In2(key);
                            r2.In3(mis);
                            ui.C_mis(mis);
                            r2.Draw(gr);
                            if (r2.on)
                            {
                                key.Nl();
                            }
                            break;
                        case (int)RM.room3:
                            r3.In(ui);
                            r3.In2(key);
                            r3.In3(mis);
                            ui.C_mis(mis);
                            r3.Draw(gr);
                            if (r3.all)
                            {
                                key.Nl();
                            }
                            break;
                        case (int)RM.room4:
                            r4.In(ui);
                            r4.In3(mis);
                            r4.Draw(gr);
                            break;
                        case (int)RM.room5:
                            r5.In(ui);
                            r5.In2(key);
                            r5.In3(mis);
                            r5.In4(r19);
                            r5.Draw(gr);
                            if (r5.all)
                            {
                                key.Nl();
                            }
                            break;
                        case (int)RM.room6:
                            r6.In(ui);
                            r6.In3(mis);
                            r6.Num_get(seco);
                            r6.Draw(gr);
                            break;
                        case (int)RM.room7:
                            r7.In(ui);
                            r7.In3(mis);
                            r7.Draw(gr);
                            break;
                        case (int)RM.room8:
                            r8.In(ui);
                            r8.In3(mis);
                            r8.In4(r9);
                            r8.Draw(gr);
                            break;
                        case (int)RM.room9:
                            r9.In(ui);
                            r9.In3(mis);
                            r9.In4(r19);
                            r9.Draw(gr);
                            break;
                        case (int)RM.room10:
                            r10.In(ui);
                            r10.In3(mis);
                            r10.Draw(gr);
                            break;
                        case (int)RM.room11:
                            r11.In(ui);
                            r11.In3(mis);
                            r11.Draw(gr);
                            break;
                        case (int)RM.room12:
                            r12.In(ui);
                            r12.In2(key);
                            r12.In3(mis);
                            r12.In4(r17);
                            r12.Draw(gr);
                            if (r12.all)
                            {
                                key.Nl();
                            }
                            break;
                        case (int)RM.room13:
                            r13.In(ui);
                            r13.In3(mis);
                            r13.In4(r3);

                            r13.Num_get(seco);
                            r13.Draw(gr);
                            break;
                        case (int)RM.room14:
                            r14.In(ui);
                            r14.In3(mis);

                            r14.Draw(gr);
                            break;
                        case (int)RM.room15:
                            r15.In(ui);
                            r15.In3(mis);
                            r15.Draw(gr);
                            break;
                        case (int)RM.room16:
                            r16.In(ui);
                            r16.In3(mis);
                            r16.Draw(gr);
                            break;
                        case (int)RM.room17:
                            r17.In(ui);
                            r17.In2(key);
                            r17.In3(mis);
                            r17.In4(r16);
                            r17.Num_get(seco);
                            r17.Draw(gr);
                            if (r17.all)
                            {
                                key.Nl();
                            }
                            break;
                        case (int)RM.room18:
                            r18.In(ui);
                            r18.In3(mis);
                            r18.Draw(gr);
                            break;
                        case (int)RM.room19:
                            r19.In(ui);
                            r19.In2(key);
                            r19.In3(mis);
                            r19.Draw(gr);
                            if (r19.all)
                            {
                                key.Nl();
                            }
                            break;
                        case (int)RM.end:
                            ed.Draw(gr);
                            break;
                        case (int)RM.story:
                            st.Draw(gr);
                            m.In(ui);
                            st.In(ui);
                            st.In2(ed);
                            st.In3(c);
                            st.In4(r1);
                            st.In5(r3);
                            st.In6(r9);
                            break;
                    }
                }
                if (!ed.end && !dead && !mis.mis && !m.s && room != (int)RM.title && room != (int)RM.story)//タイムやMENU、謎、死（追加なし）
                {
                    t.Draw(gr);
                }
                if (room != (int)RM.title)
                {
                    /*                if (!m.s && !mis.mis)
                                    {
                                        ui.Draw(gr);
                                    }
                    */
                    if (!mis.mis && room != (int)RM.story && room != (int)RM.end && !dead)
                    {
                        m.In(ui);
                        m.In1(r1);
                        m.In2(r3);
                        m.In3(r9);
                        m.Draw(gr);



                    }

                    if (!m.s && room != (int)RM.end && room != (int)RM.story)
                    {
                        mis.Draw(gr);

                    }
                }
            }
            else if (dead)
            {
                timer2.Stop();

                if (ed.dead > 6)
                {
                    end = true;
                    ed.d_dead = true;
                    ed.dead = 0;
                    d.Draw(gr);
                }
                else
                {
                    d.Draw(gr);
                }
            }
            if (end)
            {
                end = false;
                ed.end = true;
                room = (int)RM.end;
            }


        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)//フォームの座標
        {
            int x, y;

            x = e.X;
            y = e.Y;


            if (!dead)
            {
                if (!mis.mis && !m.s)//各自の部屋に+キーボードの結果確認（ここでしなくてもいいかも）
                {
                    switch (room)
                    {

                        case (int)RM.title:
                            room = c.Loc(x, y);
                            break;
                        case (int)RM.room1:

                            room = r1.Loc(x, y);
                            if (str1 == null)
                            {
                            }
                            else if (r1.nyu_click && !r1.k_nyu)
                            {
                                r1.S_good(str1);
                                str1 = null;
                            }
                            else if (r1.all)
                            {
                                str1 = null;
                            }
                            break;
                        case (int)RM.room2:
                            //ui = r1.N_ui();
                            room = r2.Loc(x, y);

                            break;
                        case (int)RM.room3:

                            room = r3.Loc(x, y);
                            if (str1 == null)
                            {
                            }
                            else if (r3.nyu_click)
                            {
                                r3.S_good(str1);
                                str1 = null;
                            }
                            if (r3.l_dead)
                            {
                                room = (int)RM.room1;
                                ui.dead++;
                                ed.dead++;
                                dead = true;
                                r3.l_dead = false;
                                r3.loc[5] = false;
                                str1 = null;
                            }
                            else if (r3.all)
                            {
                                str1 = null;
                            }
                            break;
                        case (int)RM.room4:
                            room = r4.Loc(x, y);
                            break;
                        case (int)RM.room5:
                            room = r5.Loc(x, y);
                            if (str1 == null)
                            {
                            }
                            else if (r5.nyu_click)
                            {
                                r5.S_good(str1);
                                str1 = null;
                            }
                            else if (r5.all)
                            {
                                str1 = null;
                            }
                            break;
                        case (int)RM.room6:
                            room = r6.Loc(x, y);
                            if (r6.d_miss)
                            {
                                room = (int)RM.room1;
                                ui.dead++;
                                ed.dead++;
                                dead = true;
                                r6.d_miss = false;
                                for (int i = 0; i < 4; i++)
                                {
                                    if (i == 1 && r6.pulet)
                                    {

                                    }
                                    else
                                    {
                                        r6.dool[i] = true;
                                    }
                                }
                                r6.kamado_big = false;
                                r6.All();
                            }
                            break;
                        case (int)RM.room7:
                            room = r7.Loc(x, y);
                            if (r7.soto)
                            {
                                end = true;
                                if (!r7.redkey && !r7.bulekey && !r7.yellowkey && !r7.orangekey)
                                {
                                    ed.d_b = true;
                                }
                                else
                                {
                                    if (ui.key[0] && ui.key[1] && ui.key[2] && ui.key[3])
                                    {
                                        ed.d_a = true;
                                    }
                                    else
                                    {
                                        ed.d_c = true;
                                    }
                                }
                                r7.soto = false;
                            }
                            break;
                        case (int)RM.room8:
                            room = r8.Loc(x, y);
                            break;
                        case (int)RM.room9:
                            room = r9.Loc(x, y);
                            if (r9.l_dead)
                            {
                                room = (int)RM.room1;
                                ui.dead++;
                                ed.dead++;
                                dead = true;
                                r9.l_dead = false;
                            }
                            break;
                        case (int)RM.room10:
                            room = r10.Loc(x, y);
                            break;
                        case (int)RM.room11:
                            room = r11.Loc(x, y);
                            break;
                        case (int)RM.room12:
                            room = r12.Loc(x, y);
                            if (str1 == null)
                            {
                            }
                            else if (r12.nyu_click)
                            {
                                r12.S_good(str1);
                                str1 = null;
                            }
                            else if (r12.all)
                            {
                                str1 = null;
                            }
                            break;
                        case (int)RM.room13:
                            room = r13.Loc(x, y);
                            break;
                        case (int)RM.room14:
                            room = r14.Loc(x, y);
                            break;
                        case (int)RM.room15:
                            room = r15.Loc(x, y);
                            if (r15.end)
                            {
                                end = true;
                                if (!r7.redkey && !r7.bulekey && !r7.yellowkey && !r7.orangekey)
                                {
                                    ed.d_s = true;
                                }
                                else
                                {
                                    ed.d_end = true;
                                }
                                Audio.Play_enda();
                                r15.end = false;
                            }
                            break;
                        case (int)RM.room16:
                            room = r16.Loc(x, y);
                            break;
                        case (int)RM.room17:

                            room = r17.Loc(x, y);
                            if (str1 == null)
                            {
                            }
                            else if (r17.nyu_click)
                            {
                                r17.S_good(str1);
                                str1 = null;
                            }
                            else if (r17.all)
                            {
                                str1 = null;
                            }
                            break;
                        case (int)RM.room18:
                            room = r18.Loc(x, y);
                            break;
                        case (int)RM.room19:
                            room = r19.Loc(x, y);
                            if (str1 == null)
                            {
                            }
                            else if (r19.nyu_click)
                            {
                                r19.S_good(str1);
                                str1 = null;
                            }
                            else if (r19.all)
                            {
                                str1 = null;
                            }
                            break;
                        case (int)RM.end:
                            room = ed.Loc(x, y);

                            break;
                        case (int)RM.story:
                            room = st.Loc(x, y);
                            if (room == (int)RM.title)
                            {
                                Nl();
                            }
                            break;

                    }
                }
                if (room != (int)RM.title)
                {
                    if (!mis.mis && room != (int)RM.end && room != (int)RM.story)
                    {
                        room = m.Loc(x, y, room);
                        if (m.s)
                        {
                            timer2.Stop();
                        }
                        else if (!m.s && room != (int)RM.title)
                        {
                            timer2.Start();
                        }
                        if (room == (int)RM.title)//MENUからタイトル画面に戻った時、ここにNlを配置
                        {
                            Nl();
                            //                   sw.Reset();
                        }
                        /*                    if (m.s && !t_stop)
                                            {
                                                sw.Stop();
                                                t_stop = true;
                                                t_start = false;
                                            }
                                            else if(!m.s && !t_start)
                                            {
                                                sw.Start();
                                                t_start = true;
                                                t_stop = false;
                                            }
                        */
                    }
                    if (!m.s&&room != (int)RM.end && room != (int)RM.story)
                    {
                        room = mis.Loc(x, y, room);
                    }
                }
            }
            else if (dead)
            {
                dead = d.Loc(x, y);
                if (!dead)
                {
                    timer2.Start();
                }
            }

        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)//ダブルクリック、r〇.D_Loc(x,y)；のみ記入
        {
            int x, y;

            x = e.X;
            y = e.Y;

            if (!mis.mis && !m.s && !dead)
            {
                switch (room)
                {

                    case (int)RM.title:

                        break;
                    case (int)RM.room1:
                        r1.D_Loc(x, y);
                        break;
                    case (int)RM.room2:
                        r2.D_Loc(x, y);
                        break;
                    case (int)RM.room3:
                        r3.D_Loc(x, y);
                        break;
                    case (int)RM.room4:
                        r4.D_Loc(x, y);
                        break;
                    case (int)RM.room5:
                        r5.D_Loc(x, y);
                        break;
                    case (int)RM.room6:
                        r6.D_Loc(x, y);
                        break;
                    case (int)RM.room7:
                        r7.D_Loc(x, y);
                        break;
                    case (int)RM.room8:
                        r8.D_Loc(x, y);
                        break;
                    case (int)RM.room9:
                        r9.D_Loc(x, y);
                        break;
                    case (int)RM.room10:
                        r10.D_Loc(x, y);
                        break;
                    case (int)RM.room11:
                        r11.D_Loc(x, y);
                        break;
                    case (int)RM.room12:
                        r12.D_Loc(x, y);
                        break;
                    case (int)RM.room13:
                        r13.D_Loc(x, y);
                        break;
                    case (int)RM.room14:
                        r14.D_Loc(x, y);
                        break;
                    case (int)RM.room15:
                        r15.D_Loc(x, y);
                        break;
                    case (int)RM.room16:
                        r16.D_Loc(x, y);
                        break;
                    case (int)RM.room17:
                        r17.D_Loc(x, y);
                        break;
                    case (int)RM.room18:
                        r18.D_Loc(x, y);
                        break;
                    case (int)RM.room19:
                        r19.D_Loc(x, y);
                        break;

                }
            }
        }

        public int timeLeft = 3600;//時計の初期（無視）
        public int mint;
        public int mino;
        public int sect;
        public int seco;
        private void timer1_Tick(object sender, EventArgs e)//画面描写
        {
            Invalidate();

        }
        private void timer2_Tick(object sender, EventArgs e)//一秒ごと
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                mint = timeLeft / 600 % 6;
                mino = timeLeft / 60 % 10;
                sect = timeLeft / 10 % 6;
                seco = timeLeft % 10;

                t.T_nyu(mint, mino, sect, seco);
            }
            else
            {

                timer2.Stop();
                Audio.Play_endb();
                ed.d_bad = true;
                end = true;
            }
        }



        private void Form1_KeyPress(object sender, KeyPressEventArgs e)//キーボードの入力、必要な部屋に、フラグで管理
        {
            switch (room)
            {

                case (int)RM.title:

                    break;
                case (int)RM.room1:
                    if (r1.nyu && !r1.d_cl)
                    {
                        str1 = key.Down(sender, e, 4);
                    }
                    if (key.nyu_enter && r1.nyu && !r1.k_nyu)
                    {
                        r1.S_good(str1);
                        key.nyu_enter = false;
                    }
                    break;
                case (int)RM.room2:

                    break;
                case (int)RM.room3:
                    if (r3.loc_big1 && !r3.d_cl)
                    {
                        str1 = key.Down(sender, e, 4);
                    }
                    else if (r3.kin_big && !r3.kin_open && !r3.d_cl)
                    {
                        str1 = key.Down(sender, e, 3);
                    }
                    else if (r3.nyu2 && !r3.d_cl)
                    {
                        str1 = key.Down(sender, e, 4);
                    }
                    if (key.nyu_enter)
                    {
                        if (str1 != null)
                        {
                            if ((r3.nyu1 && !r3.kin_open) || (r3.nyu2 && !r3.n_stage) || r3.loc_big1)
                            {
                                r3.S_good(str1);
                                key.nyu_enter = false;
                            }
                            if (r3.l_dead)
                            {
                                room = (int)RM.room1;
                                ui.dead++;
                                ed.dead++;
                                dead = true;
                                r3.l_dead = false;
                                r3.loc[5] = false;
                                str1 = null;
                                key.nyu_enter = false;
                            }
                        }
                        key.nyu_enter = false;
                    }
                    break;
                case (int)RM.room4:

                    break;
                case (int)RM.room5:
                    if (r5.rei && !r5.or)
                    {
                        str1 = key.Down(sender, e, 3);
                    }
                    if (key.nyu_enter && r5.rei && !r5.or)
                    {
                        r5.S_good(str1);
                        key.nyu_enter = false;
                    }
                    break;
                case (int)RM.room6:

                    break;
                case (int)RM.room7:

                    break;
                case (int)RM.room8:

                    break;
                case (int)RM.room9:

                    break;
                case (int)RM.room10:

                    break;
                case (int)RM.room11:

                    break;
                case (int)RM.room12:
                    if (r12.kin_big && !r12.kin_open)
                    {
                        str1 = key.Down(sender, e, 5);
                    }
                    else if (r12.moni_big)
                    {
                        str1 = key.Down(sender, e, 2);
                    }
                    if (key.nyu_enter && ((r12.kin_big && !r12.kin_open) || r12.moni_big))
                    {
                        r12.S_good(str1);
                        key.nyu_enter = false;
                    }
                    break;
                case (int)RM.room13:

                    break;
                case (int)RM.room14:

                    break;
                case (int)RM.room15:

                    break;
                case (int)RM.room16:

                    break;
                case (int)RM.room17:
                    if (!r17.box_open && r17.box_big)
                    {
                        str1 = key.Down(sender, e, 2);
                    }
                    if (key.nyu_enter && !r17.box_open && r17.box_big)
                    {
                        r17.S_good(str1);
                        key.nyu_enter = false;
                    }
                    break;
                case (int)RM.room18:

                    break;
                case (int)RM.room19:
                    if (r19.boxbig && !r19.boxopen)
                    {
                        str1 = key.Down(sender, e, 4);
                    }
                    if (key.nyu_enter && r19.boxbig && !r19.boxopen)
                    {
                        r19.S_good(str1);
                        key.nyu_enter = false;
                    }
                    break;

            }
        }
        public void Nl()
        {
            r1.Nl();
            r2.Nl();
            r3.Nl();
            r4.Nl();
            r5.Nl();
            r6.Nl();
            r7.Nl();
            r8.Nl();
            r9.Nl();
            r10.Nl();
            r11.Nl();
            r12.Nl();
            r13.Nl();
            r14.Nl();
            r15.Nl();
            r16.Nl();
            r17.Nl();
            r18.Nl();
            r19.Nl();
            ui.Nl();
            mis.Nl();
            mis.n_mis = false;
            st.Nl();
            ui.D_Nl();
            ed.Nl();
            m.Nl();
            c.Nl();
            key = c_key;
            timer2.Stop();
            timeLeft = 3600;
            mint = 5;
            mino = 9;
            sect = 5;
            seco = 9;
            t.T_nyu(mint, mino, sect, seco);
            ui.dead = 0;
        }
    }


}

