using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate;

public class Services
{
    [Key]
    public int ServicesId { get; set; }
    
    public string ServicesIcon { get; set; }
    
    public string ServicesTitle { get; set; }
    
    public string ServicesDescription { get; set; }

    public bool ServicesStatus { get; set; }
}