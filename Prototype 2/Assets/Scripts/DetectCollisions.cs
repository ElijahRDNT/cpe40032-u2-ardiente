using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Detects when an object collides with another object
    private void OnTriggerEnter(Collider other)
    {
        // Destroys both object that will collide with each other
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
