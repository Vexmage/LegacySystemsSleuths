namespace LegacySystemsSleuths.Models;

public class CaseFile
{
    public required string Title { get; set; }
    public required string Severity { get; set; }
    public required List<string> Symptoms { get; set; }
    public required List<string> Outcomes { get; set; }
}