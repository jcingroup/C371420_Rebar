//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProcCore.Business.DB0
{
    using System;
    using System.Collections.Generic;
    
    using Newtonsoft.Json;
    public partial class 會員產品 : BaseEntityTable
    {
        public int 流水號 { get; set; }
        public Nullable<int> 會員流水號 { get; set; }
        public Nullable<int> 產品編號 { get; set; }
        public string 產品名稱 { get; set; }
        public Nullable<int> 產品分類 { get; set; }
        public string 產品特色 { get; set; }
        public Nullable<int> 價格 { get; set; }
        public string 價格說明 { get; set; }
        public Nullable<int> 排序 { get; set; }
        public Nullable<int> 顯示狀態Flag { get; set; }
        public Nullable<int> 曝光 { get; set; }
        public Nullable<System.DateTime> 活動日期 { get; set; }
        public Nullable<System.DateTime> 修改日期 { get; set; }
        public Nullable<int> 點閱率 { get; set; }
        public string 新增人員 { get; set; }
        public string 修改人員 { get; set; }
    }
}

