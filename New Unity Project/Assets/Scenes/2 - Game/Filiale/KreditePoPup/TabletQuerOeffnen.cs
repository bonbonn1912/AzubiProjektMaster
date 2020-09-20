using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabletQuerOeffnen : MonoBehaviour
{
    public GameObject App;
    public GameObject ListAllKredits;
    public Button Aufsteigend;
    public Button Absteigend;

    public void OpenQuer()
    {
        App.SetActive(false);
        ListAllKredits.SetActive(true);
        Aufsteigend.interactable = false;
        Absteigend.interactable = false;
    }
}
