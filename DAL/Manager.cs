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
    
    public partial class Manager
    {
        public Manager()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int MId { get; set; }
        public string MName { get; set; }
        public string MPassword { get; set; }
        public string MEmail { get; set; }
        public string MAddress { get; set; }
        public string MPhone { get; set; }
        public byte[] MPicture { get; set; }
        public int MBasicSalary { get; set; }
        public int MFastiveBonus { get; set; }
        public int MPerformBonus { get; set; }
        public string MStatus { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    }
}
