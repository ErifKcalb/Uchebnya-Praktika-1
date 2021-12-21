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
    [Route("/acceptcontract")]
    public class AcceptContractController : ControllerBase
    {
        [HttpPut("Create")]
        public AcceptContract Create(AcceptContract acceptcontract)
        {
            Storage.acceptcontractStorage.Create(acceptcontract);
            return Storage.acceptcontractStorage.Read(acceptcontract.Id);
        }

        [HttpGet("Read")]
        public AcceptContract Read(int Id)
        {
            return Storage.acceptcontractStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public AcceptContract Update(int Id, AcceptContract newacceptcontract)
        {
            return Storage.acceptcontractStorage.Update(Id, newacceptcontract);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.acceptcontractStorage.Delete(Id);
        }
    }
}
