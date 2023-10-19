using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate;

public class MainSocial
{
    [Key]
    public int MainSocialId { get; set; }

    public string MainSocialIcon { get; set; }

    public bool MainIconStatus { get; set; }
    
}