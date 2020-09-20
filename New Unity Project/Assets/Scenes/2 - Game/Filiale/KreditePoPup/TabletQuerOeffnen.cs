using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletQuerOeffnen : MonoBehaviour
{
    public GameObject App;
    public GameObject ListAllKredits;

    public void OpenQuer()
    {
        App.SetActive(false);
        ListAllKredits.SetActive(true);
    }
}
