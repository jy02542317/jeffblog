using System;
using System.Collections.Generic;

namespace jeffBlog.Models
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? CreateUser { get; set; }
        public Guid? ModifyUser { get; set; }
        public bool? IsValid { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public string Memo { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string NickName { get; set; }
    }
}
