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
	/// 特定の座標範囲定数を定義する。
	/// </remarks>
	public static class CnsCoordinateArea
	{
        /// <summary> 開始ボタン座標範囲 </summary>
        public static readonly Coordinates.Coordinate START_BUTTON = new() { MinX = 400, MaxX = 800, MinY = 400, MaxY = 800 };
	}
}
