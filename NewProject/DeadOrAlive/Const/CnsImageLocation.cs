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
        //      　矢印        
        ////////////////////////

        /* 画像パス */

        /// <summary> 矢印 </summary>
        public const string ARROW_PATH = $"{ROOT_DIR}ArrowButton\\";

        /// <summary> 上矢印 </summary>
        public const string ARROW_BTN_UP = $"{ARROW_PATH}arrow_btn_up.png";

        /// <summary> 左矢印 </summary>
        public const string ARROW_BTN_LEFT = $"{ARROW_PATH}arrow_btn_left.png";

        /// <summary> 右矢印 </summary>
        public const string ARROW_BTN_RIGHT = $"{ARROW_PATH}arrow_btn_right.png";

        /// <summary> 下矢印 </summary>
        public const string ARROW_BTN_DOWN = $"{ARROW_PATH}arrow_btn_down.png";

        /* 画面表示位置 */

        /// <summary> 上矢印 基本表示位置 </summary>
        public static readonly Point LOC_ARROW_UP_DEFAULT = new(450, 50);

        /// <summary> 左矢印 基本表示位置 </summary>
        public static readonly Point LOC_ARROW_LEFT_DEFAULT = new(25, 300);

        /// <summary> 右矢印 基本表示位置 </summary>
        public static readonly Point LOC_ARROW_RIGHT_DEFAULT = new(900, 300);

        /// <summary> 下矢印 基本表示位置 </summary>
        public static readonly Point LOC_ARROW_DOWN_DEFAULT = new(450, 500);

        /// <summary> 左矢印 戻るボタン表示位置 </summary>
        public static readonly Point LOC_ARROW_LEFT_BACK_BTN = new(0, 0);

        /* 画像情報　*/

        /// <summary> 上矢印 基本表示 </summary>
        public static readonly ImageLocations ImgArrowUpDefault = new(ARROW_BTN_UP, LOC_ARROW_UP_DEFAULT);

        /// <summary> 左矢印 基本表示 </summary>
        public static readonly ImageLocations ImgArrowLeftDefault = new(ARROW_BTN_LEFT, LOC_ARROW_LEFT_DEFAULT);

        /// <summary> 右矢印 基本表示 </summary>
        public static readonly ImageLocations ImgArrowRightDefault = new(ARROW_BTN_RIGHT, LOC_ARROW_RIGHT_DEFAULT);

        /// <summary> 下矢印 基本表示 </summary>
        public static readonly ImageLocations ImgArrowDownDefault = new(ARROW_BTN_DOWN, LOC_ARROW_DOWN_DEFAULT);

        /// <summary> 左矢印 戻るボタン表示 </summary>
        public static readonly ImageLocations ImgArrowLeftBackBtn = new(ARROW_BTN_LEFT, LOC_ARROW_LEFT_BACK_BTN);


        ////////////////////////
        //      タイトル        
        ////////////////////////

        /* 画像パス */

        /// <summary> ディレクトリ位置 </summary>
        public const string TITLE_DIR_PATH = $"{ROOT_DIR}Title\\";

        /// <summary> タイトル </summary>
        public const string BK_TITLE_PATH = $"{TITLE_DIR_PATH}BK_title.png";

        /// <summary> 操作説明１ </summary>
        public const string BK_HOWTOPLAY_1_PATH = $"{TITLE_DIR_PATH}BK_how_to_play_1.png";

        /// <summary> 操作説明２ </summary>
        public const string BK_HOWTOPLAY_2_PATH = $"{TITLE_DIR_PATH}BK_how_to_play_2.png";

        /// <summary> 操作説明ボタン </summary>
        public const string HOWTOPLAY_BUTTON_PATH = $"{TITLE_DIR_PATH}how_to_play_btn.png";

        /// <summary> ゲーム開始ボタン </summary>
        public const string START_BUTTON_PATH = $"{TITLE_DIR_PATH}start_btn.png";

        /// <summary> ゲーム終了ボタン </summary>
        public const string CLOSE_BUTTON_PATH = $"{TITLE_DIR_PATH}close_btn.png";

        /* 画面表示位置 */

        /// <summary> 操作説明ボタン表示位置 </summary>
        public static readonly Point LOC_HOWTOPLAY_BUTTON = new(924, 668);

        /// <summary> ゲーム開始ボタン表示位置 </summary>
        public static readonly Point LOC_START_BUTTON = new(350, 500);

        /// <summary> ゲーム終了ボタン表示位置 </summary>
        public static readonly Point LOC_CLOSE_BUTTON = new(0, 675);

        /* 画像情報　*/

        /// <summary> タイトル表示 </summary>
        public static readonly ImageLocations ImgBKTitle = new(BK_TITLE_PATH, LOC_BACK_GROUND);

        /// <summary> 操作説明１表示 </summary>
        public static readonly ImageLocations ImgBKHowToPlay1 = new(BK_HOWTOPLAY_1_PATH, LOC_BACK_GROUND);

        /// <summary> 操作説明２表示 </summary>
        public static readonly ImageLocations ImgBKHowToPlay2 = new(BK_HOWTOPLAY_2_PATH, LOC_BACK_GROUND);

        /// <summary> 操作説明ボタン表示 </summary>
        public static readonly ImageLocations ImgHowToPlayBtn = new(HOWTOPLAY_BUTTON_PATH, LOC_HOWTOPLAY_BUTTON);

        /// <summary> ゲーム開始ボタン表示 </summary>
        public static readonly ImageLocations ImgStartBtn = new(START_BUTTON_PATH, LOC_START_BUTTON);

        /// <summary> ゲーム終了ボタン表示 </summary>
        public static readonly ImageLocations ImgCloseBtn = new(CLOSE_BUTTON_PATH, LOC_CLOSE_BUTTON);

        ////////////////////////
        //      入力文字        
        ////////////////////////

        /* 画像パス */

        /// <summary> 入力文字 </summary>
        public const string INPUT_DIR_PATH = $"{ROOT_DIR}Input\\";

        /// <summary> 数字「０」 </summary>
        public const string INPUT_NUM_0 = $"{INPUT_DIR_PATH}0.png";

        /// <summary> 数字「１」 </summary>
        public const string INPUT_NUM_1 = $"{INPUT_DIR_PATH}1.png";

        /// <summary> 数字「２」 </summary>
        public const string INPUT_NUM_2 = $"{INPUT_DIR_PATH}2.png";

        /// <summary> 数字「３」 </summary>
        public const string INPUT_NUM_3 = $"{INPUT_DIR_PATH}3.png";

        /// <summary> 数字「４」 </summary>
        public const string INPUT_NUM_4 = $"{INPUT_DIR_PATH}4.png";

        /// <summary> 数字「５」 </summary>
        public const string INPUT_NUM_5 = $"{INPUT_DIR_PATH}5.png";

        /// <summary> 数字「６」 </summary>
        public const string INPUT_NUM_6 = $"{INPUT_DIR_PATH}6.png";

        /// <summary> 数字「７」 </summary>
        public const string INPUT_NUM_7 = $"{INPUT_DIR_PATH}7.png";

        /// <summary> 数字「８」 </summary>
        public const string INPUT_NUM_8 = $"{INPUT_DIR_PATH}8.png";

        /// <summary> 数字「９」 </summary>
        public const string INPUT_NUM_9 = $"{INPUT_DIR_PATH}9.png";


        /// <summary> 英字「A」 </summary>
        public const string INPUT_ALPHABET_A = $"{INPUT_DIR_PATH}A.png";

        /// <summary> 英字「B」 </summary>
        public const string INPUT_ALPHABET_B = $"{INPUT_DIR_PATH}B.png";

        /// <summary> 英字「C」 </summary>
        public const string INPUT_ALPHABET_C = $"{INPUT_DIR_PATH}C.png";

        /// <summary> 英字「D」 </summary>
        public const string INPUT_ALPHABET_D = $"{INPUT_DIR_PATH}D.png";

        /// <summary> 英字「E」 </summary>
        public const string INPUT_ALPHABET_E = $"{INPUT_DIR_PATH}E.png";

        /// <summary> 英字「F」 </summary>
        public const string INPUT_ALPHABET_F = $"{INPUT_DIR_PATH}F.png";

        /// <summary> 英字「G」 </summary>
        public const string INPUT_ALPHABET_G = $"{INPUT_DIR_PATH}G.png";

        /// <summary> 英字「H」 </summary>
        public const string INPUT_ALPHABET_H = $"{INPUT_DIR_PATH}H.png";

        /// <summary> 英字「I」 </summary>
        public const string INPUT_ALPHABET_I = $"{INPUT_DIR_PATH}I.png";

        /// <summary> 英字「J」 </summary>
        public const string INPUT_ALPHABET_J = $"{INPUT_DIR_PATH}J.png";

        /// <summary> 英字「K」 </summary>
        public const string INPUT_ALPHABET_K = $"{INPUT_DIR_PATH}K.png";

        /// <summary> 英字「L」 </summary>
        public const string INPUT_ALPHABET_L = $"{INPUT_DIR_PATH}L.png";

        /// <summary> 英字「M」 </summary>x
        public const string INPUT_ALPHABET_M = $"{INPUT_DIR_PATH}M.png";

        /// <summary> 英字「N」 </summary>
        public const string INPUT_ALPHABET_N = $"{INPUT_DIR_PATH}N.png";

        /// <summary> 英字「O」 </summary>
        public const string INPUT_ALPHABET_O = $"{INPUT_DIR_PATH}O.png";

        /// <summary> 英字「P」 </summary>
        public const string INPUT_ALPHABET_P = $"{INPUT_DIR_PATH}P.png";

        /// <summary> 英字「Q」 </summary>
        public const string INPUT_ALPHABET_Q = $"{INPUT_DIR_PATH}Q.png";

        /// <summary> 英字「R」 </summary>
        public const string INPUT_ALPHABET_R = $"{INPUT_DIR_PATH}R.png";

        /// <summary> 英字「S」 </summary>
        public const string INPUT_ALPHABET_S = $"{INPUT_DIR_PATH}S.png";

        /// <summary> 英字「T」 </summary>
        public const string INPUT_ALPHABET_T = $"{INPUT_DIR_PATH}T.png";

        /// <summary> 英字「U」 </summary>
        public const string INPUT_ALPHABET_U = $"{INPUT_DIR_PATH}U.png";

        /// <summary> 英字「V」 </summary>
        public const string INPUT_ALPHABET_V = $"{INPUT_DIR_PATH}V.png";

        /// <summary> 英字「W」 </summary>
        public const string INPUT_ALPHABET_W = $"{INPUT_DIR_PATH}W.png";

        /// <summary> 英字「X」 </summary>
        public const string INPUT_ALPHABET_X = $"{INPUT_DIR_PATH}X.png";

        /// <summary> 英字「Y」 </summary>
        public const string INPUT_ALPHABET_Y = $"{INPUT_DIR_PATH}Y.png";

        /// <summary> 英字「Z」 </summary>
        public const string INPUT_ALPHABET_Z = $"{INPUT_DIR_PATH}Z.png";

    }
}
