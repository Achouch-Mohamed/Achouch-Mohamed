using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Asp.netCore.Models
{
    public class WorkViewModel
    {
        
        [Required(ErrorMessage = "jjjjj")]
        [Display(Name = "Project Name :")]
        public string Name { get; set; }
        [Required(ErrorMessage = "jjjj")]
        [Display(Name = "Project Desxription :")]
        [StringLength(1000)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please choose profile image")]
        [Display(Name = "Profile Picture")]
        public IFormFile Workimage { get; set; }
    }
}
