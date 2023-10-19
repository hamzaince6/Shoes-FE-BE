using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate;

public class Category
{
    // Erişim Belirleyici Türü Değişken Türü İsim {get; set;}
    
    [Key]
    public int CategoryID { get; set; }
    
    public string CategoryName { get; set; }

    public bool CategoryStatus { get; set; }
    
    
    
}