using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEvent : MonoBehaviour
{
    public GameObject Newspaper;
    public void Awake()
    {
       // Newspaper.SetActive(true);
        StartCoroutine(AblaufNewsPaper());
    }

   

    IEnumerator AblaufNewsPaper()
    {
       // Newspaper.SetActive(true);
        yield return new WaitForSeconds(10);
        Newspaper.SetActive(false);
    }
    
}
