using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// All comments by Robin
public class CollisionDetector : MonoBehaviour
{
    public GameObject panel;
    public float displayTime = 5f; // time in seconds for the panel to be displayed
    public static CollisionDetector instance;
    public GameObject player;

    bool canActivate;
    float timer;

    void Awake()
    {
        instance = this;// Set the singleton instance to this object
    }
    void Start()
    {
        player = FindObjectOfType<man>().gameObject;
        panel.SetActive(false);//Makes the panel inactive
        canActivate = true;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && canActivate)
        {
            GetComponent<Collider2D>().enabled = false;//disable collision
            panel.SetActive(true);
            Invoke("DeactivatePanel", displayTime);//Disable panel after timer is over
            player.GetComponent<man>().canMove = false;//lock player's position
            Invoke("ReactivateCollision", 10f); //set a timer to re-enable collision and unlock player's position
        }
        
    }

    private void Update()
    {
        if (!canActivate)
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {
                canActivate = true;
                timer = 0;
            }
        }
        
    }

    void ReactivateCollision()
    {
        canActivate = false;
        player.GetComponent<man>().canMove = true;//Reactivate movement
        GetComponent<Collider2D>().enabled = true;//enables collision
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
       /* panel.SetActive(true);//Activates the UI panel
        Invoke("DeactivatePanel", displayTime);//Disable collision after the timer is over
        GetComponent<Collider2D>().enabled = false; //Disable Collision*/
    }
    void DeactivatePanel()
    {
        panel.SetActive(false);//Disable panel
    }
}

