//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Change4Change.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Investment
    {
        public System.Guid Id { get; set; }
        public System.Guid UserId { get; set; }
        public int Duration { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime MatureDate { get; set; }
    
        public virtual User User { get; set; }
    }
}