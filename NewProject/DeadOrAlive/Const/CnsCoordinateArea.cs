using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadOrAlive.Data;

namespace DeadOrAlive.Const
{
	/// <summary>
	/// 座標範囲定数クラス
	/// </summary>
	/// <remarks>
	/// 座標範囲定数を定義する。
	/// </remarks>
	public static class CnsCoordinateArea
	{
        ////////////////////////
        //      　矢印        
        ////////////////////////

        /// <summary> 上矢印 基本座標範囲 </summary>
        public static readonly Coordinates.Coordinate ARROW_UP_DEFAULT = new() { MinX = 0, MaxX = 0, MinY = 0, MaxY = 0 };

        /// <summary> 左矢印 基本座標範囲 </summary>
        public static readonly Coordinates.Coordinate ARROW_LEFT_DEFAULT = new() { MinX = 0, MaxX = 0, MinY = 0, MaxY = 0 };

        /// <summary> 右矢印 基本座標範囲 </summary>
        public static readonly Coordinates.Coordinate ARROW_RIGHT_DEFAULT = new() { MinX = 900, MaxX = 1000, MinY = 300, MaxY = 400 };

        /// <summary> 下矢印 基本座標範囲 </summary>
        public static readonly Coordinates.Coordinate ARROW_DOWN_DEFAULT = new() { MinX = 0, MaxX = 0, MinY = 0, MaxY = 0 };

        /// <summary> 左矢印 戻るボタン座標範囲 </summary>
        public static readonly Coordinates.Coordinate ARROW_LEFT_BACK_BTN = new() { MinX = 0, MaxX = 100, MinY = 0, MaxY = 100 };


        ////////////////////////
        //      タイトル        
        ////////////////////////

        /// <summary> 開始ボタン座標範囲 </summary>
        public static readonly Coordinates.Coordinate START_BUTTON = new() { MinX = 350, MaxX = 700, MinY = 500, MaxY = 600 };

        /// <summary> 操作説明ボタン座標範囲 </summary>
        public static readonly Coordinates.Coordinate HOWTOPLAY_BUTTON = new() { MinX = 925, MaxX = 1050, MinY = 668, MaxY = 770 };

        ///<summary> ゲーム終了ボタン座標範囲 </summary>
        public static readonly Coordinates.Coordinate CLOSE_BUTTON = new() { MinX = 0, MaxX = 70, MinY = 675, MaxY = 765 };
    }
}
