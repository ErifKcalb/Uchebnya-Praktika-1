using FirstRepository.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FirstRepository.Repository
{
    public class ClubStorage
    {
        private readonly Dictionary<int, Club> _Club = new();

        public Club Create(Club club)
        {
            _Club.Add(club.Id, club);
            return club;
        }

        public Club Read(int clubId)
        {
            return _Club[clubId];
        }

        public Club Update(int clubId, Club newClub)
        {
            _Club[clubId] = newClub ;
            return _Club[clubId];
        }

        public bool Delete(int clubId)
        {
            return _Club.Remove(clubId);
        }
    }
}