using EntityLayer.Concreate;

namespace DataAccessLayer.Abstract;

public interface IMainDal
{
    List<Main> listAllMain();
    
    void MainAdd(Main main);
    
    void MainDelete(Main main);
    
    void MainUpdate(Main main);

    Main GetById(int id);
}