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
        panel.SetActive(true);
        Invoke("DeactivatePanel", displayTime);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        panel.SetActive(true);
        Invoke("DeactivatePanel", displayTime);
    }
    void DeactivatePanel()
    {
        panel.SetActive(false);
    }
}

