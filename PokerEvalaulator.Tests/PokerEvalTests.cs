using PokerLibrary.Models;
using PokerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PokerEvalaulator.Tests
{
    public class PokerEvalTests
    {
        [Fact]
        public void TestRoyalFlush()
        {
            var ownHand = new List<Card> {
               new Card(Suit.Spade,Rank.ten),
               new Card(Suit.Spade,Rank.king),
               new Card(Suit.Spade,Rank.queen),
               new Card(Suit.Spade,Rank.jack),
               new Card(Suit.Spade,Rank.ace)
            };
            var myCards = ownHand.OrderBy(x => x.rank).ToList();
            Assert.Equal("ROYALFLUSH", Poker.evaluateDeck(myCards));
        }
        //[Fact]
        //public void TestStarightFlush()
        //{
        //    var ownHand = new List<Card> {
        //       new Card(Suit.Spade,Rank.ten),
        //       new Card(Suit.Spade,Rank.king),
        //       new Card(Suit.Spade,Rank.queen),
        //       new Card(Suit.Spade,Rank.jack),
        //       new Card(Suit.Spade,Rank.ace)
        //    };
        //    var myCards = ownHand.OrderBy(x => x.rank).ToList();
        //    Assert.Equal("ROYALFLUSH", Poker.evaluateDeck(myCards));
        //}
    }
}
