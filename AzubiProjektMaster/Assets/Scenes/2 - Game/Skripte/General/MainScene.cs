using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScene : MonoBehaviour
{
    public Button logOut;
    public Text usernameText;
    
    //Callable transparent button covering the entire background to close tablets
    public static void TabletHandlerActivate()
    {
        GameObject.Find("Game/GameHandler/UI/TabletHandlerBtn").SetActive(true);
    }
    //Tablet Handler On Click() Game/GameHandler/UI/CloseAllTablets
    public void TabletHandler()
    {
        if (GameObject.Find("HRTablet") != null)
        {
            GameObject.Find("HRTablet").SetActive(false);
        }
        if (GameObject.Find("GraphTablet") != null)
        {
            GameObject.Find("GraphTablet").SetActive(false);
        }
        if (GameObject.Find("AktienHandelTablet") != null)
        {
            GameObject.Find("AktienHandelTablet").SetActive(false);
        }
        if (GameObject.Find("KreditTablet") != null)
        {
            GameObject.Find("KreditTablet").SetActive(false);
        }
        if (GameObject.Find("AlleKrediteAPP") != null)
        {
            GameObject.Find("AlleKrediteAPP").SetActive(false);
        }
        if (GameObject.Find("GebäudeKaufenAPP") != null)
        {
            GameObject.Find("GebäudeKaufenAPP").SetActive(false);
        }
        GameObject.Find("TabletHandlerBtn").SetActive(false);
    }
    //On Click() Game/GameHandler/UI/Statusleiste/logOut
    public void LogOut()
    {
        GlobalVariables.username = null;
        SceneManager.LoadScene(0);
    }
    // Start is called before the first frame update
    void Start()
    {
        usernameText.text = GlobalVariables.username;
    }
}
