using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GebaeudeRequirements : MonoBehaviour
{
    private static readonly int itFilialenRequirement = 2;
    private static readonly int dwsFilialenRequirement = 3;
    private static readonly int filialeFilialenRequirement = 0;
    private static readonly int hrFilialenRequirement = 4;

    private static readonly int itKaufKosten = 300000;
    private static readonly int dwsKaufKosten = 350000;
    private static readonly int filialeKaufKosten = 40000;
    private static readonly int hrKaufKosten = 350000;
    public static int FilialLevel(GameObject gebaeude)
    {
        switch (gebaeude.name)
        {
            case "ITNeu":
                return itFilialenRequirement;
            case "DWSNeu":
                return dwsFilialenRequirement;
            case "FilialeNeu":
                return filialeFilialenRequirement;
            case "HRNeu":
                return hrFilialenRequirement;
            default:
                Debug.Log("Objekt nicht gefunden. " +
                    "Wurden die gebäude Namen geändert? Skript: ./Gebaeuge/GebaeudeRequirements ");
                return 1000;
        }
    }
    public static int KaufKosten(GameObject gebaeude)
    {
        switch (gebaeude.name)
        {
            case "ITNeu":
                return itKaufKosten;
            case "DWSNeu":
                return dwsKaufKosten;
            case "FilialeNeu":
                return filialeKaufKosten;
            case "HRNeu":
                return hrKaufKosten;
            default:
                Debug.Log("Objekt nicht gefunden. " +
                    "Wurden die gebäude Namen geändert? Skript: ./Gebaeuge/GebaeudeRequirements ");
                return 1000;
        }
    }
    public static int GetGlobalVariablesStatus(GameObject gebaeude)
    {
        switch (gebaeude.name)
        {
            case "ITNeu":
                return GlobalVariables.itStatus;
            case "DWSNeu":
                return GlobalVariables.dwsStatus;
            case "FilialeNeu":
                return GlobalVariables.inStatus;
            case "HRNeu":
                return GlobalVariables.hrStatus;
            default:
                Debug.Log("Objekt nicht gefunden. " +
                    "Wurden die gebäude Namen geändert? Skript: ./Gebaeuge/GebaeudeRequirements ");
                return 1000;
        }
    }
}
