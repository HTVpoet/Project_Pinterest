namespace Project_Pinterest.Payloads.DataRequests.PostRequests
{
    public class Request_CreatePost
    {
        public string Title { get; set; }
        public IFormFile ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
