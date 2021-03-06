namespace CountyRP.Services.Forum.Infrastructure.Models
{
    public class TopicDtoIn
    {
        public string Caption { get; }

        public int ForumId { get; }

        public TopicDtoIn(
            string caption,
            int forumId
        )
        {
            Caption = caption;
            ForumId = forumId;
        }
    }
}
