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
}