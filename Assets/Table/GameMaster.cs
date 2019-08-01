using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public int Score;
    public bool IsWinner = false;

    private void Update()
    {
        if(IsWinner == false)
        {
            if (Score >= 5)
            {
                print("Výhra");
                IsWinner = true;
            }
        }      

    }
}
