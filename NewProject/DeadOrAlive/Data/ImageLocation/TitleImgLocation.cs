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
        /* 画像位置　*/
        ///////////////

        ///<summary> ディレクトリ位置 </summary>
        public const string DIR_PATH = $"{CnsImageLocation.ROOT_DIR}Title\\";

        ///<summary> タイトル </summary>
        public const string TITLE_PATH = $"{DIR_PATH}title.png";

        ///////////////
        /* 画像情報　*/
        ///////////////

        /// <summary> タイトル画像表示 </summary>
        public static readonly ImageLocations ImgTitle = new(TITLE_PATH, CnsImageLocation.LOC_BACK_GROUND);
    }
}
