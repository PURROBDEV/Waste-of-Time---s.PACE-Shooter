using UnityEngine;
using System.Collections;

public class AsteroidSpawnScript : MonoBehaviour
{
    float spawnThreshold = 65f;     // interwa³ tworzenia asteroid
    float spawnDecrement = 0.1f;     // interwa³ tworzenia asteroid 

    public GameObject Asteroid;     // prefabrykat

    void Start() { }
    void Update()
    {
        if (Random.Range(0, spawnThreshold) <=1)
        {
            Vector3 pos = transform.position;
            Instantiate(Asteroid, new Vector3(pos.x, pos.y + Random.Range(-7, 7), pos.z), Quaternion.identity);
            spawnThreshold -= spawnDecrement;
            if (spawnThreshold < 2)
            {
                spawnThreshold = 2;
            }
        }
    }
}