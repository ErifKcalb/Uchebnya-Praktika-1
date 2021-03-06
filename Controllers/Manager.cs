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
    [Route("/manager")]
    public class ManagerController : ControllerBase
    {
        [HttpPut("Create")]
        public Manager Create(Manager manager)
        {
            Storage.managerStorage.Create(manager);
            return Storage.managerStorage.Read(manager.Id);
        }

        [HttpGet("Read")]
        public Manager Read(int Id)
        {
            return Storage.managerStorage.Read(Id);
        }

        [HttpPatch("Update")]
        public Manager Update(int Id, Manager newManager)
        {
            return Storage.managerStorage.Update(Id, newManager);
        }

        [HttpDelete("Delete")]
        public bool Delete(int Id)
        {
            return Storage.managerStorage.Delete(Id);
        }
    }
}