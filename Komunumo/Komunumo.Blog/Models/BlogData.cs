using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Komunumo.Blog.Models
{
    public class BlogUser : IdentityUser
    {
        public string Department { get; set; }
        public string Degree { get; set; }
        public string College { get; set; }
    }
    public class Article
    {
        [Key]
        public int Article_ID { get; set; }
        // user ID from AspNetUser table.
        public string OwnerID { get; set; }
        [ForeignKey("AspNetUsers.Username")]
        public string Poster { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Context { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
        public DateTime EditDate { get; set; }
        public int Popularity { get; set; }
        public bool Published { get; set; }


    }
    public class Like_s_article
    {

        public string Username { get; set; }
        public int Article_ID { get; set; }
    }
    public class Photo
    {
        [Key]
        public int PhotoID { get; set; }
        public int Article_ID { get; set; }
        //public IFormFile Photos { get; set; }
    }
}