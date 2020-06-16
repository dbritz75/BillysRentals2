using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BillysRentals2.Models  //Must be the same namespace as "original" classes.
{
    public class ItemsMetadata
    {
        [ReadOnly(true)]
        [DisplayName("Item ID")]
        public int ItemID { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Item Name")]
        public string ItemName { get; set; }

        [Required]
        [DisplayName("Item Description")]
        public string ItemDescription { get; set; }


        [Required]
        [Range(1, 100)]
        public int Quantity { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        [DisplayName("Price")]
        [Range(0.01, 999.99)]
        public Nullable<decimal> PriceEach { get; set; }

        [StringLength(50)]
        public string Manufacturer { get; set; }

        [DisplayName("Acquired")]
        [DisplayFormat(DataFormatString ="{0:d}")]
        public Nullable<System.DateTime> DateAcquired { get; set; }

        [DisplayName("In Service")]
        [DisplayFormat(DataFormatString = "{0:d}")] 
        public Nullable<System.DateTime> DateInService { get; set; }

        [DisplayName("Disposed")]
        public Nullable<System.DateTime> DateDisposed { get; set; }

        [DisplayName("Modified")]
        public Nullable<System.DateTime> DateModified { get; set; }

        [DisplayName("Maint. Interval")]
        public Nullable<int> MaintenanceIntervalDays { get; set; }
    }

    public class CategoryMetadata
    {
        [DisplayName("Category")]
        public string CategoryName { get; set; }
    }

    [MetadataType(typeof(ItemsMetadata))]
    public partial class Item
    { }

    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category
    { }
}