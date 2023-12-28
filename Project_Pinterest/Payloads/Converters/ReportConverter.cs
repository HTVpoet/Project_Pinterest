using Microsoft.EntityFrameworkCore;
using Project_Pinterest.DataContexts;
using Project_Pinterest.Entities;
using Project_Pinterest.Payloads.DataResponses.DataReport;

namespace Project_Pinterest.Payloads.Converters
{
    public class ReportConverter
    {
        private readonly AppDbContext _context;
        public ReportConverter(AppDbContext context)
        {
            _context = context;
        }
        public DataResponseReport EntityToDTO(Report report)
        {
            var reportItem = _context.reports.Include(x => x.UserReport).AsNoTracking().SingleOrDefault(x => x.Id == report.Id);
            return new DataResponseReport
            {
                CreateAt = report.CreateAt,
                PostId = report.PostId,
                Reason = report.Reason,
                UserReportName = reportItem.UserReport.FullName
            };
        }
    }
}
