using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "NewCard")]
public class NewCard : ScriptableObject
{

public string CardName;

public enum CardType {PersonCard, WeaponCard, RoomCard}
public CardType Category;

}