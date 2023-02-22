using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverIndoors : MonoBehaviour
{
    //Malte
    public GameObject GameOverPanel;
    //Variabel f�r att uppt�cka Panelen
    public void LoadMenu()
    {
        SceneManager.LoadScene("StartMenu");
        //Den h�r koden �r till f�r en knapp som laddar en annan scen
    }

    // Update is called once per frame
    public void Restart()
    {
        SceneManager.LoadScene("Indoors");
        Time.timeScale = 1f;
        GameOverPanel.SetActive(false);
        //Den h�r koden �r f�r en till knapp som  ocks� laddar in scenen igen, d�remot �ndras ocks� hur tiden fungerar. Allts� �ndrar den tillbaka tiden till 1 om den tidigare var p� 0, vilket anv�nds n�r man pausar spelet
        //Den st�nger ocks� av GameOverPanelen s� att den inte l�ngre syns
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
        // den h�r koden �r f�r en knapp som g�r s� att spelet st�ngs av n�r man klickar p� den
    }
}
