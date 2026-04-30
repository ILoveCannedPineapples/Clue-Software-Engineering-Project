using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
   
    
        public List<Player> players;
        int currentPlayerIndex = 0;
/*
     * Function: CurrentPlayer
     * Input parameters: None
     * Expected values: The players list should contain at least one Player object.
     * Output: Returns the Player object whose turn it currently is.
     * Purpose: Gets the current player based on the currentPlayerIndex value.
     */
        public Player CurrentPlayer()
    {
        return players[currentPlayerIndex];
    }
       /*
     * Function: NextTurn
     * Input parameters: None
     * Expected values: The players list should contain at least one Player object.
     * Output: None
     * Purpose: Moves the turn to the next player. If the final player has taken their turn, it loops back to the first player.
     */
        public void NextTurn()
    {
        currentPlayerIndex++;
        currentPlayerIndex %= players.Count;
    }
    
}
