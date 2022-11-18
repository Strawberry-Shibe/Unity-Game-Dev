using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 30.0f;
    private float lowerBound = -10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //destroy apples going over the upper bound
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        //destroy animals that go below the lower bound, then conclude the game
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
