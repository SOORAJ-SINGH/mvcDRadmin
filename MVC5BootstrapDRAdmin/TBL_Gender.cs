//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC5BootstrapDRAdmin
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_Gender
    {
        public TBL_Gender()
        {
            this.TBL_EmployeeDetails = new HashSet<TBL_EmployeeDetails>();
        }
    
        public int GenderID { get; set; }
        public string Gender { get; set; }
    
        public virtual ICollection<TBL_EmployeeDetails> TBL_EmployeeDetails { get; set; }
    }
}
