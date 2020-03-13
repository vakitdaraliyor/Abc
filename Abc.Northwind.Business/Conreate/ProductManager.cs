using Abc.Northwind.Business.Abstract;
using Abc.Northwind.DataAccess.Abstract;
using Abc.Northwind.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Northwind.Business.Conreate
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId);
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(int id)
        {
            _productDal.Delete(new Product { ProductId = id});
        }
    }
}
