namespace Project_Pinterest.Payloads.DataRequests.PostRequests
{
    public class Request_UpdatePost
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public IFormFile ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
