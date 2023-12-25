using Project_Pinterest.DataContexts;
using Project_Pinterest.Entities;
using Project_Pinterest.Payloads.DataResponses.DataPost;

namespace Project_Pinterest.Payloads.Converters
{
    public class CommentConverter
    {
        private readonly AppDbContext _context;
        private readonly LikeCommentConverter _likeCommentConverter;

        public CommentConverter(AppDbContext context, LikeCommentConverter likeCommentConverter)
        {
            _context = context;
            _likeCommentConverter = likeCommentConverter;
        }
        public DataResponseComment EntityToDTO(UserCommentPost post)
        {
            return new DataResponseComment
            {
                Id = post.Id,
                CreateAt = DateTime.Now,
                Content = post.Content,
                FullName = _context.users.SingleOrDefault(x => x.Id == post.UserId).FullName,
                NumberOfLikes = post.NumberOfLikes,
                DataResponseLikeComments = _context.userLikeCommentOfPosts.Where(x => x.UserCommentPostId == post.Id).Select(x => _likeCommentConverter.EntityToDTO(x))
            };
        }
    }
}
