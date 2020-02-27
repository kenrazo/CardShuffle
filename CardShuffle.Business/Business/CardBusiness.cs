using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardShuffle.Common.Dtos;
using CardShuffle.Common.Enums;

namespace CardShuffle.Business.Business
{
    public class CardBusiness : ICardBusiness
    {
        /// <summary>
        /// Get all cards.
        /// </summary>
        /// <returns>List of cards.</returns>
        public IEnumerable<CardDto> GetAllCards()
        {
            foreach (var cardDto in ProcessGetAllCard()) yield return cardDto;
        }

        /// <summary>
        /// ProcessShuffle cards.
        /// </summary>
        /// <returns>List of shuffle cards.</returns>
        public IEnumerable<CardDto> ShuffleCards()
        {
            var cards = GetAllCards();
            return ProcessShuffle(cards.ToList());
        }

        private string GetCardType(CardTypeEnum cardType)
        {
            switch (cardType)
            {
                case CardTypeEnum.Diamond: return "Diamond";
                case CardTypeEnum.Heart: return "Heart";
                case CardTypeEnum.Flower: return "Flower";
                default: return "Spade";
            }
        }

        private IEnumerable<CardDto> ProcessShuffle(List<CardDto> cards)
        {
            Random random = new Random();
            for (int i = cards.Count() - 1; i > 0; --i)
            {
                int k = random.Next(i + 1);
                CardDto temp = cards[i];
                cards[i] = cards[k];
                cards[k] = temp;
            }
            return cards;
        }

        private IEnumerable<CardDto> ProcessGetAllCard()
        {
            for (int i = 1; i <= 13; i++)
            {
                for (int c = 1; c <= 4; c++)
                    yield return new CardDto
                    { CardNumber = i, CardTypeEnum = (CardTypeEnum)c, CardType = GetCardType((CardTypeEnum)c) };
            }
        }
    }
}
