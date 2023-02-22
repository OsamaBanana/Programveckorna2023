using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenuIndoors : MonoBehaviour
{
    //Malte
    public static bool isGamePaused = true;

    [SerializeField] GameObject pauseMenu;

    // Variabler för att kolla om spelet är pausat och för att hitta pausMenyn som ett spelobjekt
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
        //Om man klickar på Escapeknappen fortsätter eller pausas spelet beroende på om man är pausad eller om man inte är det
    }

    public void ResumeGameIndoors()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
        //Kod för en knapp som döljer pausmenyn, ändrar tillbaka hastigheten av spelet till 100% och sätter variabeln som kollar om spelet är pausat på false
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
        //Kod som sätter på pauspanelen, ändrar hastigheten av spelet till 0% så att man inte kan dö medan spelet är pausat sedan sätts variablen som kollar om spelet är pausat på true
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("StartMenu");
        Time.timeScale = 1f;
        //Kod som används för att en knapp ska ladda startmenyn och sätta tillbaka hastigheten av spelet till 100%
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
        //Kod som används för att en knapp ska stänga av spelet
    }
}
