using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{
    //Kod för knappar, en som startar spelet (laddar utomhusscenen), en som öppnar inställningar och en som stänger av spelet. - Malte
    public void StartGame()
    {
        SceneManager.LoadScene("Outdoors");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}