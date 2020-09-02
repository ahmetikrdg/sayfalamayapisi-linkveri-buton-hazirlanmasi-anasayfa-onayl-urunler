using System.Collections.Generic;
using bookpage.entity;

namespace bookpage.data.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        Product GetProductpageDetails(int id);
        List<Product> GetProductsByCategory(string name);
        Product GetProductDetails(string url);
        List<Product> GetProductsByCategory(string name, int page,int pageSize);
        int GetCountByCategory(string category);
        List<Product> GetHomePageProducts();
        List<Product> GetPopularProducts();
    }
}