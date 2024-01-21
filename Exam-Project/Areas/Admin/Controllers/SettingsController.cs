using Exam_Project.Areas.Admin.ViewModels.ServiceVM;
using Exam_Project.Areas.Admin.ViewModels.SettingsVM;
using Exam_Project.Context;
using Exam_Project.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Exam_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SettingsController : Controller
    {
        BoocicDbContext _dbContext { get; }

        public SettingsController(BoocicDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.Settings.ToList());
        }

        public async Task<IActionResult> Update(int id)
        {
            var item = await _dbContext.Settings.FindAsync(id);
            return View(new SettingsUpdateItemVM
            {
                Address = item.Address
            });
        }
        [HttpPost]
        public async Task<IActionResult> Update(int id, SettingsUpdateItemVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            var item = await _dbContext.Settings.FindAsync(id);
            item.Address = vm.Address;
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
