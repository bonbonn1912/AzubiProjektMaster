using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAktienHandelTablet : MonoBehaviour
{
    public GameObject AktienHandelTablet;

    public void OpenTablet()
    {
        if(AktienHandelTablet != null)
        {
            bool isActive = AktienHandelTablet.activeSelf;
            AktienHandelTablet.SetActive(!isActive);
        }
    }
}
