using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MitarbeiterPopup : MonoBehaviour
{
    public GameObject HRPopup;

    public void OpenPanel()
    {
        if(HRPopup != null)
        {
            bool isActive = HRPopup.activeSelf;
            HRPopup.SetActive(!isActive);
        }
    }
}
