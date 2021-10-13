using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Uchebnya_Praktika_1.Controllers
{
    [ApiController]
    [Route("[Manager]")]
    public class ManagerController : ControllerBase

    {
        [HttpGet]
        [Route("/Manager/SearchPlayer")]
        public string SearchPlayer(string str)
        {
            return "Поиск футболиста";
        }

        [HttpGet]
        [Route("/Manager/PositionPlayer")]
        public string PositionPlayer(string str)
        {
            return "Позиция игрока";
        }

        [HttpGet]
        [Route("/Manager/ContractExpiration")]
        public string ContractExpiration(string str)
        {
            return "Истечение контракта";
        }

        [HttpGet]
        [Route("/Manager/ScoreInTheMatch")]
        public string ScoreInTheMatch(string str)
        {
            return "Средняя оценка в матче";
        }
    }



    [ApiController]
    [Route("[FootballPlayer]")]
    public class FootballController : ControllerBase
    {




        [HttpPost]
        [Route("/FootballPlayer/Offers")]
        public string Offers(string str)
        {
            return "Предложения";
        }

        [HttpPost]
        [Route("/FootballPlayer/TransferСost")]
        public string TransferСost(string str)
        {
            return "Трансферная стоимость";
        }

        [HttpPost]
        [Route("/FootballPlayer/Сontract")]
        public string Сontract(string str)
        {
            return "Контракт";
        }

        [HttpPost]
        [Route("/FootballPlayer/Сlub")]
        public string Сlub(string str)
        {
            return "Клуб";
        }

        [HttpPost]
        [Route("/FootballPlayer/Agreement")]
        public string Agreement(string str)
        {
            return "Согласие на переход";
        }
    }
}










