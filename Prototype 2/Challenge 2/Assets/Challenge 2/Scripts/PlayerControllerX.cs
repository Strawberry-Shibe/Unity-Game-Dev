using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogCooldown = 0.75f;
    public float lastDogSpawnTime;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        lastDogSpawnTime = lastDogSpawnTime + Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && lastDogSpawnTime > dogCooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastDogSpawnTime = 0f;
        }
    }
}
