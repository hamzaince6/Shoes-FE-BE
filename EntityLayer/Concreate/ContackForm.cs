using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate;

public class ContackForm
{
    [Key]
    public int ContackFormId { get; set; }
    
    public string ContackFormImage { get; set; }
    
    public string ContackFormBgImage { get; set; }

    public string ContackFormUsername { get; set; }
    
    public string ContackFormPassword { get; set; }

    public bool ContackFormStatus { get; set; }
    
}