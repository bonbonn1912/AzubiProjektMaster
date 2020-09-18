using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHRpopup : MonoBehaviour
{
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
            FAPopUp.SetActive(false);
            PersonalPanel.SetActive(true);
        }
    }
    public void ClosePersonal()
    {
        PersonalPanel.SetActive(false);
    }

}
