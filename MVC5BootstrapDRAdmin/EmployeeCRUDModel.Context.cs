﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class somyatrans_drbetaEntities : DbContext
    {
        public somyatrans_drbetaEntities()
            : base("name=somyatrans_drbetaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_Department> TBL_Department { get; set; }
        public virtual DbSet<TBL_EmployeeDetails> TBL_EmployeeDetails { get; set; }
        public virtual DbSet<TBL_EmployeeLogin> TBL_EmployeeLogin { get; set; }
        public virtual DbSet<TBL_Gender> TBL_Gender { get; set; }
        public virtual DbSet<TBL_OfficeLocation> TBL_OfficeLocation { get; set; }
    
        public virtual ObjectResult<USP_admin_TLrelation_Result> USP_admin_TLrelation()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_admin_TLrelation_Result>("USP_admin_TLrelation");
        }
    
        public virtual ObjectResult<USP_admin_TotalDRFilled_Result> USP_admin_TotalDRFilled(Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate)
        {
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_admin_TotalDRFilled_Result>("USP_admin_TotalDRFilled", startDateParameter, endDateParameter);
        }
    
        public virtual ObjectResult<USP_EXPORT_JOB_Result> USP_EXPORT_JOB(string callType, Nullable<int> empID, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate)
        {
            var callTypeParameter = callType != null ?
                new ObjectParameter("CallType", callType) :
                new ObjectParameter("CallType", typeof(string));
    
            var empIDParameter = empID.HasValue ?
                new ObjectParameter("EmpID", empID) :
                new ObjectParameter("EmpID", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_EXPORT_JOB_Result>("USP_EXPORT_JOB", callTypeParameter, empIDParameter, startDateParameter, endDateParameter);
        }
    
        public virtual ObjectResult<USP_GETNAME_Result> USP_GETNAME(string callType, Nullable<int> empID, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate)
        {
            var callTypeParameter = callType != null ?
                new ObjectParameter("CallType", callType) :
                new ObjectParameter("CallType", typeof(string));
    
            var empIDParameter = empID.HasValue ?
                new ObjectParameter("EmpID", empID) :
                new ObjectParameter("EmpID", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_GETNAME_Result>("USP_GETNAME", callTypeParameter, empIDParameter, startDateParameter, endDateParameter);
        }
    }
}
