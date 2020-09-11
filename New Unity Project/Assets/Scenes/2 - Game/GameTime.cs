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
            Debug.Log("ID: " + results[0]);
            Debug.Log("Balance: " + results[1]);
            Debug.Log("Spieltage: " + results[2]);
            Debug.Log("Mitarbeiter: " + results[3]);


        }
    }
}
