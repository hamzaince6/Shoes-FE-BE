using EntityLayer.Concreate;

namespace DataAccessLayer.Abstract;

public interface IContackFormDal
{
    List<ContackForm> listAllContackForm();
    
    void ContackFormAdd(ContackForm contackForm);
    
    void ContackFormDelete(ContackForm contackForm);
    
    void ContackFormUpdate(ContackForm contackForm);

    ContackForm GetById(int id);
}