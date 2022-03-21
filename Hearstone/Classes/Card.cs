using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearstone.Classes
{
    public enum TierType { Tier1 = 1, Tier2, Tier3, Tier4, Tier5, Tier6 };
    public enum CategoryType
    {
        Beast, Demon, Dragon, Elemental, Mech, Murloc, Pirate, Quilboar
    }
    //Bron: https://playhearthstone.com/en-us/cards
    class Card
    {
        public Card(string inTitle, TierType inTier, int inMaxHealth, int inAttack, CategoryType inTribeType, string[] inAbilities)
        {
            Title = inTitle;
            Tier = inTier;
            MaxHealth = inMaxHealth;
            Attack = inAttack;
            TribeType = inTribeType;
            Abilities = inAbilities;
        }

        public Card(string inTitle, TierType inTier)
        {
            this.inTitle = inTitle;
            this.inTier = inTier;
        }

        public string Title { get; set; }
        public string[] Abilities { get; set; } //Todo: dit zal een klasse Ability vereisen
        internal void Draw(int x, int y)
        {
            string card = @"┌──┬─────┬──┐
│  │     │  │
├──┴─────┴──┤
│           │
├───────────┤
│           │
│           │
│           │
│           │
│           │
│           │
└───────────┘";
            string[] lines = card.Split(Environment.NewLine);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(lines[i]);
            }
            //Attack
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(x + 1, y + 1);
            Console.Write(Attack);
            Console.ResetColor();
            //Health
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x + 10, y + 1);
            Console.Write(MaxHealth);
            Console.ResetColor();
            //Tier        
            Console.SetCursorPosition(x + 4, y + 1);
            for (int i = 0; i < (int)Tier; i++)
            {
                Console.Write("*");
            }
            //Title
            Console.SetCursorPosition(x + 1, y + 3);
            if (Title.Length > 12)
                Console.Write(Title.Substring(0, 11));
            else Console.Write(Title);
        }
        private int attack;
        private string inTitle;
        private TierType inTier;

        public int Attack 
        {
            get { return attack; }
            set
            {
                if (value >= 0)
                    attack = value;
                else
                    throw new Exception("Attack can nvever be less than 0");
            } 
        }
        public int MaxHealth { get; set; }
        public TierType Tier { get; set; }
        public CategoryType TribeType { get; set; }
        public string ImagePath { get; set; }

        public Minion Summon() 
        {
            Minion toSpawn = new Minion(Title, Tier, MaxHealth);
            toSpawn.Abilities = Abilities;
            toSpawn.Attack = Attack;
            toSpawn.ActualHealth = Attack;
            toSpawn.ActualHealth = MaxHealth;
            toSpawn.ImagePath = ImagePath;
            toSpawn.MaxHealth = MaxHealth;
            toSpawn.Tier = Tier;
            toSpawn.Title = "M_"+Title;
            toSpawn.TribeType = TribeType;
            return toSpawn;
        }
    }
}