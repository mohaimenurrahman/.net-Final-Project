//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class currentBill
    {
        public int id { get; set; }
        public int buildingCode { get; set; }
        public string flatNumber { get; set; }
        public string dateStart { get; set; }
        public string dateEnd { get; set; }
        public string unitAmount { get; set; }
        public string totalAmount { get; set; }
        public string status { get; set; }
        public int buildingId { get; set; }
    
        public virtual building building { get; set; }
    }
}
