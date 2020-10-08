using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using System;

public class OpenHRpopup : MonoBehaviour
{
    public GameObject kaufenApp;
    public GameObject personalPopUpPanel;
    public GameObject personalPopUp;
    public GameObject hoverText;
    public GameObject hrTablet;
    

    public Text MitarbeiterCount;
    public Text PersonalCost;

    public void OnBuildingClick()
    {
        if (GlobalVariables.hrStatus == 0)
        {
            kaufenApp.SetActive(!kaufenApp.activeSelf);
            MainScene.TabletHandlerActivate();
        }
        else if (GlobalVariables.hrStatus == 1)
        {
            OpenPopUp();
        }
    }

    private void OpenPopUp()
    {
        if(personalPopUpPanel != null && personalPopUp != null )
        {
            personalPopUpPanel.SetActive(!personalPopUpPanel.activeSelf);
            personalPopUp.SetActive(!personalPopUp.activeSelf);
        }
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
