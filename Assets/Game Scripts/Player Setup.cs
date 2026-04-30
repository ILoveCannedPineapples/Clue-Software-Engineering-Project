using UnityEngine;
using System.Collections.Generic;

public class PlayerSetup : MonoBehaviour
{
    [Header("Game configuration")]
    [Range(2, 6)]
    public int  numberOfPlayers = 4;   // set in the inspector

    [Header("References")]
    public DeckSystem   deck;                  // Calling deck GameObject
    public Board  board;                 // Calling board GameObject

    [Header("Result")]
    public List<Player> players = new List<Player>();

    
    public void Initialise()
    {
       // Initialising objects for player
        players.Clear();
        for (int i = 0; i < numberOfPlayers; i++)
        {
            Player p = new Player
            {
                Id   = i,
                Name = $"Player {i + 1}"
            };
            players.Add(p);
        }

        deck.ShuffleCard();               // Using shuffleCard method from Deck

        
        int cardsPerPlayer = deck.card.Length / numberOfPlayers;
        for (int round = 0; round < cardsPerPlayer; round++)
        {
            foreach (var p in players)
            {
                NewCard drawn = deck.DrawCard();
                if (drawn != null) p.AddCard(drawn);
            }
        }

        Debug.Log($"[PlayerSetup] Dealt {cardsPerPlayer} cards to each of {numberOfPlayers} players.");
    }
}

