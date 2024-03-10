using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadOrAlive.Data.ImageLocation;

namespace DeadOrAlive.Const
{
    /// <summary>
    /// 画像情報定数クラス
    /// </summary>
    /// <remarks>
    /// 特定の画像情報を定義する。
    /// </remarks>
    public static class CnsImageLocation
    {
        ///////////////////////
        /* ディレクトリ位置　*/
        ///////////////////////
        
        ///<summary> ディレクトリ位置 </summary>
        public const string ROOT_DIR = @"Resourse\ImageData\";

        ///////////////////
        /* 画面表示位置　*/
        ///////////////////

        ///<summary> 画面左上 </summary>
        public static readonly Point LOC_BACK_GROUND = new(0, 0);

        ///////////////
        /* 画像情報　*/
        ///////////////

        /// <summary> タイトル画像表示 </summary>
        public static readonly ImageLocations ImgTitle = new(ROOT_DIR, LOC_BACK_GROUND);
    }
}
