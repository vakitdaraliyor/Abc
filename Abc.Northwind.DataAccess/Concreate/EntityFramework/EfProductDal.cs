using Abc.Core.DataAccess.EntityFramework;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.DataAccess.Concreate.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
    }
}
