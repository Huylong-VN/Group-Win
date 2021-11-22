using Management_St.Data.DbContext;
using Management_St.Data.Dto.Classes;
using Management_St.Data.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management_St.Controllers
{
    public class ClassController : Controller
    {
        private readonly ManagementDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;

        public ClassController(ManagementDbContext dbContext, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var listClass = _dbContext.Classes.Select(x => new ClassDto()
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
            return View(listClass);
        }

        [HttpPost]
        public IActionResult Create(Class @class)
        {
            @class.CreateTime = DateTime.Now;
            //@class.CreatorId = new Guid(_userManager.GetUserId(this.User));
            _dbContext.Classes.Add(@class);
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