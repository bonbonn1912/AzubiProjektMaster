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

    public static int startkapital = 50000;
    public static int mitarbeiterStart = 20;
    public static int PersonalCost = 2500;
    public static int buildingsStart = 0;
   
    public static int mitarbeiter;
    public static int balance;
    public static int minDuration = 20;
    public static int maxDuration = 100;
}
