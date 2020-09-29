using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
//using UnityEditor.Build;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class Window_Graph : MonoBehaviour {

    [SerializeField] private Sprite circleSprite;
    private RectTransform graphContainer;
    private RectTransform labelTemplateX;
    private RectTransform labelTemplateY;
    private RectTransform dashTemplateX;
    private RectTransform dashTemplateY;
    private List<GameObject> gameObjectList;
  //  public static List<int> valueList1 = new List<int>() {10,100};
   public static List<int> valueList2 = new List<int>() {10,100};
    public static List<int> valueList3 = new List<int>() {10,100};
    public static List<int> valueList4 = new List<int>() {10,100};
    public static List<int> valueList5 = new List<int>() {10,100};
    public static List<int> valueList6 = new List<int>() {10,100};
    public int daybefore = GlobalVariables.day;
    public int switcher = 1;

    public List<int> locallist;
    public List<int> locallist2;
    public List<int> locallist3;
    public List<int> locallist4;
    public List<int> locallist5;

    public GameObject TageHochAktie1;
    public GameObject KursHochAktie1;
    public GameObject TageTiefAktie1;
    public GameObject KursTiefAKtie1;

    public bool liste1gedreht;

    public GameObject Anzeige;

    int anzahlWerte = GlobalVariables.AktienIndex;
    private void Awake() {
        graphContainer = transform.Find("graphContainer").GetComponent<RectTransform>();
        labelTemplateX = graphContainer.Find("labelTemplateX").GetComponent<RectTransform>();
        labelTemplateY = graphContainer.Find("labelTemplateY").GetComponent<RectTransform>();
        dashTemplateX = graphContainer.Find("dashTemplateX").GetComponent<RectTransform>();
        dashTemplateY = graphContainer.Find("dashTemplateY").GetComponent<RectTransform>();
        gameObjectList = new List<GameObject>();
       
        
        
       // StartCoroutine(ExecSQL());
    }
    public void SwitchtoAktie1()
    {
        locallist = AktienKurseLesen.valueList1;
        switcher = 1;
       // locallist.Reverse();
        ShowGraph(locallist, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        Anzeige.GetComponent<Text>().text = "Aktie1";
    }
  public void SwitchtoAktie2()
    {
        locallist2 = AktienKurseLesen.valueList2;
        switcher = 2;
      //  locallist2.Reverse();
        ShowGraph(locallist2, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        Anzeige.GetComponent<Text>().text = "Aktie2";
    }
    public void SwitchtoAktie3()
    {
        locallist3 = AktienKurseLesen.valueList3;
        switcher = 3;
     //   locallist3.Reverse();
        ShowGraph(locallist3, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        Anzeige.GetComponent<Text>().text = "Aktie3";
    }
    public void SwitchtoAktie4()
    {

        locallist4 = AktienKurseLesen.valueList4;
        switcher = 4;
      // locallist4.Reverse();
        ShowGraph(locallist4, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        Anzeige.GetComponent<Text>().text = "Aktie4";
    }
    public void SwitchtoAktie5()
    {
        locallist5 = AktienKurseLesen.valueList5;
        switcher = 5;
     //   locallist5.Reverse();
        ShowGraph(locallist5, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        Anzeige.GetComponent<Text>().text = "Aktie5";
    }

    public void switchwerte30()
    {
        anzahlWerte = 30;
        if(switcher == 1)
        {
            locallist = AktienKurseLesen.valueList1;
            switcher = 1;
         //   locallist.Reverse();
            ShowGraph(locallist, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        }
        if(switcher == 2)
        {

            locallist2 = AktienKurseLesen.valueList2;
            switcher = 2;
          //  locallist2.Reverse();
            ShowGraph(locallist2, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        }
        if (switcher == 3)
        {

            locallist3 = AktienKurseLesen.valueList3;
            switcher = 3;
         //   locallist3.Reverse();
            ShowGraph(locallist3, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        }
        if(switcher == 4)
        {

            locallist4 = AktienKurseLesen.valueList4;
            switcher = 4;
        //    locallist4.Reverse();
            ShowGraph(locallist4, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        }
        if(switcher == 5)
        {
            locallist5 = AktienKurseLesen.valueList5;
            switcher = 5;
          //  locallist5.Reverse();
            ShowGraph(locallist5, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        }

    }

    public void switchwerte60()
    {
        anzahlWerte = 60;
        if (switcher == 1)
        {
            locallist = AktienKurseLesen.valueList1;
            switcher = 1;
         //   locallist.Reverse();
            ShowGraph(locallist, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        }
        if (switcher == 2)
        {

            locallist2 = AktienKurseLesen.valueList2;
            switcher = 2;
         //   locallist2.Reverse();
            ShowGraph(locallist2, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        }
        if (switcher == 3)
        {

            locallist3 = AktienKurseLesen.valueList3;
            switcher = 3;
          //  locallist3.Reverse();
            ShowGraph(locallist3, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        }
        if (switcher == 4)
        {

            locallist4 = AktienKurseLesen.valueList4;
            switcher = 4;
         //   locallist4.Reverse();
            ShowGraph(locallist4, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        }
        if (switcher == 5)
        {
            locallist5 = AktienKurseLesen.valueList5;
            switcher = 5;
          //  locallist5.Reverse();
            ShowGraph(locallist5, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        }
    }

    public void switchwerte250()
    {
        anzahlWerte = -1;
        if (switcher == 1)
        {
            locallist = AktienKurseLesen.valueList1;
            switcher = 1;
          //  locallist.Reverse();
            ShowGraph(locallist, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        }
        if (switcher == 2)
        {

            locallist2 = AktienKurseLesen.valueList2;
            switcher = 2;
           // locallist2.Reverse();
            ShowGraph(locallist2, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        }
        if (switcher == 3)
        {

            locallist3 = AktienKurseLesen.valueList3;
            switcher = 3;
          //  locallist3.Reverse();
            ShowGraph(locallist3, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        }
        if (switcher == 4)
        {

            locallist4 = AktienKurseLesen.valueList4;
            switcher = 4;
          //  locallist4.Reverse();
            ShowGraph(locallist4, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        }
        if (switcher == 5)
        {
            locallist5 = AktienKurseLesen.valueList5;
            switcher = 5;
         //   locallist5.Reverse();
            ShowGraph(locallist5, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
        }

    }



    private void Update()
    {
       if(GlobalVariables.day > daybefore)
        {
            
            daybefore = GlobalVariables.day;
            if(switcher == 1)
            {
                locallist = AktienKurseLesen.valueList1;
                Debug.Log("graph in Klasse 1 gezeichnet");
              //  locallist.Reverse();

                ShowGraph(locallist, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
               // getMinandMax(locallist);
            }
            if(switcher == 2)
            {
                locallist2 = AktienKurseLesen.valueList2;
              //  locallist2.Reverse();
                
                ShowGraph(locallist2, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
            }
            if (switcher == 3)
            {

                locallist3 = AktienKurseLesen.valueList3;
                switcher = 3;
             //   locallist3.Reverse();
                ShowGraph(locallist3, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
            }
            if (switcher == 4)
            {

                locallist4 = AktienKurseLesen.valueList4;
                switcher = 4;
            //    locallist4.Reverse();
                ShowGraph(locallist4, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
            }
            if (switcher == 5)
            {
                locallist5 = AktienKurseLesen.valueList5;
                switcher = 5;
             //   locallist5.Reverse();
                ShowGraph(locallist5, anzahlWerte, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
            }

        }
    }

   /* public void getMinandMax(List<int> valueList)
    {
        int yMinimum = valueList.Min();
        int yMaximum = valueList.Max();
        Debug.Log("Minumum: " + yMinimum);
        Debug.Log("Maximum: " + yMaximum);
        TageHochAktie1.GetComponent<Text>().text = Convert.ToString(GlobalVariables.AktienIndex);
        KursHochAktie1.GetComponent<Text>().text = Convert.ToString(yMaximum);
        TageTiefAktie1.GetComponent<Text>().text = Convert.ToString(GlobalVariables.AktienIndex);
        KursTiefAKtie1.GetComponent<Text>().text = Convert.ToString(yMinimum);



    }*/

    public void ShowGraph(List<int> valueList, int maxVisibleValueAmount = -1, Func<int, string> getAxisLabelX = null, Func<float, string> getAxisLabelY = null) {
        if (getAxisLabelX == null) {
            getAxisLabelX = delegate (int _i) { return _i.ToString(); };
        }
        if (getAxisLabelY == null) {
            getAxisLabelY = delegate (float _f) { return Mathf.RoundToInt(_f).ToString(); };
        }

        if (maxVisibleValueAmount <= 0) {
            maxVisibleValueAmount = valueList.Count;
        }

        foreach (GameObject gameObject in gameObjectList) {
            Destroy(gameObject);
        }
        gameObjectList.Clear();
        
        float graphWidth = graphContainer.sizeDelta.x;
        float graphHeight = graphContainer.sizeDelta.y;

        float yMaximum = valueList[0];
        float yMinimum = valueList[0];
        
        for (int i = Mathf.Max(valueList.Count - maxVisibleValueAmount, 0); i < valueList.Count; i++) {
            int value = valueList[i];
            if (value > yMaximum) {
                yMaximum = value;
            }
            if (value < yMinimum) {
                yMinimum = value;
            }
        }

        float yDifference = yMaximum - yMinimum; //-yMinimum for % top buffer according to highest value
        if (yDifference <= 0) {
            yDifference = 5f;
        }
        float bufferPercent = 0.8f;
        /*for(int i = 0; i <= Convert.ToInt32(yMaximum / 100f); i++)
        {
            if (i > 2)
            {
                bufferPercent -= 0.05f;
            }
            else if(i > 5)
            {
                bufferPercent -= 0.01f;
            }
            else if(i >= 9)
            {
                bufferPercent = 0.01f;
            }
        }*/
        yMaximum = yMaximum + (yDifference * bufferPercent);
        //yMinimum = yMinimum - (yDifference * 0.2f); // variable yAchse

        yMinimum = 0f; // Start the graph at zero

        float xSize = graphWidth / (maxVisibleValueAmount + 1);

        int xIndex = 0;

        GameObject lastCircleGameObject = null;
        for (int i = Mathf.Max(valueList.Count - maxVisibleValueAmount, 0); i < valueList.Count; i++) {
            float xPosition = xSize + xIndex * xSize;
            float yPosition = ((valueList[i] - yMinimum) / (yMaximum - yMinimum)) * graphHeight;
            GameObject circleGameObject = CreateCircle(new Vector2(xPosition, yPosition));
            gameObjectList.Add(circleGameObject);
            if (lastCircleGameObject != null) {
                GameObject dotConnectionGameObject = CreateDotConnection(lastCircleGameObject.GetComponent<RectTransform>().anchoredPosition, circleGameObject.GetComponent<RectTransform>().anchoredPosition);
                gameObjectList.Add(dotConnectionGameObject);
            }
            lastCircleGameObject = circleGameObject;

            RectTransform labelX = Instantiate(labelTemplateX);
            labelX.SetParent(graphContainer, false);
            labelX.gameObject.SetActive(true);
            labelX.anchoredPosition = new Vector2(xPosition, -7f);
            labelX.GetComponent<Text>().text = getAxisLabelX(i);
            gameObjectList.Add(labelX.gameObject);

            RectTransform dashY = Instantiate(dashTemplateY);
            dashY.SetParent(graphContainer, false);
            dashY.gameObject.SetActive(true);
            dashY.anchoredPosition = new Vector2(xPosition, -3f);
            gameObjectList.Add(dashY.gameObject);

            xIndex++;
        }

        int separatorCount = 10;
        for (int i = 0; i <= separatorCount; i++) {
            RectTransform labelY = Instantiate(labelTemplateY);
            labelY.SetParent(graphContainer, false);
            labelY.gameObject.SetActive(true);
            float normalizedValue = i * 1f / separatorCount;
            labelY.anchoredPosition = new Vector2(-7f, normalizedValue * graphHeight);
            labelY.GetComponent<Text>().text = getAxisLabelY(yMinimum + (normalizedValue * (yMaximum - yMinimum)));
            gameObjectList.Add(labelY.gameObject);

            RectTransform dashX = Instantiate(dashTemplateX);
            dashX.SetParent(graphContainer, false);
            dashX.gameObject.SetActive(true);
            dashX.anchoredPosition = new Vector2(-4f, normalizedValue * graphHeight);
            gameObjectList.Add(dashX.gameObject);
        }
    }

    private GameObject CreateCircle(Vector2 anchoredPosition) {
        GameObject gameObject = new GameObject("circle", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().sprite = circleSprite;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(3, 3);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        return gameObject;
    }

    private GameObject CreateDotConnection(Vector2 dotPositionA, Vector2 dotPositionB) {
        GameObject gameObject = new GameObject("dotConnection", typeof(Image));
        gameObject.transform.SetParent(graphContainer, false);
        gameObject.GetComponent<Image>().color = new Color(1, 1, 1, .5f);
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        Vector2 dir = (dotPositionB - dotPositionA).normalized;
        float distance = Vector2.Distance(dotPositionA, dotPositionB);
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(0, 0);
        rectTransform.sizeDelta = new Vector2(distance, 3f);
        rectTransform.anchoredPosition = dotPositionA + dir * distance * .5f;
        rectTransform.localEulerAngles = new Vector3(0, 0, GetAngleFromVectorFloat(dir));
        return gameObject;
    }
    public static float GetAngleFromVectorFloat(Vector3 dir)
    {
        dir = dir.normalized;
        float n = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        if (n < 0) n += 360;

        return n;
    }

  /*  IEnumerator ExecSQL()
    {
        WWWForm FetchShareData = new WWWForm();
        FetchShareData.AddField("sharename", "Aktie");
        FetchShareData.AddField("amount", 30);

        WWW fetch = new WWW("https://dominik.grandpa-kitchen.com/PHP-Skripte/AktienKurseLesen.php", FetchShareData);
        yield return fetch;
        string [] results = fetch.text.Split('/');
        //string[] results = www.text.Split('/');

        int[] intarray = new int[results.Length];

        for (int i = 0; i < results.Length - 1; i++)
        {
            intarray[i] = Convert.ToInt32(results[i]);
        }

        for (int i = 0; i < intarray.Length; i++)
        {
            valueList.Add(intarray[i]);
        }
        Debug.Log(String.Join(",", valueList));
        ShowGraph(valueList, -1, (int _i) => "" + (_i + 1), (float _f) => "$" + Mathf.RoundToInt(_f));
    }*/
}
