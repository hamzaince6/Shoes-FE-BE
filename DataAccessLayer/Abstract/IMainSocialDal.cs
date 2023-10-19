using EntityLayer.Concreate;

namespace DataAccessLayer.Abstract;

public interface IMainSocialDal
{
    List<MainSocial> listAllMainSocial();
    
    void MainSocialAdd(MainSocial mainSocial);
    
    void MainSocialDelete(MainSocial mainSocial);
    
    void MainSocialUpdate(MainSocial mainSocial);

    MainSocial GetById(int id);
}