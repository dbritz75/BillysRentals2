using BillysRentals2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BillysRentals2.PartialClasses
{
    public partial class Item
    {
        [NotMapped]
        public List<Manufacturer> ManufacturerList { get; set; }
    }
}