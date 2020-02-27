using System;
using System.Collections.Generic;
using System.Text;
using CardShuffle.Common.Enums;

namespace CardShuffle.Common.Dtos
{
    public class CardDto
    {
        /// <summary>
        /// The card number.
        /// </summary>
        public int CardNumber { get; set; }
        /// <summary>
        /// The card type.
        /// </summary>
        public string CardType { get; set; }
        /// <summary>
        /// The card type enum.
        /// </summary>
        public CardTypeEnum CardTypeEnum { get; set; }
    }
}
