using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Uchebnya_Praktika_1.Controllers
{
    [ApiController]
    [Route("FootballPlayer")]
    public class FootballController : ControllerBase
    {




        [HttpGet]
        [Route("SearchAgent")]
        public string SearchAgent(string str)
        {
            return str; //Поиск агента
        }

        [HttpGet]
        [Route("AcceptContract")]
        public string AcceptContract(string str)
        {
            return str; //Принять контракт
        }

        [HttpPost]
        [Route("AcceptJoinClub")]
        public string AcceptJoinClub(string str)
        {
            return str; //Принять переход в клуб
        }
    }
}

    

