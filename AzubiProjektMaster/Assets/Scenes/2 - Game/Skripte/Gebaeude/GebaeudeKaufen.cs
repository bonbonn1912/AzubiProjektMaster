﻿using UnityEngine;
using UnityEngine.UI;

public class GebaeudeKaufen : MonoBehaviour
{
    public DailyUpdate dailyUpdate;

    public GameObject itGebaeude;
    public GameObject dwsGebaeude;
    public GameObject filialeGebaeude;
    public GameObject hrGebaeude;

    private static GameObject kaufenApp;
    private static GameObject gebaeude;

    /*Liegt auf der Hitbox des Gebaeudes.
      Das jeweilige Gebaeude GameObject muss als Argument draufgezogen werden (parent der Hitbox)
    */
    public static void OpenKaufenApp(GameObject gebaeudeArg)
    {
        kaufenApp = GameObject.Find("Game/GameHandler/UI/GebäudeKaufenAPP");
        GameObject.Find("Game/GameHandler/UI/GebäudeKaufenAPP/Kosten/KostenDisplay").GetComponent<Text>().text = GebaeudeRequirements.KaufKosten(gebaeudeArg).ToString();
        gebaeude = gebaeudeArg;
        kaufenApp.SetActive(!kaufenApp.activeSelf);
        MainScene.TabletHandlerActivate();
    }
    //Liegt auf der GebaeudeKaufenAPP
    public void Kaufen()
    {
        // Abfrage ob Bedingungen erfüllt sind
        if (gebaeude != null)
        {
            if (GebaeudeRequirements.GetGlobalVariablesStatus(gebaeude) >= GebaeudeRequirements.FilialLevel(gebaeude))
            {
                if (GlobalVariables.balance > GebaeudeRequirements.KaufKosten(gebaeude))
                {
                    GlobalVariables.balance -= GebaeudeRequirements.KaufKosten(gebaeude);
                    SetStatus(gebaeude);//GlobalVariables
                    dailyUpdate.SetBuildingStats();//Datenbanks
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
        else
        {
            FehlerGebaeude();
        }
    }
    private void SetStatus(GameObject gebaeude)
    {
        string gebaeudeName = gebaeude.name;
        switch (gebaeudeName)
        {
            case "ITNeu":
                GlobalVariables.itStatus = 1;
                break;
            case "DWSneu":
                GlobalVariables.dwsStatus = 1;
                break;
            case "FilialeNeu":
                GlobalVariables.inStatus = 1;
                break;
            case "HRNeu":
                GlobalVariables.hrStatus = 1;
                break;
            default:
                Debug.Log("Objekt nicht gefunden. " +
                    "Wurden die gebäude Namen geändert? Skript: ./Gebaeuge/GebaeudeKaufen");
                break;
        }
    }
    //Fehlermeldungen müssen evtl noch angepasst werden bzgl Ausgabe im Spiel selber
    private void FehlerGeld()
    {
        Debug.Log("Du hast nicht genug Geld");
    }
    private void FehlerBedingung()
    {
        Debug.Log("Du hast nicht genug Filialen!" +
            GebaeudeRequirements.GetGlobalVariablesStatus(gebaeude) + ">=" + GebaeudeRequirements.FilialLevel(gebaeude));
    }
    private void FehlerGebaeude()
    {
        Debug.Log("Bitte Gebaeude GameObject auf die Hitbox verlinken! " +
                "Bsp: HR Hitbox OnClick -> Argument: HR Neu GameObjective");
    }
}
