﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comments
    {
        [Key]
        public int CommentId { get; set; }
        public string  CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool  CommentStatus { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
