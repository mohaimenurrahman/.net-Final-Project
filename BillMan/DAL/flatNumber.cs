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
    
    public partial class flatNumber
    {
        public int id { get; set; }
        public string flatSize { get; set; }
        public string flatNumber1 { get; set; }
        public string rentStatus { get; set; }
        public int buildingCode { get; set; }
        public string flatRenterName { get; set; }
        public string mobile { get; set; }
        public int buildingId { get; set; }
    
        public virtual building building { get; set; }
    }
}
