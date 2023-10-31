using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void ContinueButton()
    {
        //Load Game scene from save file
    }

    public void SettingsButton()
    {
        
    }

    public void AboutButton()
    {

    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
