using Restaurant_Site.server.IServices;
using Restaurant_Site.server.Models;
using Restaurant_Site.server.Models.Enums;
using Restaurant_Site.server.Repository;

namespace Restaurant_Site.server.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ISQLRepository<Employee> _repository;
        private readonly SemaphoreSlim _cookSemaphore;
        private readonly List<Employee> _chefs;

        public EmployeeService(ISQLRepository<Employee> repository, int maxChefs=5)
        {
            _repository = repository;
            _cookSemaphore = new SemaphoreSlim(maxChefs);
            _chefs = repository.GetAll().Where(e => e.Responsibility == EmployeeRole.Chef).ToList();
        }
        
        public IQueryable<Employee> GetAll()
        {
            return _repository.GetAll();
        }
        public IQueryable<Employee> GetAll(int skip, int take)
        {
            return _repository.GetAll().Skip(skip).Take(take);
        }
        public async Task<Employee> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public Employee TryCreate(Employee item, out string message)
        {
            if (string.IsNullOrEmpty(item.FullName) || string.IsNullOrEmpty(item.LastName))
            {
                message = "The name or description is be empty!";
                return default;
            }
            else
            {
                return _repository.TryCreate(item, out message);
            }
        }
        public bool TryUpdate(Guid id, Employee item, out string message)
        {
            var _item = _repository.GetById(id).GetAwaiter().GetResult();
            if (_item is null)
            {
                message = "Item not found";
                return false;
            }
            else
            {
                _item.FirstName = item.FirstName;
                _item.LastName = item.LastName;
                _item.Address = item.Address;
                _item.ContactInfo= item.ContactInfo;
                _item.Username= item.Username;
                _item.Password= item.Password;
                _item.Role = item.Role;

                return _repository.TryUpdate(_item, out message);
            }

        }
        public bool TryDelete(Guid id, out string message)
        {
            return _repository.TryDelete(id, out message);
        }

        public async Task<bool> ProcessOrderAsync(Order order)
        {
            try
            {
                // Попробовать занять слот повара без ожидания
                if (_cookSemaphore.Wait(0))
                {
                    var chef = GetAvailableChef();
                    if (chef != null)
                    {
                        await CookOrderAsync(chef, order);
                        return true; // Успешно приготовлено
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: Нет доступных поваров в данный момент.");
                }

                return false; // Нет доступных поваров
            }
            finally
            {
                _cookSemaphore.Release(); // Освободить слот повара после приготовления заказа
            }
        }

        private Employee GetAvailableChef()
        {
            return _chefs.FirstOrDefault(chef => chef != null && chef.IsAvailable);
        }
        private async Task CookOrderAsync(Employee chef, Order order)
        {
            // Логика приготовления заказа
            await Task.Delay(3000); 
        }
    }
}

