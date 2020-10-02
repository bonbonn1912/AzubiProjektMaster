using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GebaeudeStats : MonoBehaviour
{
    public GameObject itGebaeude;
    public GameObject hrGebaeude;
    public GameObject dwsGebaeude;
    public GameObject inFilGebaeude;

    public Sprite baustelle;
    public Sprite itSprite;
    public Sprite hrSprite;
    public Sprite dwsSprite;
    public Sprite inSprite;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(setBuildings());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator setBuildings()
    {
        yield return new WaitForSeconds(0.1f);
        
        if (GlobalVariables.itStatus == 0)
        {
            itGebaeude.GetComponent<SpriteRenderer>().sprite = baustelle;
        }
        else if (GlobalVariables.itStatus == 1)
        {
            itGebaeude.GetComponent<SpriteRenderer>().sprite = itSprite;
        }
        if (GlobalVariables.hrStatus == 0)
        {
            hrGebaeude.GetComponent<SpriteRenderer>().sprite = baustelle;
        }
        else if (GlobalVariables.hrStatus == 1)
        {
            hrGebaeude.GetComponent<SpriteRenderer>().sprite = hrSprite;
        }
        if (GlobalVariables.dwsStatus == 0)
        {
            dwsGebaeude.GetComponent<SpriteRenderer>().sprite = baustelle;
        }
        else if (GlobalVariables.dwsStatus == 1)
        {
            dwsGebaeude.GetComponent<SpriteRenderer>().sprite = dwsSprite;
        }
        if (GlobalVariables.inStatus == 0)
        {
            inFilGebaeude.GetComponent<SpriteRenderer>().sprite = baustelle;
        }
        else if (GlobalVariables.inStatus == 1)
        {
            inFilGebaeude.GetComponent<SpriteRenderer>().sprite = inSprite;
        }
    }
}
