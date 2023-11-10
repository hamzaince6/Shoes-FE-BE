using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using EntityLayer.Concreate;

namespace DataAccessLayer.Repositories;

public class CategoryRepository: ICategoryDal
{
    private Context c = new Context();
    public List<Category> ListAllCategory()
    {
        return c.Categories.ToList();
    }
    
    public void CategoryAdd(Category category)
    {
        c.Add(category);
        c.SaveChanges();
    }
    
    public void CategoryDelete(Category category)
    {
        c.Remove(category);
        c.SaveChanges();
    }

    public void CategoryUpdate(Category category)
    {
        c.Update(category);
        c.SaveChanges();
    }

    public Category GetById(int id)
    {
        return c.Categories.Find(id);
    }

    public void Insert(Category t)
    {
        throw new NotImplementedException();
    }

    public void Delete(Category t)
    {
        throw new NotImplementedException();
    }

    public void Update(Category t)
    {
        throw new NotImplementedException();
    }

    public List<Category> GetListAll()
    {
        throw new NotImplementedException();
    }

    public Category GetByID(int id)
    {
        throw new NotImplementedException();
    }
}