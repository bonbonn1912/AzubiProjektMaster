using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HauptOnClicks : MonoBehaviour
{
    public GameObject hauptPopUpPanel;
    public GameObject hoverText;
    public GameObject hoverText1;

    public void OnBuildingClick(GameObject gebaeude)
    {
        if (GlobalVariables.ausStatus == 0)
        {
            Debug.Log("Error: Foreign_Branch (benutzt für Hauptfiliale) muss immer 1 sein!");
            OpenPopUp();
        }
        else if (GlobalVariables.ausStatus >= 1)
        {
            OpenPopUp();
        }
    }

    private void OpenPopUp()
    {
        if (hauptPopUpPanel != null)
        {
            hauptPopUpPanel.SetActive(!hauptPopUpPanel.activeSelf);
        }
    }
    /*
    public void OpenHauptTablet()
    {
        if (hauptTablet != null)
        {
            hauptTablet.SetActive(!hauptTablet.activeSelf);
            MainScene.TabletHandlerActivate();
        }
    }
    public void PopUpHoverText()
    {
        if (hoverText != null)
        {
            hoverText.SetActive(!hoverText.activeSelf);
        }
    }*/

    public void AchievementsHover()
    {
        if (hoverText != null)
        {
            hoverText.SetActive(!hoverText.activeSelf);
        }
    }

    public void WerbungHover() {

        if (hoverText1 != null)
        {
            hoverText1.SetActive(!hoverText1.activeSelf);
        }
    }
}
