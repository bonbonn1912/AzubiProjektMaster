using UnityEngine;

public class GebaeudeRequirements : MonoBehaviour
{
    private static int itFilialenRequirement = 2;
    private static int dwsFilialenRequirement = 3;
    private static int filialeFilialenRequirement = 0;
    private static int hrFilialenRequirement = 4;

    private static int itKaufKosten = 150000;
    private static int dwsKaufKosten = 350000;
    private static int filialeKaufKosten = 40000;
    private static int hrKaufKosten = 100000;

    private static int itFilialenRequirementUpgrade;
    private static int dwsFilialenRequirementUpgrade;
    private static int filialeFilialenRequirementUpgrade;
    private static int hrFilialenRequirementUpgrade;

    private static int itUpgradeKosten;
    private static int dwsUpgradeKosten;
    private static int filialeUpgradeKosten;
    private static int hrUpgradeKosten;

    public static int FilialLevel(GameObject gebaeude)
    {
        switch (gebaeude.name)
        {
            case "ITNeu":
                return itFilialenRequirement;
            case "DWSneu":
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
            case "DWSneu":
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
            //Hier Building level requirement für jedes gebäude angeben. Momentan beziehen sich alle auf die Filiale.
            case "ITNeu":
                return GlobalVariables.inStatus;
            case "DWSneu":
                return GlobalVariables.inStatus;
            case "FilialeNeu":
                return GlobalVariables.inStatus;
            case "HRNeu":
                return GlobalVariables.inStatus;
            default:
                Debug.Log("Objekt nicht gefunden. " +
                    "Wurden die gebäude Namen geändert? Skript: ./Gebaeuge/GebaeudeRequirements ");
                return 1000;
        }
    }
    public static int FilialLevelUpgrade(GameObject gebaeude)
    {
        switch (gebaeude.name)
        {
            case "ITNeu":
                itFilialenRequirementUpgrade = itFilialenRequirement + GlobalVariables.itStatus * GlobalVariables.itStatus;
                return itFilialenRequirementUpgrade;
            case "DWSneu":
                dwsFilialenRequirementUpgrade = dwsFilialenRequirement + GlobalVariables.dwsStatus * GlobalVariables.dwsStatus;
                return dwsFilialenRequirementUpgrade;
            case "FilialeNeu":
                filialeFilialenRequirementUpgrade = filialeFilialenRequirement;
                return filialeFilialenRequirementUpgrade;
            case "HRNeu":
                hrFilialenRequirementUpgrade = hrFilialenRequirement + GlobalVariables.hrStatus * GlobalVariables.hrStatus;
                return hrFilialenRequirementUpgrade;
            default:
                Debug.Log("Objekt nicht gefunden. " +
                    "Wurden die gebäude Namen geändert? Skript: ./Gebaeuge/GebaeudeRequirements ");
                return 1000;
        }
    }
    public static int UpgradeKosten(GameObject gebaeude)
    {
        switch (gebaeude.name)
        {
            case "ITNeu":
                itUpgradeKosten = itKaufKosten / 10 * (GlobalVariables.itStatus * GlobalVariables.itStatus + 1);
                return itUpgradeKosten;
            case "DWSneu":
                dwsUpgradeKosten = dwsKaufKosten / 10 * (GlobalVariables.dwsStatus * GlobalVariables.dwsStatus + 1);
                return dwsUpgradeKosten;
            case "FilialeNeu":
                filialeUpgradeKosten = filialeKaufKosten / 10 * (GlobalVariables.inStatus * GlobalVariables.inStatus + 1);
                return filialeUpgradeKosten;
            case "HRNeu":
                hrUpgradeKosten = hrKaufKosten / 10 * (GlobalVariables.hrStatus * GlobalVariables.hrStatus + 1);
                return hrUpgradeKosten;
            default:
                Debug.Log("Objekt nicht gefunden. " +
                    "Wurden die gebäude Namen geändert? Skript: ./Gebaeuge/GebaeudeRequirements ");
                return 1000;
        }
    }
}
