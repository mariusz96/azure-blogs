namespace AzureBlogs.Domain.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;

        public List<Post> Posts { get; } = new();
    }
}
