public class Job
{
    public Guid Id {get; set;}

    public string Name {get; set;} = string.Empty;

    public string Payload {get; set;} = string.Empty;

    public JobStatus status {get; set;}

    public DateTime CreatedAt {get; set;}

    public DateTime? StartedAt {get; set;}

    public DateTime? CompletedAt {get; set;}

    public string? ErrorMessage {get; set;} 


}