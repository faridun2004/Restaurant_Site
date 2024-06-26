using Microsoft.AspNetCore.Mvc;

namespace Restaurant_Site.server.Contracts
{
    public record RequestDishDtoByHolderId
    {
        [FromQuery]
        public Guid HorderId { get; set; }
    }
}
