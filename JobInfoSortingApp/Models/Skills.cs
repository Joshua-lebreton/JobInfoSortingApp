namespace JobInfoSortingApp.Models
{
    public class Skills
    {
        public int SkillsId { get; set; }
        public string SkillName { get; set; }
        public string SkillType { get; set; }
        public List<Profile>? Profiles { get; set; }
    }
}
