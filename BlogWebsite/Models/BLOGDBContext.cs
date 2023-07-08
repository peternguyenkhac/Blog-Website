using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BlogWebsite.Models
{
    public partial class BLOGDBContext : DbContext
    {
        public BLOGDBContext()
        {
        }

        public BLOGDBContext(DbContextOptions<BLOGDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=MSI;Database=BLOGDB2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(e => e.ArticleDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ArticlePriority).HasDefaultValueSql("((0))");

                entity.Property(e => e.ArticleStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.LikeCounts).HasDefaultValueSql("((0))");

                entity.Property(e => e.ViewCounts).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_article_user");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_article_category");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserRole).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
