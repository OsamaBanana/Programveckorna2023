using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Indoors1");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}