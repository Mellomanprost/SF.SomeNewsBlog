using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeNewsBlog.BLL.Models
{
    public class RoleModel
    {
        public string? Description { get; set; }

        public RoleModel(RoleModel role)
        {
            this.Description = role.Description;
        }
    }
}
