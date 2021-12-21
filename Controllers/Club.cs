using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstRepository.Domain;
using FirstRepository.Repository;

namespace FirstRepository.Controllers
{
    [ApiController]
    [Route("/club")]
    public class ClubController : ControllerBase
    {
        [HttpPut("Create")]
        public Club Create(Club club)
        {
            Storage.clubStorage.Create(club);
            return Storage.clubStorage.Read(club.Id);
        }

        [HttpGet("Read")]
        public Club Read(int Id)
        {
            return Storage.clubStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Club Update(int Id, Club newclub)
        {
            return Storage.clubStorage.Update(Id, newclub);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.clubStorage.Delete(Id);
        }
    }
}