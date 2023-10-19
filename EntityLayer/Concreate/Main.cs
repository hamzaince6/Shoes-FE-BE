using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using System.Runtime;

namespace EntityLayer.Concreate;

public class Main
{
    [Key]
    public int MainId { get; set; }

    public string MainImage { get; set; }

    public string MainTitle { get; set; }

    public string MainDescription { get; set; }

    public bool MainStatus { get; set; }
    
}