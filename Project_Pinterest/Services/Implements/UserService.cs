using Microsoft.EntityFrameworkCore;
using Project_Pinterest.DataContexts;
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
        public UserService(AppDbContext context, ResponseObject<DataResponseUser> responseObject, UserConverter converter)
        {
            _context = context;
            _responseObject = responseObject;
            _converter = converter;
        }

        public async Task<string> DeleteUser(int userId)
        {
            var user = await _context.users.SingleOrDefaultAsync(x => x.Id == userId);
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

        public async Task<ResponseObject<DataResponseUser>> UpdateUser(int userId, Request_UpdateUserInfor request)
        {
            var user = await _context.users.SingleOrDefaultAsync(x => x.Id == userId);
            if(string.IsNullOrEmpty(request.FullName) || string.IsNullOrEmpty(request.Email) || request.DateOfBirth == null)
            {
                return _responseObject.ResponseError(StatusCodes.Status400BadRequest, "Vui lòng điền đầy đủ thông tin", null);
            }
            user.FullName = request.FullName;
            user.Email = request.Email;
            user.DateOfBirth = request.DateOfBirth;
            _context.users.Update(user);
            await _context.SaveChangesAsync();
            return _responseObject.ResponseSuccess("Cập nhật thông tin người dùng thành công", _converter.EntityToDTO(user));
        }
    }
}
