using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVariables : MonoBehaviour
{
    
    public static string username;
    
    public static int day;
    public static int PID;
    public static string registrationResult = null;


    public static bool LoggedIn { get { return username != null; } }

    public static void LogOut()
    {
        username = null;
    }

    public static bool Tutorialcheck= true;
    public static int startkapital = 50000;
    public static int mitarbeiterStart = 20;
    public static int PersonalCost = 4000;
    public static int buildingsStart = 0;
   
    public static int mitarbeiter;
    public static int balance = 10000000;
    public static int minDuration = 20;
    public static int maxDuration = 100;
    public static int Mitarbeitergewinn = 5000;

    public static int Aktie1KursGlob;
    public static int Aktie2KursGlob;
    public static int Aktie3KursGlob;
    public static int Aktie4KursGlob;
    public static int Aktie5KursGlob;

    public static int AktienIndex = 250;

    public static int itStatus=1;
    public static int hrStatus=1;
    public static int dwsStatus=1;
    public static int inStatus=1;
    public static int ausStatus=1;
}
