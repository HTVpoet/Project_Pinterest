using Project_Pinterest.Payloads.DataRequests.TokenRequests;
using Project_Pinterest.Payloads.DataRequests.UserRequests;
using Project_Pinterest.Payloads.DataResponses.DataToken;
using Project_Pinterest.Payloads.DataResponses.DataUser;
using Project_Pinterest.Payloads.Responses;

namespace Project_Pinterest.Services.Interfaces
{
    public interface IAuthService
    {
        Task<ResponseObject<DataResponseUser>> Register(Request_Register request);
        Task<ResponseObject<DataResponseToken>> Login(Request_Login request);
        ResponseObject<DataResponseToken> RenewAccessToken(Request_Token request);
        Task<ResponseObject<DataResponseUser>> ConfirmCreateNewPassword(Request_ConfirmNewPassword request);
        Task<string> ForgotPassword(Request_ForgotPassword request);
        Task<string> ConfirmCreateNewAccount(Request_ConfirmCreateNewAccount request);
        Task<string> ChangePassword(int userId, Request_ChangePassword request);
    }
}
