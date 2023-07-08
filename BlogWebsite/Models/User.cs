using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BlogWebsite.Models
{
    [Table("user")]
    public partial class User
    {
        public User()
        {
            Articles = new HashSet<Article>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("user_name")]
        [StringLength(50)]
        public string UserName { get; set; }
        [Column("user_email")]
        [StringLength(50)]
        public string UserEmail { get; set; }
        [Column("user_login")]
        [StringLength(50)]
        public string UserLogin { get; set; }
        [Column("user_password")]
        [StringLength(50)]
        public string UserPassword { get; set; }
        [Column("user_role")]
        [StringLength(10)]
        public string UserRole { get; set; }

        [InverseProperty(nameof(Article.Author))]
        public virtual ICollection<Article> Articles { get; set; }
    }
}
