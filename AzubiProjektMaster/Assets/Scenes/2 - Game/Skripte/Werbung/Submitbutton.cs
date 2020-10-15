using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submitbutton : MonoBehaviour
{
    public GameObject Submitbuttonwerbung;

    int werbungcheck = GlobalVariables.werbungsswitch;
    public void Werbung()
    {
        switch (werbungcheck)
        {
            //abwarten
            case 1:
                GlobalVariables.kundenanzahl += 10;
                break;

            //buswerbung
            case 2:
                GlobalVariables.kundenanzahl += 10;
                GlobalVariables.balance -= 20000;
                break;
            
            //feier
            case 3:
                GlobalVariables.kundenanzahl += 30;
                GlobalVariables.balance -= 2000;
                break;

            //online
            case 4:
                GlobalVariables.kundenanzahl += 180;
                GlobalVariables.balance -= 45000;
                break;
            
            //plakate
            case 5:
                GlobalVariables.kundenanzahl += 5;
                GlobalVariables.balance -= 500;
                break;

            //tvwerbung
            case 6:
                GlobalVariables.kundenanzahl += 120;
                GlobalVariables.balance -= 30000;
                break;

            //auto
            case 7:
                GlobalVariables.kundenanzahl += 5;
                GlobalVariables.balance -= 500;
                break;

            //zeitung
            case 8:
                GlobalVariables.kundenanzahl += 5;
                GlobalVariables.balance -= 500;
                break;

            //zusatz
            case 9:
                GlobalVariables.kundenanzahl += 5;
                GlobalVariables.balance -= 500;
                break;
        }
    }
}
