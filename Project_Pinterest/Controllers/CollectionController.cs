using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Pinterest.Handler.HandlePagination;
using Project_Pinterest.Payloads.DataRequests.CollectionRequests;
using Project_Pinterest.Payloads.DataResponses.DataCollection;
using Project_Pinterest.Payloads.DataResponses.DataPostCollection;
using Project_Pinterest.Payloads.Responses;
using Project_Pinterest.Services.Interfaces;

namespace Project_Pinterest.Controllers
{
    [Route("api/collection")]
    [ApiController]
    public class CollectionController : ControllerBase
    {
        private readonly ICollectionService _collectionService;
        private readonly IPostCollectionService _postCollectionService;
        public CollectionController(ICollectionService collectionService, IPostCollectionService postCollectionService)
        {
            _collectionService = collectionService;
            _postCollectionService = postCollectionService;
        }
        [HttpPost("CreateCollection")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> CreateCollection(Request_CreateCollection request)
        {
            int id = int.Parse(HttpContext.User.FindFirst("Id").Value);
            return Ok(await _collectionService.CreateCollection(id, request));
        }
        [HttpDelete("DeleteCollection")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> DeleteCollection(int collectionId)
        {
            int id = int.Parse(HttpContext.User.FindFirst("Id").Value);
            return Ok(await _collectionService.DeleteCollection(id, collectionId));
        }
        [HttpGet("GetAllCollections")]
        public async Task<IActionResult> GetAllCollections(int pageSize = 10, int pageNumber = 1)
        {
            return Ok(await _collectionService.GetAllCollections(pageSize, pageNumber));
        }
        [HttpGet("GetCollectionById")]
        public async Task<IActionResult> GetCollectionById(int collectionId)
        {
            return Ok(await _collectionService.GetCollectionById(collectionId));
        }
        [HttpGet("GetCollectionByName")]
        public async Task<IActionResult> GetCollectionByName(string name, int pageSize = 10, int pageNumber = 1)
        {
            return Ok(await _collectionService.GetCollectionByName(name, pageSize, pageNumber));
        }
        [HttpPut("UpdateCollection")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> UpdateCollection(Request_UpdateCollection request)
        {
            int id = int.Parse(HttpContext.User.FindFirst("Id").Value);
            return Ok(await _collectionService.UpdateCollection(id, request));
        }
        [HttpPost("CreateListPostCollection")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> CreateListPostCollection(int collectionId, List<Request_CreatePostCollection> requests)
        {
            int id = int.Parse(HttpContext.User.FindFirst("Id").Value);
            return Ok(await _postCollectionService.CreateListPostCollection(id,collectionId, requests));
        }
        [HttpPost("CreatePostCollection")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> CreatePostCollection(int collectionId, Request_CreatePostCollection request)
        {
            int id = int.Parse(HttpContext.User.FindFirst("Id").Value);
            return Ok(await _postCollectionService.CreatePostCollection(id, collectionId, request));
        }
    }
}
