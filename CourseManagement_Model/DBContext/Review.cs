//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseManagement_Model.DBContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public decimal Rating { get; set; }
        public string ReviewText { get; set; }
        public System.DateTime ReviewDate { get; set; }
    
        public virtual Users Users { get; set; }
        public virtual Course Course { get; set; }
    }
}