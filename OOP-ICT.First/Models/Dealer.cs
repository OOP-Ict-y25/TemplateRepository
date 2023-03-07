using OOP_ICT.Interfaces;

namespace OOP_ICT.Models;

/// <summary>
/// Class Dealer contains data about deck on table and data about each player hand, including dealers hand.
/// </summary>
//P.S Реализация руки игроков будет менятся в будущем, я понимаю,
//что представление руки игроков в диллере является не очень правильным.
//Также отсутствует возможность играть более чем одному игроку, будет поправлено позже.
public class Dealer : IDealer
{
    private CardDeck _tableDeck;
    private readonly PlayerHand _dealerHand = new PlayerHand();
    private readonly PlayerHand _playerHand = new PlayerHand();
    /// <summary>
    /// Method InitializeCardDeck makes deck for a table via CardDeck default builder
    /// </summary>
    public void InitializeCardDeck() 
    {
        _tableDeck = new CardDeck();
    }

    /// <summary>
    /// Method ShuffleDeckAtDealer marks deck as unpacked and shuffling it in random order.
    /// </summary>
    public void ShuffleDeckAtDealer()
    {
        _tableDeck = _tableDeck.ShuffleDeck();
        _tableDeck.DeckUnpacked = true;
    }

    /// <summary>
    /// Method InitiateGameStart starts game (currently BlackJack and only for 1 player)
    /// by playing default amount of cards.
    /// </summary>
    public void InitiateGameStart()
    {
        _playerHand.AddCard(_tableDeck.GetLastCard());
        _tableDeck.DeleteLastCard();
        _dealerHand.AddCard(_tableDeck.GetLastCard());
        _tableDeck.DeleteLastCard();
        _playerHand.AddCard(_tableDeck.GetLastCard());
        _tableDeck.DeleteLastCard();
        _dealerHand.AddCard(_tableDeck.GetLastCard());
        _tableDeck.DeleteLastCard();
    }

    /// <summary>
    /// Method ShowDealerHand shows first dealers card.
    /// P.S - Will be used for insurance.
    /// </summary>
    public void ShowDealerHand()
    {
        Console.WriteLine(_dealerHand.Hand[0]);
    }

    /// <summary>
    /// Method ShowPlayerHand shows all cards in players hand.
    /// </summary>
    public void ShowPlayerHand()
    {
        Console.WriteLine(_playerHand);
    }

    /// <summary>
    /// Method CheckDeck allows player to check unpacked deck for order of cards. 
    /// </summary>
    public void CheckDeck()
    {
        if (!_tableDeck.DeckUnpacked)
        {
            Console.WriteLine(CardDeck.GetDeck(_tableDeck));
        }
    }

    /// <summary>
    /// Method EndGame emptying everyone's hand.
    /// If amount of cards in deck is inefficient updates deck played on table. 
    /// </summary>
    public void EndGame()
    {
        _playerHand.CleanHand();
        _dealerHand.CleanHand();
        if (Convert.ToInt32(_tableDeck.Count()) >= 16) return;
        _tableDeck = new CardDeck()
        {
            DeckUnpacked = false
        };
        Console.WriteLine("Deck on table has been updated.");
    }
    
    public PlayerHand GetDealerHandTest()
    {
        return _dealerHand;
    }
    
    public PlayerHand GetPlayererHandTest()
    {
        return _playerHand;
    }

   /* public void AskForACard(CardDeck deck)
    {
        Console.WriteLine("Would you like to take another card?\r\n Write y for yes or n for no");
        string? answer = Console.ReadLine();
        if (answer is "y" or "Y")
        {
            _playerHand.AddCard(CardDeck.GetLastCard(_tableDeck));
            _tableDeck.DeleteLastCard(_tableDeck);
        }
    }
    */
}
