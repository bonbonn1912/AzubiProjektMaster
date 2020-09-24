using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDWSPopup : MonoBehaviour
{
    public GameObject DWSPanel;


    public void OpenPanel()
    {
        if(DWSPanel != null)
        {
            bool isActive = DWSPanel.activeSelf;
            DWSPanel.SetActive(!isActive);
        }
    }
}
