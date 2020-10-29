using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour 
{
    public Button registrationButton;
    public Button loginButton;
    public Button playButton;
    
    private Button button;
    private Button prevButton;

    public Text playerDisplay;

    private int tabSelect = 0;

    private void Start()
    {
        if (registrationButton != null)
        {
            button = registrationButton;
            FadeToColor(button, button.colors.highlightedColor);
        }
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (tabSelect == 2)
            {
                tabSelect = 0;
            }
            else
            {
                tabSelect += 1;
            }
            switch (tabSelect)
            {
                case 0:
                    button = registrationButton;
                    prevButton = playButton;
                    break;
                case 1:
                    button = loginButton;
                    prevButton = registrationButton;
                    break;
                case 2:
                    button = playButton;
                    prevButton = loginButton;
                    break;
                default:
                    Debug.Log("Hard to count from 0, huh?");
                    break;
            }
            FadeToColor(prevButton, prevButton.colors.normalColor);
            FadeToColor(button, button.colors.highlightedColor);
        }
        else if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            button.onClick.Invoke();
        }
    }
    public void FadeToColor(Button button, Color color)
    {
        Graphic graphic = button.GetComponent<Graphic>();
        graphic.CrossFadeColor(color, button.colors.fadeDuration, true, true);
    }
    // Start is called before the first frame update
    public void GoToRegister()
    {
      
        SceneManager.LoadScene(1);

    }

    public void GoToLogin()
    {
       
        SceneManager.LoadScene(2);
    }

    public void GoToGame()
    {
        
        GlobalVariables.username = "patrickRich";
        SceneManager.LoadScene(3);
    }

    public void LeaveGame()
    {
        Application.Quit();
    }
}
