using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float spaceInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public GameObject applePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // LR movement
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        // Spawning ApplePrefab
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch apple prefab
            Instantiate(applePrefab, transform.position, applePrefab.transform.rotation);
        }
    }
}
