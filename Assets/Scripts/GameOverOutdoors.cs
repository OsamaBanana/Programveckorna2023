using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverOutdoors : MonoBehaviour
{
    public GameObject GameOverPanel;
    public void LoadMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Outdoors");
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