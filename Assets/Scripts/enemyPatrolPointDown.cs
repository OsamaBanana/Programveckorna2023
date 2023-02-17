using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPatrolPointDown : MonoBehaviour
{
    public float speed = 3;
    public float range = 10;
    float startingY;
    int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        startingY = transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime * direction);
        if (transform.position.y < startingY || transform.position.y > startingY + range)
            direction *= -1;
    }
}
