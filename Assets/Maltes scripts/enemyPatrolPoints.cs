using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPatrolPoints : MonoBehaviour
{
    // All kod �r skriven av -Malte
    public float speed = 3;
    public Vector2 range;
    Vector2 starting;
    [SerializeField] Vector2 direction;
   
    // Variabler f�r att �ndra hastighet, hur l�ngt vakterna f�rdas, deras startposition och vilken riktning de f�rdas i
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
        //Den h�r koden �ndrar vaktens position genom att ta hastigheten multiplicerat med riktningen och s�klart time.deltaTime f�r att spelet inte ska g� s�nder om man spelar p� h�gre fps
        //Den h�r koden g�r ocks� s� att vakten �ker tillbaka efter den n�tt sin slutpunkt
    }
}
