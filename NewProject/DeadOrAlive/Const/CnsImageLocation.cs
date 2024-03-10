using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadOrAlive.Data;

namespace DeadOrAlive.Const
{
    /// <summary>
    /// 画像情報定数クラス
    /// </summary>
    /// <remarks>
    /// 画像情報を定義する。
    /// </remarks>
    public static class CnsImageLocation
    {
        ////////////////////////
        //      共通定数        
        ////////////////////////

        /* ディレクトリパス　*/
        
        ///<summary> ディレクトリ位置 </summary>
        public const string ROOT_DIR = @"Resourse\ImageData\";


        /* 画面表示位置　*/

        ///<summary> 画面左上 </summary>
        public static readonly Point LOC_BACK_GROUND = new(0, 0);

        ////////////////////////
        //      タイトル        
        ////////////////////////

        /* 画像パス　*/

        ///<summary> ディレクトリ位置 </summary>
        public const string DIR_PATH = $"{ROOT_DIR}Title\\";

        ///<summary> タイトル </summary>
        public const string TITLE_PATH = $"{DIR_PATH}bk_title.png";

        ///<summary> 操作説明ボタン </summary>
        public const string HOWTOPLAY_BUTTON_PATH = $"{DIR_PATH}howtoplaybtn.png";

        ///<summary> ゲーム開始ボタン </summary>
        public const string START_BUTTON_PATH = $"{DIR_PATH}startbtn.png";

        ///<summary> ゲーム終了ボタン </summary>
        public const string CLOSE_BUTTON_PATH = $"{DIR_PATH}closebtn.png";

        /* 画面表示位置　*/

        ///<summary> 操作説明ボタン表示位置 </summary>
        public static readonly Point LOC_HOWTOPLAY_BUTTON = new(924, 668);

        ///<summary> ゲーム開始ボタン表示位置 </summary>
        public static readonly Point LOC_START_BUTTON = new(350, 500);

        ///<summary> ゲーム終了ボタン表示位置 </summary>
        public static readonly Point LOC_CLOSE_BUTTON = new(0, 675);

        /* 画像情報　*/

        /// <summary> タイトル表示 </summary>
        public static readonly ImageLocations ImgTitle = new(TITLE_PATH, LOC_BACK_GROUND);

        /// <summary> 操作説明ボタン表示 </summary>
        public static readonly ImageLocations ImgHowToPlayBtn = new(HOWTOPLAY_BUTTON_PATH, LOC_HOWTOPLAY_BUTTON);

        /// <summary> ゲーム開始ボタン表示 </summary>
        public static readonly ImageLocations ImgStartBtn = new(START_BUTTON_PATH, LOC_START_BUTTON);

        /// <summary> ゲーム終了ボタン表示 </summary>
        public static readonly ImageLocations ImgCloseBtn = new(CLOSE_BUTTON_PATH, LOC_CLOSE_BUTTON);
    }
}
