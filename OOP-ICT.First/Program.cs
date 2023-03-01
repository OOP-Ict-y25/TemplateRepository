
using OOP_ICT;
using System.Security.Cryptography.X509Certificates;

Dealer dealer = new Dealer();
dealer.Shuffle();
for (int i = 1; i <= 4; i++)
{
    Console.WriteLine("UserDeck {0} :", i);
    UserDeck userDeck = dealer.CreateShuffledUserDeck(13);
    userDeck.Show();
    Console.WriteLine();
}
    