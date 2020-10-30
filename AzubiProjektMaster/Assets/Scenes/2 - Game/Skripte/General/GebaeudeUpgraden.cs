using UnityEngine;
using UnityEngine.UI;
public class GebaeudeUpgraden : MonoBehaviour
{
    public DailyUpdate dailyUpdate;
    public GameObject itGebaeude;
    public GameObject dwsGebaeude;
    public GameObject filialeGebaeude;
    public GameObject hrGebaeude;

    private static GameObject upgradeApp;
    private static GameObject gebaeude;

    private string appPath = "Game/GameHandler/UI/GebäudeUpgradeAPP/";

    /*Liegt dem Upgrade Pupup des Gebaeudes.
      Das jeweilige Gebaeude GameObject muss als Argument draufgezogen werden (parent der Hitbox)
    */
    public void OpenUpgradeApp(GameObject gebaeudeArg)
    {
        upgradeApp = GameObject.Find(appPath);
        gebaeude = gebaeudeArg;

        UpdateTexts();
        upgradeApp.SetActive(!upgradeApp.activeSelf);
        MainScene.TabletHandlerActivate();
    }

    //Liegt auf der GebaeudeUpgradeAPP
    public void Upgrade()
    {
        // Abfrage ob Bedingungen erfüllt sind
        if (gebaeude != null)
        {
            if (GebaeudeRequirements.GetGlobalVariablesStatus(gebaeude) >= GebaeudeRequirements.FilialLevelUpgrade(gebaeude))
            {
                if (GlobalVariables.balance > GebaeudeRequirements.UpgradeKosten(gebaeude))
                {
                    GlobalVariables.balance -= GebaeudeRequirements.UpgradeKosten(gebaeude);
                    SetStatus();//GlobalVariables
                    dailyUpdate.SetBuildingStats();//Datenbank
                    UpdateTexts();
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
    private void SetStatus()
    {
        string gebaeudeName = gebaeude.name;
        switch (gebaeudeName)
        {
            case "ITNeu":
                Debug.Log("Status vor Kauf: " + GlobalVariables.itStatus);
                GlobalVariables.itStatus += 1;
                Debug.Log("Status nach Kauf: " + GlobalVariables.itStatus);
                break;
            case "DWSneu":
                Debug.Log("Status vor Kauf: " + GlobalVariables.dwsStatus);
                GlobalVariables.dwsStatus += 1;
                Debug.Log("Status nach Kauf: " + GlobalVariables.dwsStatus);
                break;
            case "FilialeNeu":
                Debug.Log("Status vor Kauf: " + GlobalVariables.inStatus);
                GlobalVariables.inStatus += 1;
                Debug.Log("Status nach Kauf: " + GlobalVariables.inStatus);
                break;
            case "HRNeu":
                Debug.Log("Status vor Kauf: " + GlobalVariables.hrStatus);
                GlobalVariables.hrStatus += 1;
                Debug.Log("Status nach Kauf: " + GlobalVariables.hrStatus);
                break;
            default:
                Debug.Log("Objekt nicht gefunden. " +
                    "Wurden die gebäude Namen geändert? Skript: ./Gebaeuge/GebaeudeUpgrade");
                break;
        }
    }
    private void UpdateTexts()
    {
        int level = GebaeudeRequirements.GetGlobalVariablesStatus(gebaeude);
        GameObject.Find(appPath + "Fehler").GetComponent<Text>().text = "";
        GameObject.Find(appPath + "FilialenRequirement/FilialenDisplay").GetComponent<Text>().text = GebaeudeRequirements.FilialLevelUpgrade(gebaeude).ToString();
        GameObject.Find(appPath + "GebäudeLevel").GetComponent<Text>().text = level.ToString();
        GameObject.Find(appPath + "GebäudeLevel/UpgradeSprite/UpgradeLevel").GetComponent<Text>().text = (level + 1).ToString();
        GameObject.Find(appPath + "Kosten/KostenDisplay").GetComponent<Text>().text = GebaeudeRequirements.UpgradeKosten(gebaeude).ToString();
    }
    //Fehlermeldungen müssen evtl noch angepasst werden bzgl Ausgabe im Spiel selber
    private void FehlerGeld()
    {
        GameObject.Find(appPath + "Fehler").GetComponent<Text>().text = "Du hast nicht genug Geld!\n" +
            GlobalVariables.balance + "/" + GebaeudeRequirements.UpgradeKosten(gebaeude);
    }
    private void FehlerBedingung()
    {
        GameObject.Find(appPath + "Fehler").GetComponent<Text>().text = "Du brauchst mehr Filialen!\n" +
        GebaeudeRequirements.GetGlobalVariablesStatus(gebaeude) + "/" + GebaeudeRequirements.FilialLevelUpgrade(gebaeude);
    }
    private void FehlerGebaeude()
    {
        Debug.Log("Bitte Gebaeude GameObject auf die Hitbox verlinken! " +
                "Bsp: HR Hitbox OnClick -> Argument: HR Neu GameObjective");
    }
}
