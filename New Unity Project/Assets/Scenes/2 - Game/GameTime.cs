using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    // public Text ausgabeZeit;
    public DailyUpdate ausfuhren;
    public TagUpdaten erhoehen;
    private int day = GlobalVariables.day;
    private int month = 1;
    private int year = 1;
    private float timePassed = 0;
    private float timeCounter;
    private int x = 0;
    
    private void Update() 
    {
        timeCounter = Time.time - timePassed;

        //die Zahl in if-Bedingung ist Tageslänge in Sekunden
          if (timeCounter > 10) 
          {
              timePassed += timeCounter;
              day++;
              GlobalVariables.day = day;
             // Debug.Log(day);
            ausfuhren.execute();
            erhoehen.TagErhoehen();
          }
        
       
    }
}
