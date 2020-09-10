using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    // public Text ausgabeZeit;

    private int day = GlobalVariables.day;
    private int month = 1;
    private int year = 1;
    private float timePassed = 0;
    private float timeCounter;

    private void Update() 
    {
        timeCounter = Time.time - timePassed;
         if (timeCounter > 5) 
         {
             timePassed += timeCounter;
             day++;
             GlobalVariables.day = day;
             Debug.Log(day);
         } 
    }
}
