//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CutPlanes.DataAccess.CutPlanes
{
    using System;
    using System.Collections.Generic;
    
    public partial class Constraint
    {
        public int Id { get; set; }
        public int ConstraintSetId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int UserCreatedId { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public Nullable<int> UserUpdatedId { get; set; }
        public Nullable<int> FiscalYear { get; set; }
        public Nullable<decimal> SummerN0 { get; set; }
        public Nullable<decimal> SummerN1 { get; set; }
        public Nullable<decimal> WinterN0 { get; set; }
        public Nullable<decimal> WinterN1 { get; set; }
        public Nullable<decimal> AreaLoss { get; set; }
        public Nullable<decimal> AreaLossInPercentage { get; set; }
        public Nullable<decimal> TotalLoss { get; set; }
        public Nullable<decimal> TotalLossInPercentage { get; set; }
        public Nullable<decimal> IntermittentRmr { get; set; }
    }
}
