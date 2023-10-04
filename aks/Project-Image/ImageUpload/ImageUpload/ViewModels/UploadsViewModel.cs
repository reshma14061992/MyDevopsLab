using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImageUpload.ViewModels
{
    public class UploadsViewModel
    {
        [Required(ErrorMessage = "Please choose  image")]
        [Display(Name = "Picture")]
        public IFormFile ProfileImage { get; set; }
    }
}
