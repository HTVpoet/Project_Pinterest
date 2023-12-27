using Microsoft.EntityFrameworkCore;
using Project_Pinterest.DataContexts;
using Project_Pinterest.Entities;
using Project_Pinterest.Handler.HandleImage;
using Project_Pinterest.Handler.HandlePagination;
using Project_Pinterest.Payloads.Converters;
using Project_Pinterest.Payloads.DataRequests.UserRequests;
using Project_Pinterest.Payloads.DataResponses.DataUser;
using Project_Pinterest.Payloads.Responses;
using Project_Pinterest.Services.Interfaces;

namespace Project_Pinterest.Services.Implements
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        private readonly ResponseObject<DataResponseUser> _responseObject;
        private readonly UserConverter _converter;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserService(AppDbContext context, ResponseObject<DataResponseUser> responseObject, UserConverter converter, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _responseObject = responseObject;
            _converter = converter;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> ChangeDecentralization(Request_ChangeDecentralization request)
        {
            var user = await _context.users.SingleOrDefaultAsync(x => x.Id == request.UserId);
            if (user is null)
            {
                return "Không tìm thấy id người dùng";
            }
            var currentUser = _httpContextAccessor.HttpContext.User;

            if (!currentUser.Identity.IsAuthenticated)
            {
                return "Người dùng không được xác thực hoặc không được xác định";
            }

            if (!currentUser.IsInRole("Admin"))
            {
                return "Người dùng không có quyền sử dụng chức năng này";
            }
            user.RoleId = request.RoleId;
            _context.users.Update(user);
            await _context.SaveChangesAsync();
            return "Thay đổi quyền người dùng thành công";
        }

        public async Task<string> DeleteUser(int userId)
        {
            var user = await _context.users.SingleOrDefaultAsync(x => x.Id == userId && x.IsLocked == false && x.IsActive == true);
            if(user is null)
            {
                return "Người dùng không tồn tại";
            }
            user.IsActive = false;
            _context.users.Update(user);
            await _context.SaveChangesAsync();
            return "Xóa thông tin người dùng thành công";
        }

        public async Task<PageResult<DataResponseUser>> GetAllUsers(int pageSize, int pageNumber)
        {
            var query = _context.users.Select(x => _converter.EntityToDTO(x));
            var result = Pagination.GetPagedData(query, pageSize, pageNumber);
            return result;
        }

        public async Task<PageResult<DataResponseUser>> GetUserByName(string? name, int pageSize, int pageNumber)
        {
            var query = _context.users.Where(x => x.FullName.Trim().ToLower().Contains(name.Trim().ToLower())).Select(x => _converter.EntityToDTO(x));
            var result = Pagination.GetPagedData(query, pageSize, pageNumber);
            return result;
        }

        public async Task<string> LockAccount(int adminId, int userLockedId)
        {
            var admin = await _context.users.SingleOrDefaultAsync(x => x.Id == adminId && x.IsActive == true && x.IsLocked == false);
            var userLocked = await _context.users.SingleOrDefaultAsync(x => x.Id == userLockedId && x.IsActive == true && x.IsLocked == false);
            var currentUser = _httpContextAccessor.HttpContext.User;

            if (!currentUser.Identity.IsAuthenticated)
            {
                return "Người dùng không được xác thực hoặc không được xác định";
            }

            if (!currentUser.IsInRole("Admin"))
            {
                return "Người dùng không có quyền sử dụng chức năng này";
            }
            if (userLocked == null)
            {
                return "Người dùng không tồn tại";
            }
            if(userLocked.IsLocked == true)
            {
                return "Tài khoản này đã bị khóa";
            }
            userLocked.IsLocked = true;
            _context.users.Update(userLocked);
            await _context.SaveChangesAsync();
            return "Khóa tài khoản người dùng thành công";
        }

        public async Task<string> UnLockAccount(int adminId, int userUnLockedId)
        {
            var admin = await _context.users.SingleOrDefaultAsync(x => x.Id == adminId && x.IsActive == true && x.IsLocked == false);
            var userLocked = await _context.users.SingleOrDefaultAsync(x => x.Id == userUnLockedId);
            var currentUser = _httpContextAccessor.HttpContext.User;

            if (!currentUser.Identity.IsAuthenticated)
            {
                return "Người dùng không được xác thực hoặc không được xác định";
            }

            if (!currentUser.IsInRole("Admin"))
            {
                return "Người dùng không có quyền sử dụng chức năng này";
            }
            if (userLocked == null)
            {
                return "Người dùng không tồn tại";
            }
            if (userLocked.IsLocked == false)
            {
                return "Tài khoản này chưa bị khóa";
            }
            userLocked.IsLocked = false;
            _context.users.Update(userLocked);
            await _context.SaveChangesAsync();
            return "Mở khóa tài khoản người dùng thành công";
        }

        public async Task<ResponseObject<DataResponseUser>> UpdateUser(int userId, Request_UpdateUserInfor request)
        {
            var user = await _context.users.SingleOrDefaultAsync(x => x.Id == userId && x.IsLocked == false && x.IsActive == true);
            if(string.IsNullOrEmpty(request.FullName) || string.IsNullOrEmpty(request.Email) || request.DateOfBirth == null)
            {
                return _responseObject.ResponseError(StatusCodes.Status400BadRequest, "Vui lòng điền đầy đủ thông tin", null);
            }
            user.FullName = request.FullName;
            user.Email = request.Email;
            user.AvatarUrl = await HandleUploadImage.UpdateFile(user.AvatarUrl, request.Avatar);
            user.DateOfBirth = request.DateOfBirth;
            _context.users.Update(user);
            await _context.SaveChangesAsync();
            return _responseObject.ResponseSuccess("Cập nhật thông tin người dùng thành công", _converter.EntityToDTO(user));
        }


    }
}
