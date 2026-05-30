namespace LegacySystemsSleuths.Models;

public class ServiceOffering
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required List<string> Bullets { get; set; }
}