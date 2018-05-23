using System;
using System.Collections.Generic;

namespace jeffBlog.Models
{
    public partial class Event
    {
        public Guid Id { get; set; }
        public string Event1 { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? CreateUser { get; set; }
        public Guid? ModifyUser { get; set; }
        public DateTime? ValidTime { get; set; }
        public bool? IsValid { get; set; }
        public bool? EmailorNot { get; set; }
    }
}
