﻿using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class DailyUpdate : MonoBehaviour
{
    public static int check = 10;
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
      //   Debug.Log("Daily statusbarupdate "+www.text);
        string[] results = www.text.Split('-');


        GlobalVariables.PID = Convert.ToInt32(results[0]);
        GlobalVariables.balance = Convert.ToInt32(results[1]);
        GlobalVariables.day = Convert.ToInt32(results[2]);
     //   Debug.Log("globale variable nach zuweisung " + GlobalVariables.day);
        GlobalVariables.mitarbeiter = Convert.ToInt32(results[3]);
       // Debug.Log(GlobalVariables.PID);

      //  Debug.Log("Balance: " + GlobalVariables.balance);
      //  Debug.Log("Spieltage: " + GlobalVariables.day);
     //   Debug.Log("Mitarbeiter aus DatenBank: " + GlobalVariables.mitarbeiter);


    }

    IEnumerator Initco()
    {
       // Debug.Log("in init");
        WWWForm form = new WWWForm();
        form.AddField("username", GlobalVariables.username);
        WWW www = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/statusbarupdate.php", form);
        yield return www;
        Debug.Log("Init datenbank "+www.text);
        string[] results = www.text.Split('-');


        GlobalVariables.PID = Convert.ToInt32(results[0]);
        GlobalVariables.balance = Convert.ToInt32(results[1]);
        GlobalVariables.day = Convert.ToInt32(results[2]);
        GlobalVariables.mitarbeiter = Convert.ToInt32(results[3]);
         check = Convert.ToInt32(results[4]);
        if (check == 1)
        {
            GlobalVariables.Tutorialcheck = true;
            FigurPopUp.GameTimeGlob = 3;
        } 
        else if(check == 0)
        {
           GlobalVariables.Tutorialcheck = false;
            FigurPopUp.GameTimeGlob = 1000;

        }

        // Debug.Log(GlobalVariables.Tutorialcheck);

        //  Debug.Log("Balance: " + GlobalVariables.balance);
        //  Debug.Log("Spieltage: " + GlobalVariables.day);
        // Debug.Log("Mitarbeiter aus DatenBank: " + GlobalVariables.mitarbeiter);
    }

}
