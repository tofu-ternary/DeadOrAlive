using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadOrAlive.Data;
using DeadOrAlive.Display;

namespace DeadOrAlive.Servise
{
    /// <summary>
    /// 画面表示管理クラス
    /// </summary>
    /// <remarks>
    /// 画面表示と表示させる内容の切り替えを行う。
    /// </remarks>
    public class ManagementDisplay
    {
        public delegate void CheckAreaEvent(ManagementDisplay md);

        /// <summary>基本表示データ</summary>
        public List<ImageLocations> DefaultImages = [];

        /// <summary>更新表示データ</summary>
        public List<ImageLocations> UpdateImages = [];

        /// <summary> 表示画面Dictionary </summary>
        public static readonly Dictionary<DisplayName, DisplayBase> DisplayDic = new()
        {
            /// タイトル
            [DisplayName.Title] = new TitleDisplay(){},
        };

        /// <summary>
        /// 基本画面表示
        /// </summary>
        /// <param name="e"></param>
        public void DisplayOnDefault(PaintEventArgs e)
        {
            foreach (ImageLocations img in DefaultImages)
            {
                img.DrawImg(e);
            }
        }

        /// <summary>
        /// 画面更新
        /// </summary>
        public void UpdateDisplay(PaintEventArgs e, CheckAreaEvent? @event)
        {
            // 範囲イベントチェック処理
            @event?.Invoke(this);

            foreach (ImageLocations img in UpdateImages)
            {
                img.DrawImg(e);
            }
        }

        /// <summary>
        /// 画面選択解除
        /// </summary>
        public void DeselectDisplay()
        {
            DefaultImages = [];
            UpdateImages = [];
        }
    }
}
