using Project_Pinterest.DataContexts;
using Project_Pinterest.Entities;
using Project_Pinterest.Payloads.DataResponses.DataUser;

namespace Project_Pinterest.Payloads.Converters
{
    public class UserConverter
    {
        private readonly AppDbContext _context;
        public UserConverter(AppDbContext context)
        {
            _context = context;
        }
        public DataResponseUser EntityToDTO(User user)
        {
            return new DataResponseUser
            {
                AvatarUrl = user.AvatarUrl,
                DateOfBirth = user.DateOfBirth,
                Email = user.Email,
                FullName = user.FullName,
                RoleName = _context.roles.SingleOrDefault(x => x.Id == user.RoleId).Name,
                UserName = user.UserName,
                UserStatusName = _context.userStatuses.SingleOrDefault(x => x.Id == user.UserStatusId).Name
            };
        }
    }
}
