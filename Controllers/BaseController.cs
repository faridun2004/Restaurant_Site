using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;  
using System.Net;

namespace Restaurant_Site.server.Controllers
{
    [Authorize]
    public abstract class BaseController<TEntity> : ControllerBase where TEntity : BaseEntity
    {
        protected readonly IBaseService<TEntity> _baseService;
        protected readonly ILogger<BaseController<TEntity>> _logger;
        public BaseController(ILogger<BaseController<TEntity>> logger, IBaseService<TEntity> baseService)
        {
            _logger = logger;
            _baseService = baseService;
        }
        
        [HttpGet("Allitems")]
        [AllowAnonymous]
        public virtual IEnumerable<TEntity> Get()
        {
            _logger.LogDebug("API started...");
            try
            {
                throw new Exception("Test exception");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}");
            }

            _logger.LogInformation("API finished...");

            return _baseService.GetAll();
        }
        [HttpGet("GetElementById")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(BaseEntity), (int)HttpStatusCode.OK)]
        public virtual async Task<ActionResult<TEntity>> Get(Guid id)
        {
            var item=await _baseService.GetById(id);
            if(item is null)
                return NotFound(404);
            return Ok(item);
        }

        [HttpPost("Create")]
        public virtual ActionResult<TEntity> Post([FromBody] TEntity item)
        {
            var createdItem = _baseService.TryCreate(item, out string message);
            if (createdItem is null)
                return BadRequest(message);

            return Ok(createdItem);
        }

        [HttpPut("Update")]
        public virtual ActionResult<string> Put([FromQuery] Guid id, [FromBody] TEntity item)
        {
            var updated = _baseService.TryUpdate(id, item, out string message);
            if (!updated)
                return BadRequest(message);

            return Ok("Successfully updated");
        }

        [HttpDelete("Delete")]
        public virtual ActionResult<string> Delete([FromQuery] Guid id)
        {
            var deleted = _baseService.TryDelete(id, out string message);
            if (!deleted)
                return BadRequest(message);

            return Ok("Successfully deleted");
        }
    }
}
