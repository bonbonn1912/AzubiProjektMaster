using UnityEngine;
using UnityEngine.UI;
using System;

public class HROnClicks : MonoBehaviour
{
    public GameObject kaufenApp;
    public GameObject hrPopUpPanel;
    public GameObject hoverText;
    public GameObject hrTablet;
    

    public Text MitarbeiterCount;
    public Text PersonalCost;

    public void OnBuildingClick(GameObject gebaeude)
    {
        if (GlobalVariables.hrStatus == 0)
        {
            KaufenApp(gebaeude);
        }
        else if (GlobalVariables.hrStatus >= 1)
        {
            OpenPopUp();
        }
    }

    private void OpenPopUp()
    {
        if(hrPopUpPanel != null)
        {
            hrPopUpPanel.SetActive(!hrPopUpPanel.activeSelf);
        }
    }
    public void PopupClickUpgrade(GameObject gebaeude)
    {
        GebaeudeUpgraden GebaeudeUpgraden = new GebaeudeUpgraden();
        GebaeudeUpgraden.OpenUpgradeApp(gebaeude);
    }
    private void KaufenApp(GameObject gebaeude)
    {
        GebaeudeKaufen GebaeudeKaufen = new GebaeudeKaufen();
        GebaeudeKaufen.OpenKaufenApp(gebaeude);
    }

    public void OpenHRTablet()
    {
        if (hrTablet != null)
        {
            hrTablet.SetActive(!hrTablet.activeSelf);
            MitarbeiterCount.text = Convert.ToString(GlobalVariables.mitarbeiter);
            PersonalCost.text = GlobalVariables.mitarbeiter * GlobalVariables.PersonalCost + " €";
            MainScene.TabletHandlerActivate();
        }
    }
    public void PopUpHoverText()
    {
        if (hoverText != null)
        {
            hoverText.SetActive(!hoverText.activeSelf);
        }
    }
}
