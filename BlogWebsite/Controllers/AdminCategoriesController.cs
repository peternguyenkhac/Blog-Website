using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BlogWebsite.Models;
using BlogWebsite.Services;
using Microsoft.AspNetCore.Authorization;

namespace BlogWebsite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminCategoriesController : Controller
    {
        private readonly CategoriesService _categoriesService;

        public AdminCategoriesController(CategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        [Route("Admin/Categories")]
        public async Task<IActionResult> Index()
        {
            var categories = _categoriesService.GetCategories();
            return View(categories);
        }

        [Route("Admin/EditCategory/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var category = _categoriesService.DetailsCategory(id);
            return View(category);
        }

        [HttpPost]
        [Route("Admin/EditCategory/{id}")]
        public IActionResult Edit([Bind("Id,CategoryName,CategoryDescription")] Category updateCategory)
        {
            _categoriesService.UpdateCategory(updateCategory);
            TempData["Message"] = "Sửa thành công";
            return Redirect("/Admin/Categories");
        }

        [Route("Admin/DeleteCategory/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _categoriesService.DeleteCategory(id);
            TempData["Message"] = "Xoá thành công";
            return Redirect("/Admin/Categories");
        }
        [Route("Admin/CreateCategory")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Route("Admin/CreateCategory")]
        public async Task<IActionResult> Create([Bind("CategoryName,CategoryDescription")] Category category)
        {
            _categoriesService.CreateCategory(category);
            TempData["Message"] = "Tạo thành công";
            return Redirect("/Admin/Categories");
        }

      
    }
}
