using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class DeckSystem : MonoBehaviour
{
   [SerializeField]
   public NewCard[] card;

   public int cardIndex = 0;
    /*
     * Function: ShuffleCard
     * Input parameters: None
     * Expected values: The card array should contain one or more NewCard objects.
     * Output: None
     * Purpose: Randomly shuffles all cards in the deck using the Fisher-Yates shuffle method.
     */
public void ShuffleCard() // using Fisher-Yates shuffle
    {
      for (int i = card.Length - 1; i > 0; i-- )
        {
          int j = Random.Range(0, i + 1);
          NewCard temp = card[i];
          card[i] = card[j];
          card[j] = temp;  


        }
    
       cardIndex = 0;
    /*
     * Function: DrawCard
     * Input parameters: None
     * Expected values: The card array should contain NewCard objects and cardIndex should be within the deck range.
     * Output: Returns a NewCard object if cards are available. Returns null if there are no cards left.
     * Purpose: Draws the next card from the deck and moves the card index forward by one.
     */
    }

public NewCard DrawCard()
    {
        if (cardIndex >= card.Length)
        {
            Debug.LogWarning("No more cards");
            return null;
        }

        NewCard drawnCard = card[cardIndex];
        cardIndex++;
        return drawnCard;
    }




}
