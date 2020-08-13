using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebTest : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        WWW request = new WWW("http://localhost/sqlconnect/webtest.php");
        yield return request;
        string[] webresults = request.text.Split('\t');
        Debug.Log(webresults[0]);
        double webnumer = double.Parse(webresults[1]);
        webnumer *= 2;
        Debug.Log(webnumer);
    }
}
