using System.Drawing;
using System.Windows.Forms;

namespace test
{
    class Key
    {
        Image img;
        Point point = new Point(160, 50);
        Point point2 = new Point(260, 50);
        Point point3 = new Point(360, 50);
        Point point4 = new Point(460, 50);
        Point point5 = new Point(560, 50);
        public string str;
        public char[] s = new char[5];
        public bool mozi = false;
        public bool nyu_enter = false;


        public string Down(object sender, KeyPressEventArgs e, int it)
        {

            if (str != null)
            {
                if (e.KeyChar == '\b')
                {
                    switch (str.Length)
                    {
                        case 1:
                            str = null;
                            break;
                        case 2:
                            str = str.Substring(0, 1);//Remove(1, 1);<-文字列から文字だと二倍になるから注意
                            break;
                        case 3:
                            str = str.Substring(0, 2);
                            break;
                        case 4:
                            str = str.Substring(0, 3);
                            break;
                        case 5:
                            str = str.Substring(0, 4);
                            break;
                        default:
                            break;

                    }
                }
            }
            if (e.KeyChar != '\b' && e.KeyChar != (char)Keys.Enter)
            {
                if (str == null)
                {
                    str = str + e.KeyChar;
                  //  Audio.Play_keyboard();
                }
                else if (str.Length < it)
                {
                    str = str + e.KeyChar;
                //   Audio.Play_keyboard();
                }
                else if (str.Length == it)
                {

                }
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                nyu_enter = true;
            }

            if (str != null)
            {
                S_insert(str);
            }
            return str;

        }
        public void S_insert(string str)
        {
            s = str.ToCharArray();
        }

        public void Nl()
        {
            if (str == null)
            {

            }
            else if (str.Length == 4)
            {
                s[0] = '\0';
                s[1] = '\0';
                s[2] = '\0';
                s[3] = '\0';
            }
            else if (str.Length == 3)
            {
                s[0] = '\0';
                s[1] = '\0';
                s[2] = '\0';
            }
            else if (str.Length == 2)
            {
                s[0] = '\0';
                s[1] = '\0';
            }
            else if (str.Length == 1)
            {
                s[0] = '\0';
            }


            str = null;
        }

        public void Draw(Graphics gr, int x)
        {
            if (x == 0 && mozi)
            {
                point = new Point(160, 50);
                point2 = new Point(260, 50);
                point3 = new Point(360, 50);
                point4 = new Point(460, 50);
                point5 = new Point(560, 50);
                mozi = false;
            }
            else if (x == 1 && !mozi)
            {
                point5 = new Point(570, 50);
                point4 = new Point(470, 50);
                point3 = new Point(370, 50);
                point2 = new Point(270, 50);
                point = new Point(170, 50);
                mozi = true;
            }


            if (str == null)
            {

            }
            else if (str.Length >= 5)
            {
                img = S_image(s[4]);
                gr.DrawImage(img, point5);
                img = S_image(s[3]);
                gr.DrawImage(img, point4);
                img = S_image(s[2]);
                gr.DrawImage(img, point3);
                img = S_image(s[1]);
                gr.DrawImage(img, point2);
                img = S_image(s[0]);
                gr.DrawImage(img, point);
            }
            else if (str.Length >= 4)
            {
                img = S_image(s[3]);
                gr.DrawImage(img, point4);
                img = S_image(s[2]);
                gr.DrawImage(img, point3);
                img = S_image(s[1]);
                gr.DrawImage(img, point2);
                img = S_image(s[0]);
                gr.DrawImage(img, point);
            }
            else if (str.Length >= 3)
            {
                img = S_image(s[2]);
                gr.DrawImage(img, point3);
                img = S_image(s[1]);
                gr.DrawImage(img, point2);
                img = S_image(s[0]);
                gr.DrawImage(img, point);
            }
            else if (str.Length >= 2)
            {
                img = S_image(s[1]);
                gr.DrawImage(img, point2);
                img = S_image(s[0]);
                gr.DrawImage(img, point);
            }
            else
            {
                img = S_image(s[0]);
                gr.DrawImage(img, point);
            }




        }

        public Image S_image(char c)
        {
            switch (c)
            {
                case 'a':
                    return test.Properties.Resources.A;
                case 'b':
                    return test.Properties.Resources.B;
                case 'c':
                    return test.Properties.Resources.C;
                case 'd':
                    return test.Properties.Resources.D;
                case 'e':
                    return test.Properties.Resources.E;
                case 'f':
                    return test.Properties.Resources.F;
                case 'g':
                    return test.Properties.Resources.G;
                case 'h':
                    return test.Properties.Resources.H;
                case 'i':
                    return test.Properties.Resources.I;
                case 'j':
                    return test.Properties.Resources.J;
                case 'k':
                    return test.Properties.Resources.K;
                case 'l':
                    return test.Properties.Resources.L;
                case 'm':
                    return test.Properties.Resources.M;
                case 'n':
                    return test.Properties.Resources.N;
                case 'o':
                    return test.Properties.Resources.O;
                case 'p':
                    return test.Properties.Resources.P;
                case 'q':
                    return test.Properties.Resources.Q;
                case 'r':
                    return test.Properties.Resources.R;
                case 's':
                    return test.Properties.Resources.S;
                case 't':
                    return test.Properties.Resources.T;
                case 'u':
                    return test.Properties.Resources.U;
                case 'v':
                    return test.Properties.Resources.V;
                case 'w':
                    return test.Properties.Resources.W;
                case 'x':
                    return test.Properties.Resources.X;
                case 'y':
                    return test.Properties.Resources.Y;
                case 'z':
                    return test.Properties.Resources.Z;
                case '0':
                    return test.Properties.Resources._0;
                case '1':
                    return test.Properties.Resources._1;
                case '2':
                    return test.Properties.Resources._2;
                case '3':
                    return test.Properties.Resources._3;
                case '4':
                    return test.Properties.Resources._4;
                case '5':
                    return test.Properties.Resources._5;
                case '6':
                    return test.Properties.Resources._6;
                case '7':
                    return test.Properties.Resources._7;
                case '8':
                    return test.Properties.Resources._8;
                case '9':
                    return test.Properties.Resources._9;

            }
            return test.Properties.Resources._null;
        }
    }
}
