using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDWSPopup : MonoBehaviour
{
    public GameObject DWSPanel;


    public void OpenPanel()
    {
      //  Debug.Log("Open Panel");
        if(DWSPanel != null)
        {
            bool isActive = DWSPanel.activeSelf;
            DWSPanel.SetActive(!isActive);
        }
    }
}
