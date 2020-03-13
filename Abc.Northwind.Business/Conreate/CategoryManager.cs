using Abc.Northwind.Business.Abstract;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Business.Conreate
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
