using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using System.Net;

namespace Restaurant_Site.Controllers
{
    [Authorize(Roles ="Admin")]
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
        public virtual TEntity Get(Guid id)
        {
            return _baseService.GetById(id);
        }

        [HttpPost("Create")]
        public virtual string Post([FromBody] TEntity item)
        {
            return _baseService.Create(item);
        }

        [HttpPut("Update")]
        public virtual string Put([FromQuery] Guid id, [FromBody] TEntity item)
        {
            return _baseService.Update(id, item);
        }

        [HttpDelete("Delete")]
        public virtual string Delete([FromQuery] Guid id)
        {
            return _baseService.Delete(id);
        }
    }
}
