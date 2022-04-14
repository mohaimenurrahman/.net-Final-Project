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
    
    public partial class building
    {
        public building()
        {
            this.flats = new HashSet<flat>();
            this.currentBills = new HashSet<currentBill>();
            this.flatNumbers = new HashSet<flatNumber>();
            this.flatRents = new HashSet<flatRent>();
            this.wasaBills = new HashSet<wasaBill>();
            this.subUsers = new HashSet<subUser>();
        }
    
        public int id { get; set; }
        public int buildingCode { get; set; }
        public string buildingName { get; set; }
        public int totalFloors { get; set; }
        public int totalFlats { get; set; }
        public string ownerName { get; set; }
        public int colonyCode { get; set; }
        public string username { get; set; }
    
        public virtual ICollection<flat> flats { get; set; }
        public virtual ICollection<currentBill> currentBills { get; set; }
        public virtual ICollection<flatNumber> flatNumbers { get; set; }
        public virtual ICollection<flatRent> flatRents { get; set; }
        public virtual ICollection<wasaBill> wasaBills { get; set; }
        public virtual ICollection<subUser> subUsers { get; set; }
    }
}
