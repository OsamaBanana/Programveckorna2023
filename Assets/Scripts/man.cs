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

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        //den kod för om röra sig - erwin
        rb.MovePosition(rb.position + movement * playerspeed * Time.fixedDeltaTime);
    }

    public void SavePlayer()
    {
        Savesystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = Savesystem.LoadPlayer();  
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
        SceneManager.LoadScene("Outdoors");
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