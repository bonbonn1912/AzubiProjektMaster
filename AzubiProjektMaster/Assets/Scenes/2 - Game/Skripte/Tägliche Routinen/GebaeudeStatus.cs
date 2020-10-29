using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GebaeudeStatus : MonoBehaviour
{
    public void getBuildingStatus()
    {
        StartCoroutine(buildingsCo());
    }
    IEnumerator buildingsCo()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", GlobalVariables.username);

        WWW www = new WWW("https://dominikw.de/AzubiProjekt/buildingStatusLesenDEV.php", form);
        yield return www;
        string[] results = www.text.Split('-'); //0=BID,1=IT,2=HR,3=DWS,4=InlandFil,5=AuslandFil
        Debug.Log(www.text);
    }
}
