using EntityLayer.Concreate;

namespace DataAccessLayer.Abstract;

public interface IAboutDal
{
    List<About> listAllAbout();
    
    void AboutAdd(About about);
    
    void AboutDelete(About about);
    
    void AboutUpdate(About about);

    About GetById(int id);
}