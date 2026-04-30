using UnityEngine;

public class DiceSystem : MonoBehaviour


{
    /*
     * Function: roll
     * Input parameters: None
     * Expected values: No input is required.
     * Output: Returns an integer between 1 and 6.
     * Purpose: Simulates rolling a standard six-sided dice.
     */
    public int roll()
    {
     return Random.Range(1,7); 
    } 

}
