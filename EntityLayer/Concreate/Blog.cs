﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public bool BlogStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public string BlogContent { get; set; }
        public string BlogTitle { get; set; }
        public string ThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
