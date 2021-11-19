using Management_St.Data.DbContext;
using Management_St.Data.Dto.Categories;
using Management_St.Data.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management_St.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ManagementDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;

        public CategoryController(ManagementDbContext dbContext, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var listCategory = _dbContext.Categories.Select(x => new CategoryDto()
            {
                CreateTime = x.CreateTime,
                CreatorId = x.CreatorId,
                DeletorId = x.DeletorId,
                Description = x.Description,
                Id = x.Id,
                Name = x.Name,
                UpdaterId = x.UpdaterId,
                UpdateTime = x.UpdateTime
            });
            return View(listCategory);
        }
        [HttpPost]
        public IActionResult Create(Category @category)
        {
            @category.CreateTime = DateTime.Now;
            //@class.CreatorId = new Guid(_userManager.GetUserId(this.User));
            _dbContext.Categories.Add(@category);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
