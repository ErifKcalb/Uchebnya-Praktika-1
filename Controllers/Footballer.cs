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
    [Route("/footballer")]
    public class FootballerController : ControllerBase
    {
        [HttpPut("Create")]
        public Footballer Create(Footballer footballer)
        {
            Storage.footballerStorage.Create(footballer);
            return Storage.footballerStorage.Read(footballer.Id);
        }

        [HttpGet("Read")]
        public Footballer Read(int Id)
        {
            return Storage.footballerStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Footballer Update(int Id, Footballer newFootballer)
        {
            return Storage.footballerStorage.Update(Id, newFootballer);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.footballerStorage.Delete(Id);
        }
    }
}
