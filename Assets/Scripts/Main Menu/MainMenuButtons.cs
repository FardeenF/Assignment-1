using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public void GoToLevelEditor()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToTutorial()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
