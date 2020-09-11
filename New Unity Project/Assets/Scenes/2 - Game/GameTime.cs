using System;
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
    private int x = 0;

    private void Update() 
    {
        /* timeCounter = Time.time - timePassed;
          if (timeCounter > 5) 
          {
              timePassed += timeCounter;
              day++;
              GlobalVariables.day = day;
              Debug.Log(day);
          } */
         // Debug.Log("test");
        
        if (x == 80)
        {
            StartCoroutine(StatusBarUpdate());
            x = 0;
            Debug.Log("trigger Routine");
        }
        x++;
        IEnumerator StatusBarUpdate()
        {
            WWWForm form = new WWWForm();
            form.AddField("username", GlobalVariables.username);
            WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/statusbarupdate.php", form);
            yield return www;
            string[] results = www.text.Split('-');

            

            GlobalVariables.balance = Convert.ToInt32(results[1]);
            GlobalVariables.day = Convert.ToInt32(results[2]);
            GlobalVariables.mitarbeiter = Convert.ToInt32(results[3]);

          
            Debug.Log("Balance: " + GlobalVariables.balance);
            Debug.Log("Spieltage: " + GlobalVariables.day);
            Debug.Log("Mitarbeiter: " + GlobalVariables.mitarbeiter);


        }
    }
}
