namespace OOP_ICT.Models;

public class Card
{
    private Faces Face;
    private Suits Suit;

    public Card(Faces CardFace, Suits CardSuit)
    {
        Face = CardFace;
        Suit = CardSuit;
    }

    public override string ToString() => 
        Face + " of " + Suit + " ";
}