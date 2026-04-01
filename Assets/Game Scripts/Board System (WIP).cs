using UnityEngine;

public class BoardSystem : MonoBehaviour
{
    public static BoardSystem Instance;


    void Awake() // Initialises system before start
   {
       Instance = this;   
   }



}

