using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadOrAlive.Data.ImageLocation
{
    /// <summary>
    /// 画像情報クラス
    /// </summary>
    /// <remarks>
    /// 特定の画像情報を定義する。
    /// </remarks>
    /// <param name="path"></param>
    /// <param name="pt"></param>
    public class ImageLocations(string path, Point pt)
    {
        /// <summary> 画像パス </summary>
        private readonly string ImgPath = path;
        /// <summary> 画像箇所 </summary>
        private readonly Point Point = pt;

        /// <summary>
        /// 描写処理
        /// </summary>
        /// <remarks>
        /// 特定の位置に画像を表示する。
        /// </remarks>
        /// <param name="e">描写イベント引数</param>
        public void DrawImg(PaintEventArgs e)
        {
            using Image img = Image.FromFile(ImgPath);
            e.Graphics.DrawImage(img, Point);
        }
    }
}
