using UnityEngine;

public class DiceSystem : MonoBehaviour


{
    public int roll()
    {
     return Random.Range(1,7); 
    } 

}
