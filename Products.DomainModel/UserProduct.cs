using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Products.DomainModel
{
    public class UserProduct
    {
        [Required]
        public long UserId { get; set; }

        [Required]
        public long ProductId { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
    }
}
