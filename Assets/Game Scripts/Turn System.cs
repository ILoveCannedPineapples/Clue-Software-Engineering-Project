using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
   
    
        public List<Player> players;
        int currentPlayerIndex = 0;

        public Player CurrentPlayer()
    {
        return players[currentPlayerIndex];
    }
        public void NextTurn()
    {
        currentPlayerIndex++;
        currentPlayerIndex %= players.Count;
    }
    
}
