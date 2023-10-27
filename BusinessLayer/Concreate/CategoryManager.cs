using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concreate;

namespace BusinessLayer.Concreate;

public class CategoryManager: ICategoryService
{
    private GenericRepository<Category> repo = new GenericRepository<Category>();
    public void CategoryAdd(Category category)
    {
        throw new NotImplementedException();
    }

    public void CategoryDelete(Category category)
    {
        if (category.CategoryID != 0)
        {
            repo.Delete(category);
        }
    }

    public void CategoryUpdate(Category category)
    {
        throw new NotImplementedException();
    }

    public List<Category> Getlist()
    {
        throw new NotImplementedException();
    }

    public Category GetById(int id)
    {
        throw new NotImplementedException();
    }
}