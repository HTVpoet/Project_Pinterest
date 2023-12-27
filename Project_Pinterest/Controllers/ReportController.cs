using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Pinterest.Handler.HandlePagination;
using Project_Pinterest.Payloads.DataRequests.ReportRequests;
using Project_Pinterest.Payloads.DataResponses.DataReport;
using Project_Pinterest.Services.Interfaces;

namespace Project_Pinterest.Controllers
{
    [Route("api/report")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;
        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }
        [HttpPost("CreateReport")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> CreateReport(Request_CreateReport request)
        {
            int id = int.Parse(HttpContext.User.FindFirst("Id").Value);
            return Ok(await _reportService.CreateReport(id, request));
        }
        [HttpGet("GetAllReportByPost/{postId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllReportByPost([FromRoute] int postId, int pageSize = 10, int pageNumber = 1)
        {
            return Ok(await _reportService.GetAllReportByPost(postId, pageSize, pageNumber));
        }

        [HttpGet("GetAllReports")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllReports(int pageSize = 10, int pageNumber = 1)
        {
            return Ok(await _reportService.GetAllReports(pageSize, pageNumber));
        }
    }
}
