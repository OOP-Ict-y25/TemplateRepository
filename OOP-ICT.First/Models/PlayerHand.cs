namespace OOP_ICT.Models;

/// <summary>
/// Class PlayerHand implements hand for each player in game, including dealer. 
/// </summary>
public class PlayerHand
{
    internal readonly List<Card> Hand = new List<Card>();

    /// <summary>
    /// Method AddCard adding card, given by a dealer, to the hand.
    /// </summary>
    /// <param name="card"></param>
    public void AddCard(Card card)
    {
        Hand.Add(card);
    }
    
    /// <summary>
    /// Method CleanHand emptying hand of a player.
    /// </summary>
    public void CleanHand()
    {
        Hand.Clear();
    }
}