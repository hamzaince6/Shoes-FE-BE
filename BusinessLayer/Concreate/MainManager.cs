using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;

namespace BusinessLayer.Concreate;

public class MainManager : IMainService
{
    private IMainDal _mainDal;

    public MainManager(IMainDal mainDal)
    {
        _mainDal = mainDal;
    }

    public void MainAdd(Main main)
    {
        throw new NotImplementedException();
    }

    public void MainDelete(Main main)
    {
        throw new NotImplementedException();
    }

    public void Mainupdate(Main main)
    {
        throw new NotImplementedException();
    }

    public List<Main> Getlist()
    {
        return _mainDal.GetListAll();
    }

    public Main GetbyId(int id)
    {
        throw new NotImplementedException();
    }
}