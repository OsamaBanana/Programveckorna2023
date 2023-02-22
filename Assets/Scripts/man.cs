using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class man : MonoBehaviour
{
    public static bool isPlayerAlive = true;
    public float playerspeed = 5f;
    [SerializeField]
    Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;
    public GameObject GameOverPanel;
    [SerializeField]
    public int keyss = 1;
    // Start is called before the first frame update - erwin
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame - erwin
    void Update()
    {
        //den kod för att röra sig fungera - erwin
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
      
        //kod fÃ¶r att animatationerna ska triggas - Malte
        animator.SetFloat("Horizontal", movement.x); 
        animator.SetFloat("Vertical", movement.y); 
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        //den kod för om röra sig - erwin
        rb.MovePosition(rb.position + movement * playerspeed * Time.fixedDeltaTime);
    }
        
    public void OnCollisionEnter2D(Collision2D other)
    {
        //if (other.gameObject.tag == "Enemy")
        {
            //Den kod för när man krok och dö - erwin
            //Destroy(gameObject);
            //GameOverPanel.SetActive(true);
        }
        if (other.gameObject.tag == "keys")
        {
            //den koden gör så att man kroka och döda - erwin
            collectm.instance.keyscollect(keyss);
            Debug.Log("he");
            Destroy(other.gameObject);
        }
    }

}