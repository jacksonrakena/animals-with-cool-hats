using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Awch.Site;

public class ImageRecord
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Url { get; set; }
    
    [ScaffoldColumn(false)]
    public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    
    public string Author { get; set; }
}