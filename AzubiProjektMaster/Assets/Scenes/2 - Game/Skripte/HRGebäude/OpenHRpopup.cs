using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using System;

public class OpenHRpopup : MonoBehaviour
{
    public GameObject PersonalPanel;
  //  public Text Mitarbeitercount;
    public GameObject FAPopUp;
    public void OpenPanel()
    {
        if (FAPopUp != null)
        {
            bool isActive = FAPopUp.activeSelf;
            FAPopUp.SetActive(!isActive);
        }
    }

    public void OpenPersonal()
    {
        if(PersonalPanel != null)
        {
            bool isActive = PersonalPanel.activeSelf;
            FAPopUp.SetActive(true);
            PersonalPanel.SetActive(!isActive);
         //   Mitarbeitercount.text = Convert.ToString(GlobalVariables.mitarbeiter);
        }
    }
    public void ClosePersonal()
    {
        PersonalPanel.SetActive(false);
    }
}
