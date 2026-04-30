using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class DeckSystem : MonoBehaviour
{
   [SerializeField]
   public NewCard[] card;

   public int cardIndex = 0;

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
