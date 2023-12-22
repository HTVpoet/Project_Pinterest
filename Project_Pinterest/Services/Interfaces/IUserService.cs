using Project_Pinterest.Handler.HandlePagination;
using Project_Pinterest.Payloads.DataRequests.UserRequests;
using Project_Pinterest.Payloads.DataResponses.DataUser;
using Project_Pinterest.Payloads.Responses;

namespace Project_Pinterest.Services.Interfaces
{
    public interface IUserService
    {
        Task<ResponseObject<DataResponseUser>> UpdateUser(int userId, Request_UpdateUserInfor request);
        Task<string> DeleteUser(int userId);
        Task<PageResult<DataResponseUser>> GetAllUsers(int pageSize, int pageNumber);
        Task<PageResult<DataResponseUser>> GetUserByName(string? name, int pageSize, int pageNumber);
    }
}
