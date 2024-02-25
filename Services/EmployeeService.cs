﻿using Restaurant_Site.Models;
using Restaurant_Site.Repository;

namespace Restaurant_Site.Services
{
    public class EmployeeService: IEmployeeService
    {
        ISQLRepository<Employee> _repository;
        public EmployeeService(ISQLRepository<Employee> repository)
        {
            _repository = repository;
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
                _item.Role=item.Role;
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
    }
}

