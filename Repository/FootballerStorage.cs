using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class FootballerStorage
    {
        private readonly Dictionary<int, Footballer> _Footballers = new();

        public Footballer Create(Footballer footballer)
        {
            _Footballers.Add(footballer.Id, footballer);
            return footballer;
        }

        public Footballer Read(int footballerId)
        {
            return _Footballers[footballerId];
        }

        public Footballer Update(int footballerId, Footballer newFootballer)
        {
            _Footballers[footballerId] = newFootballer;
            return _Footballers[footballerId];
        }

        public bool Delete(int footballerId)
        {
            return _Footballers.Remove(footballerId); 
        }
    }
}
