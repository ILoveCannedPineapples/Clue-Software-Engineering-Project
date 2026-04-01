using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/CardSystem")]
public class Card: ScriptableObject
{
    public string cardName;
    public CardType type;
}

public enum CardType
{
    Person,
    Weapon,
    Room
}
