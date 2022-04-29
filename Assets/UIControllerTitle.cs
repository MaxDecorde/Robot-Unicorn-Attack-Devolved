using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControllerTitle : MonoBehaviour
{
    public GameObject panelMain;
    public GameObject panelSettings;
    
    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    public void Parameters(bool toggle)
    {
        panelMain.SetActive(!toggle);
        panelSettings.SetActive(toggle);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
