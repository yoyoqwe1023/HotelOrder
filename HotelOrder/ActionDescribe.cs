//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelOrder
{
    using System;
    using System.Collections.Generic;
    
    public partial class ActionDescribe
    {
        public int ActionToRoomID { get; set; }
        public string RoomID { get; set; }
        public Nullable<int> ActioID { get; set; }
        public string MemberID { get; set; }
    
        public virtual Action Action { get; set; }
        public virtual RoomMember RoomMember { get; set; }
    }
}
