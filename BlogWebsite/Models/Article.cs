using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BlogWebsite.Models
{
    [Table("article")]
    public partial class Article
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("article_title")]
        [StringLength(50)]
        public string ArticleTitle { get; set; }
        [Column("article_description")]
        [StringLength(100)]
        public string ArticleDescription { get; set; }
        [Column("article_content")]
        public string ArticleContent { get; set; }
        [Column("article_thumb")]
        [StringLength(100)]
        public string ArticleThumb { get; set; }
        [Column("article_date", TypeName = "date")]
        public DateTime ArticleDate { get; set; }
        [Column("category_id")]
        public int? CategoryId { get; set; }
        [Column("author_id")]
        public int? AuthorId { get; set; }
        [Column("article_priority")]
        public int? ArticlePriority { get; set; }
        [Column("view_counts")]
        public int? ViewCounts { get; set; }
        [Column("like_counts")]
        public int? LikeCounts { get; set; }
        [Column("article_status")]
        public bool? ArticleStatus { get; set; }
        [Column("source")]
        [StringLength(50)]
        public string Source { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty(nameof(User.Articles))]
        public virtual User Author { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("Articles")]
        public virtual Category Category { get; set; }
    }
}
