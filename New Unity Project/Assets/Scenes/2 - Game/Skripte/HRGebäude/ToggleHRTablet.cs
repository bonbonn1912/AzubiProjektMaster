using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ToggleHRTablet : MonoBehaviour
{
    public Text MitarbeiterCount;
    public Text PersonalCost;
    public GameObject HRTablet;
    public void OpenHRTablet()
    {
        if(HRTablet != null)
        {
            bool isActive = HRTablet.activeSelf;
            HRTablet.SetActive(!isActive);
            MitarbeiterCount.text = Convert.ToString(GlobalVariables.mitarbeiter);
            PersonalCost.text = GlobalVariables.mitarbeiter * GlobalVariables.PersonalCost + " €"
;
        }
       
    }
}
