using System.Collections.Generic;
using Nise.Shared;

namespace NorthwindMvc.Models
{
    public class HomeIndexViewModel
    {
        public int VisitorCount;
        public IList<Category> Categories { get; set; }
        public IList<Product> Products { get; set; }   
    }
}