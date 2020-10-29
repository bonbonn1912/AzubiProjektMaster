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

    /*Liegt dem Upgrade Pupup des Gebaeudes.
      Das jeweilige Gebaeude GameObject muss als Argument draufgezogen werden (parent der Hitbox)
    */
    public void OpenUpgradeApp(GameObject gebaeudeArg)
    {
        upgradeApp = GameObject.Find("Game/GameHandler/UI/GebäudeUpgradeAPP");
        GameObject.Find("Game/GameHandler/UI/GebäudeUpgradeAPP/Kosten/KostenDisplay").GetComponent<Text>().text = GebaeudeRequirements.UpgradeKosten(gebaeudeArg).ToString();
        gebaeude = gebaeudeArg;
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
                Debug.Log("if Status: " + GebaeudeRequirements.GetGlobalVariablesStatus(gebaeude) + " >= " + "Requirement :" + GebaeudeRequirements.FilialLevelUpgrade(gebaeude));
                if (GlobalVariables.balance > GebaeudeRequirements.UpgradeKosten(gebaeude))
                {
                    GlobalVariables.balance -= GebaeudeRequirements.UpgradeKosten(gebaeude);
                    SetStatus(gebaeude);//GlobalVariables
                    dailyUpdate.SetBuildingStats();//Datenbank
                    GameObject.Find("Game/GameHandler/UI/GebäudeUpgradeAPP/Kosten/KostenDisplay").GetComponent<Text>().text = GebaeudeRequirements.UpgradeKosten(gebaeude).ToString();
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
    //Fehlermeldungen müssen evtl noch angepasst werden bzgl Ausgabe im Spiel selber
    private void FehlerGeld()
    {
        Debug.Log("Du hast nicht genug Geld");
    }
    private void FehlerBedingung()
    {
        Debug.Log("Du hast nicht genug Filialen!" +
            GebaeudeRequirements.GetGlobalVariablesStatus(gebaeude) + ">=" + GebaeudeRequirements.FilialLevelUpgrade(gebaeude));
    }
    private void FehlerGebaeude()
    {
        Debug.Log("Bitte Gebaeude GameObject auf die Hitbox verlinken! " +
                "Bsp: HR Hitbox OnClick -> Argument: HR Neu GameObjective");
    }
}
