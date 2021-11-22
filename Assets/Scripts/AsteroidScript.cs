using UnityEngine;
using System.Collections;

public class AsteroidScript : MonoBehaviour
{
    float speed = -5f;

    float rotation;

    void Start()
    {
        rotation = Random.Range(-10, 10);
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        Destroy(this.gameObject);
    }
}