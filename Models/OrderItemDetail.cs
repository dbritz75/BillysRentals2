//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BillysRentals2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderItemDetail
    {
        public int ID { get; set; }
        public int OrderItemID { get; set; }
        public Nullable<int> CheckedInByID { get; set; }
        public Nullable<int> ReturnMethodID { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public Nullable<System.TimeSpan> ReturnTime { get; set; }
        public Nullable<int> ItemReplacementID { get; set; }
        public System.DateTime DateModified { get; set; }
        public byte[] UpdateTimeStamp { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual OrderItem OrderItem { get; set; }
    }
}