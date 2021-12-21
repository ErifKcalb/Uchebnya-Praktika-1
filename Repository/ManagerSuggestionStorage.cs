using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class ManagerSuggestionStorage
    {
        private readonly Dictionary<int, ManagerSuggestion> _ManagerSuggestion = new();

        public ManagerSuggestion Create(ManagerSuggestion managersuggestion)
        {
            _ManagerSuggestion.Add(managersuggestion.Id, managersuggestion);
            return managersuggestion;
        }

        public ManagerSuggestion Read(int managersuggestionId)
        {
            return _ManagerSuggestion[managersuggestionId];
        }

        public ManagerSuggestion Update(int managersuggestionId, ManagerSuggestion newManagerSuggestion)
        {
            _ManagerSuggestion[managersuggestionId] = newManagerSuggestion;
            return _ManagerSuggestion[managersuggestionId];
        }

        public bool Delete(int managersuggestionId)
        {
            return _ManagerSuggestion.Remove(managersuggestionId);
        }
    }
}
