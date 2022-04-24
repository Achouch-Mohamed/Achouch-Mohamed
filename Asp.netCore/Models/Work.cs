using System.ComponentModel.DataAnnotations;

namespace Asp.netCore.Models
{
    public class Work
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage ="")]
        [Display(Name ="Project Name :")]
        public string Name { get; set; }
        [Required(ErrorMessage ="")]
        [Display(Name ="Project Desxription :")]
        [StringLength(1000)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please choose profile image")]
        [Display(Name = "Profile Picture")]
        public string Workimage { get; set; }

    }
}
