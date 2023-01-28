using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{


    public void LoadGame()
    {
        SceneManager.LoadScene("Select");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
