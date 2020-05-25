using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Komunumo.Blog.Models
{
    public class Article
    {
        [Key]
        public int Article_ID { get; set; }

        [ForeignKey("AspNetUsers.Username")]
        public string Poster { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
        public DateTime EditDate { get; set; }
        public int Popularity { get; set; }
    }
}