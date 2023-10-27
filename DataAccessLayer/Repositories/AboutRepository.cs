using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using EntityLayer.Concreate;

namespace DataAccessLayer.Repositories;

public class AboutRepository : IAboutDal
{
    public List<About> listAllAbout()
    {
        using var c = new Context();
        return c.Abouts.ToList();
    }

    public void AboutAdd(About about)
    {
        using var c = new Context();
        c.Add(about);
        c.SaveChanges();
    }

    public void AboutDelete(About about)
    {
        using var c = new Context();
        c.Remove(about);
        c.SaveChanges();
    }

    public void AboutUpdate(About about)
    {
        using var c = new Context();
        c.Update(about);
        c.SaveChanges();
    }

    public About GetById(int id)
    {
        using var c = new Context();
        return c.Abouts.Find(id);
    }

    public void Insert(About t)
    {
        throw new NotImplementedException();
    }

    public void Delete(About t)
    {
        throw new NotImplementedException();
    }

    public void Update(About t)
    {
        throw new NotImplementedException();
    }

    public List<About> GetListAll()
    {
        throw new NotImplementedException();
    }

    public About GetByID(int id)
    {
        throw new NotImplementedException();
    }
}