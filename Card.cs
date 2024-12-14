using System;

namespace TopTrumps
{
    //The card class represents a single card in the game
    
    public class Card
    {
       //Input/Output: Properties to store and retrieve card data.
       public string Name { get; set;} //Name of the card
       public int Strength { get; set;} //Strength attribute
       public int Magic { get; set;} //Magic attribute
       public int Defense { get; set;} //Defense attribute
       public int Vitality { get; set;} //Vitality attribute

       // Variables: Constructor to initialize the card with specific values
       public Card(string name, int vitality, int strength, int magic, int defense)
       {
        Name = name;
        Strength = strength;
        Defense = defense;
        Vitality = vitality;
        Magic = magic;
        }

        //Procedurs: Method to display the card's attributes

        public void DisplayCard()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Defense: {Defense}");
            Console.WriteLine($"Vitality: {Vitality}");
            Console.WriteLine($"Magic: {Magic}");
        }

        // Alrgoriths: Compare a specific attribute of two cards.
        public static int Compare(Card card1, Card card2, string attribute)
        {
            switch (attribute.ToLower())
            {
                case "strength":
                return card1.Strength.CompareTo(card2.Strength);
                case "vitality":
                return card1.Vitality.CompareTo(card2.Vitality);
                case "magic":
                return card1.Magic.CompareTo(card2.Magic);
                case "defense":
                return card1.Defense.CompareTo(card2.Defense);
                default:
                throw new ArgumentException("Invalid Attribute");

            }
        }
    }
}