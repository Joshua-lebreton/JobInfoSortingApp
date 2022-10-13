using System.Security.Policy;

namespace JobInfoSortingApp.Models
{
    public class Jobs
    {
        public int JobsId { get; set; }
        public string JobName { get; set; }
        public Boolean JobStatus { get; set; }
        public string? JobLocation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string JobTitle { get; set; }
        public string? Refrence { get; set; }


    }
}
