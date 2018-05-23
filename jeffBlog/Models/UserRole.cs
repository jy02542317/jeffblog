using System;
using System.Collections.Generic;

namespace jeffBlog.Models
{
    public partial class UserRole
    {
        public Guid FkUser { get; set; }
        public Guid FkRole { get; set; }
        public bool IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public Guid? CreateUser { get; set; }
        public Guid? ModifyUser { get; set; }
    }
}
