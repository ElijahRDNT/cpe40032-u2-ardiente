using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // speed variable for the game objects that moves forward
    public float speed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Makes the object move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
