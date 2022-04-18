using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        //Constructor Method:
        public Deck()
        {
            // Don't have to define the list here because it is a property of the class
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i; //This casts the counter val to the enumerated list
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }
        //Properties:
        public List<Card> Cards { get; set; }

        //method or function for shuffling deck
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }

    }
}
