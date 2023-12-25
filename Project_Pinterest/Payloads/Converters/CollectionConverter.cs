using Project_Pinterest.DataContexts;
using Project_Pinterest.Entities;
using Project_Pinterest.Payloads.DataResponses.DataCollection;

namespace Project_Pinterest.Payloads.Converters
{
    public class CollectionConverter
    {
        private readonly AppDbContext _context;
        private readonly PostCollectionConverter _converter;


        public CollectionConverter(AppDbContext context, PostCollectionConverter converter)
        {
            _context = context;
            _converter = converter;
        }
        public DataResponseCollection EntityToDTO(Collection collection)
        {
            return new DataResponseCollection()
            {
                Id = collection.Id,
                Name = collection.Name,
                Title = collection.Title,
                UserName = _context.users.SingleOrDefault(x => x.Id == collection.UserId).FullName,
                DataResponsePostCollections = _context.postCollections.Where(x => x.CollectionId == collection.Id).Select(x => _converter.EntityToDTO(x)),
            };
        }
    }
}
