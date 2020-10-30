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
            KaufenApp(gebaeude);
        }
        else if (GlobalVariables.inStatus >= 1)
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
