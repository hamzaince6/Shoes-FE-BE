using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate;

public class About
{
    [Key]
    public int AboutId { get; set; }
    
    public string AboutImage  { get; set; }
    
    public string AboutDescription  { get; set; }

    public bool AboutStatus { get; set; }
}