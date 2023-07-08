using BlogWebsite.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebsite.ViewComponents
{
    public class BreakingNewsViewComponent : ViewComponent
    {
        private readonly ArticlesService _articlesService;
        public BreakingNewsViewComponent(ArticlesService articlesService)
        {
            _articlesService = articlesService;
        }
        public IViewComponentResult Invoke()
        {
            var articles = _articlesService.GetPriorityArticles();
            return View(articles);
        }
    }
}
