using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCorn : MonoBehaviour
{

    public float rotationSpeed = 10f; // Adjust the speed of rotation as needed

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        // Rotate the object around its up axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
