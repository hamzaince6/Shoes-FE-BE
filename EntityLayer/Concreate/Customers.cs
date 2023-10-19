using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate;

public class Customers
{
    [Key]
    public int CustomersID { get; set; }
    
    public string CustomersImage { get; set; }
    
    public string CustomersName { get; set; }
    
    public string CustomersDescription { get; set; }

    public bool CustomersStatus { get; set; }
}