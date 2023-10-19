using EntityLayer.Concreate;

namespace DataAccessLayer.Abstract;

public interface IServicesDal
{
    List<Services> listAllServices();
    
    void ServicesAdd(Services services);
    
    void ServicesDelete(Services services);
    
    void ServicesUpdate(Services services);

    Services GetById(int id);
}