namespace Project_Pinterest.Payloads.DataResponses.DataPost
{
    public class DataResponsePost
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string FullName { get; set; }
        public int? NumberOfLikes { get; set; }
        public int? NumberOfComments { get; set; }
        public string PostStatusName { get; set; }
        public IQueryable<DataResponseComment>? DataResponseComments { get; set; }
        public IQueryable<DataResponseLike>? DataResponseLikes { get; set; }
    }
}
