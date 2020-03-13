using Abc.Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
