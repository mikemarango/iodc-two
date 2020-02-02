using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB.Models
{
    public class OrderPhotoViewModel
    {
        public OrderPhotoViewModel(string address)
        {
            Address = address;
        }

        public string Address { get; set; } = string.Empty;
    }
}
