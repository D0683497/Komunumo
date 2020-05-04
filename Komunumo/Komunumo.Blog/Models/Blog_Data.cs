using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Komunumo.Blog.Models
{
    public class Blog_Data
    {
        public int Id { get; set; }
        public string ArticleTitle { get; set; }
        public string Context { get; set; }
    }
}
