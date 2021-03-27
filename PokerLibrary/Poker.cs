using PokerLibrary.Models;
using System;
using System.Collections.Generic;

namespace PokerLibrary
{
    public static class Poker
    {
        public static Hand evaluateDeck(List<Card> cards)
        {
            if (Eval.isPair(cards))
                return Hand.pair;
            else if (Eval.isTwoPair(cards))
                return Hand.twoPair;
            else if (Eval.isThreeOfAKind(cards))
                return Hand.threeOfAKind;
            else if (Eval.isStraight(cards))
                return Hand.straight;
            else if (Eval.isFlush(cards))
                return Hand.flush;
            else if (Eval.isFullHouse(cards))
                return Hand.fullHouse;
            else if (Eval.isFourOfAKind(cards))
                return Hand.fourOfAKind;
            else if (Eval.isStraightFlush(cards))
                return Hand.straightFlush;
            else if (Eval.isRoyalFlush(cards))
                return Hand.royalFlush;
            else
                return Hand.highCard;
        }
    }
}
