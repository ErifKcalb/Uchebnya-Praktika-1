using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class ContractStorage
    {
        private readonly Dictionary<int, Contract> _Contract = new();

        public Contract Create(Contract contract)
        {
            _Contract.Add(contract.Id, contract);
            return contract;
        }

        public Contract Read(int contractId)
        {
            return _Contract[contractId];
        }

        public Contract Update(int contractId, Contract newContract)
        {
            _Contract[contractId] = newContract;
            return _Contract[contractId];
        }

        public bool Delete(int contractId)
        {
            return _Contract.Remove(contractId);
        }
    }
}

