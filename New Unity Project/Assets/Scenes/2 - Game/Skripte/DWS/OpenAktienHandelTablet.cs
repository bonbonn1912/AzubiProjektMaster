using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenAktienHandelTablet : MonoBehaviour
{
    public GameObject AktienHandelTablet;
    public Text DepotInhaberTextbox;
    public Color InhaberTextbox;

    public void OpenTablet()
    {
      //  Debug.Log("OPen Tablet");
        if(AktienHandelTablet != null)
        {
            bool isActive = AktienHandelTablet.activeSelf;
            AktienHandelTablet.SetActive(!isActive);
           // DepotInhaberTextbox.color = InhaberTextbox;
            DepotInhaberTextbox.text = GlobalVariables.username;
        }
    }
}
