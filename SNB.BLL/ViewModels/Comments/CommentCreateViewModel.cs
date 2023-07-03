using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SNB.BLL.ViewModels.Comments
{
    public class CommentCreateViewModel
    {
        //[Required(ErrorMessage = "Поле Заголовок обязательно для заполнения")]
        //[DataType(DataType.Text)]
        //[Display(Name = "Заголовок", Prompt = "Заголовок")]
        //public string? Title { get; set; }

        [Required(ErrorMessage = "Поле Содержание обязательно для заполнения")]
        [DataType(DataType.Text)]
        [Display(Name = "Содержание", Prompt = "Содержание")]
        public string? Content { get; set; }

        [Required(ErrorMessage = "Поле Автор обязательно для заполнения")]
        [DataType(DataType.Text)]
        [Display(Name = "Автор", Prompt = "Автор")]
        public string? Author { get; set; }

        public Guid PostId;
    }
}
