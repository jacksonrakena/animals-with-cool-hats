using System.ComponentModel.DataAnnotations.Schema;

namespace Awch.Site;

public class ImageRecord
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Url { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    public string Author { get; set; }
}