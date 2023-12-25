using Project_Pinterest.Entities;
using Project_Pinterest.Payloads.DataResponses.DataPostCollection;
using Project_Pinterest.Payloads.Responses;
using Project_Pinterest.Services.Interfaces;

namespace Project_Pinterest.Services.Implements
{
    public class PostCollectionService : IPostCollectionService
    {
        public Task<List<PostCollection>> CreateListPostCollection(int userId, int collectionId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseObject<DataResponsePostCollection>> CreatePostCollection(int userId, int collectionId)
        {
            throw new NotImplementedException();
        }
    }
}
