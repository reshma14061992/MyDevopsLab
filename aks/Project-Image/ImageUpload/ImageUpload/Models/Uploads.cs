using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImageUpload.Models
{
    public class Uploads
    {
        [Required(ErrorMessage = "Please choose image")]
        public string ProfilePicture { get; set; }
    }
}
