using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Uchebnya_Praktika_1.Controllers
{
    
    [ApiController]
    [Route("Club")]
    public class ClubController : ControllerBase
    {




        [HttpGet]
        [Route("SearchManager")]
        public string SearchManager(string str)
        {
            return str; //Поиск менеджера
        }

        [HttpGet]
        [Route("BuyFootballPlayer")]
        public string BuyFootballPlayer(string str)
        {
            return str; //Купить футболиста
        }
        }
    }




    

