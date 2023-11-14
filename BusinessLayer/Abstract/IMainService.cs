using EntityLayer.Concreate;

namespace BusinessLayer.Abstract;

public interface IMainService
{
    void MainAdd(Main main);

    void MainDelete(Main main);

    void Mainupdate(Main main);

    List<Main> Getlist();

    Main GetbyId(int id);

}