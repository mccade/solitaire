using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solitaire
{
    //establish Card class
    //each card has:
    //value - integer for comparisons
    //appearance - string for printing
    //suit - string for comparing when moving
    //face - string for determining if face up or down
    public class Card
    {
        public int cardValue { get; set; }
        public string cardAppearance { get; set; }
        public string cardSuit { get; set; }
        public string cardFace { get; set; }
        public Card(int cValue, string cAppearance, string cSuit, string cFace)
        {
            cardValue = cValue;
            cardAppearance = cAppearance;
            cardSuit = cSuit;
            cardFace = cFace;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //initialize deck and other variables
            List<Card> deckList = new List<Card>()
            {
                new Card(1, "ACEclub", "club", "down"),
                new Card(2, "TWOclub", "club", "down"),
                new Card(3, "THREEclub", "club", "down"),
                new Card(4, "FOURclub", "club", "down"),
                new Card(5, "FIVEclub", "club", "down"),
                new Card(6, "SIXclub", "club", "down"),
                new Card(7, "SEVENclub", "club", "down"),
                new Card(8, "EIGHTclub", "club", "down"),
                new Card(9, "NINEclub", "club", "down"),
                new Card(10, "TENclub", "club", "down"),
                new Card(11, "JACKclub", "club", "down"),
                new Card(12, "QUEENclub", "club", "down"),
                new Card(13, "KINGclub", "club", "down"),
                new Card(1, "ACEspade", "spade", "down"),
                new Card(2, "TWOspade", "spade", "down"),
                new Card(3, "THREEspade", "spade", "down"),
                new Card(4, "FOURspade", "spade", "down"),
                new Card(5, "FIVEspade", "spade", "down"),
                new Card(6, "SIXspade", "spade", "down"),
                new Card(7, "SEVENspade", "spade", "down"),
                new Card(8, "EIGHTspade", "spade", "down"),
                new Card(9, "NINEspade", "spade", "down"),
                new Card(10, "TENspade", "spade", "down"),
                new Card(11, "JACKspade", "spade", "down"),
                new Card(12, "QUEENspade", "spade", "down"),
                new Card(13, "KINGspade", "spade", "down"),
                new Card(1, "ACEheart", "heart", "down"),
                new Card(2, "TWOheart", "heart", "down"),
                new Card(3, "THREEheart", "heart", "down"),
                new Card(4, "FOURheart", "heart", "down"),
                new Card(5, "FIVEheart", "heart", "down"),
                new Card(6, "SIXheart", "heart", "down"),
                new Card(7, "SEVENheart", "heart", "down"),
                new Card(8, "EIGHTheart", "heart", "down"),
                new Card(9, "NINEheart", "heart", "down"),
                new Card(10, "TENheart", "heart", "down"),
                new Card(11, "JACKheart", "heart", "down"),
                new Card(12, "QUEENheart", "heart", "down"),
                new Card(13, "KINGheart", "heart", "down"),
                new Card(1, "ACEdiamond", "diamond", "down"),
                new Card(2, "TWOdiamond", "diamond", "down"),
                new Card(3, "THREEdiamond", "diamond", "down"),
                new Card(4, "FOURdiamond", "diamond", "down"),
                new Card(5, "FIVEdiamond", "diamond", "down"),
                new Card(6, "SIXdiamond", "diamond", "down"),
                new Card(7, "SEVENdiamond", "diamond", "down"),
                new Card(8, "EIGHTdiamond", "diamond", "down"),
                new Card(9, "NINEdiamond", "diamond", "down"),
                new Card(10, "TENdiamond", "diamond", "down"),
                new Card(11, "JACKdiamond", "diamond", "down"),
                new Card(12, "QUEENdiamond", "diamond", "down"),
                new Card(13, "KINGdiamond", "diamond", "down")
            };
            List<Card> heartList = new List<Card>();
            List<Card> diamondList = new List<Card>();
            List<Card> clubList = new List<Card>();
            List<Card> spadeList = new List<Card>();
            List<Card> tabList1 = new List<Card>();
            List<Card> tabList2 = new List<Card>();
            List<Card> tabList3 = new List<Card>();
            List<Card> tabList4 = new List<Card>();
            List<Card> tabList5 = new List<Card>();
            List<Card> tabList6 = new List<Card>();
            List<Card> tabList7 = new List<Card>();
            List<Card>[] tableau = new List<Card>[7];
            tableau[0] = tabList1;
            tableau[1] = tabList2;
            tableau[2] = tabList3;
            tableau[3] = tabList4;
            tableau[4] = tabList5;
            tableau[5] = tabList6;
            tableau[6] = tabList7;
            int hitAdd;
            int cardDraw;
            Random rando = new Random();
            int deckRemaining = 52;
            int iterator = 0;
            string input ="";

            //title screen
            Console.Write("Solitaire!\n\npress any key to begin");
            Console.ReadKey();
            Console.Clear();

            //initialize game
            cardDraw = rando.Next(0, deckRemaining);
            deckRemaining--;
            tabList1.Add(deckList[cardDraw]);
            deckList.RemoveAt(cardDraw);
            tabList1[0].cardFace = "up";

            for(iterator = 0; iterator < 2; iterator++)
            {
                cardDraw = rando.Next(0, deckRemaining);
                deckRemaining--;
                tabList2.Add(deckList[cardDraw]);
                deckList.RemoveAt(cardDraw);
            }
            tabList2[1].cardFace = "up";

            for(iterator = 0; iterator < 3; iterator++)
            {
                cardDraw = rando.Next(0, deckRemaining);
                deckRemaining--;
                tabList3.Add(deckList[cardDraw]);
                deckList.RemoveAt(cardDraw);
            }
            tabList3[2].cardFace = "up";

            for(iterator = 0; iterator < 4; iterator++)
            {
                cardDraw = rando.Next(0, deckRemaining);
                deckRemaining--;
                tabList4.Add(deckList[cardDraw]);
                deckList.RemoveAt(cardDraw);
            }
            tabList4[3].cardFace = "up";

            for(iterator = 0; iterator < 5; iterator++)
            {
                cardDraw = rando.Next(0, deckRemaining);
                deckRemaining--;
                tabList5.Add(deckList[cardDraw]);
                deckList.RemoveAt(cardDraw);
            }
            tabList5[4].cardFace = "up";

            for (iterator = 0; iterator < 6; iterator++)
            {
                cardDraw = rando.Next(0, deckRemaining);
                deckRemaining--;
                tabList6.Add(deckList[cardDraw]);
                deckList.RemoveAt(cardDraw);
            }
            tabList6[5].cardFace = "up";

            for (iterator = 0; iterator < 7; iterator++)
            {
                cardDraw = rando.Next(0, deckRemaining);
                deckRemaining--;
                tabList7.Add(deckList[cardDraw]);
                deckList.RemoveAt(cardDraw);
            }
            tabList7[6].cardFace = "up";

            //play screen
            while(input != "quit")
            {
                Console.Write("tab1: ");
                for(iterator = 0; iterator < tabList1.Count(); iterator++)
                {
                    if(tabList1[iterator].cardFace == "up")
                    {
                        Console.Write(tabList1[iterator].cardAppearance + " ");
                    }
                    else
                    {
                        Console.Write("card");
                    }
                }
                Console.Write("\n");

                Console.Write("tab2: ");
                for (iterator = 0; iterator < tabList2.Count(); iterator++)
                {
                    if (tabList2[iterator].cardFace == "up")
                    {
                        Console.Write(tabList2[iterator].cardAppearance + " ");
                    }
                    else
                    {
                        Console.Write("card ");
                    }
                }
                Console.Write("\n");

                Console.Write("tab3: ");
                for (iterator = 0; iterator < tabList3.Count(); iterator++)
                {
                    if (tabList3[iterator].cardFace == "up")
                    {
                        Console.Write(tabList3[iterator].cardAppearance + " ");
                    }
                    else
                    {
                        Console.Write("card ");
                    }
                }
                Console.Write("\n");

                Console.Write("tab4: ");
                for (iterator = 0; iterator < tabList4.Count(); iterator++)
                {
                    if (tabList4[iterator].cardFace == "up")
                    {
                        Console.Write(tabList4[iterator].cardAppearance + " ");
                    }
                    else
                    {
                        Console.Write("card ");
                    }
                }
                Console.Write("\n");

                Console.Write("tab5: ");
                for (iterator = 0; iterator < tabList5.Count(); iterator++)
                {
                    if (tabList5[iterator].cardFace == "up")
                    {
                        Console.Write(tabList5[iterator].cardAppearance + " ");
                    }
                    else
                    {
                        Console.Write("card ");
                    }
                }
                Console.Write("\n");

                Console.Write("tab6: ");
                for (iterator = 0; iterator < tabList6.Count(); iterator++)
                {
                    if (tabList6[iterator].cardFace == "up")
                    {
                        Console.Write(tabList6[iterator].cardAppearance + " ");
                    }
                    else
                    {
                        Console.Write("card ");
                    }
                }
                Console.Write("\n");

                Console.Write("tab7: ");
                for (iterator = 0; iterator < tabList7.Count(); iterator++)
                {
                    if (tabList7[iterator].cardFace == "up")
                    {
                        Console.Write(tabList7[iterator].cardAppearance + " ");
                    }
                    else
                    {
                        Console.Write("card ");
                    }
                }
                Console.Write("\n\n");

                Console.Write("clubs (8): ");
                for (iterator = 0; iterator < clubList.Count(); iterator++)
                {
                    Console.Write(clubList[iterator].cardAppearance + " ");
                }
                Console.Write("\n");

                Console.Write("hearts (9): ");
                for (iterator = 0; iterator < heartList.Count(); iterator++)
                {
                    Console.Write(heartList[iterator].cardAppearance + " ");
                }
                Console.Write("\n");

                Console.Write("spades (10): ");
                for (iterator = 0; iterator < spadeList.Count(); iterator++)
                {
                    Console.Write(spadeList[iterator].cardAppearance + " ");
                }
                Console.Write("\n");

                Console.Write("diamonds (11): ");
                for (iterator = 0; iterator < diamondList.Count(); iterator++)
                {
                    Console.Write(diamondList[iterator].cardAppearance + " ");
                }
                Console.Write("\n\n");

                //gameplay
                Console.Write("Hits left:  " + deckRemaining/6 + "\nInput (tab# card# tab#, ie 1 2 3):  ");
                input = Console.ReadLine();
                if(input == "quit")
                {
                    break;
                }

                //if user chooses hit, cards from the deck are added to the stacks randomly
                else if((input == "hit") && (deckRemaining > 5))
                {
                    for (iterator = 0; iterator < 6; iterator++)
                    {
                        cardDraw = rando.Next(0, deckRemaining);
                        deckRemaining--;
                        hitAdd = rando.Next(0, 7);
                        tableau[hitAdd].Add(deckList[cardDraw]);
                        deckList.RemoveAt(cardDraw);
                        tableau[hitAdd][tableau[hitAdd].Count() - 1].cardFace = "up";
                    }
                }
                //if user chooses a card to move
                else
                {
                    string[] move = input.Split(' ');
                    int moveStart = Int32.Parse(move[0]);
                    int moveCard = Int32.Parse(move[1]);
                    int moveStop = Int32.Parse(move[2]);

                    //if user moves the kings to their foundations
                    if (moveStop == 8 && tableau[moveStart - 1][moveCard - 1].cardAppearance == "KINGclub")
                    {
                        for (iterator = moveCard - 1; iterator < tableau[moveStart - 1].Count(); iterator++)
                        {
                            clubList.Add(tableau[moveStart - 1][iterator]);
                        }
                        tableau[moveStart - 1].RemoveRange(moveCard - 1, tableau[moveStart - 1].Count() - (moveCard - 1));
                    }

                    else if (moveStop == 9 && tableau[moveStart - 1][moveCard - 1].cardAppearance == "KINGheart")
                    {
                        for (iterator = moveCard - 1; iterator < tableau[moveStart - 1].Count(); iterator++)
                        {
                            heartList.Add(tableau[moveStart - 1][iterator]);
                        }
                        tableau[moveStart - 1].RemoveRange(moveCard - 1, tableau[moveStart - 1].Count() - (moveCard - 1));
                    }

                    else if (moveStop == 10 && tableau[moveStart - 1][moveCard - 1].cardAppearance == "KINGspade")
                    {
                        for (iterator = moveCard - 1; iterator < tableau[moveStart - 1].Count(); iterator++)
                        {
                            spadeList.Add(tableau[moveStart - 1][iterator]);
                        }
                        tableau[moveStart - 1].RemoveRange(moveCard - 1, tableau[moveStart - 1].Count() - (moveCard - 1));
                    }

                    else if (moveStop == 11 && tableau[moveStart - 1][moveCard - 1].cardAppearance == "KINGdiamond")
                    {
                        for (iterator = moveCard - 1; iterator < tableau[moveStart - 1].Count(); iterator++)
                        {
                            diamondList.Add(tableau[moveStart - 1][iterator]);
                        }
                        tableau[moveStart - 1].RemoveRange(moveCard - 1, tableau[moveStart - 1].Count() - (moveCard - 1));
                    }

                    //check if move is valid and complete it
                    else if (tableau[moveStop - 1].Count() == 0)
                    {
                        if(tableau[moveStart - 1][moveCard - 1].cardValue == 13)
                        {
                            for (iterator = moveCard - 1; iterator < tableau[moveStart - 1].Count(); iterator++)
                            {
                                tableau[moveStop - 1].Add(tableau[moveStart - 1][iterator]);
                            }
                            tableau[moveStart - 1].RemoveRange(moveCard - 1, tableau[moveStart - 1].Count() - (moveCard - 1));
                            if (tableau[moveStart - 1].Count() > 0)
                            {
                                tableau[moveStart - 1][moveCard - 2].cardFace = "up";
                            }
                        }
                    }
                    else{
                        if((tableau[moveStart - 1][moveCard - 1].cardSuit == tableau[moveStop - 1][tableau[moveStop - 1].Count - 1].cardSuit) && (tableau[moveStart - 1][moveCard - 1].cardValue < tableau[moveStop - 1][tableau[moveStop - 1].Count - 1].cardValue))
                        {
                            for (iterator = moveCard - 1; iterator < tableau[moveStart - 1].Count(); iterator++)
                            {
                                tableau[moveStop - 1].Add(tableau[moveStart - 1][iterator]);
                            }
                            tableau[moveStart - 1].RemoveRange(moveCard - 1, tableau[moveStart - 1].Count() - (moveCard - 1));
                            if (tableau[moveStart - 1].Count() > 0)
                            {
                                tableau[moveStart - 1][moveCard - 2].cardFace = "up";
                            }
                        }
                    }
                }
                Console.Clear();

                //if foundations contain the whole deck, you win
                if(heartList.Count() + clubList.Count() + diamondList.Count() + spadeList.Count() == 52)
                {
                    input = "quit";
                    Console.Write("you win!\n");
                    Console.ReadLine();
                }
            }
        }
    }
}
