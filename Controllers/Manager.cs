using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Uchebnya_Praktika_1.Controllers
{
    [ApiController]
    [Route("Manager")]
    public class ManagerController : ControllerBase

    {
        [HttpGet]
        [Route("SearchPlaye")]
        public string SearchPlayer(string str)
        {
            return str; //"ПоискФутболиста"
        }

        [HttpGet]
        [Route("OfferContract")]
        public string OfferContract(string str)
        {
            return str; //Предложить контракт
        }

        [HttpGet]
        [Route("OfferInJoinTheClub")]
        public string OfferInJoinTheClub(string str)
        {
            return str; //Предложить переход в клуб
        }

        [HttpGet]
        [Route("SuggestPlayer")]
        public string SuggestPlayer(string str)
        {
            return str; //Предложить игрока
        }

        [HttpGet]
        [Route("SearchClub")]
        public string SearchClub(string str)
        {
            return str; //Найти клуб
        }
    }
}



 
    











