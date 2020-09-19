using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenKreditVergabeApp : MonoBehaviour
{
    public GameObject KreditVergabeApp;

    public void OpenApp()
    {
        if(KreditVergabeApp != null)
        {
            KreditVergabeApp.SetActive(true);
        }
    }

    public void BackToMenu()
    {
        KreditVergabeApp.SetActive(false);
    }
}
