using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEventPanel : MonoBehaviour
{
    public GameObject EventPanel;
    public GameObject Newspaper;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenEventPanel_()
    {
        EventPanel.SetActive(true);
        Newspaper.SetActive(false);
    }
}
