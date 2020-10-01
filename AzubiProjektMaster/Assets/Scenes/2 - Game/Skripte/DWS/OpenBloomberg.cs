using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBloomberg : MonoBehaviour
{
    public GameObject Bloomberg;
    public GameObject AktienhandelTablet;

    public void openBloomBerg()
    {
        bool isActive = Bloomberg.activeSelf;
        Bloomberg.SetActive(!isActive);
        AktienhandelTablet.SetActive(false);
    }
}
