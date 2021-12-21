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
    [Route("/att")]
    public class AcceptTheTransetionController : ControllerBase
    {
        [HttpPut("Create")]
        public AcceptTheTransetion Create(AcceptTheTransetion att)
        {
            Storage.attStorage.Create(att);
            return Storage.attStorage.Read(att.Id);
        }

        [HttpGet("Read")]
        public AcceptTheTransetion Read(int Id)
        {
            return Storage.attStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public AcceptTheTransetion Update(int Id, AcceptTheTransetion newatt)
        {
            return Storage.attStorage.Update(Id, newatt);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.attStorage.Delete(Id);
        }
    }
}
