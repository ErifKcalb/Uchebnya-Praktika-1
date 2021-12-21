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
    [Route("/managersuggestion")]
    public class ManagerSuggestionController : ControllerBase
    {
        [HttpPut("Create")]
        public ManagerSuggestion Create(ManagerSuggestion managersuggestion)
        {
            Storage.managersuggestionStorage.Create(managersuggestion);
            return Storage.managersuggestionStorage.Read(managersuggestion.Id);
        }

        [HttpGet("Read")]
        public ManagerSuggestion Read(int Id)
        {
            return Storage.managersuggestionStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public ManagerSuggestion Update(int Id, ManagerSuggestion newmanagersuggestion)
        {
            return Storage.managersuggestionStorage.Update(Id, newmanagersuggestion);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.managersuggestionStorage.Delete(Id);
        }
    }
}
