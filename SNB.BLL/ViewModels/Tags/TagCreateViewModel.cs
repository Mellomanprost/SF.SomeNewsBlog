﻿using System.ComponentModel.DataAnnotations;

namespace SNB.BLL.ViewModels.Tags
{
    public class TagCreateViewModel
    {
        [Required(ErrorMessage = "Поле Название обязательно для заполнения")]
        [DataType(DataType.Text)]
        [Display(Name = "Название", Prompt = "Название")]
        public string? Name { get; set; }
    }
}
