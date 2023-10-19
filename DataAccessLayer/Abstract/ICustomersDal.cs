using EntityLayer.Concreate;

namespace DataAccessLayer.Abstract;

public interface ICustomersDal
{
    List<Customers> listAllCustomers();
    
    void CustomersAdd(Customers customers);
    
    void CustomersDelete(Customers customers);
    
    void CustomersUpdate(Customers customers);

    Customers GetById(int id);
}