//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Megumirai.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public decimal ItemId { get; set; }
        public int Stock1 { get; set; }
        public Nullable<System.DateTime> ReceiptDate { get; set; }
    
        public virtual Item Item { get; set; }
    }
}
