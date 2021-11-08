using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour
{

    public static bool isLoading = false;

    public GameObject playWindow;
    public GameObject playTutorial; 

    public void NewGame()
    {
        SceneManager.LoadScene(1);

        playWindow.SetActive (true);
    }

    public void gameTutorial()
    {
        playTutorial.SetActive(true);
    }


    public void LoadGame()
    {
        isLoading = true;
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
        //Just to make sure its working
    }

    public void closePlayWindow()
    {
        playWindow.SetActive(false);
    }
}