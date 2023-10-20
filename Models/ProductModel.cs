using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProductModel
    {
        [DisplayName("Products Id")]
        public int Id { get; set; }

        [DisplayName("Products Name")]
        [Required(ErrorMessage = "Products name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Products name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Products observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Products observation must be between 3 and 200 characters")]
        public string Observation { get; set; }
    }
}
