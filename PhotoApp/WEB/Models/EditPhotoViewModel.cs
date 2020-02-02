using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.Models
{
    public class EditPhotoViewModel
    {
        [Required]
        public int ID { get; set; }
        [Required, Display(Name = "Picture Title")]
        public string Title { get; set; }
    }
}
