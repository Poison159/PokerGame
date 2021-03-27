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
            Assert.Equal(Hand.royalFlush, Poker.evaluateDeck(myCards));
        }

        [Fact]
        public void TestStarightFlush()
        {
            var ownHand = new List<Card> {
               new Card(Suit.Spade,Rank.three),
               new Card(Suit.Spade,Rank.four),
               new Card(Suit.Spade,Rank.five),
               new Card(Suit.Spade,Rank.six),
               new Card(Suit.Spade,Rank.seven)
            };
            var myCards = ownHand.OrderBy(x => x.rank).ToList();
            Assert.Equal(Hand.straightFlush, Poker.evaluateDeck(myCards));
        }

        [Fact]
        public void TestFlush()
        {
            var ownHand = new List<Card> {
               new Card(Suit.Spade,Rank.ace),
               new Card(Suit.Spade,Rank.four),
               new Card(Suit.Spade,Rank.jack),
               new Card(Suit.Spade,Rank.six),
               new Card(Suit.Spade,Rank.ten)
            };
            var myCards = ownHand.OrderBy(x => x.rank).ToList();
            Assert.Equal(Hand.flush, Poker.evaluateDeck(myCards));
        }

        [Fact]
        public void TestFourOfAkind()
        {
            var ownHand = new List<Card> {
               new Card(Suit.Spade,Rank.four),
               new Card(Suit.Heart,Rank.four),
               new Card(Suit.Spade,Rank.five),
               new Card(Suit.Dimond,Rank.four),
               new Card(Suit.Club,Rank.four)
            };
            var myCards = ownHand.OrderBy(x => x.rank).ToList();
            Assert.Equal(Hand.fourOfAKind, Poker.evaluateDeck(myCards));
        }

        [Fact]
        public void TestStraight()
        {
            var ownHand = new List<Card> {
               new Card(Suit.Heart,Rank.two),
               new Card(Suit.Dimond,Rank.three),
               new Card(Suit.Club,Rank.four),
               new Card(Suit.Heart,Rank.five),
               new Card(Suit.Spade,Rank.six)
            };
            var myCards = ownHand.OrderBy(x => x.rank).ToList();
            Assert.Equal(Hand.straight, Poker.evaluateDeck(myCards));
        }

        [Fact]
        public void TestTwoPair()
        {
            var ownHand = new List<Card> {
               new Card(Suit.Heart,Rank.two),
               new Card(Suit.Dimond,Rank.two),
               new Card(Suit.Club,Rank.four),
               new Card(Suit.Heart,Rank.five),
               new Card(Suit.Spade,Rank.five)
            };
            var myCards = ownHand.OrderBy(x => x.rank).ToList();
            Assert.Equal(Hand.twoPair, Poker.evaluateDeck(myCards));
        }

        [Fact]
        public void TestFullHouse()
        {
            var ownHand = new List<Card> {
               new Card(Suit.Heart,Rank.two),
               new Card(Suit.Dimond,Rank.two),
               new Card(Suit.Club,Rank.two),
               new Card(Suit.Heart,Rank.five),
               new Card(Suit.Spade,Rank.five)
            };
            var myCards = ownHand.OrderBy(x => x.rank).ToList();
            Assert.Equal(Hand.fullHouse, Poker.evaluateDeck(myCards));
        }

        [Fact]
        public void TestThreeOfAKind()
        {
            var ownHand = new List<Card> {
               new Card(Suit.Heart,Rank.two),
               new Card(Suit.Dimond,Rank.two),
               new Card(Suit.Club,Rank.two),
               new Card(Suit.Heart,Rank.ace),
               new Card(Suit.Spade,Rank.queen)
            };
            var myCards = ownHand.OrderBy(x => x.rank).ToList();
            Assert.Equal(Hand.threeOfAKind, Poker.evaluateDeck(myCards));
        }

        [Fact]
        public void TestPair()
        {
            var ownHand = new List<Card> {
               new Card(Suit.Heart,Rank.two),
               new Card(Suit.Dimond,Rank.two),
               new Card(Suit.Club,Rank.four),
               new Card(Suit.Heart,Rank.ace),
               new Card(Suit.Spade,Rank.jack)
            };
            var myCards = ownHand.OrderBy(x => x.rank).ToList();
            Assert.Equal(Hand.pair, Poker.evaluateDeck(myCards));
        }

        [Fact]
        public void TestHighCard()
        {
            var ownHand = new List<Card> {
               new Card(Suit.Heart,Rank.seven),
               new Card(Suit.Dimond,Rank.two),
               new Card(Suit.Club,Rank.four),
               new Card(Suit.Heart,Rank.ace),
               new Card(Suit.Spade,Rank.jack)
            };
            var myCards = ownHand.OrderBy(x => x.rank).ToList();
            Assert.Equal(Hand.highCard, Poker.evaluateDeck(myCards));
        }
    }
}
