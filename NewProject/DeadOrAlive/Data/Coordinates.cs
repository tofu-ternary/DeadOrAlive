using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadOrAlive.Data
{
	/// <summary>
	/// 座標範囲クラス
	/// </summary>
	/// <remarks>
	/// 特定の座標範囲を保持し、範囲内が押下されたか判断できる。
	/// </remarks>
	public static class Coordinates
	{
        public struct Coordinate
		{
			public int MinX;
			public int MaxX;
			public int MinY;
			public int MaxY;
		}

		/// <summary> 押下位置座標X </summary>
		private static int PointX;
		/// <summary> 押下位置座標Y </summary>
		private static int PointY;

		/// <summary>
		/// 押下位置座標セッター
		/// </summary>
		/// <param name="ptX"></param>
		/// <param name="ptY"></param>
		public static void SetPoint(int ptX, int ptY)
		{
			PointX = ptX;
			PointY = ptY;
		}

		/// <summary>
		/// 座標範囲整合チェック
		/// </summary>
		/// <remarks>
		/// 最小値＞最大値の場合 ArgumentOutOfRangeExceptionの例外が発生させる。
		/// </remarks>
		/// <param name="coordinate">座標範囲</param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		private static void RangeCheck(Coordinate coordinate)
		{
			if ((coordinate.MinX > coordinate.MaxX) || (coordinate.MinY > coordinate.MaxY))
			{
				throw new ArgumentOutOfRangeException(nameof(coordinate), "minValue is larger than maxValue.");
			}
		}

		/// <summary>
		/// 座標範囲内チェック
		/// </summary>
		/// <remarks>
		/// 引数の座標範囲の、範囲内が押下されたか判断できる。
		/// </remarks>
		/// <param name="coordinate">座標範囲</param>
		public static bool IsArea(Coordinate coordinate)
		{
			RangeCheck(coordinate);

			return (coordinate.MinX <= PointX) && (PointX <= coordinate.MaxX) && (coordinate.MinY <= PointY) && (PointY <= coordinate.MaxY);
		}
	}
}
