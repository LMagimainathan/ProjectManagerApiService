//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int TaskId { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Nullable<bool> ParentTask { get; set; }
        public string TaskName { get; set; }
        public Nullable<int> ParentTaskId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> Priority { get; set; }
        public string Status { get; set; }
        public Nullable<int> UserId { get; set; }
        public string ParentTaskName { get; set; }
        public string UserName { get; set; }
    }
}
