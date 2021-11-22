using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    void Start() { }
    void Update() { }

    void OnTriggerEnter(Collider asteroid)
    {
        Destroy(asteroid.gameObject);
    }
}