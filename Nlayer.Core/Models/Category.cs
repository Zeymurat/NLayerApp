using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Core.Models
{
    public class Category : BaseEntity
    {
        //public Category(string name)
        //{
        //    Name = name ?? throw new ArgumentNullException(nameof(Name));

        //}
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
