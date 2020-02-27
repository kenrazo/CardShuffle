using System;
using System.Collections.Generic;
using System.Text;
using CardShuffle.Common.Dtos;

namespace CardShuffle.Business.Business
{
    public interface ICardBusiness
    {
        IEnumerable<CardDto> GetAllCards();
        IEnumerable<CardDto> ShuffleCards();
    }
}
