using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using CardShuffle.Business.Business;
using FluentAssertions;
using NUnit.Framework;

namespace CardShuffle.Business.Tests
{
    [TestFixture]
    public class CardTests
    {
        [Test]
        public void GetAllCards_ShouldReturn52CountOfCards()
        {
            //arrange
            var expectedResult = 52;

            var cardBusiness = new CardBusiness();
            //act
            var result = cardBusiness.GetAllCards().Count();
            //assert
            result.Should().Equals(expectedResult);
        }

        [Test]
        public void ShuffleCards_ShouldReturn52CountOfCards()
        {
            //arrange
            var expectedResult = 52;

            var cardBusiness = new CardBusiness();
            //act
            var result = cardBusiness.ShuffleCards().Count();
            //assert
            result.Should().Equals(expectedResult);
        }
    }
}
