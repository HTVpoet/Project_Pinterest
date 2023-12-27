using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Pinterest.Handler.HandlePagination;
using Project_Pinterest.Payloads.DataRequests.PostRequests;
using Project_Pinterest.Payloads.DataResponses.DataPost;
using Project_Pinterest.Payloads.Responses;
using Project_Pinterest.Services.Interfaces;

namespace Project_Pinterest.Controllers
{
    [Route("api/post")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        [HttpPost("CreatePost")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Consumes(contentType: "multipart/form-data")]
        public async Task<IActionResult> CreatePost([FromForm] Request_CreatePost request)
        {
            int id = int.Parse(HttpContext.User.FindFirst("Id").Value);
            return Ok(await _postService.CreatePost(id, request));
        }
        [HttpPut("DeletePost/{postId}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeletePost([FromRoute] int postId)
        {
            int id = int.Parse(HttpContext.User.FindFirst("Id").Value);
            return Ok(await _postService.DeletePost(id, postId));
        }
        [HttpGet("GetAllPost")]
        public async Task<IActionResult> GetAllPost(int pageSize = 10, int pageNumber = 1)
        {
            return Ok(await _postService.GetAllPost(pageSize, pageNumber));
        }
        [HttpGet("GetPostByUser")]
        public async Task<IActionResult> GetPostByUser(int userId, int pageSize = 10, int pageNumber = 1)
        {
            return Ok(await _postService.GetPostByUser(userId, pageSize, pageNumber));
        }
        [HttpPut("UpdatePost")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Consumes(contentType: "multipart/form-data")]
        public async Task<IActionResult> UpdatePost([FromForm] Request_UpdatePost request)
        {
            int id = int.Parse(HttpContext.User.FindFirst("Id").Value);
            return Ok(await _postService.UpdatePost(id, request));
        }
        [HttpPost("CreateComment")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> CreateComment(Request_CreateComment request)
        {
            int id = int.Parse(HttpContext.User.FindFirst("Id").Value);
            return Ok(await _postService.CreateComment(id, request));
        }
        [HttpPut("DeleteComment")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> DeleteComment(Request_DeleteComment request)
        {
            int id = int.Parse(HttpContext.User.FindFirst("Id").Value);
            return Ok(await _postService.DeleteComment(id, request));
        }
        [HttpGet("GetCommentByUser/{userId}")]
        public async Task<IActionResult> GetCommentByUser([FromRoute] int userId, int pageSize = 10, int pageNumber = 1)
        {
            return Ok(await _postService.GetCommentByUser(userId, pageSize, pageNumber));
        }
        [HttpGet("GetPostById/{postId}")]
        public async Task<IActionResult> GetPostById([FromRoute] int postId)
        {
            return Ok(await _postService.GetPostById(postId));
        }
        [HttpPost("LikePost")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> LikePost(Request_UserLikePost request)
        {
            int id = int.Parse(HttpContext.User.FindFirst("Id").Value);
            return Ok(await _postService.LikePost(id, request));
        }
        [HttpPut("UpdateComment")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> UpdateComment(int commentId,Request_UpdateComment request)
        {
            int id = int.Parse(HttpContext.User.FindFirst("Id").Value);
            return Ok(await _postService.UpdateComment(commentId, id, request));
        }
        [HttpPost("UserLikeComment/{commentId}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> UserLikeComment([FromRoute] int commentId)
        {
            int id = int.Parse(HttpContext.User.FindFirst("Id").Value);
            return Ok(await _postService.UserLikeComment(id, commentId));
        }
        [HttpPost("SharePost/{postId}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> SharePost([FromRoute] int postId)
        {
            int id = int.Parse(HttpContext.User.FindFirst("Id").Value);
            return Ok(await _postService.SharePost(id, postId));
        }
        [HttpPost("DownloadImageForPost")]
        public async Task<IActionResult> DownloadImageForPost(int postId)
        {
            return Ok(await _postService.DownloadImageForPost(postId));
        }
        [HttpGet("GetCommentByPost/{postId}")]
        public async Task<IActionResult> GetCommentByPost([FromRoute] int postId, int pageSize = 10, int pageNumber = 1)
        {
            return Ok(await _postService.GetCommentByPost(postId, pageSize, pageNumber));
        }
    }
}
