using Project_Pinterest.DataContexts;
using Project_Pinterest.Entities;
using Project_Pinterest.Payloads.DataResponses.DataPost;

namespace Project_Pinterest.Payloads.Converters
{
    public class LikeCommentConverter
    {
        private readonly AppDbContext _context;
        public LikeCommentConverter(AppDbContext context)
        {
            _context = context;
        }
        public DataResponseLikeComment EntityToDTO(UserLikeCommentOfPost userLike)
        {
            return new DataResponseLikeComment
            {
                Id = userLike.Id,
                FullName = _context.users.SingleOrDefault(x => x.Id == userLike.UserId).FullName,
                LikeTime = userLike.LikeTime,
                Unlike = userLike.Unlike
            };
        }
    }
}
