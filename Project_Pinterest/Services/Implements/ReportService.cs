using Microsoft.EntityFrameworkCore;
using Project_Pinterest.DataContexts;
using Project_Pinterest.Entities;
using Project_Pinterest.Handler.HandlePagination;
using Project_Pinterest.Payloads.Converters;
using Project_Pinterest.Payloads.DataRequests.ReportRequests;
using Project_Pinterest.Payloads.DataResponses.DataReport;
using Project_Pinterest.Payloads.Responses;
using Project_Pinterest.Services.Interfaces;

namespace Project_Pinterest.Services.Implements
{
    public class ReportService : IReportService
    {
        private readonly AppDbContext _context;
        private readonly ResponseObject<DataResponseReport> _responseObject;
        private readonly ReportConverter _converter;
        public ReportService(AppDbContext context, ResponseObject<DataResponseReport> responseObject, ReportConverter converter)
        {
            _context = context;
            _responseObject = responseObject;
            _converter = converter;
        }

        public async Task<ResponseObject<DataResponseReport>> CreateReport(int userReportId, Request_CreateReport request)
        {
            var user = await _context.users.SingleOrDefaultAsync(x => x.Id == userReportId && x.IsLocked == false && x.IsActive == true);
            var post = await _context.posts.SingleOrDefaultAsync(x => x.Id == request.PostId && x.IsDeleted == false);
            if(post == null)
            {
                return _responseObject.ResponseError(StatusCodes.Status400BadRequest, "Bài viết không tồn tại", null);
            }
            Report report = new Report
            {
                CreateAt = DateTime.Now,
                PostId = request.PostId,
                Reason = request.Reason,
                UserReportId = userReportId
            };
            await _context.reports.AddAsync(report);
            await _context.SaveChangesAsync();
            var numberOfReport = _context.reports.Count(x => x.PostId ==  request.PostId);
            if(numberOfReport >= 2)
            {
                _context.posts.Remove(post);
                _context.SaveChanges();
            }

            return _responseObject.ResponseSuccess("Báo cáo bài viết thành công", _converter.EntityToDTO(report));
        }

        public async Task<PageResult<DataResponseReport>> GetAllReportByPost(int postId, int pageSize, int pageNumber)
        {
            var query = _context.reports.Include(x => x.Post).AsNoTracking().Where(x => x.PostId == postId).Select(x => _converter.EntityToDTO(x));
            var result = Pagination.GetPagedData(query, pageSize, pageNumber);
            return result;
        }

        public async Task<PageResult<DataResponseReport>> GetAllReports(int pageSize, int pageNumber)
        {
            var query = _context.reports.Include(x => x.Post).AsNoTracking().Select(x => _converter.EntityToDTO(x));
            var result = Pagination.GetPagedData(query, pageSize, pageNumber);
            return result;
        }
    }
}
