using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadOrAlive.Const;

namespace DeadOrAlive.Data.ImageLocation
{
    internal class TitleImgLocation
    {
        ///////////////
        /* 画像情報　*/
        ///////////////

        /// <summary> タイトル画像表示 </summary>
        public static readonly ImageLocations ImgTitle = new(CnsImageLocation.ROOT_DIR, CnsImageLocation.LOC_BACK_GROUND);
    }
}
