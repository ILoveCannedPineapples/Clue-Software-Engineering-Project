using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Player
{
    public int Id;    

    public string Name;     
    
    public bool IsActive = true;
    public List<NewCard> Hand = new List<NewCard>();

    // Add drawn card to player's hand
    public void AddCard(NewCard c) => Hand.Add(c);

    // Checks if player has the card in their hand
    public bool HasCard(NewCard c) => Hand.Contains(c);

   
    public NewCard ChooseCardToShow(List<NewCard> options)
    {
        return options[Random.Range(0, options.Count)];
    }
}
