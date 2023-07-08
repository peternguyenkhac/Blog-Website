using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BlogWebsite.Models
{
    [Table("category")]
    public partial class Category
    {
        public Category()
        {
            Articles = new HashSet<Article>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("category_name")]
        [StringLength(50)]
        public string CategoryName { get; set; }
        [Column("category_description")]
        [StringLength(100)]
        public string CategoryDescription { get; set; }

        [InverseProperty(nameof(Article.Category))]
        public virtual ICollection<Article> Articles { get; set; }
    }
}
