using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject panel;
    public float displayTime = 5f; // time in seconds for the panel to be displayed
    public static CollisionDetector instance;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        panel.SetActive(false);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //disable collision
            GetComponent<Collider2D>().enabled = false;
        }
        panel.SetActive(true);
        Invoke("DeactivatePanel", displayTime);
        //lock player's position
        GetComponent<Rigidbody2D>().isKinematic = true;
        //set a timer to re-enable collision and unlock player's position after some time
        Invoke("ReactivateCollision", 10f);
    }

    void ReactivateCollision()
    {
        GetComponent<Rigidbody2D>().isKinematic = false;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        panel.SetActive(true);
        Invoke("DeactivatePanel", displayTime);
        GetComponent<Collider2D>().enabled = false;
    }
    void DeactivatePanel()
    {
        panel.SetActive(false);
    }
}

