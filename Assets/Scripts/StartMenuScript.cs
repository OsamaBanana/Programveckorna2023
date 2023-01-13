using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Outdoors");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}