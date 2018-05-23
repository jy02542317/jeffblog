using System;
using System.Collections.Generic;

namespace jeffBlog.Models
{
    public partial class File
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
        public string Picture { get; set; }
        public string Type { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? CreateUser { get; set; }
        public Guid? ModifyUser { get; set; }
    }
}
