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
    
    public partial class subUser
    {
        public int id { get; set; }
        public int colonyId { get; set; }
        public int buildingId { get; set; }
        public string flatNumber { get; set; }
        public string mobile { get; set; }
        public string usertype { get; set; }
    
        public virtual building building { get; set; }
        public virtual colony colony { get; set; }
    }
}
