using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPatrolPointRight : MonoBehaviour
{
    public float speed = 3;
    public float range = 10;
    float startingX;
    int direction = -1;
    // Start is called before the first frame update
    void Start()
    {
        startingX = transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime * direction);
        if (transform.position.x < startingX || transform.position.x > startingX + range)
            direction *= -1;
    }
}