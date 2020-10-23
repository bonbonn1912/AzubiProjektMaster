using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SaveVolume : MonoBehaviour
{
    public Slider MVolume;
    public Scrollbar CashSound;

    // Start is called before the first frame update
    void Start(){
        MVolume.value = PlayerPrefs.GetFloat("musikVolume");
        CashSound.value = PlayerPrefs.GetFloat("cashSound");
    }

    void Update(){
        PlayerPrefs.SetFloat("musikVolume", MVolume.value);
        PlayerPrefs.SetFloat("cashSound", CashSound.value);

    }
}
