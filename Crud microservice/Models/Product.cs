using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_microservice.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dscription { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
