using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{

    public Button newGameButton;

    public Button infoButton;

    public Button exitGameButton;

    public void NewGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void OpenLoadGameMenu()
    {
        SceneManager.LoadScene("End");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}