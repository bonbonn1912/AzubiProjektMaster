﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalVariables
{
    public static string username;
    public static int day;


    public static bool LoggedIn { get { return username != null; } }

    public static void LogOut()
    {
        username = null;
    }

    public static int startkapital = 50000;
    public static int mitarbeiterStart = 20;
    public static int buildingsStart = 0;
}

