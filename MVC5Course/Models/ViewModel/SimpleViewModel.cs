using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models.ViewModel
{
    public class SimpleViewModel
    {
        [Required]
        [Display(Name="使用者名稱")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "密碼")]

        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        [Display(Name = "密碼核對")]

        public string ConfirmPassword { get; set; }
        [Required]
        [Display(Name = "年齡")]

        public int age { get; set; }
    }
}