﻿using System;
using System.Collections.Generic;

namespace jeffBlog.Models
{
    public partial class Role
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? CreateUser { get; set; }
        public Guid? ModifyUser { get; set; }
        public bool? IsValid { get; set; }
    }
}
