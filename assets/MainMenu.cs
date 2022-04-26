using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string lvlToLoad;
    public GameObject settingsWindow;
    
    public void StartButton()
    {
        SceneManager.LoadScene(lvlToLoad);
    }
    
    public void OpenSettingsButton() {
        settingsWindow.SetActive(true);
    }
    
    public void CloseSettingsButton() {
        settingsWindow.SetActive(false);
    }
    
    public void QuitButton()
    {
        Application.Quit();
    }
}
