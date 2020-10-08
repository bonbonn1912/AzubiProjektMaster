using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabletQuerOeffnen : MonoBehaviour
{
    public GameObject App;
    public GameObject ListAllKredits;
    public Button Value;
    public Button Name;
    public Button Duration;

    public void OpenQuer()
    {
        App.SetActive(false);
        ListAllKredits.SetActive(true);
        Value.interactable = false;
        Name.interactable = false;
        Duration.interactable = false;
    }
}
