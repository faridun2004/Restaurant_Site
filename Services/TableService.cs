using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.Repository;

namespace Restaurant_Site.Services
{
    public class TableService : ITableService
    {
         ISQLRepository<Table> _repository;

        public TableService(ISQLRepository<Table> repository)
        {
            _repository = repository;
        }
        public IQueryable<Table> GetAll()
        {
            return _repository.GetAll();
        }
        public Table GetById(Guid id)
        {
            return _repository.GetById(id);
        }
        public string Create(Table item)
        {
            _repository.Create(item);
            return $"Created new table with this ID: {item.Id}";
        }
        public string Update(Guid id, Table item)
        {
            var existingTable = _repository.GetById(id);
            if (existingTable != null)
            {
                existingTable.Capacity = item.Capacity;
                _repository.Update(existingTable);
                return "Table updated successfully.";
            }
            else
            {
                return "Table not found.";
            }
        }
        public string Delete(Guid id)
        {
            var result = _repository.Delete(id);
            if (result)
                return "Table deleted successfully.";
            else
                return "Table not found.";
        }
    }
}
