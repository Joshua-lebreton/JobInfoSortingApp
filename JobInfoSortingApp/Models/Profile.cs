namespace JobInfoSortingApp.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string? JobTitle { get; set; }
        public string? Location { get; set; }        
        public List<Skills>? Skills { get; set; }
        public List<Jobs>? Jobs { get; set; }
        public string? Resume { get; set; }
    }
}
