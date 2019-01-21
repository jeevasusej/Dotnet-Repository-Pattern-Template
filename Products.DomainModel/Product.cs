using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Products.DomainModel
{
    public class Product
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public IList<UserProduct> UserProducts { get; set; }
    }
}
