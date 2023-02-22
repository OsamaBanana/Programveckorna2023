using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenuIndoors : MonoBehaviour
{
    //Malte
    public static bool isGamePaused = true;

    [SerializeField] GameObject pauseMenu;

    // Variabler f�r att kolla om spelet �r pausat och f�r att hitta pausMenyn som ett spelobjekt
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                ResumeGameIndoors();
            }
            else
            {
                PauseGame();
            }
        }
        //Om man klickar p� Escapeknappen forts�tter eller pausas spelet beroende p� om man �r pausad eller om man inte �r det
    }

    public void ResumeGameIndoors()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
        //Kod f�r en knapp som d�ljer pausmenyn, �ndrar tillbaka hastigheten av spelet till 100% och s�tter variabeln som kollar om spelet �r pausat p� false
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
        //Kod som s�tter p� pauspanelen, �ndrar hastigheten av spelet till 0% s� att man inte kan d� medan spelet �r pausat sedan s�tts variablen som kollar om spelet �r pausat p� true
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1f;
        //Kod som anv�nds f�r att en knapp ska ladda startmenyn och s�tta tillbaka hastigheten av spelet till 100%
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
        //Kod som anv�nds f�r att en knapp ska st�nga av spelet
    }
}
