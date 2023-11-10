using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using EntityLayer.Concreate;

namespace DataAccessLayer.Repositories;

public class ContackFormRepository : IContackFormDal
{
    private Context c = new Context();
    public List<ContackForm> listAllContackForm()
    {
        return c.ContackForms.ToList();
    }

    public void ContackFormAdd(ContackForm contackForm)
    {
        c.Add(contackForm);
        c.SaveChanges();
    }

    public void ContackFormDelete(ContackForm contackForm)
    {
        c.Remove(contackForm);
        c.SaveChanges();
    }

    public void ContackFormUpdate(ContackForm contackForm)
    {
        c.Update(contackForm);
        c.SaveChanges();
    }

    public ContackForm GetById(int id)
    {
        return c.ContackForms.Find(id);
    }

    public void Insert(ContackForm t)
    {
        throw new NotImplementedException();
    }

    public void Delete(ContackForm t)
    {
        throw new NotImplementedException();
    }

    public void Update(ContackForm t)
    {
        throw new NotImplementedException();
    }

    public List<ContackForm> GetListAll()
    {
        throw new NotImplementedException();
    }

    public ContackForm GetByID(int id)
    {
        throw new NotImplementedException();
    }
}