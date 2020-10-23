using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Setting : MonoBehaviour {

    public GameObject Panel;

    public void OpenPanel(){
		if(Panel != null){
			bool isActive = Panel.activeSelf;
			Panel.SetActive(!isActive);
		}
	}
}
