using System;
using System.Collections.Generic;

namespace jeffBlog.Models
{
    public partial class Menu
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool? IsValid { get; set; }
        public Guid? ParentId { get; set; }
        public int? DisplayOrder { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? CreateUser { get; set; }
        public Guid? ModifyUser { get; set; }
    }
}
