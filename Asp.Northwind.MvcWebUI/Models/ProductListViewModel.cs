using Abc.Northwind.Entities.Concreate;
using System.Collections.Generic;

namespace Asp.Northwind.MvcWebUI
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; internal set; }
    }
}