using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEventPanel : MonoBehaviour
{
    public GameObject EventPanel;
    public GameObject Newspaper;
    public GameObject AuswirkungsPanel;
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
        AuswirkungsPanel.SetActive(false);
        

        MainScene.TabletHandlerActivate();

    }

    public void ZurKenntnis()
    {
        EventPanel.SetActive(false);
        Newspaper.SetActive(false);
        AuswirkungsPanel.SetActive(false);
    }

    
}
