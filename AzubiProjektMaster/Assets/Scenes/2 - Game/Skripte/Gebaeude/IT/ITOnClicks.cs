using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITOnClicks : MonoBehaviour
{
    public GameObject kaufenApp;
    public GameObject itPupUpPanel;

    public DailyUpdate dailyUp;

    public void ITOnClick(GameObject gebaeude)
    {
        if (GlobalVariables.itStatus == 0)
        {
            GebaeudeKaufenUpgrade.OpenKaufenApp(gebaeude);
        }
        else if (GlobalVariables.itStatus >= 1)
        {
            OpenPopUp();
        }
    }
    private void OpenPopUp()
    {
        if (itPupUpPanel != null)
        {
            itPupUpPanel.SetActive(!itPupUpPanel.activeSelf);
        }
    }
    public void Kaufen()
    {
        // Abfrage ob Bedingungen erfüllt sind
        if (GlobalVariables.inStatus >= 2)
        {
            if (GlobalVariables.balance > 1000)
            {
                GlobalVariables.balance = GlobalVariables.balance - 1000;
                GlobalVariables.itStatus = 1;
                dailyUp.SetBuildingStats();
                kaufenApp.SetActive(false);
            }
            else
            {
                FehlerGeld();
            }
        }
        else
        {
            FehlerBedingung();
        }
    }

    //Fehlermeldungen müssen evtl noch angepasst werden bzgl Ausgabe im Spiel selber
    public void FehlerGeld()
    {
        Debug.Log("Du hast nicht genug Geld");
    }
    public void FehlerBedingung()
    {
        Debug.Log("Du hast nicht genug Filialen");
    }
}
