using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    //Kod som anv�nds n�r man ska tillbaka till startmenyn - Malte
    public void LoadMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
