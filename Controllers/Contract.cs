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
    [Route("/contract")]
    public class ContractController : ControllerBase
    {
        [HttpPut("Create")]
        public Contract Create(Contract contract)
        {
            Storage.contractStorage.Create(contract);
            return Storage.contractStorage.Read(contract.Id);
        }

        [HttpGet("Read")]
        public Contract Read(int Id)
        {
            return Storage.contractStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Contract Update(int Id, Contract newcontract)
        {
            return Storage.contractStorage.Update(Id, newcontract);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.contractStorage.Delete(Id);
        }
    }
}
