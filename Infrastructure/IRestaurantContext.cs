namespace Restaurant_Site.server.Infrastructure
{
    public interface IRestaurantContext
    {
        public IQueryable<T> GetEntities<T>() where T : class;
    }
}
