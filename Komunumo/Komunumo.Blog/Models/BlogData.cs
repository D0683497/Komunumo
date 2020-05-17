using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komunumo.Blog.Models
{
    public class BlogData
    {
        [Key]
        public int Id { get; set; }
        public string Poster { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
        public DateTime EditDate { get; set; }
        public int LikeCounter { get; set; }
    }
}
