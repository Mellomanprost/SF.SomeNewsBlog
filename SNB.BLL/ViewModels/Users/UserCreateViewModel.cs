﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SNB.BLL.ViewModels.Users
{
    public class UserCreateViewModel
    {
        [Required(ErrorMessage = "Поле Имя обязательно для заполнения")]
        [DataType(DataType.Text)]
        [Display(Name = "Имя", Prompt = "Имя")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Поле Фамилия обязательно для заполнения")]
        [DataType(DataType.Text)]
        [Display(Name = "Фамилия", Prompt = "Фамилия")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Поле Никнейм обязательно для заполнения")]
        [DataType(DataType.Text)]
        [Display(Name = "Никнейм", Prompt = "Никнейм")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Поле Почта обязательно для заполнения")]
        [EmailAddress]
        [Display(Name = "Почта")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Поле Пароль обязательно для заполнения")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string? Password { get; set; }

        public Guid Id { get; set; }
    }
}