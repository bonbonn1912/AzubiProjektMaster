using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeitungtrigger : MonoBehaviour
{
    public GameObject Zeitung;

    public void open()
    {
        bool isActive = Zeitung.activeSelf;
        Zeitung.SetActive(!isActive);
    }
}
