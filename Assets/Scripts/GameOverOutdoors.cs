using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameOverOutdoors : MonoBehaviour
{

    public GameObject GameOverPanel;
    //Kod som var t�nkt f�r att knappar skulle fungera n�r man f�rlorat - Malte
    public void LoadMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Outdoors");
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}