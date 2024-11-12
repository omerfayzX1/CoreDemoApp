﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentUserName { get; set; }
        public bool CommentStatus { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
    }
}
