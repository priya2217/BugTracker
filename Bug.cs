namespace BugTrackerAPI.Models
{
public class Bug
{
    public int BugId { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Status { get; set; } = "Open"; 
    public string Severity { get; set; } = "Medium"; 
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public int Project{ get; set; }
    public int Assignee { get; set; }
    public int Creator { get; set; }
}
}

