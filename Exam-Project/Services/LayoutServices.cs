using Exam_Project.Context;
using Exam_Project.Models;

namespace Exam_Project.Services
{
    public class LayoutServices
    {
        BoocicDbContext _context { get; }
        public LayoutServices(BoocicDbContext context)
        {
            _context = context;
        }
        public async Task<Settings> GetSettingsAsync() => await _context.Settings.FindAsync(1);
    }
}
