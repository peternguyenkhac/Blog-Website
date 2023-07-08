using BlogWebsite.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogWebsite.Services
{
    public class ArticlesService
    {
        private readonly BLOGDBContext _dbContext;
        public ArticlesService(BLOGDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Article> GetArticles(string searchString, string sortOrder, int? categoryId, int? authorId, bool allowHidden = false)
        {
            var articles = _dbContext.Articles
                .Include(a => a.Author)
                .Include(a => a.Category)
                .Select(a => a)
                ;

            if (!allowHidden)
            {
                articles = articles.Where(a => a.ArticleStatus == true);
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                articles = articles.Where(a => a.ArticleTitle.Contains(searchString));
            }

            if (categoryId != null)
            {
                articles = articles.Where(a => a.CategoryId == categoryId);
            }

            if (authorId != null)
            {
                articles = articles.Where(a => a.AuthorId == authorId);
            }

            switch (sortOrder)
            {
                case "date":
                    articles = articles.OrderByDescending(a => a.ArticleDate);
                    break;
                case "title":
                    articles = articles.OrderBy(a => a.ArticleTitle);
                    break;
                case "date_desc":
                    articles = articles.OrderBy(a => a.ArticleDate);
                    break;
                case "title_desc":
                    articles = articles.OrderByDescending(a => a.ArticleTitle);
                    break;
                default:
                    articles = articles.OrderByDescending(a => a.ArticleDate);
                    break;
            }

            var result = articles.ToList();

            return result;
        }

        public List<Article> GetPriorityArticles(bool allowHidden = false)
        {
            var articles = _dbContext.Articles
                .Where(a => a.ArticlePriority > 0 
                && ((allowHidden==false)?(a.ArticleStatus == true):true))
                .OrderBy(a => a.ArticlePriority)
                .Include(a => a.Category)
                .Include(a => a.Author)
                .ToList();
            return articles;
        }

        public List<Article> GetTopViewArticles()
        {
            var articles = _dbContext.Articles
                .Where(a => a.ArticleStatus == true)
                .OrderBy(a => a.ViewCounts)
                .Take(4)
                .ToList();
            return articles;
        }

        public Article DetailsArticle(int id)
        {

            var article = _dbContext.Articles
                .Include(a => a.Author)
                .Include(a => a.Category)
                .AsNoTracking()
                .Single(a => a.Id == id && a.ArticleStatus == true);
            return article;
        }

        public void CreateArticle(Article article)
        {

            _dbContext.Add(article);
            _dbContext.SaveChanges();
            Console.WriteLine(article.Id);
        }

        public void UpdateArticle(Article updateArticle)
        {
            var article = _dbContext.Articles.Single(a => a.Id == updateArticle.Id);

            article.ArticleTitle = updateArticle.ArticleTitle;
            article.ArticleDescription = updateArticle.ArticleDescription;
            article.ArticleContent = updateArticle.ArticleContent;
            article.ArticleThumb = updateArticle.ArticleThumb;
            article.CategoryId = updateArticle.CategoryId;
            article.Source = updateArticle.Source;

            _dbContext.SaveChanges();

        }

        public void DeleteArticle(int id)
        {
            var article = new Article { Id = id };
            _dbContext.Remove<Article>(article);
            _dbContext.SaveChanges();
        }

        public void ChangeStatus(int id)
        {
            var article = _dbContext.Articles.Find(id);
            article.ArticleStatus = !article.ArticleStatus;
            _dbContext.SaveChanges();
        }

        public void ChangePriority(int id, int priority)
        {
            var article = _dbContext.Articles.Find(id);
            article.ArticlePriority = priority;
            _dbContext.SaveChanges();
        }

        public void AddViewCount(int id)
        {
            var article = _dbContext.Articles.Find(id);
            article.ViewCounts++;
            _dbContext.SaveChanges();
        }

        public void LikeArticle(int id, bool like)
        {
            var article = _dbContext.Articles.Find(id);
            if (like)
            {
                article.LikeCounts++;
            }
            else if(article.LikeCounts > 0)
            {
                article.LikeCounts--;
            }
            _dbContext.SaveChanges();
        }
    }
}
