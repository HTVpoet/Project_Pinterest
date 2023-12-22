using Project_Pinterest.DataContexts;
using Project_Pinterest.Entities;
using Project_Pinterest.Payloads.DataResponses.DataPost;

namespace Project_Pinterest.Payloads.Converters
{
    public class LikeConverter
    {
        private readonly AppDbContext _context;
        public LikeConverter(AppDbContext context)
        {
            _context = context;
        }
        public DataResponseLike EntityToDTO(UserLikePost likePost)
        {
            return new DataResponseLike
            {
                FullName = _context.users.SingleOrDefault(x => x.Id == likePost.UserId).FullName,
                LikeTime = likePost.LikeTime,
                Unlike = likePost.Unlike
            };
        }
    }
}
