using Microsoft.EntityFrameworkCore;
using Products.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        
        public string Name { get; set; }

        
        public Fabricante Fabricante { get; set; }

        
        public Categoria Categoria { get; set; }


        public int Preco { get; set; }
    }
}
