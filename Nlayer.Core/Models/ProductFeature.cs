using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Nlayer.Core.Models
{
    public class ProductFeature
    {
        //public ProductFeature(ProductFeature product)
        //{
        //    Product = product ?? throw new ArgumentNullException(nameof(Product));
        //}

        public int Id { get; set; }
        public string Color { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
