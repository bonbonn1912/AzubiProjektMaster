using System.Collections;
using System.Collections.Generic;
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

    public GameObject orderVolumenDynamischDefault;
    public Color DepotInhaberTextboxColor;
    public Text DepotInhaberTextbox;

    public DailyUpdate dailyUp;

    public void DWSOnClick(GameObject gebaeude)
    {
        if (GlobalVariables.dwsStatus == 0)
        {
            GebaeudeKaufen.OpenKaufenApp(gebaeude);
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
}
