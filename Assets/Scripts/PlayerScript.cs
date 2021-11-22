using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 8f;           //szybkoœæ gracza

    public GameObject bullet;           //prefabrykat pocisku
          
    public GameControlScript control;

    public float bulletThreshold = 0.5f;          //strza³ mo¿liwy co ... s
    float elapsedTime = 0;

    void Start() {}

    void Update()
    {
        elapsedTime += Time.deltaTime;          //sprawdzanie interwa³u dla strza³u

        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f);

        if (Input.GetButtonDown("Jump"))
         {
             if (elapsedTime > bulletThreshold)
             {
                 Instantiate(bullet, new Vector3(transform.position.x + 2f, transform.position.y, 0f), Quaternion.identity);        

                 elapsedTime = 0f;           //zeruj licznik
             }
         }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        control.PlayerDied();
        Destroy(this.gameObject);
    }
}