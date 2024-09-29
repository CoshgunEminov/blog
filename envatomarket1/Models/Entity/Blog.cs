namespace envatomarket1.Models.Entity
{
    public class Blog
    {
        public int Id { get; set; }
        public string Description {  get; set; }
        public string Title {  get; set; }
        public DateTime Day { get; set; }
        public Category Category { get; set; }
    }
}
