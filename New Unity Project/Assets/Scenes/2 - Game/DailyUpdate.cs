﻿using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class DailyUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //test
    public void execute()
    {
     //   Debug.Log("Coroutine wird gestartet");
        StartCoroutine(StatusBarUpdate());
    }

    public void Init()
    {
        StartCoroutine(Initco());
    }
    IEnumerator StatusBarUpdate()
    {
      //  Debug.Log("Routine getriggert");
        WWWForm form = new WWWForm();
        form.AddField("username", GlobalVariables.username);
        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/statusbarupdate.php", form);
        yield return www;
        // Debug.Log(www.text);
        string[] results = www.text.Split('-');


        GlobalVariables.PID = Convert.ToInt32(results[0]);
        GlobalVariables.balance = Convert.ToInt32(results[1]);
        GlobalVariables.day = Convert.ToInt32(results[2]);
        GlobalVariables.mitarbeiter = Convert.ToInt32(results[3]);
       // Debug.Log(GlobalVariables.PID);

      //  Debug.Log("Balance: " + GlobalVariables.balance);
      //  Debug.Log("Spieltage: " + GlobalVariables.day);
     //   Debug.Log("Mitarbeiter aus DatenBank: " + GlobalVariables.mitarbeiter);


    }

    IEnumerator Initco()
    {
        Debug.Log("in init");
        WWWForm form = new WWWForm();
        form.AddField("username", GlobalVariables.username);
        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/statusbarupdate.php", form);
        yield return www;
         Debug.Log(www.text);
        string[] results = www.text.Split('-');


        GlobalVariables.PID = Convert.ToInt32(results[0]);
        GlobalVariables.balance = Convert.ToInt32(results[1]);
        GlobalVariables.day = Convert.ToInt32(results[2]);
        GlobalVariables.mitarbeiter = Convert.ToInt32(results[3]);
        Debug.Log(GlobalVariables.PID);

        //  Debug.Log("Balance: " + GlobalVariables.balance);
        //  Debug.Log("Spieltage: " + GlobalVariables.day);
       // Debug.Log("Mitarbeiter aus DatenBank: " + GlobalVariables.mitarbeiter);
    }
}
