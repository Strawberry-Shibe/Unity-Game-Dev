using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{

    public GameObject Propeller;
    private float PropRotSpeed = 400.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Propeller.transform.Rotate(Vector3.forward * PropRotSpeed * Time.deltaTime);
    }
}
