using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenZeitung : MonoBehaviour
{
    public GameObject ZeitungPanel;

    public void OeffneZeitung()
    {
        ZeitungPanel.SetActive(true);
    }
}
