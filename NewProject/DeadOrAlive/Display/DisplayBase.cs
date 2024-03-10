using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeadOrAlive.Data;
using DeadOrAlive.Servise;

namespace DeadOrAlive.Display
{
    /// <summary>
    /// 画面クラスの基底クラス
    /// 実装必須なメソッドを定義している。
    /// </summary>
    public class DisplayBase
    {
        public virtual void LoadDisplayData(ManagementDisplay md) { }
        public virtual void CheckAreaEvent(ManagementDisplay md) { }
    }
}
