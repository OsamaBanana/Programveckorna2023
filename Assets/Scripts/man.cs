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
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    private void FixedUpdate()
    {
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
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameOverPanel.SetActive(true);
        }
    }
}