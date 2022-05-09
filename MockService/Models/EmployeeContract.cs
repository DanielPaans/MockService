namespace MockService.Models;

public class EmployeeContract
{
    public Guid Id { get; set; }
    public int Number { get; set; }
    public string? ScheduleCompetence { get; set; } = string.Empty;
    public DateTime? TrialPeriodEnd { get; set; }
    public DateTime ValidFrom { get; set; }
    public DateTime ValidTo { get; set; }
}