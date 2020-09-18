using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverButtonHR : MonoBehaviour
{
    public GameObject Personal;
    // Start is called before the first frame update

    public void Sichtbar()
    {
        if (Personal != null)
        {
            bool isActive = Personal.activeSelf;
            Personal.SetActive(!isActive);
        }
    }
}
