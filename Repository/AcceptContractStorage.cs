using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class AcceptContractStorage
    {
        private readonly Dictionary<int, AcceptContract> _AcceptContract = new();

        public AcceptContract Create(AcceptContract acceptcontract)
        {
            _AcceptContract.Add(acceptcontract.Id, acceptcontract);
            return acceptcontract;
        }

        public AcceptContract Read(int acceptcontractId)
        {
            return _AcceptContract[acceptcontractId];
        }

        public AcceptContract Update(int acceptcontractId, AcceptContract newAcceptContract)
        {
            _AcceptContract[acceptcontractId] = newAcceptContract;
            return _AcceptContract[acceptcontractId];
        }

        public bool Delete(int acceptcontractId)
        {
            return _AcceptContract.Remove(acceptcontractId);
        }
    }
}
