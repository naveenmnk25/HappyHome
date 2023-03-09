namespace HappyHome.Models;

public partial class Faq
{
    public int Id { get; set; }

    public string? Heading { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }
}
