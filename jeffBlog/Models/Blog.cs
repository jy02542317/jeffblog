using System;
using System.Collections.Generic;

namespace jeffBlog.Models
{
    public partial class Blog
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string MainContent { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? CreateUser { get; set; }
        public Guid? ModifyUser { get; set; }
        public bool? Private { get; set; }
        public int? ReadAmount { get; set; }
    }
}
