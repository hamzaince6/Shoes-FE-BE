using EntityLayer.Concreate;


namespace BusinessLayer.Abstract;

public interface ICategoryService
{
    void CategoryAdd(Category category);

    void CategoryDelete(Category category);

    void CategoryUpdate(Category category);
    
    List<Category> Getlist();

    Category GetById(int id);
    
}