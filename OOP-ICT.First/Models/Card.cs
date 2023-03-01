namespace OOP_ICT;
public class Card
{

    public string Suit { get; set; }
    public string FaceValue { get; set; }
    public Card(string suit, string faceValue)
    {
        Suit = suit;
        FaceValue = faceValue;
    }
    public string Display()
    {
        return string.Format("{0} of {1}", FaceValue, Suit);
    }
}