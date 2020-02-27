using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardShuffle.Business.Business;
using Microsoft.AspNetCore.Mvc;

namespace CardShuffle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardBusiness _cardBusiness;

        public CardController(ICardBusiness cardBusiness)
        {
            _cardBusiness = cardBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _cardBusiness.GetAllCards();
            return Ok(result);
        }

        [HttpGet("shuffle")]
        public IActionResult GetShuffleCards()
        {
            var result = _cardBusiness.ShuffleCards();
            return Ok(result);
        }
    }
}