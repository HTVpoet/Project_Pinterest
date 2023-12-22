using Microsoft.AspNetCore.Http;

namespace Project_Pinterest.Payloads.DataRequests.UserRequests
{
    public class Request_UpdateAvatar
    {
        public IFormFile Avatar { get; set; }
    }
}
