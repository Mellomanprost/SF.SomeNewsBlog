using SNB.BLL.ViewModels.Tags;
using System.ComponentModel.DataAnnotations;

namespace SNB.BLL.ViewModels.Posts
{
    public class PostEditViewModel
    {
        public Guid Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Заголовок", Prompt = "Заголовок")]
        public string? Title { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Контент", Prompt = "Контент")]
        public string? Content { get; set; }

        [Display(Name = "Теги", Prompt = "Теги")]
        public List<TagViewModel>? Tags { get; set; }
    }
}
