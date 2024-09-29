namespace envatomarket1.Models.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Blog> Blogs { get; set; }
    }
}
