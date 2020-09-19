using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToogleTablet : MonoBehaviour
{
    public GameObject Tablet;
    public GameObject StatsButton1;
    public GameObject App;
    public GameObject Success;
    public GameObject Abgelehnt;

    public void OpenTablet()
    {
        if(Tablet != null)
        {
            bool isActiveStats = StatsButton1.activeSelf;

            StatsButton1.SetActive(!isActiveStats);
            bool isActive = Tablet.activeSelf;
            Tablet.SetActive(!isActive);
            App.SetActive(false);
            Success.SetActive(false);
            Abgelehnt.SetActive(false);


        }
    }
}
