﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Entity
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Desciption { get; set; }
        public string Body { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public bool isApproved { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
