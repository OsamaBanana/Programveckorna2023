using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPatrolPoints : MonoBehaviour
{
    // All kod är skriven av -Malte
    public float speed = 3;
    public Vector2 range;
    Vector2 starting;
    [SerializeField] Vector2 direction;
   
    // Variabler för att ändra hastighet, hur långt vakterna färdas, deras startposition och vilken riktning de färdas i
    void Start()
    {
        starting = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime * direction);
        if (Vector2.Distance( transform.position,starting) < 0.05f || Vector2.Distance( transform.position, starting + range) < 0.05f)
            direction *= -1;
        //Den här koden ändrar vaktens position genom att ta hastigheten multiplicerat med riktningen och såklart time.deltaTime för att spelet inte ska gå sönder om man spelar på högre fps
        //Den här koden gör också så att vakten åker tillbaka efter den nått sin slutpunkt
    }
}
