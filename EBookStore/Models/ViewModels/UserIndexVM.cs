﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookStore.Models.ViewModels
{
    internal class UserIndexVM
    {
        [DisplayName("使用者id")]
        public int Id { get; set; }
        [DisplayName("帳號")]
        public string Account { get; set; }
        [DisplayName("密碼")]
        public string Password { get; set; }
        [DisplayName("使用者")]
        public string Name { get; set; }
    }
    public class UserVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "帳號必填")]
        public string Account { get; set; }
        [Required(ErrorMessage = "密碼必填")]
        public string Password { get; set; }
        [Required(ErrorMessage = "姓名必填")]
        public string Name { get; set; }
    }
}
