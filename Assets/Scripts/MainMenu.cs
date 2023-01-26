using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Debug.Log("QUTI!");
        Application.Quit();
    }

    public void SelectWorld()
    {
        SceneManager.LoadScene("Select");
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene("Game2");
    }
}
