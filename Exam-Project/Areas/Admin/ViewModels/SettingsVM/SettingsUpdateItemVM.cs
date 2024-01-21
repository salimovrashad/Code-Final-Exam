using System.ComponentModel.DataAnnotations;

namespace Exam_Project.Areas.Admin.ViewModels.SettingsVM
{
    public class SettingsUpdateItemVM
    {
        [Required]
        public string Address { get; set; }
    }
}
