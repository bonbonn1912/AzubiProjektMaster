using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITOnClicks : MonoBehaviour
{
    public GameObject kaufenApp;
    public GameObject itPupUpPanel;
    public GameObject UpgradeText;

    public DailyUpdate dailyUp;

    public void ITOnClick(GameObject gebaeude)
    {
        if (GlobalVariables.itStatus == 0)
        {
            KaufenApp(gebaeude);
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
    public void PopupClickUpgrade(GameObject gebaeude)
    {
        GebaeudeUpgraden GebaeudeUpgraden = new GebaeudeUpgraden();
        GebaeudeUpgraden.OpenUpgradeApp(gebaeude);
    }

    public void OpenPopUpUpgrade()
    {
        if (UpgradeText != null)
        {
            UpgradeText.SetActive(!UpgradeText.activeSelf);
        }
    }
    private void KaufenApp(GameObject gebaeude)
    {
        GebaeudeKaufen GebaeudeKaufen = new GebaeudeKaufen();
        GebaeudeKaufen.OpenKaufenApp(gebaeude);
    }
}
