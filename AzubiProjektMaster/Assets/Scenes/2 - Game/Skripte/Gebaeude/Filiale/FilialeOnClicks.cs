using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilialeOnClicks : MonoBehaviour
{
    public GameObject kaufenApp;
    public GameObject inFilPopUpPanel;
    public GameObject kreditTablet;
    public GameObject alleKreditTablet;
    //public GameObject statsTablet;


    public void FilialeOnClick(GameObject gebaeude)
    {
        if (GlobalVariables.inStatus == 0)
        {
            GebaeudeKaufenUpgrade.OpenKaufenApp(gebaeude);
        }
        else if (GlobalVariables.inStatus == 1)
        {
            if (inFilPopUpPanel != null)
            {
                OpenPopUp();
            }

        }
    }
    private void OpenPopUp()
    {
        if (inFilPopUpPanel != null)
        {
            inFilPopUpPanel.SetActive(!inFilPopUpPanel.activeSelf);
        }
    }

    public void OpenKrediteTablet()
    {
        kreditTablet.SetActive(!kreditTablet.activeSelf);
        MainScene.TabletHandlerActivate();
    }
    public void OpenAlleKrediteTablet()
    {
        kreditTablet.SetActive(false);
        alleKreditTablet.SetActive(!alleKreditTablet.activeSelf);
        MainScene.TabletHandlerActivate();
    }

}
