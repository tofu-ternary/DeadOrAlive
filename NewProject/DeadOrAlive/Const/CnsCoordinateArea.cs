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
