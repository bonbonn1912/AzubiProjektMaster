using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenKreditVergabeApp : MonoBehaviour
{
    public GameObject KreditVergabeApp;
    public GameObject ListApp;
    public GameObject MainApp;
 

    public void OpenApp()
    {
        if(KreditVergabeApp != null)
        {
            KreditVergabeApp.SetActive(true);
        }
    }

    public void OpenListApp()
    {
        
            KreditVergabeApp.SetActive(false);
            ListApp.SetActive(true);
        
       
    }

    public void BackToMenu()
    {
        KreditVergabeApp.SetActive(false);

    }

    public void BackFromList()
    {
        Debug.Log("Back Knopf");
        ListApp.SetActive(false);
        KreditVergabeApp.SetActive(false);
        MainApp.SetActive(true);

      //  KrediteAnTagX.text = GlobalVariables.
    }

}
