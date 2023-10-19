using EntityLayer.Concreate;

namespace DataAccessLayer.Abstract;

public interface IProductsDal
{
    List<Products> ListAllProducts();
    
    void ProductsAdd(Products products);
    
    void ProductsDelete(Products products);
    
    void ProductsUpdate(Products products);

    Products GetById(int id);
}