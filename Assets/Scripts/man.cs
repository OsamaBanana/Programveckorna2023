using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class man : MonoBehaviour
{
    float playerspeed = 5f;
    [SerializeField]
    Rigidbody2D rb;
    Vector2 movement;
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
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerspeed = 10f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerspeed = 5f;
        }
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
}
