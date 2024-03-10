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
using DeadOrAlive.Display;

namespace DeadOrAlive.Servise
{
    public partial class Main : Form
    {
        public Main() => InitializeComponent();

        private readonly ManagementDisplay md = new();

        private ManagementDisplay.CheckAreaEvent? checkArea;

        private DisplayBase? display;

        private bool isChangeDisplay = false;

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
            display = ManagementDisplay.DisplayDic[DisplayName.Title];

            checkArea += display.CheckAreaEvent;

            display.LoadDisplayData(md);

            isChangeDisplay = true;

            // 画面再描画
            Invalidate();
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

            Debug.WriteLine($"X:{e.X} ,Y:{e.Y}");

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
            if (isChangeDisplay)
            {
                isChangeDisplay = false;
                md.DisplayOnDefault(e);
            }
            else
            {
                md.UpdateDisplay(e, checkArea);
            }
        }
    }
}
