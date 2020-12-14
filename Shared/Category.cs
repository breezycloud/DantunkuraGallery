using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DantunkuraGallery.Shared
{
    public class Category
    {
        public Guid CategoryNo { get; set; }
        [Required(ErrorMessage = "Category Name field is required")]
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
