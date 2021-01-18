
namespace Csharp9

{

    public class Post
    {
        public int userId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public override string ToString()
        {
            return $"{this.userId}- {this.Id}- {this.Title}";
        }
    }

}