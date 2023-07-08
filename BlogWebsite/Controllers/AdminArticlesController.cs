using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using BlogWebsite.Models;
using BlogWebsite.Services;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using PagedList;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace BlogWebsite.Controllers
{
    [Authorize]
    public class AdminArticlesController : Controller
    {
        private readonly ArticlesService _articlesService;
        private readonly CategoriesService _categoriesService;
        private readonly FileService _fileService;

        public AdminArticlesController(ArticlesService articlesService, CategoriesService categoriesService, FileService fileService)
        {
            _articlesService = articlesService;
            _categoriesService = categoriesService;
            _fileService = fileService;
        }

        [Route("Admin/Articles/{page?}")]
        public async Task<IActionResult> Index(string q, string? sortOrder, int? categoryId, int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 5;
            List<Article> articles;

            if (User.IsInRole("Admin"))
            {
                articles = _articlesService.GetArticles(q, sortOrder, categoryId, null, true);
            }
            else
            {
                int authorId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                articles = _articlesService.GetArticles(q, sortOrder, categoryId, authorId);
            }

            List<string> order = new List<string> { "date", "date_desc", "title", "title_desc" };

            ViewBag.SearchString = q;
            ViewBag.CategorySelectlist = new SelectList(_categoriesService.GetCategories(), "Id", "CategoryName", categoryId);
            ViewBag.OrderSelectlist = new SelectList(order, sortOrder);
            return View(articles.ToPagedList(pageNumber, pageSize));
        }

        [Route("Admin/EditArticle/{id}")]
        public async Task<IActionResult> Edit(int id)
        {

            var article = _articlesService.DetailsArticle(id);

            ViewBag.CategorySelectlist = new SelectList(_categoriesService.GetCategories(), "Id", "CategoryName", article.CategoryId);

            return View(article);
        }

        [HttpPost]
        [Route("Admin/EditArticle/{id}")]
        public async Task<IActionResult> Edit([Bind("Id,ArticleTitle,ArticleDescription,ArticleContent,ArticleThumb,CategoryId,Source")] Article updateArticle)
        {
            int authorId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            if (User.IsInRole("Admin") || authorId == updateArticle.AuthorId)
            {
                TempData["Message"] = "Sửa thành công";
                _articlesService.UpdateArticle(updateArticle);
            }
            else
            {
                return Redirect("/Admin/Articles");
            }

            return Redirect("/Admin/Articles"); ;
        }

        [Route("Admin/DeleteArticle/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            int authorId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var article = _articlesService.DetailsArticle(id);
            if (User.IsInRole("Admin") || article.AuthorId == authorId)
            {
                TempData["Message"] = "Xoá thành công";
                _articlesService.DeleteArticle(id);
            }
            else
            {
                return Redirect("/Admin/Articles");
            }
            return Redirect("/Admin/Articles");
        }

        [Route("Admin/CreateArticle")]
        public IActionResult Create()
        {
            ViewBag.CategorySelectlist = new SelectList(_categoriesService.GetCategories(), "Id", "CategoryName");
            return View();
        }


        [HttpPost]
        [Route("Admin/CreateArticle")]
        public async Task<IActionResult> Create([Bind("ArticleTitle,ArticleDescription,ArticleContent,ArticleThumb,CategoryId,Source")] Article article)
        {
            int authorId = Int32.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            article.AuthorId = authorId;
            _articlesService.CreateArticle(article);
            TempData["Message"] = "Tạo thành công";
            return Redirect("/Admin/Articles");
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [Route("Admin/ActiveArticle/{id}")]
        public IActionResult Active(int id)
        {
            _articlesService.ChangeStatus(id);
            return Ok("Thay đổi trạng thái bài viết thành công");
        }
        [Authorize(Roles = "Admin")]
        [Route("Admin/BreakingNews")]
        public IActionResult ChangePriority()
        {
            var articles = _articlesService.GetPriorityArticles(true);
            return View(articles);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [Route("Admin/ChangePriority")]
        public async Task<IActionResult> ChangePriority(int id, int priority)
        {
            _articlesService.ChangePriority(id, priority);
            if(priority != 0)
            {
                TempData["Message"] = "Thay đổi thành công";
            }
            else
            {
                TempData["Message"] = "Xoá thành công";
            }
            return Redirect("/Admin/BreakingNews");
        }

        [HttpPost]
        [Authorize]
        [Route("Admin/UploadImage")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            string path = _fileService.Upload(file);
            return Ok(path);
        }

    }
}
