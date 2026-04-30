using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "NewCard")]
public class NewCard : ScriptableObject
{
    // CardName stores the name of the card.
    // Expected value: A valid card name, such as a character, weapon, or room name.
    public string CardName;

    // CardType defines the possible categories a card can belong to.
    // Expected values: PersonCard, WeaponCard, or RoomCard.
    public enum CardType {PersonCard, WeaponCard, RoomCard}

    // Category stores the selected card category for this card.
    // Expected value: One of the CardType enum values.
    public CardType Category;
}
