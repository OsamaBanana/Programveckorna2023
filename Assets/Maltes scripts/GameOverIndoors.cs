using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameOverIndoors : MonoBehaviour
{
    //Malte
    public GameObject GameOverPanel;
    //Variabel för att upptäcka Panelen
    public void LoadMenu()
    {
        SceneManager.LoadScene("StartMenu");
        //Den här koden är till för en knapp som laddar en annan scen
    }

    public void Restart()
    {
        SceneManager.LoadScene("Indoors");
        Time.timeScale = 1f;
        GameOverPanel.SetActive(false);
        //Den här koden är för en till knapp som  också laddar in scenen igen, däremot ändras också hur tiden fungerar. Alltså ändrar den tillbaka tiden till 1 om den tidigare var på 0, vilket används när man pausar spelet
        //Den stänger också av GameOverPanelen så att den inte längre syns
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
        // den här koden är för en knapp som gör så att spelet stängs av när man klickar på den
    }
}