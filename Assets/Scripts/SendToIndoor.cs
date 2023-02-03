using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SendToIndoor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        {
            if (other.CompareTag("Player"))
            {
                // Change the scene using the SceneManager
                UnityEngine.SceneManagement.SceneManager.LoadScene("Indoors");
            }
        }
    }
     
}
