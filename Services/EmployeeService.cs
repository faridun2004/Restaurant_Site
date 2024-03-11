using Restaurant_Site.IServices;
using Restaurant_Site.Models;
using Restaurant_Site.Repository;


namespace Restaurant_Site.Services
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
            _chefs = repository.GetAll().Where(e => e.Role == Role.Chef).ToList();
        }
        public IQueryable<Employee> GetAll()
        {
            return _repository.GetAll();
        }

        public IQueryable<Employee> GetAll(int skip, int take)
        {
            return _repository.GetAll().Skip(skip).Take(take);
        }

        public Employee GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Create(Employee item)
        {
            if (string.IsNullOrEmpty(item.FirstName))
            {
                return "The name cannot be empty";
            }
            else
            {
                _repository.Create(item);
                return $"Created new item with this ID: {item.Id}";
            }
        }

        public string Update(Guid id, Employee item)
        {
            var _item = _repository.GetById(id);
            if (_item is not null)
            {
                _item.FirstName = item.FirstName;
                _item.LastName = item.LastName;
                _item.ContactInfo = item.ContactInfo;
                _item.Role = item.Role;
                var result = _repository.Update(_item);
                if (result)
                    return "Item updated";
            }

            return "Item not updated";
        }

        public string Delete(Guid id)
        {
            var result = _repository.Delete(id);
            if (result)
                return "Item deleted";
            else
                return "Item not found";
        }

        public async Task<bool> ProcessOrderAsync(Order order)
        {
            // Попробовать занять слот повара без ожидания
            if (_cookSemaphore.Wait(0))
            {
                var chef = GetAvailableChef();
                if (chef != null)
                {
                    if (chef.Role == Role.Chef) // Проверяем, является ли сотрудник поваром
                    {
                        await CookOrderAsync(chef, order);
                        _cookSemaphore.Release(); // Освободить слот повара после приготовления заказа
                        return true; // Успешно приготовлено
                    }
                    else
                    {
                        // Сотрудник не является поваром
                        // Возможно, следует вывести сообщение об ошибке
                    }
                }
            }

            return false; // Нет доступных поваров
        }

        private Employee GetAvailableChef()
        {
            foreach (var chef in _chefs)
            {
                // Проверяем доступность повара
                // В данном примере просто проверяем, что повар не занят (нет логики реального времени)
                if (chef != null)
                {
                    return chef; // Используем тип Chef вместо Employee
                }
            }

            return null; // Нет доступных поваров
        }

        private async Task CookOrderAsync(Employee chef, Order order)
        {
            // Логика приготовления заказа
            await Task.Delay(3000); // Симуляция времени приготовления
        }
    }
}

