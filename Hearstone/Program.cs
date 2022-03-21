using Hearstone.Classes;
using System;
using System.Collections.Generic;

namespace HeartStoneAP
{
    class Program
    {
        static void Main(string[] args)
        {
            Card myFirstCard = new Card("Rockpool Hunter", TierType.Tier1, 3, 2, CategoryType.Murloc, new string[] { "BattleCry: Give a friendly Murloc +1/+1" }); //PlayerA
            //myFirstCard.Draw(5, 5);

            Card mySecondCard = new Card("Nathrezim Overseer", TierType.Tier2, 4, 2, CategoryType.Demon, new string[] { "BattleCry: Give a friendly Demon +2/+2" }); //PlayerB
            //mySecondCard.Draw(20, 8);

            Player humanPlayer = new Player("Raf");
            humanPlayer.Deck.Add(myFirstCard);
            humanPlayer.Deck.Add(myFirstCard);
            humanPlayer.Deck.Add(myFirstCard);
            humanPlayer.ShowDeck(2);


            Player aiPlayer = new Player("AI");
            aiPlayer.Deck.Add(mySecondCard);
            aiPlayer.Deck.Add(mySecondCard);
            aiPlayer.Deck.Add(mySecondCard);
            aiPlayer.Deck.Add(mySecondCard);
            aiPlayer.Deck.Add(mySecondCard);
            aiPlayer.ShowDeck(20);

            Console.ReadKey();
        }
    }
}
