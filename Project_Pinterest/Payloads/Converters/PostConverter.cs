using Project_Pinterest.DataContexts;
using Project_Pinterest.Entities;
using Project_Pinterest.Payloads.DataResponses.DataPost;

namespace Project_Pinterest.Payloads.Converters
{
    public class PostConverter
    {
        private readonly AppDbContext _context;
        private readonly CommentConverter _commentConverter;
        private readonly LikeConverter _userLikePost;
        public PostConverter(AppDbContext context, CommentConverter commentConverter, LikeConverter userLikePost)
        {
            _context = context;
            _commentConverter = commentConverter;
            _userLikePost = userLikePost;
        }
        public DataResponsePost EntityToDTO(Post post)
        {
            return new DataResponsePost
            {
                Title = post.Title,
                CreateAt = post.CreateAt,
                UpdateAt = post.UpdateAt,
                Description = post.Description,
                ImageUrl = post.ImageUrl,
                NumberOfComments = post.NumberOfComments,
                NumberOfLikes = post.NumberOfLikes,
                PostStatusName= _context.postsStatus.SingleOrDefault(x => x.Id == post.PostStatusId).Name,
                FullName = _context.users.SingleOrDefault(x => x.Id == post.UserId).FullName,
                DataResponseComments = _context.userCommentPosts.Where(x => x.PostId == post.Id).Select(x => _commentConverter.EntityToDTO(x)),
                DataResponseLikes = _context.userLikePosts.Where(x => x.PostId == post.Id).Select(x => _userLikePost.EntityToDTO(x))
            };
        }
    }
}
