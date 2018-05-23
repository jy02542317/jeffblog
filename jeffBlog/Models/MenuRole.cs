using System;
using System.Collections.Generic;

namespace jeffBlog.Models
{
    public partial class MenuRole
    {
        public Guid FkRole { get; set; }
        public Guid FkMenu { get; set; }
        public bool IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? CreateUser { get; set; }
        public Guid? ModifyUser { get; set; }
    }
}
