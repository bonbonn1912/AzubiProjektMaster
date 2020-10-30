using UnityEngine;
using UnityEngine.UI;

public class DWSOnClicks : MonoBehaviour
{
    public GameObject kaufenApp;
    public GameObject dwsPopUpPanel;
    public GameObject graphTablet;
    public GameObject aktienTablet;
    public GameObject AktienHandelPopupText;
    public GameObject graphPopUpText;
    public GameObject UpgradeText;
    public GameObject orderVolumenDynamischDefault;
    public Color DepotInhaberTextboxColor;
    public Text DepotInhaberTextbox;

    public DailyUpdate dailyUp;

    public void DWSOnClick(GameObject gebaeude)
    {
        if (GlobalVariables.dwsStatus == 0)
        {
            KaufenApp(gebaeude);
        }
        else if (GlobalVariables.dwsStatus >= 1)
        {
            OpenPupup();
        }
    }
    private void OpenPupup()
    {
        if (dwsPopUpPanel != null)
        {
            dwsPopUpPanel.SetActive(!dwsPopUpPanel.activeSelf);
        }
    }
    private void KaufenApp(GameObject gebaeude)
    {
        GebaeudeKaufen GebaeudeKaufen = new GebaeudeKaufen();
        GebaeudeKaufen.OpenKaufenApp(gebaeude);
    }
    public void PopupClickUpgrade(GameObject gebaeude)
    {
        GebaeudeUpgraden GebaeudeUpgraden = new GebaeudeUpgraden();
        GebaeudeUpgraden.OpenUpgradeApp(gebaeude);
    }
    public void OpenGraphTablet()
    {
        graphTablet.SetActive(!graphTablet.activeSelf);
        MainScene.TabletHandlerActivate();
    }
    public void OpenAktienTablet()
    {
        if (aktienTablet != null)
        {
            aktienTablet.SetActive(!aktienTablet.activeSelf);
            DepotInhaberTextbox.text = GlobalVariables.username;
            MainScene.TabletHandlerActivate();
        }
    }
    public void AktienPopUpHover()
    {
        if (AktienHandelPopupText != null)
        {
            AktienHandelPopupText.SetActive(!AktienHandelPopupText.activeSelf);
        }
    }

    public void GraphPopUpHover()
    {
        if (graphPopUpText != null)
        {
            graphPopUpText.SetActive(!graphPopUpText.activeSelf);
        }
    }

    public void OpenPopUpUpgrade()
    {
        if (UpgradeText != null)
        {
            UpgradeText.SetActive(!UpgradeText.activeSelf);
        }
    }
}
