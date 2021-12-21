using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class ManagerStorage
    {
        private readonly Dictionary<int, Manager> _Manager = new();

        public Manager Create(Manager manager)
        {
            _Manager.Add(manager.Id, manager);
            return manager;
        }

        public Manager Read(int managerId)
        {
            return _Manager[managerId];
        }

        public Manager Update(int managerId, Manager newManager)
        {
            _Manager[managerId] = newManager;
            return _Manager[managerId];
        }

        public bool Delete(int managerId)
        {
            return _Manager.Remove(managerId);
        }
    }
}