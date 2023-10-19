using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace EntityLayer.Concreate;

public class Products
{
    [Key]
    public int ProductsID { get; set; }

    public string ProductsName { get; set; }

    public string ProductsDescription { get; set; }

    public int ProducstPrice { get; set; }

    public bool ProductsStatus { get; set; }
    
}