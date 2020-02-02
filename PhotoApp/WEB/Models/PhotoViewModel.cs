using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.Models
{
    public class PhotoViewModel
    {
        public IEnumerable<Photo> Photos { get; set; } = new List<Photo>();
    }
}
