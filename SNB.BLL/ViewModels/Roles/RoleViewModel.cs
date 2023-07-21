using System.ComponentModel.DataAnnotations;

namespace SNB.BLL.ViewModels.Roles
{
    public class RoleViewModel
    {
        public string? Id { get; set; }

        [Display(Name = "Name")]
        public string? Name { get; set; }

        public bool IsSelected { get; set; }
    }
}
