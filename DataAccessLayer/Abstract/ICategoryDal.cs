using EntityLayer.Concreate;

namespace DataAccessLayer.Abstract;

public interface ICategoryDal
{
    List<Category> ListAllCategory();
    
    void CategoryAdd(Category category);
    
    void CategoryDelete(Category category);
    
    void CategoryUpdate(Category category);

    Category GetById(int id);

}