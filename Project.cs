namespace BugTrackerAPI.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime StartDate { get; set; } = DateTime.Now;
        public int CreatedBy { get; set; }
    }
}