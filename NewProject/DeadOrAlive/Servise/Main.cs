using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeadOrAlive.Const;
using DeadOrAlive.Data;
using DeadOrAlive.Data.ImageLocation;

namespace DeadOrAlive.Servise
{
    public partial class Main : Form
    {
        public Main() => InitializeComponent();

        /// <summary>
        /// 画面初期処理
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 画面押下時処理（クリック）
        /// </summary>
        /// <remarks>
        /// 押下位置の座標を取得する。
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_MouseClick(object sender, MouseEventArgs e)
        {
            // 押下位置の座標を取得
            Coordinates.SetPoint(e.X, e.Y);
            // Debug.WriteLine($"{Coordinates.PointX},{Coordinates.PointY}");

            // 座標チェック：START_BUTTON
            if (Coordinates.IsArea(CnsCoordinateArea.START_BUTTON))
            {
                Debug.WriteLine("LET'S START!");
            }

            // 画面再描画
            Invalidate();
        }

        /// <summary>
        /// 画面描画時処理
        /// </summary>
        /// <remarks>
        /// 画面を描画する。
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Paint(object sender, PaintEventArgs e)
        {
            TitleImgLocation.ImgTitle.DrawImg(e);
        }
    }
}
