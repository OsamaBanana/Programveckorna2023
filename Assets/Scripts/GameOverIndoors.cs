using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameOverIndoors : MonoBehaviour
{

    public GameObject GameOverPanel;
    public void LoadMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Indoors");
        Time.timeScale = 1f;
        GameOverPanel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            GameOverPanel.SetActive(true);
        }
    }
}