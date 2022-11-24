using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // public variables
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 20.0f;
    // variable for the food prefab
    public GameObject[] projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int projectileIndex = Random.Range(0, projectilePrefab.Length);

        // Prevents the player from passing through the left boundary of the screen
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Prevents the player from passing through the right boundary of the screen
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Gets the left and right input and make the player go left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Makes the player fire food projectile whenever the space bar is pressed down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab[projectileIndex], transform.position, projectilePrefab[projectileIndex].transform.rotation);
        }
    }
}
