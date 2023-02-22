using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    //Kod som används när man ska tillbaka till startmenyn - Malte
    public void LoadMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
