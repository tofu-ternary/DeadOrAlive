using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadOrAlive.Const;
using DeadOrAlive.Data;
using DeadOrAlive.Servise;
using static System.Windows.Forms.AxHost;

namespace DeadOrAlive.Display
{
    public class TitleDisplay : DisplayBase
    {
        /// <summary>
        /// 画面遷移状態
        /// </summary>
        [Flags]
        private enum DisplayState
        {
            State_Title = 0x00,
            State_HowToPlay_1 = 0x01,
            State_HowToPlay_2 = 0x02,
        }

        /// <summary>
        /// 画面遷移状態
        /// </summary>
        private DisplayState state;

        private readonly List<ImageLocations> StateTitleImages =
        [
            CnsImageLocation.ImgTitle,
            CnsImageLocation.ImgHowToPlayBtn,
            CnsImageLocation.ImgStartBtn,
            CnsImageLocation.ImgCloseBtn
        ];

        private readonly List<ImageLocations> StateHowToPlay1Images =
        [
            CnsImageLocation.ImgTitle,
            CnsImageLocation.ImgHowToPlayBtn,
            CnsImageLocation.ImgCloseBtn
        ];

        private readonly List<ImageLocations> StateHowToPlay2Images = 
        [
            CnsImageLocation.ImgTitle,
            CnsImageLocation.ImgCloseBtn
        ];

        /// <summary>
        /// 画面データ読み込み
        /// </summary>
        public override void LoadDisplayData(ManagementDisplay md)
        {
            // デフォルトの画面描画リスト
            md.DefaultImages = StateTitleImages;

            // 更新時の画面描画リスト
            md.UpdateImages = md.DefaultImages;
        }

        /// <summary>
        /// タイトルイベント処理
        /// </summary>
        public override void CheckAreaEvent(ManagementDisplay md)
        {
            switch (state)
            {
                case DisplayState.State_Title:
                    AreaEventOnStateTilte(md);
                    break;
                case DisplayState.State_HowToPlay_1:
                    AreaEventOnHowToPlay_1(md);
                    break;
                case DisplayState.State_HowToPlay_2:
                    AreaEventOnHowToPlay_2(md);
                    break;
            }
        }

        /// <summary>
        /// 遷移状態：タイトル時イベント
        /// </summary>
        public void AreaEventOnStateTilte(ManagementDisplay md)
        {
            // 座標チェック：START_BUTTON
            if (Coordinates.IsArea(CnsCoordinateArea.START_BUTTON))
            {
                Debug.WriteLine("LET'S START!");
                return;
            }

            // 座標チェック：CLOSE_BUTTON
            if (Coordinates.IsArea(CnsCoordinateArea.CLOSE_BUTTON))
            {
                Debug.WriteLine("GAME IS END.");
                return;
            }

            // 座標チェック：HOWTOPLAY_BUTTON
            if (Coordinates.IsArea(CnsCoordinateArea.HOWTOPLAY_BUTTON))
            {
                state = DisplayState.State_HowToPlay_1;
                md.UpdateImages = StateHowToPlay1Images;
                return;
            }
        }

        /// <summary>
        /// 遷移状態：操作説明１
        /// </summary>
        public void AreaEventOnHowToPlay_1(ManagementDisplay md)
        {
            // 座標チェック：CLOSE_BUTTON
            if (Coordinates.IsArea(CnsCoordinateArea.CLOSE_BUTTON))
            {
                state = DisplayState.State_Title;
                md.UpdateImages = StateTitleImages;
                return;
            }

            // 座標チェック：HOWTOPLAY_BUTTON
            if (Coordinates.IsArea(CnsCoordinateArea.HOWTOPLAY_BUTTON))
            {
                state = DisplayState.State_HowToPlay_2;
                md.UpdateImages = StateHowToPlay2Images;
                return;
            }
        }

        /// <summary>
        /// 遷移状態：操作説明２
        /// </summary>
        public void AreaEventOnHowToPlay_2(ManagementDisplay md)
        {
            // 座標チェック：CLOSE_BUTTON
            if (Coordinates.IsArea(CnsCoordinateArea.CLOSE_BUTTON))
            {
                state = DisplayState.State_HowToPlay_1;
                md.UpdateImages = StateHowToPlay1Images;
            }
        }
    }
}
