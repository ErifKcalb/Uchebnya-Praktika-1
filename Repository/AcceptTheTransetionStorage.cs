using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class AcceptTheTransetionStorage
    {
        private readonly Dictionary<int, AcceptTheTransetion> _ATT = new();

        public AcceptTheTransetion Create(AcceptTheTransetion att)
        {
            _ATT.Add(att.Id, att);
            return att;
        }

        public AcceptTheTransetion Read(int attId)
        {
            return _ATT[attId];
        }

        public AcceptTheTransetion Update(int attId, AcceptTheTransetion newAcceptTheTransetion)
        {
            _ATT[attId] = newAcceptTheTransetion;
            return _ATT[attId];
        }

        public bool Delete(int attId)
        {
            return _ATT.Remove(attId);
        }
    }
}
